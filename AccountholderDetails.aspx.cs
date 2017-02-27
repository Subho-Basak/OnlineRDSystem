using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class AccountholderDetails : System.Web.UI.Page
{
    LogicClass lc = new LogicClass();
    protected void Page_Load(object sender, EventArgs e)
    {
        Panel1.Visible = false;
        if (!IsPostBack)
        {
            ArrayList list = new ArrayList();

            String id = Request.QueryString["a"].ToString();
           // String type= Request.QueryString["t"].ToString();
            
            //int id = Convert.ToInt32(Request.QueryString["a"].ToString());

            //list = lc.fetchJointAccount(id);
            list = lc.fetchSingleAccount(id);
            if (list == null)
             {

                Response.Redirect("JointAccountHolderDetails.aspx?a=" + id);
             }
             Label4.Text = list[1] + " " + list[2] + " " + list[3];
             Label1.Text = list[0].ToString();
             Label3.Text = list[4].ToString();
             DateTime opdate = Convert.ToDateTime(list[12].ToString());

             Label5.Text = opdate.Date.ToString("d");
             DateTime cldate = Convert.ToDateTime(list[13].ToString());
             Label6.Text = cldate.Date.ToString("d");
             TextBox5.Text = list[6].ToString();
             TextBox7.Text = list[7].ToString();
             TextBox8.Text = list[8].ToString();
             TextBox9.Text = list[9].ToString();
             TextBox10.Text = list[10].ToString();
             TextBox11.Text = list[11].ToString();

             Label7.Text = list[16].ToString();
             Label8.Text = list[17].ToString();
             Label9.Text = list[18].ToString();
             Label10.Text = list[19].ToString();
             DateTime ndob = Convert.ToDateTime(list[20].ToString());
             Label11.Text = ndob.Date.ToString("d");

             TextBox20.Text = list[21].ToString();
             TextBox21.Text = list[22].ToString();
             TextBox22.Text = list[23].ToString();
             TextBox23.Text = list[24].ToString();
             TextBox24.Text = list[25].ToString();
             TextBox25.Text = list[26].ToString();

             Image1.ImageUrl = "FetchImage.ashx?accno=" + id;

           // pay.HRef = "MakePayment.aspx?a="+id;

        }
    }

    protected void submitBtn_Click(object sender, EventArgs e)
    {
        String msg = lc.UpdateSingleAccount(Label1.Text,TextBox5.Text, TextBox7.Text, TextBox8.Text, TextBox9.Text, TextBox10.Text, TextBox11.Text, TextBox20.Text, TextBox21.Text, TextBox22.Text, TextBox23.Text, TextBox24.Text, TextBox25.Text);
        
        if (msg == "success")
        {
            Panel1.Visible = true;

            //Response.Write("<script>alert('Successfully Updated')</script>");
        }
    }
}