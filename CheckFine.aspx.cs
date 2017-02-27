using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class CheckFine : System.Web.UI.Page
{
    LogicClass lc = new LogicClass();
    protected void Page_Load(object sender, EventArgs e)
    {

        if (!IsPostBack)
        {

            tableContainer.Visible = false;
        }
    }


    //Text Box to search against account number of Single Account
    protected void TextBox1_TextChanged(object sender, EventArgs e)
    {
        // String id = TextBox1.Text;
        ArrayList list = lc.fetchFewSingleAccount(TextBox1.Text);
        String lpdate = lc.fetchPaymentDate(TextBox1.Text);

        if (list != null && lpdate != null)
        {
            checkFineDetails(list, lpdate);
        }else
        {
            theMsg.Visible = true;
            Label1.Visible = true;
            tableContainer.Visible = false;
        }


    }


    //Text Box to search against account number of Joint Account
    protected void TextBox2_TextChanged(object sender, EventArgs e)
    {

        //String id = TextBox1.Text;
        ArrayList list = lc.fetchFewJointAccount(TextBox2.Text);
        String lpdate = lc.fetchPaymentDate(TextBox2.Text);

        if (list != null && lpdate != null)
        {
            checkFineDetails(list, lpdate);
        }
        else
        {
            theMsg.Visible = true;
            Label1.Visible = true;
            tableContainer.Visible = false;
        }
       
    }

    //T calculate Fine and display all details of account along with fine
    private void checkFineDetails(ArrayList list, string lpdate)
    {
       
            theMsg.Visible = false;
            Label1.Visible = false;
            tableContainer.Visible = true;


            Label2.Text = list[0].ToString();
            Label3.Text = list[1].ToString() + " " + list[2].ToString() + " " + list[3].ToString();
            String date = list[4].ToString();
            DateTime opdate = Convert.ToDateTime(date);
            Label4.Text = list[5].ToString();


            double amount = Convert.ToDouble(Label4.Text);

            double fine = 0.0;
            if (lpdate != "")
            {

                DateTime FirstDate = Convert.ToDateTime(lpdate);
                DateTime EndDate = DateTime.Now;

                int diff = (EndDate.Year - FirstDate.Year) * 12 + (EndDate.Month - FirstDate.Month);


                // Response.Write(diff);
                if (opdate.Day <= 15)
                {
                    if (EndDate.Day > 15)
                    {
                        fine = 0.04 * amount * lc.calFine(diff);
                        Label5.Text = diff.ToString();
                    }
                    else
                    {
                        fine = 0.04 * amount * lc.calFine(diff - 1);
                        Label5.Text = (diff - 1).ToString();
                    }
                }
                else
                {
                    fine = 0.04 * amount * lc.calFine(diff - 1);
                    Label5.Text = (diff - 1).ToString();
                }

            }


            Label6.Text = fine.ToString();
        }
       
    
}