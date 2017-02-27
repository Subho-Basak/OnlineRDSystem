using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class CheckDue : System.Web.UI.Page
{
    LogicClass lc = new LogicClass();
    Dbconnection db = new Dbconnection();
    StringBuilder htmlTable = new StringBuilder();
    protected void Page_Load(object sender, EventArgs e)
    {

        
        if (!IsPostBack) { 
        Button2.Style.Add("border-bottom", "3px solid #444");
        DueSingleAccount();

    }
    }


    protected void submitBtn_Click(object sender, EventArgs e)
    {
        int paymentid = Convert.ToInt32(TextBox1.Text);
       // Response.Write("<script>alert(paymentid)</script>");
        String status = "Cleared";
        String cleardate = DateTime.Now.Date.ToString("d");
        String msg=lc.UpdateDueStatus(paymentid,cleardate,status);
        if (msg == "success")
        {
            Response.Redirect("CheckDue.aspx");
        }
        if (msg == "failed")
        {
            Response.Write("<script>alert('Failed')</script>");
        }
    }

    protected void Button2_Click(object sender, EventArgs e)
    {
       
        DueSingleAccount();
      
        Button1.Style.Remove("border-bottom");
        Button2.Style.Add("border-bottom", "3px solid #444");
    }

    private void DueSingleAccount()
    {
        String status = "Due";
        //Label1.Text = accno.ToString();
        SqlCommand cmd = new SqlCommand("select s.ufname,s.umname,s.ulname,d.* from DueTable d,SingleAccountEntryTable s where d.status=@ID and d.accountno=s.accountno;", db.con);
        cmd.Parameters.AddWithValue("@ID", status);
        db.openconnection();
        SqlDataReader articleReader = cmd.ExecuteReader();

        htmlTable.Append("<table border='0'>");
        htmlTable.Append("<thead>");
        htmlTable.Append("<tr>");
        htmlTable.Append("<th>ID</th>");
        htmlTable.Append("<th>DATE</th>");
        htmlTable.Append("<th>ACCOUNT NO</th>");
        htmlTable.Append("<th>ACCOUNT NAME</th>");
        htmlTable.Append("<th>DENOMINATION</th>");
        htmlTable.Append("<th>FINE</th>");
        htmlTable.Append("<th>TOTAL AMOUNT</th>");
        htmlTable.Append("<th>STATUS</th>");
        htmlTable.Append("</tr>");
        htmlTable.Append("</thead>");
        if (articleReader.HasRows)
        {

            theMsg.Visible = false;
            while (articleReader.Read())
            {
                DateTime date = Convert.ToDateTime(articleReader["paymentdate"]);
                htmlTable.Append("<tbody>");
                htmlTable.Append("<tr>");
                htmlTable.Append("<td><h3>" + articleReader["paymentid"] + "</h3></td>");
                htmlTable.Append("<td>" + date.Date.ToString("d") + "</td>");
                htmlTable.Append("<td><label name='accno'>" + articleReader["accountno"] + "</label></ td >");
                htmlTable.Append("<td><label>" + articleReader["ufname"] + "  " + articleReader["umname"] + "  " + articleReader["ulname"] + "</label><br/> </ td >");
                htmlTable.Append("<td>&#8377; " + articleReader["openningamount"] + "</td>");
                htmlTable.Append("<td>&#8377; " + articleReader["fineamount"] + "</td>");
                htmlTable.Append("<td>&#8377; " + articleReader["totalamount"] + "</td>");
                htmlTable.Append("<td>" + articleReader["status"] + "<br/>" + articleReader["cleardate"] + "</td>");

                htmlTable.Append("</tr>");
                htmlTable.Append("</tbody>");
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

    protected void Button1_Click(object sender, EventArgs e)
    {
       
        DueJointAccount();
       
        Button2.Style.Remove("border-bottom");
        Button1.Style.Add("border-bottom", "3px solid #444");
    }

    private void DueJointAccount()
    {
        String status = "Due";
        //Label1.Text = accno.ToString();
        SqlCommand cmd = new SqlCommand("select s.pfname,s.pmname,s.plname,d.* from DueTable d,JointAccountTable s where d.status=@ID and d.accountno=s.accountno;", db.con);
        cmd.Parameters.AddWithValue("@ID", status);
        db.openconnection();
        SqlDataReader articleReader = cmd.ExecuteReader();

        htmlTable.Append("<table border='0'>");
        htmlTable.Append("<thead>");
        htmlTable.Append("<tr>");
        htmlTable.Append("<th>ID</th>");
        htmlTable.Append("<th>DATE</th>");
        htmlTable.Append("<th>ACCOUNT NO</th>");
        htmlTable.Append("<th>ACCOUNT NAME</th>");
        htmlTable.Append("<th>DENOMINATION</th>");
        htmlTable.Append("<th>FINE</th>");
        htmlTable.Append("<th>TOTAL AMOUNT</th>");
        htmlTable.Append("<th>STATUS</th>");
        htmlTable.Append("</tr>");
        htmlTable.Append("</thead>");
        if (articleReader.HasRows)
        {

            theMsg.Visible = false;
            while (articleReader.Read())
            {
                DateTime date = Convert.ToDateTime(articleReader["paymentdate"]);
                htmlTable.Append("<tbody>");
                htmlTable.Append("<tr>");
                htmlTable.Append("<td><h3>" + articleReader["paymentid"] + "</h3></td>");
                htmlTable.Append("<td>" + date.Date.ToString("d") + "</td>");
                htmlTable.Append("<td><label name='accno'>" + articleReader["accountno"] + "</label></ td >");
                htmlTable.Append("<td><label>" + articleReader["pfname"] + "  " + articleReader["pmname"] + "  " + articleReader["plname"] + "</label><br/> </ td >");
                htmlTable.Append("<td>&#8377; " + articleReader["openningamount"] + "</td>");
                htmlTable.Append("<td>&#8377; " + articleReader["fineamount"] + "</td>");
                htmlTable.Append("<td>&#8377; " + articleReader["totalamount"] + "</td>");
                htmlTable.Append("<td>" + articleReader["status"] + "<br/>" + articleReader["cleardate"] + "</td>");

                htmlTable.Append("</tr>");
                htmlTable.Append("</tbody>");
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
    