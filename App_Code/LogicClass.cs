
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.Sql;
using System.Data.SqlClient;
using System.Data.SqlTypes;
using System.Collections;
using System.Web.UI.WebControls;

/// <summary>
/// Summary description for LogicClass
/// </summary>
public class LogicClass
{
    Dbconnection db = new Dbconnection();
    public LogicClass()
    {
        //
        // TODO: Add constructor logic here
        //
    }

    //fetch login credetial from login table
    public ArrayList fetchLoginCredential()
    {
        ArrayList arr = new ArrayList();
        SqlCommand cmd = new SqlCommand("select loginid,loginpass,emailid from LoginTable", db.con);

        db.openconnection();
        SqlDataReader dr = cmd.ExecuteReader();
        if (dr.HasRows)
        {
            while (dr.Read())
            {
                arr.Add(dr[0].ToString());
                arr.Add(dr[1].ToString());
                arr.Add(dr[2].ToString());

            }
        }
        else
        {
            arr = null;
        }
        return arr;
    }




    //To Register New Single Type Account
    public String singleAccountEntry(String accountno,String ufname,String umname,String ulname,String uaddress,String ugender,DateTime udob,String uemailid,String ucontact,String ucity,String ustate,String ucountry,DateTime dop,DateTime doc,Double amount,String signtype,String paidthrough,String nfname,String nmname,String nlname,String ngender,DateTime ndob,String naddress,String nemailid,String ncontact,String ncity, String nstate,String ncountry,Byte[] signproof,Byte[] profileproof)
    {
        String status = "Active";
        SqlCommand cmd = new SqlCommand("Insert into SingleAccountEntryTable values(@v1,@v2,@v3,@v4,@v5,@v6,@v7,@v8,@v9,@v10,@v11,@v12,@v13,@v14,@v15,@v16,@v17,@v18,@v19,@v20,@v21,@v22,@v23,@v24,@v25,@v26,@v27,@v28,@v29,@v30,@v31)", db.con);
        cmd.Parameters.AddWithValue("@v1", accountno);
        cmd.Parameters.AddWithValue("@v2",ufname);
        cmd.Parameters.AddWithValue("@v3",umname);
        cmd.Parameters.AddWithValue("@v4",ulname);
        cmd.Parameters.AddWithValue("@v5",ugender);
        cmd.Parameters.AddWithValue("@v6",udob);
        cmd.Parameters.AddWithValue("@v7",uaddress);
        cmd.Parameters.AddWithValue("@v8",uemailid);
        cmd.Parameters.AddWithValue("@v9",ucontact);
        cmd.Parameters.AddWithValue("@v10",ucity);
        cmd.Parameters.AddWithValue("@v11",ustate);
        cmd.Parameters.AddWithValue("@v12",ucountry);
        cmd.Parameters.AddWithValue("@v13",dop);
        cmd.Parameters.AddWithValue("@v14", doc);
        cmd.Parameters.AddWithValue("@v15", amount);
        cmd.Parameters.AddWithValue("@v16", signtype);
        cmd.Parameters.AddWithValue("@v17", signproof);
        cmd.Parameters.AddWithValue("@v18", profileproof);
        cmd.Parameters.AddWithValue("@v19", paidthrough);
        cmd.Parameters.AddWithValue("@v20", nfname);
        cmd.Parameters.AddWithValue("@v21", nmname);
        cmd.Parameters.AddWithValue("@v22", nlname);
        cmd.Parameters.AddWithValue("@v23", ngender);
        cmd.Parameters.AddWithValue("@v24", ndob);
        cmd.Parameters.AddWithValue("@v25", naddress);
        cmd.Parameters.AddWithValue("@v26", nemailid);
        cmd.Parameters.AddWithValue("@v27", ncontact);
        cmd.Parameters.AddWithValue("@v28", ncity);
        cmd.Parameters.AddWithValue("@v29", nstate);
        cmd.Parameters.AddWithValue("@v30", ncountry);
        cmd.Parameters.AddWithValue("@v31", status);

        db.openconnection();
        

        if (cmd.ExecuteNonQuery() > 0)
            return "success";
        else
            return "failed";
    }


