using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.SqlClient;

/// <summary>
/// Summary description for Dbconnection
/// </summary>
public class Dbconnection
{
    public Dbconnection()
    { }
        //
        // TODO: Add constructor logic here
        //
        public SqlConnection con = new SqlConnection("Data Source=BASAK-PC\\SQLEXPRESS;Initial Catalog=onlinerdsystemdb;Integrated Security=True");
    public void openconnection()
    {
        try
        {
            con.Open();
        }
        catch (InvalidOperationException)
        {
            con.Close();
            con.Open();
        }
    }
}
