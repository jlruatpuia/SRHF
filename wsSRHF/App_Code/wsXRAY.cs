using MySql.Data.MySqlClient;
using System;
using System.Configuration;
using System.Data;
using System.Web.Services;

/// <summary>
/// Summary description for wsXRAY
/// </summary>
[WebService(Namespace = "http://tempuri.org/")]
[WebServiceBinding(ConformsTo = WsiProfiles.BasicProfile1_1)]
// To allow this Web Service to be called from script, using ASP.NET AJAX, uncomment the following line. 
// [System.Web.Script.Services.ScriptService]
public class wsXRAY : System.Web.Services.WebService
{

    MySqlConnection cm = new MySqlConnection(ConfigurationManager.ConnectionStrings["cs"].ConnectionString);

    [WebMethod]
    public Server2Client GetXray()
    {
        Server2Client sc = new Server2Client();
        MySqlCommand cmd = new MySqlCommand("ID, I_Date, DailyNo, MonthlyNo, EMRNo, Diagnosis, ReceiptNo, Remarks, Charge FROM xray", cm);
        MySqlDataAdapter da = new MySqlDataAdapter(cmd);
        DataSet ds = new DataSet();
        da.Fill(ds);
        sc.count = ds.Tables[0].Rows.Count;
        sc.dt = ds.Tables[0];
        return sc;
    }

    [WebMethod]
    public Server2Client GetXrayByPatient(string EMRNo)
    {
        Server2Client sc = new Server2Client();
        MySqlCommand cmd = new MySqlCommand("ID, I_Date, DailyNo, MonthlyNo, EMRNo, Diagnosis, ReceiptNo, Remarks, Charge FROM xray WHERE EMRNo='" + EMRNo + "'", cm);
        MySqlDataAdapter da = new MySqlDataAdapter(cmd);
        DataSet ds = new DataSet();
        da.Fill(ds);
        sc.count = ds.Tables[0].Rows.Count;
        sc.dt = ds.Tables[0];
        return sc;
    }

    [WebMethod]
    public Server2Client AddXray(XRAY xray)
    {
        Server2Client sc = new Server2Client();
        MySqlCommand cmd = new MySqlCommand("INSERT INTO xray(I_Date, DailyNo, MonthlyNo, EMRNo, Diagnosis, ReceiptNo, Remarks, Charge) VALUES (@IDT, @DNO, @MNO, @ERM, @DGN, @RNO, @RMK, @CRG)", cm);
        cmd.Parameters.AddWithValue("@IDT", xray.I_Date);
        cmd.Parameters.AddWithValue("@DNO", xray.DailyNo);
        cmd.Parameters.AddWithValue("@MNO", xray.MonthlyNo);
        cmd.Parameters.AddWithValue("@ERM", xray.EMRNo);
        cmd.Parameters.AddWithValue("@DGN", xray.Diagnosis);
        cmd.Parameters.AddWithValue("@RNO", xray.ReceiptNo);
        cmd.Parameters.AddWithValue("@RMK", xray.Remarks);
        cmd.Parameters.AddWithValue("@CRG", xray.Charge);
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
    public Server2Client UpdateXray(XRAY xray)
    {
        Server2Client sc = new Server2Client();
        MySqlCommand cmd = new MySqlCommand("UPDATE xray SET I_Date=@IDT, DailyNo=@DNO, MonthlyNo=@MNO, EMRNo=@ERM, Diagnosis=@DGN, ReceiptNo=@RNO, Remarks=@RMK, Charge=@CRG WHERE ID=" + xray.ID, cm);
        cmd.Parameters.AddWithValue("@IDT", xray.I_Date);
        cmd.Parameters.AddWithValue("@DNO", xray.DailyNo);
        cmd.Parameters.AddWithValue("@MNO", xray.MonthlyNo);
        cmd.Parameters.AddWithValue("@ERM", xray.EMRNo);
        cmd.Parameters.AddWithValue("@DGN", xray.Diagnosis);
        cmd.Parameters.AddWithValue("@RNO", xray.ReceiptNo);
        cmd.Parameters.AddWithValue("@RMK", xray.Remarks);
        cmd.Parameters.AddWithValue("@CRG", xray.Charge);
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
    public Server2Client DeleteXray(XRAY xray)
    {
        Server2Client sc = new Server2Client();
        MySqlCommand cmd = new MySqlCommand("DELETE FROM xray WHERE ID=" + xray.ID, cm);
        
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

    //[WebMethod]
    //public int DailyNo()
    //{
    //    int i = 0;
    //    MySqlCommand cmd = new MySqlCommand("S"
    //}
}