    //fetch account name and opening date from single account
    public ArrayList fetchFewSingleAccount(String accountno)
    {
        ArrayList acclist = new ArrayList();
        SqlCommand cmd = new SqlCommand("select accountno,ufname,umname,ulname,openingdate,openingamount from SingleAccountEntryTable where accountno=@ID", db.con);
        cmd.Parameters.AddWithValue("@ID", accountno);
        db.openconnection();
        SqlDataReader dr = cmd.ExecuteReader();
        
        if (dr.HasRows)
        {

            while (dr.Read())
            {
                acclist.Add(dr[0].ToString());
                acclist.Add(dr[1].ToString());
                acclist.Add(dr[2].ToString());
                acclist.Add(dr[3].ToString());
                acclist.Add(dr[4].ToString());
                acclist.Add(dr[5].ToString());

            }
        }
        else
        {
            acclist = null;
        }
        return acclist;
    }


    //fetch account name and opening date from joint account
    public ArrayList fetchFewJointAccount(String accountno)
    {
        ArrayList acclist = new ArrayList();
        SqlCommand cmd = new SqlCommand("select accountno,pfname,pmname,plname,openingdate,openingamount from JointAccountTable where accountno=@ID", db.con);
        cmd.Parameters.AddWithValue("@ID", accountno);
        db.openconnection();
        SqlDataReader dr = cmd.ExecuteReader();
        if (dr.HasRows)
        {
            while (dr.Read())
            {
                acclist.Add(dr[0].ToString());
                acclist.Add(dr[1].ToString());
                acclist.Add(dr[2].ToString());
                acclist.Add(dr[3].ToString());
                acclist.Add(dr[4].ToString());
                acclist.Add(dr[5].ToString());

            }
        }
        else
        {
            acclist = null;
        }
        return acclist;
    }

    //fetch details of a particular account from singleaccounttable

    public ArrayList fetchSingleAccount( String id)
    {
        ArrayList accList = new ArrayList();

        SqlCommand cmd = new SqlCommand("select * from SingleAccountEntryTable where accountno =@ID",db.con);
        cmd.Parameters.AddWithValue("@ID", id);
        db.openconnection();
        SqlDataReader dr = cmd.ExecuteReader();

        if (dr.HasRows)
        {
            while (dr.Read())
            {
                accList.Add(dr[0].ToString());
                accList.Add(dr[1].ToString());
                accList.Add(dr[2].ToString());
                accList.Add(dr[3].ToString());
                accList.Add(dr[4].ToString());
                accList.Add(dr[5].ToString());
                accList.Add(dr[6].ToString());
                accList.Add(dr[7].ToString());
                accList.Add(dr[8].ToString());
                accList.Add(dr[9].ToString());
                accList.Add(dr[10].ToString());
                accList.Add(dr[11].ToString());
                accList.Add(dr[12].ToString());
                accList.Add(dr[13].ToString());
                accList.Add(dr[14].ToString());
                accList.Add(dr[17].ToString());
                accList.Add(dr[19].ToString());

                accList.Add(dr[20].ToString());
                accList.Add(dr[21].ToString());
                accList.Add(dr[22].ToString());
                accList.Add(dr[23].ToString());
                accList.Add(dr[24].ToString());
                accList.Add(dr[25].ToString());
                accList.Add(dr[26].ToString());
                accList.Add(dr[27].ToString());
                accList.Add(dr[28].ToString());
                accList.Add(dr[29].ToString());
            }
        }
        else {
            accList = null;
        }
            return accList;
    }

