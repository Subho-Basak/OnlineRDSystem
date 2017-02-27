using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text.RegularExpressions;
using System.Web;
using System.Web.Services;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class DemoPage : System.Web.UI.Page
{
    LogicClass lc = new LogicClass();
    Dbconnection db = new Dbconnection();
    protected void Page_Load(object sender, EventArgs e)
    {
        errPanel.Visible = false;

        TextBox12.Text = DateTime.Now.Date.ToShortDateString();
        TextBox13.Text = DateTime.Now.Date.AddYears(5).ToShortDateString();
        
        if (!IsPostBack)
        {
            TextBox12.Text = DateTime.Now.Date.ToShortDateString();
            TextBox13.Text = DateTime.Now.Date.AddYears(5).ToShortDateString();
        
        }
    }

    protected void submitBtn_Click(object sender, EventArgs e)
    {
        //Accountholder Details
        int flag1 = 0,flag2=0,flag3=0,flag4=0,flag5=0;

        String pattern = null;
        pattern = "^([0-9a-zA-Z]([-\\.\\w]*[0-9a-zA-Z])*@([0-9a-zA-Z][-\\w]*[0-9a-zA-Z]\\.)+[a-zA-Z]{2,9})$";
        if ((Regex.IsMatch(TextBox7.Text, pattern)) && (Regex.IsMatch(TextBox21.Text, pattern)))
        {
            flag5 = 1;
        }
        else
        {

            errPanel.Visible = true;
            errMsg.InnerHtml = "Invalid Email Id format";
            submitpanel.Style.Add("color", "white");
        }



        if (TextBox1.Text != "" || TextBox2.Text != "" || TextBox3.Text != "" || TextBox4.Text != "" || TextBox5.Text != "" || TextBox6.Text != "" || TextBox7.Text != "" || TextBox8.Text != "" || TextBox9.Text != "" || TextBox10.Text != "" || TextBox11.Text != "" || TextBox12.Text != "" || TextBox13.Text != "" || TextBox14.Text != "" || TextBox15.Text != "" || TextBox16.Text != "" || TextBox17.Text != "" || TextBox18.Text != "" || TextBox19.Text != "" || TextBox20.Text != "" || TextBox21.Text != "" || TextBox22.Text != "" || TextBox23.Text != "" || TextBox24.Text != "" || TextBox25.Text != "")
        {
            flag1 = 1;
        }
        if (TextBox6.Text != "" && TextBox8.Text != "" && TextBox12.Text != "" && TextBox13.Text != "" && TextBox14.Text != "" && TextBox19.Text != "")
        {
            flag2 = 1;
        }
        if ((Request.Form["UGender"] != null)&&(Request.Form["NGender"] != null) && (Request.Form["pth"] != null) && (Request.Form["pth"] != null))
        {
            flag3 = 1;
        }
        if((FileUpload1.HasFile&&FileUpload1.PostedFile!=null)&&(FileUpload2.HasFile && FileUpload2.PostedFile != null))
        {
            flag4 = 1;
        }

            if (flag1==1 && flag2 == 1 && flag3==1&&flag4==1) { 
            String accountno = TextBox1.Text;
            String ufname = TextBox2.Text;
            String umname = TextBox3.Text;
            String ulname = TextBox4.Text;
            String uaddress = TextBox5.Text;
            String uemailid = TextBox7.Text;
            String ucontact = TextBox8.Text;
            String ucity = TextBox9.Text;
            String ustate = TextBox10.Text;
            String ucountry = TextBox11.Text;
            String ugender = null;
            if (Request.Form["UGender"] != null)
            {
                ugender = Request.Form["UGender"].ToString();
                Response.Write("<Script>alert(ugender)</script>");
            }
            String paidthrough = "";
            if (Request.Form["pth"] != null)
            {
                paidthrough = Request.Form["pth"].ToString();
            }
            string udobstr = TextBox6.Text;
            DateTime udob = Convert.ToDateTime(udobstr);

            //Account Details
            DateTime dop = Convert.ToDateTime((string)TextBox12.Text);
            DateTime doc = Convert.ToDateTime((string)TextBox13.Text);
            Double amount = Convert.ToDouble(TextBox14.Text);
            String signtype = TextBox15.Text;
           
            // FileUpload signproof = (FileUpload)FileUpload1;
            Byte[] signByte = null;
            Byte[] profileByte = null;
            try
            {
                FileUpload signproof = (FileUpload)FileUpload1;
                signByte = null;
                if (signproof.HasFile && signproof.PostedFile != null)
                {
                    //To create a PostedFile
                    HttpPostedFile File = FileUpload1.PostedFile;
                    //Create byte Array with file len
                    signByte = new Byte[File.ContentLength];
                    //force the control to load data in array
                    File.InputStream.Read(signByte, 0, File.ContentLength);
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.StackTrace);
            }

            try
            {
                FileUpload profileproof = (FileUpload)FileUpload2;
                profileByte = null;
                if (profileproof.HasFile && profileproof.PostedFile != null)
                {
                    //To create a PostedFile
                    HttpPostedFile File1 = FileUpload2.PostedFile;
                    //Create byte Array with file len
                    profileByte = new Byte[File1.ContentLength];
                    //force the control to load data in array
                    File1.InputStream.Read(profileByte, 0, File1.ContentLength);
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.StackTrace);
            }

            //Nominee Details
            String nfname = TextBox16.Text;
            String nmname = TextBox17.Text;
            String nlname = TextBox18.Text;
            DateTime ndob = Convert.ToDateTime((string)TextBox19.Text);
            String naddress = TextBox20.Text;
            String nemailid = TextBox21.Text;
            String ncontact = TextBox22.Text;
            String ncity = TextBox23.Text;
            String nstate = TextBox24.Text;
            String ncountry = TextBox25.Text;
            String ngender = null;
            if (Request.Form["NGender"] != null)
            {
                ngender = Request.Form["NGender"].ToString();
                Response.Write("<Script>alert(ngender)</script>");
            }
       
            String msg = lc.singleAccountEntry(accountno, ufname, umname, ulname, uaddress, ugender, udob, uemailid, ucontact, ucity, ustate, ucountry, dop, doc, amount, signtype, paidthrough, nfname, nmname, nlname, ngender, ndob, naddress, nemailid, ncontact, ncity, nstate, ncountry, signByte, profileByte);

            if (msg == "success")
            {

                //Response.Write("<Script>alert('Succesfull')</script>");
                Response.Redirect("SuccessResponse.aspx?accountno=" + accountno);
            }

            //Console.WriteLine(udob);

        }
        else {
            errPanel.Visible = true;
            errMsg.InnerHtml= "Validation failed.Some fields are Empty.";
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
        SqlCommand cmd = new SqlCommand("select * from SingleAccountEntryTable where accountno=@ID", con);
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