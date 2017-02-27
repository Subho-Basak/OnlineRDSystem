using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Net.Mail;
using System.Collections;

public partial class Home : System.Web.UI.Page
{
    LogicClass lc = new LogicClass();

    protected void Page_Load(object sender, EventArgs e)
    {
        Label1.Visible = false;
        
    }

    protected void LoginBtn_Click1(object sender, EventArgs e)
    {
        ArrayList list = lc.fetchLoginCredential();
        if ((TextBox1.Text == "") || (TextBox2.Text == ""))
        {
            
            Label1.Visible = true;
            Label1.Text = "Username or Password field is empty";
        }
        else {

            if ((TextBox1.Text == "Admin") && (TextBox2.Text == "adminrdedbo123"))
            {
                Label1.Visible = true;
                Label1.Text = "Admin Control will be available soon";
            }
            else {

                if ((TextBox1.Text == list[0].ToString()) && (TextBox2.Text == list[1].ToString()))
                {
                    //Session["loginid"] = TextBox1.Text;
                    Response.Redirect("DemoPage.aspx");
                }
                else if (TextBox1.Text != list[0].ToString())
                {
                    Label1.Visible = true;
                    Label1.Text = "Invalid Username";
                }
                else if ((TextBox1.Text == list[0].ToString()) && (TextBox2.Text != list[1].ToString()))
                {
                    Label1.Visible = true;
                    Label1.Text = "Invalid Password";
                }
                else
                {
                    Label1.Visible = true;
                    Label1.Text = "Invalid Username or Password";
                }

            }
        }
    }
    
}