using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class NewJointAccount : System.Web.UI.Page
{
    LogicClass lc = new LogicClass();
    protected void Page_Load(object sender, EventArgs e)
    {

    }


    protected void submitBtn_Click(object sender, EventArgs e)
    {
        //primary account holder details
        int accountno = Convert.ToInt32(TextBox1.Text);
        String pfname = TextBox2.Text;
        String pmname = TextBox3.Text;
        String plname = TextBox4.Text;
        String psex = "";
        if (Request.Form["psex"] != null)
        {
            psex = Request.Form["psex"].ToString();
        }
       DateTime pdob =Convert.ToDateTime( TextBox6.Text);//convert to date
        String paddress = TextBox5.Text;
        String pemailid = TextBox7.Text;
        String pcontact = TextBox8.Text;
        String pcity = TextBox9.Text;
        String pstate = TextBox10.Text;
        String pcountry = TextBox11.Text;
        //account details field
        DateTime dop =Convert.ToDateTime( TextBox12.Text);//convert to date
        DateTime doc =Convert.ToDateTime( TextBox13.Text);//convert to date
        Double amount = Convert.ToDouble(TextBox14.Text);
        String psigntype = TextBox15.Text;
        String ssigntype = TextBox16.Text;
        String paidthrough = "";
        if (Request.Form["paid"] != null)
        {
            paidthrough = Request.Form["paid"].ToString();
        }
       // String paidthrough = TextBox26.Text;
        //Secondary account holder details
        String sfname = TextBox28.Text;
        String smname = TextBox29.Text;
        String slname = TextBox30.Text;
        String ssex = "";
        if (Request.Form["ssex"] != null)
        {
            ssex = Request.Form["ssex"].ToString();
        }
        DateTime sdob = Convert.ToDateTime(TextBox31.Text);//convert to date
        String saddress = TextBox32.Text;
        String semailid = TextBox33.Text;
        String scontact = TextBox34.Text;
        String scity = TextBox35.Text;
        String sstate = TextBox36.Text;
        String scountry = TextBox37.Text;
        
        Byte[] psignproof = lc.fetchImage((FileUpload)FileUpload1);
        Byte[] pphotoproof = lc.fetchImage((FileUpload)FileUpload2);
        Byte[] ssignproof = lc.fetchImage((FileUpload)FileUpload3);
        Byte[] sphotoproof = lc.fetchImage((FileUpload)FileUpload4);
        String msg = lc.jointAccountEntry(accountno, pfname, pmname, plname, psex, pdob, paddress, pemailid, pcontact, pcity, pstate, pcountry, sfname, smname, slname, ssex, sdob, saddress, semailid, scontact, scity, sstate, scountry, dop, doc, amount, psigntype, ssigntype, psignproof, pphotoproof, ssignproof, sphotoproof, paidthrough);
        if (msg == "success")
        {
            Response.Redirect("SuccesResponse.aspx?accountno=" + accountno);
        }
        else
        {
            Response.Redirect("NewJointAccount.aspx");
        }
    }

   
}