    //fetch joint account
    public ArrayList fetchJointAccount(String id)
    {
        ArrayList accList = new ArrayList();

        SqlCommand cmd = new SqlCommand("select * from JointAccountTable where accountno =@ID", db.con);
        cmd.Parameters.AddWithValue("@ID", id);
        db.openconnection();
        SqlDataReader dr = cmd.ExecuteReader();
        if (dr.HasRows)
        {
            while (dr.Read())
            {
                accList.Add(dr[0].ToString());
                accList.Add(dr[1].ToString());
                accList.Add(dr[2].ToString());
                accList.Add(dr[3].ToString());
                accList.Add(dr[6].ToString());
                accList.Add(dr[7].ToString());
                accList.Add(dr[8].ToString());
                accList.Add(dr[9].ToString());
                accList.Add(dr[10].ToString());
                accList.Add(dr[11].ToString());
                accList.Add(dr[12].ToString());
                accList.Add(dr[13].ToString());
                accList.Add(dr[14].ToString());
                accList.Add(dr[17].ToString());
                accList.Add(dr[18].ToString());
                accList.Add(dr[19].ToString());
                accList.Add(dr[20].ToString());
                accList.Add(dr[21].ToString());
                accList.Add(dr[22].ToString());
                accList.Add(dr[23].ToString());
                accList.Add(dr[24].ToString());
                accList.Add(dr[25].ToString());

            }
        }
        else
        {
            accList = null;
        }

        return accList;
    }
    //fetch payment date from PaymentDetailsTable
    public string fetchPaymentDate(String accountno)
    {
        string date = "";
        SqlCommand cmd = new SqlCommand("select top 1 paymentdate from PaymentDetailsTable where accountno = @v1 order by paymentid desc", db.con);
        cmd.Parameters.AddWithValue("@v1", accountno);
        db.openconnection();
        SqlDataReader dr = cmd.ExecuteReader();
        if (dr.HasRows)
        {
            
            while (dr.Read())
            {
                date = dr[0].ToString();
            }
        }
        else
        {
            date = null;
        }
        return date;
    }

    //Fine Calculation
    public int calFine(int m)
    {
        int res = 0;
        if (m < 1)
        {
            return 0;
        }
        else {
            res = m + calFine(m - 1);

        }

        return res;
    }


    //Generate payment Id
    public int GeneratePaymentId()
    {
        int countId = 0;
        SqlCommand cmd = new SqlCommand("Select count(paymentid) from PaymentDetailsTable", db.con);
        db.openconnection();
        SqlDataReader dr = cmd.ExecuteReader();
        while (dr.Read())
        {
            countId=Convert.ToInt32(dr[0].ToString());
        }
        countId++;
        return countId;
    }

    //Generate payment Id
    public int GenerateDuePaymentId()
    {
        int countId = 0;
        SqlCommand cmd = new SqlCommand("Select count(paymentid) from DueTable", db.con);
        db.openconnection();
        SqlDataReader dr = cmd.ExecuteReader();
        while (dr.Read())
        {
            countId = Convert.ToInt32(dr[0].ToString());
        }
        countId++;
        return countId;
    }

    //Insert Payment details
    public String NewPaymentEntry(int paymentid, String accountno, Double amount, DateTime paymentdate, Double fine, String paidby, Double totalamount)
    {
        SqlCommand cmd = new SqlCommand("Insert into PaymentDetailsTable values(@v1,@v2,@v3,@v4,@v5,@v6,@v7)", db.con);
        cmd.Parameters.AddWithValue("@v1", paymentid);
        cmd.Parameters.AddWithValue("@v2", accountno);
        cmd.Parameters.AddWithValue("@v3", amount);
        cmd.Parameters.AddWithValue("@v4", paymentdate);
        cmd.Parameters.AddWithValue("@v5", fine);
        cmd.Parameters.AddWithValue("@v6", paidby);
        cmd.Parameters.AddWithValue("@v7", totalamount);
        db.openconnection();


        if (cmd.ExecuteNonQuery() > 0)
            return "success";
        else
            return "failed";
    }

