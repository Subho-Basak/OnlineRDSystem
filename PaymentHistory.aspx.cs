using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class PaymentHistory : System.Web.UI.Page
{
    Dbconnection db = new Dbconnection();
    StringBuilder htmlTable = new StringBuilder();
    protected void Page_Load(object sender, EventArgs e)
    {
        SqlCommand cmd = new SqlCommand("select s.ufname,s.umname,s.ulname,p.* from PaymentDetailsTable p,SingleAccountEntryTable s where p.accountno=s.accountno;", db.con);

        db.openconnection();
        SqlDataReader articleReader = cmd.ExecuteReader();

        htmlTable.Append("<table border='0'>");
        htmlTable.Append("<thead>");
        htmlTable.Append("<tr>");
        htmlTable.Append("<th>DATE</th>");
        htmlTable.Append("<th>ACCOUNT NO</th>");
        htmlTable.Append("<th>ACCOUNT HOLDER NAME</th>");
        htmlTable.Append("<th>DENOMINATION</th>");
        htmlTable.Append("<th>FINE</th>");
        htmlTable.Append("<th>TOTAL AMOUNT</th>");
        htmlTable.Append("<th>PAID BY</th>");
        htmlTable.Append("</tr>");
        htmlTable.Append("</thead>");
        if (articleReader.HasRows)
        {
           // Label1.Visible = false;
            while (articleReader.Read())
            {
                DateTime date = Convert.ToDateTime(articleReader["paymentdate"]);
                htmlTable.Append("<tbody>");
                htmlTable.Append("<tr>");
                htmlTable.Append("<td>"+ date.Date.ToString("d") +"</td>");
                htmlTable.Append("<td><label name='accno'>" + articleReader["accountno"] + "</label></ td >");
                htmlTable.Append("<td><label>" + articleReader["ufname"] + "  " + articleReader["umname"] + "  " + articleReader["ulname"] + "</label><br/> </ td >");
                htmlTable.Append("<td>&#8377; " + articleReader["openingamount"] + "</td>");
                htmlTable.Append("<td>&#8377; " + articleReader["fine"] + "</td>");
                htmlTable.Append("<td>&#8377; " + articleReader["totalamount"] + "</td>");
                htmlTable.Append("<td>" + articleReader["paidby"] + "</td>");

                htmlTable.Append("</tr>");
                htmlTable.Append("</tbody>");
            }
            htmlTable.Append("</table>");

            PlaceHolder1.Controls.Add(new Literal { Text = htmlTable.ToString() });

            articleReader.Close();
            articleReader.Dispose();
        }

}
}