﻿using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class DueHistory : System.Web.UI.Page
{
    Dbconnection db = new Dbconnection();
    StringBuilder htmlTable = new StringBuilder();
    protected void Page_Load(object sender, EventArgs e)
    {
       
        
    }

    protected void Button2_Click(object sender, EventArgs e)
    {
        DueSingleAccount();
    }
    private void DueSingleAccount()
    {
        //Label1.Text = accno.ToString();
        SqlCommand cmd = new SqlCommand("select s.ufname,s.umname,s.ulname,d.* from DueTable d,SingleAccountEntryTable s where d.accountno=s.accountno;", db.con);
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

    }

    protected void Button1_Click(object sender, EventArgs e)
    {
        DueJointAccount();
    }

    private void DueJointAccount()
    {
        //Label1.Text = accno.ToString();
        SqlCommand cmd = new SqlCommand("select s.pfname,s.pmname,s.plname,d.* from DueTable d,JointAccountTable s where  d.accountno=s.accountno;", db.con);
        db.openconnection();
        SqlDataReader articleReader = cmd.ExecuteReader();

        htmlTable.Append("<table border='0'>");
        htmlTable.Append("<tr>");
        htmlTable.Append("<th>ID</th>");
        htmlTable.Append("<th>DATE</th>");
        htmlTable.Append("<th>ACCOUNT NO</th>");
        htmlTable.Append("<th>ACCOUNT NAME</th>");
        htmlTable.Append("<th>DENOMINATION</th>");
        htmlTable.Append("<th>FINE</th>");
        htmlTable.Append("<th>TOTAL AMOUNT</th>");
        htmlTable.Append("<th>STATUS</th>");
        if (articleReader.HasRows)
        {

            theMsg.Visible = false;
            while (articleReader.Read())
            {
                DateTime date = Convert.ToDateTime(articleReader["paymentdate"]);
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
            }
            htmlTable.Append("</table>");

            PlaceHolder1.Controls.Add(new Literal { Text = htmlTable.ToString() });

            articleReader.Close();
            articleReader.Dispose();
        }

    }
}