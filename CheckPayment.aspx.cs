using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class CheckPayment : System.Web.UI.Page
{
    LogicClass lc = new LogicClass();
    protected void Page_Load(object sender, EventArgs e)
    {

    }

    protected void TextBox1_TextChanged(object sender, EventArgs e)
    {
        int accountno = Convert.ToInt32(TextBox1.Text);
        ArrayList arr = lc.FetchSinglePayment(accountno);
        DateTime lpdate = Convert.ToDateTime(arr[5].ToString());
        DateTime opdate = Convert.ToDateTime(arr[3].ToString());
        int mpaid = ((lpdate.Year - opdate.Year) * 12) + (lpdate.Month - opdate.Month);
        DateTime nxtpaid = lpdate.AddMonths(1);
        Label2.Text = arr[4].ToString();
        Label3.Text = arr[0].ToString() +" "+ arr[1].ToString() +" "+ arr[2].ToString();
        Label4.Text = arr[6].ToString();
        Label5.Text = mpaid.ToString();
        Label6.Text = nxtpaid.Date.ToString("d");

    }
}