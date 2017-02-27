using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class JointAccountHolderDetails : System.Web.UI.Page
{
    LogicClass lc = new LogicClass();
    protected void Page_Load(object sender, EventArgs e)
    {
        if (!IsPostBack)
        {
            ArrayList list = new ArrayList();

            String id = Request.QueryString["a"].ToString();
            list = lc.fetchJointAccount(id);
            if (list != null)
            {
                theMsg.Visible = false;
               DateTime opdate = Convert.ToDateTime(list[19].ToString());
               DateTime cldate = Convert.ToDateTime(list[20].ToString());
                Label1.Text = list[0].ToString();
                Label4.Text = list[1].ToString() + " " + list[2].ToString() + " " + list[3].ToString();
                Label5.Text = opdate.Date.ToShortDateString();
                Label6.Text = cldate.Date.ToShortDateString();
                Label7.Text = list[10].ToString() + " " + list[11].ToString() + " " + list[12].ToString();
                TextBox5.Text = list[4].ToString();
                TextBox7.Text = list[5].ToString();
                TextBox8.Text = list[6].ToString();
                TextBox9.Text = list[7].ToString();
                TextBox10.Text = list[8].ToString();
                TextBox11.Text = list[9].ToString();
                TextBox20.Text = list[13].ToString();
                TextBox21.Text = list[14].ToString();
                TextBox22.Text = list[15].ToString();
                TextBox23.Text = list[16].ToString();
                TextBox24.Text = list[17].ToString();
                TextBox25.Text = list[18].ToString();
                Image1.ImageUrl = "FetchImage.ashx?accno=" + id;
                Image2.ImageUrl = "FetchImage.ashx?accno=" + id;

            }
            else
            {

                theMsg.Visible = true;
                accContainer.Visible = false;
            }
        }
    }

    protected void submitBtn_Click(object sender, EventArgs e)
    {
        String msg = lc.UpdateSingleAccount(Label1.Text, TextBox5.Text, TextBox7.Text, TextBox8.Text, TextBox9.Text, TextBox10.Text, TextBox11.Text, TextBox20.Text, TextBox21.Text, TextBox22.Text, TextBox23.Text, TextBox24.Text, TextBox25.Text);

        if (msg == "success")
        {
            //Response.Write("<script>alert('Successfully Updated')</script>");
        }
    }
}