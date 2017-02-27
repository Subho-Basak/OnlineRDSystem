<%@ WebHandler Language="C#" Class="FetchImage" %>

using System;
using System.Configuration;
using System.Web;
using System.IO;
using System.Data;
using System.Data.SqlClient;
public class FetchImage : IHttpHandler
{

    Dbconnection db = new Dbconnection();
    public void ProcessRequest(HttpContext context)
    {
        String empno;
        string type = "";
        //int id;
        if (context.Request.QueryString["accno"] != null )
        {
            empno = context.Request.QueryString["accno"];
            //type= context.Request.QueryString["type"];
        }

        else
            throw new ArgumentException("No parameter specified");

        context.Response.ContentType = "image/jpeg";
        Stream strm = ShowEmpImage(empno,type);
        byte[] buffer = new byte[4096];
        int byteSeq = strm.Read(buffer, 0, 4096);

        while (byteSeq > 0)
        {

            context.Response.OutputStream.Write(buffer, 0, byteSeq);
            byteSeq = strm.Read(buffer, 0, 4096);
        }
        //context.Response.BinaryWrite(buffer);
    }



    public Stream ShowEmpImage(String empno,string type)
    {
        String sql = "SELECT profilephoto FROM SingleAccountEntryTable WHERE accountno = @ID";

        //sql = "SELECT pphotoproof FROM JointAccountTable WHERE accountno = @ID";



        SqlCommand cmd = new SqlCommand(sql, db.con);
        cmd.CommandType = CommandType.Text;
        cmd.Parameters.AddWithValue("@ID", empno);

        db.openconnection();
        object img = cmd.ExecuteScalar();
        if (img == null)
        {
                sql = "SELECT pphotoproof FROM JointAccountTable WHERE accountno = @ID";



        cmd = new SqlCommand(sql, db.con);
        cmd.CommandType = CommandType.Text;
        cmd.Parameters.AddWithValue("@ID", empno);

        db.openconnection();
        img = cmd.ExecuteScalar();

        }
        try
        {
            return new MemoryStream((byte[])img);
        }
        catch
        {
            return null;
        }
        finally
        {
            db.con.Close();
        }
    }

    public bool IsReusable
    {
        get
        {
            return false;
        }
    }
}
