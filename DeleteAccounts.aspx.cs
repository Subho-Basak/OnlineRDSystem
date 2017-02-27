using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Web.Services;
using System.Data.SqlClient;

public partial class DeleteAccounts : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {

    }

    [WebMethod]
    public static String checkPassword(String pass)
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

        SqlCommand cmd = new SqlCommand("select loginpass from LoginTable where loginpass=@v",con);
        cmd.Parameters.AddWithValue("@v", pass);
        SqlDataReader dr = cmd.ExecuteReader();

        if (dr.HasRows)
        {
            return "true";
        }else
            return "false";
    }

    [WebMethod]
    public static String validateAccountNo(String accountno)
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
        SqlCommand cmd = new SqlCommand("select * from SingleAccountEntryTable where accountno=@ID and status=@v1", con);
        cmd.Parameters.AddWithValue("@ID", accountno);
        cmd.Parameters.AddWithValue("@v1", "Active");
        SqlDataReader dr = cmd.ExecuteReader();
        if (dr.HasRows)
        {
            return "true";
        }
        else
        {
            String ret = jointValidation(accountno);
            return ret;
           /*
            SqlCommand cmd1 = new SqlCommand("select * from JointAccountTable where accountno=@ID", con);
            cmd1.Parameters.AddWithValue("@ID", accountno);
            SqlDataReader dr1 = cmd1.ExecuteReader();
            if (dr1.HasRows)
            {
                return "true";
            }
            else
            {
                return "false";
            }
            */
        }
           

    }

    [WebMethod]
    public static String jointValidation(String accno)
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

        SqlCommand cmd1 = new SqlCommand("select * from JointAccountTable where accountno=@ID and status=@v1", con);
        cmd1.Parameters.AddWithValue("@ID", accno);
        cmd1.Parameters.AddWithValue("@v1", "Active");
        SqlDataReader dr1 = cmd1.ExecuteReader();
        if (dr1.HasRows)
        {
            return "true";
        }
        else
        {
            return "false";
        }

    }

    [WebMethod]
    public static String deleteAccount(String accountno)
    {
        String status = "Deleted";
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
        SqlCommand cmd = new SqlCommand("update SingleAccountEntryTable set status=@v1 where accountno=@ID", con);
        cmd.Parameters.AddWithValue("@ID", accountno);
        cmd.Parameters.AddWithValue("@v1", status);
        if (cmd.ExecuteNonQuery() > 0)
        {
            return "true";
        }
        else
        {
           // String ret = deleteJointAccount(accountno);
            //return ret;
            
            cmd = new SqlCommand("update JointAccountTable set status=@v1 where accountno=@ID", con);
            cmd.Parameters.AddWithValue("@ID", accountno);
            cmd.Parameters.AddWithValue("@v1", status);
            if (cmd.ExecuteNonQuery() > 0)
            {
                return "true";
            }
            else
            {
                return "false";
            }
            
        }
    }

   /* [WebMethod]
    public static String deleteJointAccount(String accountno)
    {

        String status = "Deleted";
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


        SqlCommand cmd = new SqlCommand("update JointAccountTable set status=@v1 where accountno=@ID", con);
       
        cmd.Parameters.AddWithValue("@ID", accountno);
        cmd.Parameters.AddWithValue("@v1", status);
        if (cmd.ExecuteNonQuery() > 0)
        {
            return "success";
        }
        else
        {
            return "failed";
        }
    }*/
}