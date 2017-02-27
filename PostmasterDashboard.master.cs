using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class PostmasterDashboard : System.Web.UI.MasterPage
{
    
    protected void Page_Load(object sender, EventArgs e)
    { 
       /* if (!IsPostBack)
        {
            if (Session["username"] == "")
            {
                Response.Redirect("Home.aspx");
            }
        }*/
    }

    protected void TextBox1_TextChanged(object sender, EventArgs e)
    {
        Boolean valid = IsDigitsOnly(TextBox1.Text);
        if (valid == true)
            errMsg.InnerHtml = "Only numbers are allowed";
        else {
            // String qry = "a=" + TextBox1.Text + "&t=" + dropdown.Text;
            Response.Redirect("AccountholderDetails.aspx?a=" + TextBox1.Text);
            //dropdown.Text = dropdown.Text.Replace(" ","");
            //Response.Redirect(String.Format("AccountholderDetails.aspx?a={0}&t={1}", Server.UrlEncode(TextBox1.Text), Server.UrlEncode(dropdown.Text)));
        }
    }

    protected void TextBox2_TextChanged(object sender, EventArgs e)
    {
        Boolean valid = IsDigitsOnly(TextBox2.Text);
        if (valid == false)
            errMsg.InnerHtml = "Only alphabets are allowed";
        else {
            String accname = TextBox2.Text;
            accname = accname.Replace(" ", "");

            Response.Redirect("PostMasterDashboard.aspx?accname=" + accname);
        }
    }

    private Boolean IsDigitsOnly(string str)
    {
        foreach (char c in str)
        {
            if (char.IsDigit(c))
                return false;
        }

        return true;
    }

    protected void Button1_Click(object sender, EventArgs e)
    {
       
    }
}
