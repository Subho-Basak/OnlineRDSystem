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

    }

    protected void TextBox1_TextChanged(object sender, EventArgs e)
    {
        int id = Convert.ToInt32(TextBox1.Text);
        ArrayList list = lc.fetchSingleAccount(id);
        String lpdate = lc.fetchPaymentDate(id);
        if (list != null)
        {
            Label1.Visible = false;
        }

        String date = list[12].ToString();
        Label2.Text = id.ToString();
        Label3.Text= list[1].ToString() + " " + list[2].ToString() + " " + list[3].ToString();
        DateTime opdate = Convert.ToDateTime(date);
        Label4.Text = list[14].ToString();
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
                    Label5.Text = (diff-1).ToString();
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