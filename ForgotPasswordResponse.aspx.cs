using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Net;
using System.Net.Mail;
using System.Text.RegularExpressions;

public partial class ForgotPasswordResponse : System.Web.UI.Page
{
    LogicClass lc = new LogicClass();
    protected void Page_Load(object sender, EventArgs e)
    {
       
       /* String loginid = Request.QueryString["loginid"].ToString();
        ArrayList list = lc.fetchLoginCredential(loginid);
        String idtxt = "Your Login Id : " + list[0].ToString();
        String passwordtxt = "Your Password : " + list[1].ToString();
        String emailid = list[3].ToString();
        MailMessage mail = new MailMessage();
        mail.From = new MailAddress("onlinerdsystem@gmail.com");
        mail.To.Add(list[3].ToString());
        mail.Subject = "Password Recovery from OnlineRDSystem Admin ";

        mail.Body = idtxt + Environment.NewLine + passwordtxt;
        mail.IsBodyHtml = true;

        SmtpClient smtp = new SmtpClient();
        smtp.Host = "smtp.gmail.com";

        NetworkCredential networkCred = new NetworkCredential();
        networkCred.UserName = "onlinerdsystem@gmail.com";
        networkCred.Password = "rdsystem123456789";
        smtp.UseDefaultCredentials = true;
        smtp.Credentials = networkCred;
        smtp.Port = 587;
        smtp.EnableSsl = true;
        smtp.Send(mail);
        Response.Write("A password recovery mail is forward to your email address");
    }*/
    }
    protected void sendMail(object sender, EventArgs e)
    {
       // String loginid = Request.QueryString["loginid"].ToString();
        ArrayList list = lc.fetchLoginCredential();
        String idtxt = "Your Login Id : " + list[0].ToString();
        String passwordtxt = "Your Password : " + list[1].ToString();
        String emailid = list[2].ToString();

        String pattern = null;
        pattern = "^([0-9a-zA-Z]([-\\.\\w]*[0-9a-zA-Z])*@([0-9a-zA-Z][-\\w]*[0-9a-zA-Z]\\.)+[a-zA-Z]{2,9})$";
        if ((Regex.IsMatch(TextBox1.Text, pattern)))
        {
            if((emailid == TextBox1.Text))
            {

                MailMessage mail = new MailMessage();
                mail.From = new MailAddress("onlinerdsystem@gmail.com");
                mail.To.Add(list[2].ToString());
                mail.Subject = "Password Recovery from OnlineRDSystem Admin ";

                mail.Body = idtxt + Environment.NewLine + passwordtxt;
                mail.IsBodyHtml = true;

                SmtpClient smtp = new SmtpClient();
                smtp.Host = "smtp.gmail.com";

                NetworkCredential networkCred = new NetworkCredential();
                networkCred.UserName = "onlinerdsystem@gmail.com";
                networkCred.Password = "rdsystem123456789";
                smtp.UseDefaultCredentials = true;
                smtp.Credentials = networkCred;
                smtp.Port = 587;
                smtp.EnableSsl = true;
                smtp.Send(mail);
                Label1.Text="A password recovery mail is forward to your email id";
                TextBox1.Text = "";
            }
            else
            {
                Label1.Text = "Your enter Wrong Email Id.";
            }
        }
        else
        {

            Label1.Text = "Invalid Email format. Enter a valid EmailId.";
        }


    }
}