    //Update account holder details in SingleAccountEntryTable
    public String UpdateSingleAccount(String id,String uaddress,String uemailid,String ucontact,String ucity,String ustate,String ucountry,String naddress,String nemailid,String ncontact,String ncity,String nstate,String ncountry)
    {
        SqlCommand cmd = new SqlCommand("update SingleAccountEntryTable set uaddress=@v1,uemailid=@v2,ucontact=@v3,ucity=@v4,ustate=@v5,ucountry=@v6,naddress=@v7,nemailid=@v8,ncontact=@v9,ncity=@v10,nstate=@v11,ncountry=@v12 where accountno=@ID", db.con);
        cmd.Parameters.AddWithValue("@ID", id);
        cmd.Parameters.AddWithValue("@v1", uaddress);
        cmd.Parameters.AddWithValue("@v2", uemailid);
        cmd.Parameters.AddWithValue("@v3", ucontact);
        cmd.Parameters.AddWithValue("@v4", ucity);
        cmd.Parameters.AddWithValue("@v5", ustate);
        cmd.Parameters.AddWithValue("@v6", ucountry);
        cmd.Parameters.AddWithValue("@v7", naddress);
        cmd.Parameters.AddWithValue("@v8", nemailid);
        cmd.Parameters.AddWithValue("@v9", ncontact);
        cmd.Parameters.AddWithValue("@v10", ncity);
        cmd.Parameters.AddWithValue("@v11", nstate);
        cmd.Parameters.AddWithValue("@v12", ncountry);
        db.openconnection();


        if (cmd.ExecuteNonQuery() > 0)
            return "success";
        else
            return "failed";
    }

    //Update Joint Account Details
    public String UpdateJointAccount(String id, String paddress, String pemailid, String pcontact, String pcity, String pstate, String pcountry, String saddress, String semailid, String scontact, String scity, String sstate, String scountry)
    {
        SqlCommand cmd = new SqlCommand("update JointAccountTable set paddress=@v1,pemailid=@v2,pcontact=@v3,pcity=@v4,pstate=@v5,pcountry=@v6,saddress=@v7,semailid=@v8,scontact=@v9,scity=@v10,sstate=@v11,scountry=@v12 where accountno=@ID", db.con);
        cmd.Parameters.AddWithValue("@ID", id);
        cmd.Parameters.AddWithValue("@v1", paddress);
        cmd.Parameters.AddWithValue("@v2", pemailid);
        cmd.Parameters.AddWithValue("@v3", pcontact);
        cmd.Parameters.AddWithValue("@v4", pcity);
        cmd.Parameters.AddWithValue("@v5", pstate);
        cmd.Parameters.AddWithValue("@v6", pcountry);
        cmd.Parameters.AddWithValue("@v7", saddress);
        cmd.Parameters.AddWithValue("@v8", semailid);
        cmd.Parameters.AddWithValue("@v9", scontact);
        cmd.Parameters.AddWithValue("@v10", scity);
        cmd.Parameters.AddWithValue("@v11", sstate);
        cmd.Parameters.AddWithValue("@v12", scountry);
        db.openconnection();


        if (cmd.ExecuteNonQuery() > 0)
            return "success";
        else
            return "failed";
    }

    //Due entry
    public String NewDuePaymentEntry(int paymentid, String accountno, Double amount, DateTime paymentdate, Double fine, String paidby, Double totalamount,String due,String clearDate)
    {
        SqlCommand cmd = new SqlCommand("Insert into DueTable values(@v1,@v2,@v3,@v4,@v5,@v6,@v7,@v8,@v9)", db.con);
        cmd.Parameters.AddWithValue("@v1", paymentid);
        cmd.Parameters.AddWithValue("@v2", accountno);
        cmd.Parameters.AddWithValue("@v3", amount);
        cmd.Parameters.AddWithValue("@v4", paymentdate);
        cmd.Parameters.AddWithValue("@v5", fine);
        cmd.Parameters.AddWithValue("@v6", paidby);
        cmd.Parameters.AddWithValue("@v7", totalamount);
        cmd.Parameters.AddWithValue("@v8", due);
        cmd.Parameters.AddWithValue("@v9", clearDate);
        db.openconnection();


        if (cmd.ExecuteNonQuery() > 0)
            return "success";
        else
            return "failed";
    }

