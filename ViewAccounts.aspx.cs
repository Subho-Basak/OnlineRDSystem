using System;
using System.Collections;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class ViewAccounts : System.Web.UI.Page
{
    Dbconnection db = new Dbconnection();
    StringBuilder htmlTable = new StringBuilder();
    protected void Page_Load(object sender, EventArgs e)
    {
        if (!IsPostBack)
        {
         
            Label3.Style.Add("border-bottom", "3px solid #444");
            viewSingleAccount();

        }
        
       
        ///theMsg.Visible = true;
    }
    protected void Label2_Click(Object sender, EventArgs e)
    {

        viewJointAccount();
        Label3.Style.Remove("border-bottom");
        Label2.Style.Add("border-bottom", "3px solid #444");
    }
    protected void Label3_Click(Object sender, EventArgs e)
    {

        viewSingleAccount();
        Label2.Style.Remove("border-bottom");
       Label3.Style.Add("border-bottom", "3px solid #444");
    }
    private void viewJointAccount()
    {
        SqlCommand cmd = new SqlCommand("select * from JointAccountTable", db.con);

        db.openconnection();
        SqlDataReader articleReader = cmd.ExecuteReader();

        htmlTable.Append("<table border='0'>");

        if (articleReader.HasRows)
        {
            string type = "joint";
            theMsg.Visible = false;
            while (articleReader.Read())
            {
                htmlTable.Append("<tr>");
                htmlTable.Append("<td><img alt='' src='FetchImage.ashx?accno=" + articleReader["accountno"] +"' /></td>");
                htmlTable.Append("<td><label>" + articleReader["pfname"] + "  " + articleReader["pmname"] + "  " + articleReader["plname"] + "</label><br/>" +
                  "<label> " + articleReader["sfname"] + "  " + articleReader["smname"] + "  " + articleReader["slname"] + " </label><br/> "+
                    "<label name='accno'>" + articleReader["accountno"] + "</label></ td >");
                DateTime opdate = Convert.ToDateTime(articleReader["openingdate"]);
                DateTime cldate = Convert.ToDateTime(articleReader["closingdate"]);
                htmlTable.Append("<td><span>Opening date</span><br/>" + opdate.Date.ToString("d") + "</td>");
                htmlTable.Append("<td><span>Closing date</span><br/>" + cldate.Date.ToString("d") + "</td>");
                htmlTable.Append("<td><span>Opening amount</span><br/>" + articleReader["openingamount"] + "</td>");
                htmlTable.Append("</tr>");
            }
            htmlTable.Append("</table>");

            PlaceHolder1.Controls.Add(new Literal { Text = htmlTable.ToString() });

            articleReader.Close();
            articleReader.Dispose();
        }
        else
        {
            theMsg.Visible = true;
        }

    
}

    protected void viewSingleAccount()
    {
        SqlCommand cmd = new SqlCommand("select * from SingleAccountEntryTable", db.con);

        db.openconnection();
        SqlDataReader articleReader = cmd.ExecuteReader();

        htmlTable.Append("<table border='0'>");

        if (articleReader.HasRows)
        {
            string type = "single";
           theMsg.Visible = false;
            while (articleReader.Read())
            {
                htmlTable.Append("<tr>");
                htmlTable.Append("<td><img alt='' src='FetchImage.ashx?accno=" + articleReader["accountno"]+"' /></td>");
                htmlTable.Append("<td><label>" + articleReader["ufname"] + "  " + articleReader["umname"] + "  " + articleReader["ulname"] + "</label><br/>" +
                  "<label name='accno'>" + articleReader["accountno"] + "</label></ td >");
                DateTime opdate = Convert.ToDateTime(articleReader["openingdate"]);
                DateTime cldate = Convert.ToDateTime(articleReader["closingdate"]);
                htmlTable.Append("<td><span>Opening date</span><br/>" + opdate.Date.ToString("d") + "</td>");
                htmlTable.Append("<td><span>Closing date</span><br/>" + cldate.Date.ToString("d") + "</td>");
                htmlTable.Append("<td><span>Opening amount</span><br/>" + articleReader["openingamount"] + "</td>");
                htmlTable.Append("</tr>");
            }
            htmlTable.Append("</table>");

            PlaceHolder1.Controls.Add(new Literal { Text = htmlTable.ToString() });

            articleReader.Close();
            articleReader.Dispose();
        }
        else
        {
            theMsg.Visible = true;
        }

    }
}