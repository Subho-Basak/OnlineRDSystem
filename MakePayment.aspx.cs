﻿using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class MakePayment : System.Web.UI.Page
{
    LogicClass lc = new LogicClass();
   
    protected void Page_Load(object sender, EventArgs e)
    {
       // String id = Request.QueryString['a'].ToString();
          //  TextBox1.Text = id;
      
       
        
        if (!IsPostBack)
        {
            if (Session["username"] != "")
            {
                tableContainer.Visible = false;
                paynow.Visible = false;
            }
        }
        //Label1.Text = "";
        //Label2.Text = "";
        //Label3.Text = "";
    }

    protected void TextBox1_TextChanged(object sender, EventArgs e)
    {
        if (TextBox1.Text != "") { 
            ArrayList list = lc.fetchFewSingleAccount(TextBox1.Text);
        string lpdate = lc.fetchPaymentDate(TextBox1.Text);
        fetchPayment(list, lpdate);
        }
        else
        {
            theMsg.Visible = true;
        }
    }

    protected void TextBox6_TextChanged(object sender, EventArgs e)
    {
        if (TextBox6.Text != "")
        {
            ArrayList list = lc.fetchFewJointAccount(TextBox6.Text);
            String lpdate = lc.fetchPaymentDate(TextBox6.Text);
            fetchPayment(list, lpdate);
        }
        else
        {
            theMsg.Visible = true;
        }
    }

    protected void submitBtn_Click(object sender, EventArgs e)
    {
       
        DateTime paymentdate = DateTime.Now;
        Double amount = Convert.ToDouble(TextBox2.Text);
        Double fineamount = Convert.ToDouble(TextBox4.Text);
        Double totalamount = Convert.ToDouble(TextBox5.Text);
        String accountno = Label3.Text;
        String paidby = "";
        if (Request.Form["Paidby"] != null)
        {
            paidby= Request.Form["Paidby"].ToString();
            //Response.Write("<Script>alert(ugender)</script>");
        }
        int paymentid = lc.GeneratePaymentId();
        String msg = null;
        if (paidby == "Post Master")
        {
            String status = "Due";
            String cleareddate = "";
            int duepaymentid = lc.GenerateDuePaymentId();
            msg = lc.NewDuePaymentEntry(duepaymentid, accountno, amount, paymentdate, fineamount, paidby, totalamount, status, cleareddate);
        }

        msg = lc.NewPaymentEntry(paymentid, accountno, amount, paymentdate, fineamount, paidby, totalamount);

        if (msg == "success")
        {
            // Response.Redirect("PaymentSlip.aspx?id="+paymentid);
            Response.Write("<script>alert('Successfully inserted');</script>");
        }
    }

    private void fetchPayment(ArrayList list,String lpdate)
    {
        if (IsPostBack)
        {
            theMsg.Visible = false;
            paynow.Visible = true;
            tableContainer.Visible = true;
 
            if (list != null)
            {

                string date = list[4].ToString();
                DateTime opdate = Convert.ToDateTime(date);

                Label2.Text = list[1] + " " + list[2] + " " + list[3];

                Label3.Text = list[0].ToString();
                TextBox2.Text = list[5].ToString();
                double amount = Convert.ToDouble(TextBox2.Text);
                double fine = 0.0;
                if (lpdate != "")
                {

                    DateTime FirstDate = Convert.ToDateTime(lpdate);
                    DateTime EndDate = DateTime.Now;

                    int diff = (EndDate.Year - FirstDate.Year) * 12 + (EndDate.Month - FirstDate.Month);
                    // Label3.Text = diff.ToString();
                    // Response.Write(diff);
                    if (opdate.Day <= 15)
                    {
                        if (EndDate.Day > 15)
                        {
                            fine = 0.04 * amount * lc.calFine(diff);
                        }
                        else
                        {
                            fine = 0.04 * amount * lc.calFine(diff - 1);
                        }
                    }
                    else
                    {
                        fine = 0.04 * amount * lc.calFine(diff - 1);
                    }

                }

                TextBox3.Text = DateTime.Now.ToString("MM/dd/yyyy");
                TextBox4.Text = fine.ToString();
                TextBox5.Text = (amount + fine).ToString();
            }
            else
            {
                theMsg.Visible = true;
                Label1.Text = "No payment details found";
                paynow.Visible = false;
                tableContainer.Visible = false;
            }
                
        }
    }
}