    //Fetch Payment Details For A Particular Account
    public ArrayList FetchSinglePayment(String accountno)
    {
        ArrayList arr = new ArrayList();
        SqlCommand cmd = new SqlCommand("select s.ufname,s.umname,s.ulname,s.openingdate,p.accountno,p.paymentdate,p.openingamount from PaymentDetailsTable p,SingleAccountEntryTable s where p.accountno=@ID and p.accountno=s.accountno", db.con);
        cmd.Parameters.AddWithValue("@ID", accountno);
        db.openconnection();
        SqlDataReader dr = cmd.ExecuteReader();
        if (dr.HasRows)
        {
            while (dr.Read())
            {
                arr.Add(dr[0].ToString());
                arr.Add(dr[1].ToString());
                arr.Add(dr[2].ToString());
                arr.Add(dr[3].ToString());
                arr.Add(dr[4].ToString());
                arr.Add(dr[5].ToString());
                arr.Add(dr[6].ToString());
            }
        }
        else
        {
            arr = null;
        }
        return arr;
    }


    //Fetch Payment Details For A Particular Account
    public ArrayList FetchJointPayment(String accountno)
    {
        ArrayList arr = new ArrayList();
        SqlCommand cmd = new SqlCommand("select s.pfname,s.pmname,s.plname,s.openingdate,p.accountno,p.paymentdate,p.openingamount from PaymentDetailsTable p,JointAccountTable s where p.accountno=@ID and p.accountno=s.accountno", db.con);
        cmd.Parameters.AddWithValue("@ID",accountno);
        db.openconnection();
        SqlDataReader dr = cmd.ExecuteReader();
        if (dr.HasRows)
        {
            while (dr.Read())
            {
                arr.Add(dr[0].ToString());
                arr.Add(dr[1].ToString());
                arr.Add(dr[2].ToString());
                arr.Add(dr[3].ToString());
                arr.Add(dr[4].ToString());
                arr.Add(dr[5].ToString());
                arr.Add(dr[6].ToString());
            }
        }
        else
        {
            arr = null;
        }
        return arr;
    }



    //update due status
    public String UpdateDueStatus(int paymentid,String cleardate,String status)
    {
        SqlCommand cmd = new SqlCommand("update DueTable set status=@v1,cleardate=@v2 where paymentid=@ID",db.con);
        cmd.Parameters.AddWithValue("@ID", paymentid);
        cmd.Parameters.AddWithValue("@v1",status);
        cmd.Parameters.AddWithValue("@v2", cleardate);
        db.openconnection();

        if (cmd.ExecuteNonQuery() > 0)
            return "success";
        else
            return "failed";
    }

    //joint account entry

    public String jointAccountEntry(String accno, String pfname, String pmname, String plname, String psex, DateTime pdob, String paddr, String pemail, String pcontact, String pcity, String pstate, String pcountry, String sfname, String smname, String slname, String ssex, DateTime sdob, String saddr, String semail, String scontact, String scity, String sstate, String scountry, DateTime dop, DateTime doc, Double amount, String psigntype, String ssigntype, Byte[] psignproof, Byte[] pphotoproof, Byte[] ssignproof, Byte[] sphotoproof, String paidth)
    {
        String status = "Active";
        SqlCommand cmd = new SqlCommand("insert into JointAccountTable values(@v0,@v1,@v2,@v3,@v4,@v5,@v6,@v7,@v8,@v9,@v10,@v11,@v12,@v13,@v14,@v15,@v16,@v17,@v18,@v19,@v20,@v21,@v22,@v23,@v24,@v25,@v26,@v27,@v28,@v29,@v30,@v31,@v32,@v33)", db.con);
        cmd.Parameters.AddWithValue("@v0",accno);
        cmd.Parameters.AddWithValue("@v1",pfname);
        cmd.Parameters.AddWithValue("@v2",pmname);
        cmd.Parameters.AddWithValue("@v3",plname);
        cmd.Parameters.AddWithValue("@v4",psex);
        cmd.Parameters.AddWithValue("@v5",pdob);
        cmd.Parameters.AddWithValue("@v6",paddr);
        cmd.Parameters.AddWithValue("@v7",pemail);
        cmd.Parameters.AddWithValue("@v8",pcontact);
        cmd.Parameters.AddWithValue("@v9",pcity);
        cmd.Parameters.AddWithValue("@v10",pstate);
        cmd.Parameters.AddWithValue("@v11",pcountry);
        cmd.Parameters.AddWithValue("@v12",sfname);
        cmd.Parameters.AddWithValue("@v13",smname);
        cmd.Parameters.AddWithValue("@v14",slname);
        cmd.Parameters.AddWithValue("@v15",ssex);
        cmd.Parameters.AddWithValue("@v16",sdob);
        cmd.Parameters.AddWithValue("@v17",saddr);
        cmd.Parameters.AddWithValue("@v18",semail);

        cmd.Parameters.AddWithValue("@v19",scontact);
        cmd.Parameters.AddWithValue("@v20",scity);
        cmd.Parameters.AddWithValue("@v21",sstate);
        cmd.Parameters.AddWithValue("@v22",scountry);
        cmd.Parameters.AddWithValue("@v23",dop);
        cmd.Parameters.AddWithValue("@v24",doc);
        cmd.Parameters.AddWithValue("@v25",amount);
        cmd.Parameters.AddWithValue("@v26",psigntype);
        cmd.Parameters.AddWithValue("@v27",ssigntype);
        cmd.Parameters.AddWithValue("@v28",psignproof);
        cmd.Parameters.AddWithValue("@v29",pphotoproof);
        cmd.Parameters.AddWithValue("@v30",ssignproof);
        cmd.Parameters.AddWithValue("@v31",sphotoproof);
        cmd.Parameters.AddWithValue("@v32",paidth);
        cmd.Parameters.AddWithValue("@v33", status);
        db.openconnection();

        if(cmd.ExecuteNonQuery() > 0)
        {
            return "success";
        }
        else
        {
            return "false";
        }
    }

