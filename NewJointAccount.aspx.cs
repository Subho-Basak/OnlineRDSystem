using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text.RegularExpressions;
using System.Web;
using System.Web.Services;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class NewJointAccount : System.Web.UI.Page
{
    LogicClass lc = new LogicClass();
    protected void Page_Load(object sender, EventArgs e)
    {
        errPanel.Visible = false;
        TextBox12.Text = DateTime.Now.Date.ToShortDateString();
        TextBox13.Text = DateTime.Now.Date.AddYears(5).ToShortDateString();
        
    }


    protected void submitBtn_Click(object sender, EventArgs e)
    {
        int flag1 = 0, flag2 = 0, flag3 = 0, flag4 = 0,flag5=0;
        String pattern = null;
        pattern = "^([0-9a-zA-Z]([-\\.\\w]*[0-9a-zA-Z])*@([0-9a-zA-Z][-\\w]*[0-9a-zA-Z]\\.)+[a-zA-Z]{2,9})$";
        if ((Regex.IsMatch(TextBox7.Text, pattern))&&(Regex.IsMatch(TextBox33.Text, pattern)))
        {
            flag5 = 1;
        }
        else
        {
            errPanel.Visible = true;
            errMsg.Text = "Invalid Email Id format";
            submitpanel.Style.Add("color", "white");
        }

        if (TextBox1.Text != null && TextBox2.Text != null && TextBox3.Text != null && TextBox4.Text != null && TextBox5.Text != null && TextBox6.Text != null && TextBox7.Text != null && TextBox8.Text != null && TextBox9.Text != null && TextBox10.Text != null && TextBox11.Text != null && TextBox12.Text != null && TextBox13.Text != null && TextBox14.Text != null && TextBox15.Text != null && TextBox16.Text != null && TextBox28.Text != null && TextBox29.Text != null && TextBox30.Text != null && TextBox31.Text != null && TextBox32.Text != null && TextBox33.Text != null && TextBox34.Text != null && TextBox35.Text != null && TextBox36.Text != null && TextBox37.Text != null)
        {
            flag1 = 1;
        }
        if ((FileUpload1.HasFile && FileUpload1.PostedFile != null) && (FileUpload1.HasFile && FileUpload1.PostedFile != null) && (FileUpload3.HasFile && FileUpload3.PostedFile != null) && (FileUpload4.HasFile && FileUpload4.PostedFile != null))
        {
            flag2 = 1;
        }
        if ((Request.Form["psex"] != null) && (Request.Form["ssex"] != null))
        {
            flag3 = 1;
        }

        if ((Request.Form["paid"] != null) && TextBox6.Text != null && TextBox31.Text != null && TextBox12.Text != null && TextBox13.Text != null && TextBox14.Text != null)
        {
            flag4 = 1;
        }

        //primary account holder details

        if (flag1 == 1 && flag2 == 1 && flag3 == 1 && flag4 == 1 && flag5==1)
        {
            String accountno = TextBox1.Text;
            String pfname = TextBox2.Text;
            String pmname = TextBox3.Text;
            String plname = TextBox4.Text;
            String psex = "";
            if (Request.Form["psex"] != null)
            {
                psex = Request.Form["psex"].ToString();
            }
            DateTime pdob = Convert.ToDateTime(TextBox6.Text);//convert to date
            String paddress = TextBox5.Text;
            String pemailid = TextBox7.Text;
            String pcontact = TextBox8.Text;
            String pcity = TextBox9.Text;
            String pstate = TextBox10.Text;
            String pcountry = TextBox11.Text;
            //account details field
            DateTime dop = Convert.ToDateTime(TextBox12.Text);//convert to date
            TextBox13.Text = dop.AddYears(5).ToString();
            DateTime doc = Convert.ToDateTime(TextBox13.Text);//convert to date
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
                Response.Redirect("SuccessResponse.aspx?accountno=" + accountno);
            }
            else
            {
                Response.Redirect("NewJointAccount.aspx");
            }
        }
        else
        {
            errPanel.Visible = true;
            errMsg.Text= "Fields are Empty ! Refresh the page";
            
            submitpanel.Style.Add("color", "white");
        }

    }

    [WebMethod]
    public static string validateAccountNo(String accountno)
    {
        SqlConnection con = new SqlConnection("Data Source=BASAK-PC\\SQLEXPRESS;Initial Catalog=onlinerdsystemdb;Integrated Security=True");

        try
        {
            con.Open();
        }
        catch (InvalidOperationException)
        {
            con.Close();
            con.Open();
        }

        // int accno = Convert.ToInt32(accountno);
        SqlCommand cmd = new SqlCommand("select * from JointAccountTable where accountno=@ID", con);
        cmd.Parameters.AddWithValue("@ID", accountno);
        SqlDataReader dr = cmd.ExecuteReader();
        if (dr.HasRows)
        {
            return "false";
        }
        else
            return "true";

    }

}