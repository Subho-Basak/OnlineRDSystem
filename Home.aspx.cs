using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class Home : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        Label1.Visible = false;
        
    }
   
    protected void LoginBtn_Click1(object sender, EventArgs e)
    {
        if (TextBox1.Text != "Admin" && TextBox2.Text != "password")
        {
            Label1.Visible = true;
            Label1.Text = "Username and Password are incorrect";
        }else if(TextBox1.Text != "Admin")
        {
            Label1.Visible = true;
            Label1.Text = "Username is incorrect";
            TextBox1.Text = "";
        }
        else if (TextBox2.Text != "password")
        {
            Label1.Visible = true;
            Label1.Text = "Password is incorrect";
            TextBox1.Text = "";

        }else
        {
            Response.Redirect("DemoPage.aspx");
        }
    }
}