    //fetch image

    public Byte[] fetchImage(FileUpload uploadedfile)
    {
        Byte[] uploadedfileByte = null;
        try
        {
            
           
            if (uploadedfile.HasFile && uploadedfile.PostedFile != null)
            {
                //To create a PostedFile
                HttpPostedFile File = uploadedfile.PostedFile;
                //Create byte Array with file len
                uploadedfileByte = new Byte[File.ContentLength];
                //force the control to load data in array
                File.InputStream.Read(uploadedfileByte, 0, File.ContentLength);
               
            }
            
        }
        catch (Exception ex)
        {
            Console.WriteLine(ex.StackTrace);
        }
        return uploadedfileByte;
    }

  /*  public String checkAccountNo(int accno)
    {
        SqlCommand cmd = new SqlCommand("select * from SingleAccountEntryTable where accountno=@ID", db.con);
        cmd.Parameters.AddWithValue("@ID", accno);
        db.openconnection();
        SqlDataReader dr = cmd.ExecuteReader();
        if (dr.HasRows)
        {
            return "true";
        }
        else
            return "false";
    }*/
//fetch few details
    public ArrayList fetchFewAccountDetails(String accountno)
    {
        ArrayList acclist = new ArrayList();
        SqlCommand cmd = new SqlCommand("select accountno,pfname,pmname,plname,openingdate,openingamount from JointAccountTable where accountno=@ID", db.con);
        cmd.Parameters.AddWithValue("@ID", accountno);
        db.openconnection();
        SqlDataReader dr = cmd.ExecuteReader();
        if (dr.HasRows)
        {
            while (dr.Read())
            {
                acclist.Add(dr[0].ToString());
                acclist.Add(dr[1].ToString());
                acclist.Add(dr[2].ToString());
                acclist.Add(dr[3].ToString());
                acclist.Add(dr[4].ToString());
                acclist.Add(dr[5].ToString());

            }
        }
        else
        {
            cmd = new SqlCommand("select accountno,ufname,umname,ulname,openingdate,openingamount from SingleAccountEntryTable where accountno=@ID", db.con);
            cmd.Parameters.AddWithValue("@ID", accountno);
            db.openconnection();
            dr = cmd.ExecuteReader();

            if (dr.HasRows)
            {
                while (dr.Read())
                {
                    acclist.Add(dr[0].ToString());
                    acclist.Add(dr[1].ToString());
                    acclist.Add(dr[2].ToString());
                    acclist.Add(dr[3].ToString());
                    acclist.Add(dr[4].ToString());
                    acclist.Add(dr[5].ToString());

                }
            }
            else
            {
                acclist = null;
            }
        }
        return acclist;
    }

}