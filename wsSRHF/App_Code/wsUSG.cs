using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Linq;
using System.Web;
using System.Web.Services;

/// <summary>
/// Summary description for wsUSG
/// </summary>
[WebService(Namespace = "http://tempuri.org/")]
[WebServiceBinding(ConformsTo = WsiProfiles.BasicProfile1_1)]
// To allow this Web Service to be called from script, using ASP.NET AJAX, uncomment the following line. 
// [System.Web.Script.Services.ScriptService]
public class wsUSG : System.Web.Services.WebService
{
    MySqlConnection cm = new MySqlConnection(ConfigurationManager.ConnectionStrings["cs"].ConnectionString);

    [WebMethod]
    public Server2Client GetUSG()
    {
        Server2Client sc = new Server2Client();
        MySqlCommand cmd = new MySqlCommand("ID, I_Date, DailyNo, MonthlyNo, EMRNo, Diagnosis, ReceiptNo, Remarks, Charge FROM usg", cm);
        MySqlDataAdapter da = new MySqlDataAdapter(cmd);
        DataSet ds = new DataSet();
        da.Fill(ds);
        sc.count = ds.Tables[0].Rows.Count;
        sc.dt = ds.Tables[0];
        return sc;
    }

    [WebMethod]
    public Server2Client GetUSGByPatient(string EMRNo)
    {
        Server2Client sc = new Server2Client();
        MySqlCommand cmd = new MySqlCommand("ID, I_Date, DailyNo, MonthlyNo, EMRNo, Diagnosis, ReceiptNo, Remarks, Charge FROM usg WHERE EMRNo='" + EMRNo + "'", cm);
        MySqlDataAdapter da = new MySqlDataAdapter(cmd);
        DataSet ds = new DataSet();
        da.Fill(ds);
        sc.count = ds.Tables[0].Rows.Count;
        sc.dt = ds.Tables[0];
        return sc;
    }

    [WebMethod]
    public Server2Client AddUSG(USG usg)
    {
        Server2Client sc = new Server2Client();
        MySqlCommand cmd = new MySqlCommand("INSERT INTO usg (I_Date, DailyNo, MonthlyNo, EMRNo, Diagnosis, ReceiptNo, Remarks, Charge) VALUES (@IDT, @DNO, @MNO, @ERM, @DGN, @RNO, @RMK, @CRG)", cm);
        cmd.Parameters.AddWithValue("@IDT", usg.I_Date);
        cmd.Parameters.AddWithValue("@DNO", usg.DailyNo);
        cmd.Parameters.AddWithValue("@MNO", usg.MonthlyNo);
        cmd.Parameters.AddWithValue("@ERM", usg.EMRNo);
        cmd.Parameters.AddWithValue("@DGN", usg.Diagnosis);
        cmd.Parameters.AddWithValue("@RNO", usg.ReceiptNo);
        cmd.Parameters.AddWithValue("@RMK", usg.Remarks);
        cmd.Parameters.AddWithValue("@CRG", usg.Charge);
        try
        {
            cm.Open();
            cmd.ExecuteNonQuery();
        }
        catch (Exception ex)
        {
            sc.message = ex.Message;
        }
        finally { cm.Close(); }
        return sc;
    }

    [WebMethod]
    public Server2Client UpdateUSG(USG usg)
    {
        Server2Client sc = new Server2Client();
        MySqlCommand cmd = new MySqlCommand("UPDATE usg SET I_Date=@IDT, DailyNo=@DNO, MonthlyNo=@MNO, EMRNo=@ERM, Diagnosis=@DGN, ReceiptNo=@RNO, Remarks=@RMK, Charge=@CRG WHERE ID=" + usg.ID, cm);
        cmd.Parameters.AddWithValue("@IDT", usg.I_Date);
        cmd.Parameters.AddWithValue("@DNO", usg.DailyNo);
        cmd.Parameters.AddWithValue("@MNO", usg.MonthlyNo);
        cmd.Parameters.AddWithValue("@ERM", usg.EMRNo);
        cmd.Parameters.AddWithValue("@DGN", usg.Diagnosis);
        cmd.Parameters.AddWithValue("@RNO", usg.ReceiptNo);
        cmd.Parameters.AddWithValue("@RMK", usg.Remarks);
        cmd.Parameters.AddWithValue("@CRG", usg.Charge);
        try
        {
            cm.Open();
            cmd.ExecuteNonQuery();
        }
        catch (Exception ex)
        {
            sc.message = ex.Message;
        }
        finally { cm.Close(); }
        return sc;
    }

    [WebMethod]
    public Server2Client DeleteUSG(USG usg)
    {
        Server2Client sc = new Server2Client();
        MySqlCommand cmd = new MySqlCommand("DELETE FROM usg WHERE ID=" + usg.ID, cm);

        try
        {
            cm.Open();
            cmd.ExecuteNonQuery();
        }
        catch (Exception ex)
        {
            sc.message = ex.Message;
        }
        finally { cm.Close(); }
        return sc;
    }


}
