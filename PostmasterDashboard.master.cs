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

    }
    
    protected void TextBox1_TextChanged(object sender, EventArgs e)
    {
        
        if(dropdown.Text=="Account Number")
        {
            Boolean valid=IsDigitsOnly(TextBox1.Text);
            if (valid == true)
                errMsg.InnerHtml = "Only numners are allowed";
            else
                Response.Redirect("AccountholderDetails.aspx?a=" + TextBox1.Text);
        }
        if (dropdown.Text == "Account Holder ")
        {
            Boolean valid = IsDigitsOnly(TextBox1.Text);
            if (valid == false)
                errMsg.InnerHtml = "Only alphabets are allowed";
            else { 
            String accname = TextBox1.Text;
                accname = accname.Replace(" ","");
               
           Response.Redirect("PostMasterDashboard.aspx?accname=" + accname);
        }
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

   
}
