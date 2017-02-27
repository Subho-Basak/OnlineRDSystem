using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class PostMasterDashboard : System.Web.UI.Page
{
    Dbconnection db = new Dbconnection();
    StringBuilder htmlTable = new StringBuilder();
    protected void Page_Load(object sender, EventArgs e)
    {
        String name = Request.QueryString["accname"].ToString();
        

        if (!IsPostBack)
        {
            
            viewSingleAccount(name);
            viewJointAccount(name);
        }
       
    }

    private void viewJointAccount(String name)
    {

        SqlCommand cmd = new SqlCommand("SELECT s.* from JointAccountTable s where s.pfname +s.pmname+s.plname LIKE @v1", db.con);
        cmd.Parameters.AddWithValue("@v1","%"+ name+"%");
        db.openconnection();
        SqlDataReader articleReader = cmd.ExecuteReader();
      
        htmlTable.Append("<table border='0'>");

        if (articleReader.HasRows)
        {
           // string type = "joint";
            theMsg.Visible = false;
            while (articleReader.Read())
            {
                htmlTable.Append("<tr>");
                htmlTable.Append("<td><img alt='' src='FetchImage.ashx?accno=" + articleReader["accountno"] + "' /></td>");
                htmlTable.Append("<td><label>" + articleReader["pfname"] + "  " + articleReader["pmname"] + "  " + articleReader["plname"] + "</label><br/>" +
                  "<label> " + articleReader["sfname"] + "  " + articleReader["smname"] + "  " + articleReader["slname"] + " </label><br/> " +
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
            htmlTable.Clear();
        }
        else
        {
          //  theMsg.Visible = true;
        }


    }

    protected void viewSingleAccount(String name)
    {
        SqlCommand cmd = new SqlCommand("SELECT s.* from SingleAccountEntryTable s where s.ufname + s.umname + s.ulname LIKE @v1 ", db.con);
        cmd.Parameters.AddWithValue("@v1","%"+name+"%");
        db.openconnection();
        SqlDataReader articleReader = cmd.ExecuteReader();
        
        htmlTable.Append("<p>Showing results for: "+name+"</p>");
        htmlTable.Append("<table border='0'>");

        if (articleReader.HasRows)
        {
           // string type = "single";
           theMsg.Visible = false;
            
            while (articleReader.Read())
            {
                htmlTable.Append("<tr>");
                htmlTable.Append("<td><img alt='' src='FetchImage.ashx?accno=" + articleReader["accountno"] + "' /></td>");
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
            htmlTable.Clear();
        }
        else
        {
           // theMsg.Visible = true;
        }

    }
}