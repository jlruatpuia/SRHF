using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Linq;
using System.Web;
using System.Web.Services;

/// <summary>
/// Summary description for wsECG
/// </summary>
[WebService(Namespace = "http://tempuri.org/")]
[WebServiceBinding(ConformsTo = WsiProfiles.BasicProfile1_1)]
// To allow this Web Service to be called from script, using ASP.NET AJAX, uncomment the following line. 
// [System.Web.Script.Services.ScriptService]
public class wsECG : System.Web.Services.WebService
{
    MySqlConnection cm = new MySqlConnection(ConfigurationManager.ConnectionStrings["cs"].ConnectionString);

    [WebMethod]
    public Server2Client GetECG()
    {
        Server2Client sc = new Server2Client();
        MySqlCommand cmd = new MySqlCommand("SELECT ID, I_Date, DailyNo, MonthlyNo, EMRNo, Diagnosis, ReceiptNo, Remarks, Charge FROM ecg", cm);
        MySqlDataAdapter da = new MySqlDataAdapter(cmd);
        DataSet ds = new DataSet();
        da.Fill(ds);
        sc.count = ds.Tables[0].Rows.Count;
        sc.dt = ds.Tables[0];
        return sc;
    }

    [WebMethod]
    public ECG GetECGByID(int ID)
    {
        ECG ecg = new ECG();
        MySqlCommand cmd = new MySqlCommand("SELECT I_Date, DailyNo, MonthlyNo, EMRNo, Diagnosis, ReceiptNo, Remarks, Charge FROM ecg WHERE ID=" + ID, cm);
        try
        {
            cm.Open();
            MySqlDataReader rd = cmd.ExecuteReader();
            rd.Read();
            ecg.I_Date = DateTime.Parse(rd[0].ToString());
            ecg.DailyNo = Convert.ToInt32(rd[1]);
            ecg.MonthlyNo = Convert.ToInt32(rd[2]);
            ecg.EMRNo = rd[3].ToString();
            ecg.Diagnosis = rd[4].ToString();
            ecg.ReceiptNo = rd[5].ToString();
            ecg.Remarks = rd[6].ToString();
            ecg.Charge = Convert.ToDouble(rd[7]);
        }
        catch (Exception ex)
        {
            throw ex;
        }
        finally { cm.Close(); }
        return ecg;
    }

    [WebMethod]
    public Server2Client GetECGByEMR(string EMRNo)
    {
        Server2Client sc = new Server2Client();
        MySqlCommand cmd = new MySqlCommand("SELECT I_Date, EMRNo, Diagnosis, ReceiptNo, Remarks, Charge FROM ecg WHERE EMRNo='" + EMRNo + "' ORDER BY I_Date", cm);
        MySqlDataAdapter da = new MySqlDataAdapter(cmd);
        DataSet ds = new DataSet();
        da.Fill(ds);
        sc.count = ds.Tables[0].Rows.Count;
        sc.dt = ds.Tables[0];
        return sc;
    }

    [WebMethod]
    public Server2Client GetECGByDate(DateTime dt)
    {
        Server2Client sc = new Server2Client();
        string d = Settings.getDate(dt);
        MySqlCommand cmd = new MySqlCommand("SELECT ecg.ID, ecg.I_Date, ecg.DailyNo, ecg.MonthlyNo, ecg.EMRNo, patient.PName, patient.Address, patient.Age, CASE WHEN patient.Sex='Male' THEN 'M' ELSE 'F' END AS Sex, ecg.Diagnosis, ecg.ReceiptNo, ecg.Remarks, ecg.Charge FROM ecg INNER JOIN patient ON ecg.EMRNo = patient.EMRNo WHERE DATE(I_DATE)='" + d + "'", cm);
        MySqlDataAdapter da = new MySqlDataAdapter(cmd);
        DataSet ds = new DataSet();
        da.Fill(ds);
        sc.count = ds.Tables[0].Rows.Count;
        sc.dt = ds.Tables[0];
        return sc;
    }

    [WebMethod]
    public Server2Client GetECGByDates(DateTime df, DateTime dt)
    {
        Server2Client sc = new Server2Client();
        string d1 = Settings.getDate(df);
        string d2 = Settings.getDate(dt);
        MySqlCommand cmd = new MySqlCommand("SELECT ecg.ID, ecg.I_Date, ecg.DailyNo, ecg.MonthlyNo, ecg.EMRNo, patient.PName, patient.Address, patient.Age, patient.Sex, ecg.Diagnosis, ecg.ReceiptNo, ecg.Remarks, ecg.Charge FROM ecg INNER JOIN patient ON ecg.EMRNo = patient.EMRNo WHERE DATE(I_DATE) BETWEEN '" + d1 + "' AND '" + d2 + "'", cm);
        MySqlDataAdapter da = new MySqlDataAdapter(cmd);
        DataSet ds = new DataSet();
        da.Fill(ds);
        sc.count = ds.Tables[0].Rows.Count;
        sc.dt = ds.Tables[0];
        return sc;
    }

    [WebMethod]
    public Server2Client AddECG(ECG ecg)
    {
        Server2Client sc = new Server2Client();
        MySqlCommand cmd = new MySqlCommand("INSERT INTO ecg (I_Date, DailyNo, MonthlyNo, EMRNo, Diagnosis, ReceiptNo, Remarks, Charge) VALUES (@IDT, @DNO, @MNO, @ERM, @DGN, @RNO, @RMK, @CRG)", cm);
        cmd.Parameters.AddWithValue("@IDT", ecg.I_Date);
        cmd.Parameters.AddWithValue("@DNO", ecg.DailyNo);
        cmd.Parameters.AddWithValue("@MNO", ecg.MonthlyNo);
        cmd.Parameters.AddWithValue("@ERM", ecg.EMRNo);
        cmd.Parameters.AddWithValue("@DGN", ecg.Diagnosis);
        cmd.Parameters.AddWithValue("@RNO", ecg.ReceiptNo);
        cmd.Parameters.AddWithValue("@RMK", ecg.Remarks);
        cmd.Parameters.AddWithValue("@CRG", ecg.Charge);
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
    public Server2Client UpdateECG(ECG ecg)
    {
        Server2Client sc = new Server2Client();
        MySqlCommand cmd = new MySqlCommand("UPDATE ecg SET I_Date=@IDT, DailyNo=@DNO, MonthlyNo=@MNO, EMRNo=@ERM, Diagnosis=@DGN, ReceiptNo=@RNO, Remarks=@RMK, Charge=@CRG WHERE ID=" + ecg.ID, cm);
        cmd.Parameters.AddWithValue("@IDT", ecg.I_Date);
        cmd.Parameters.AddWithValue("@DNO", ecg.DailyNo);
        cmd.Parameters.AddWithValue("@MNO", ecg.MonthlyNo);
        cmd.Parameters.AddWithValue("@ERM", ecg.EMRNo);
        cmd.Parameters.AddWithValue("@DGN", ecg.Diagnosis);
        cmd.Parameters.AddWithValue("@RNO", ecg.ReceiptNo);
        cmd.Parameters.AddWithValue("@RMK", ecg.Remarks);
        cmd.Parameters.AddWithValue("@CRG", ecg.Charge);
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
    public Server2Client DeleteECG(ECG ecg)
    {
        Server2Client sc = new Server2Client();
        MySqlCommand cmd = new MySqlCommand("DELETE FROM ecg WHERE ID=" + ecg.ID, cm);

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
    public Server2Client GetDailyNo(DateTime dt)
    {
        Server2Client sc = new Server2Client();
        MySqlCommand cmd = new MySqlCommand("SELECT MAX(DailyNo) FROM ecg WHERE DAY(I_Date)=" + dt.Date.Day + " AND MONTH(I_Date)=" + dt.Date.Month + " AND YEAR(I_DATE)=" + dt.Date.Year, cm);
        try
        {
            cm.Open();
            sc.count = Convert.ToInt32(cmd.ExecuteScalar());
            sc.count++;
        }
        catch { sc.count = 1; }
        finally { cm.Close(); }
        return sc;
    }

    [WebMethod]
    public Server2Client GetMonthlyNo(DateTime dt)
    {
        Server2Client sc = new Server2Client();
        MySqlCommand cmd = new MySqlCommand("SELECT MAX(MonthlyNo) FROM ecg WHERE MONTH(I_Date)=" + dt.Date.Month + " AND YEAR(I_DATE)=" + dt.Date.Year, cm);
        try
        {
            cm.Open();
            sc.count = Convert.ToInt32(cmd.ExecuteScalar());
            sc.count++;
        }
        catch { sc.count = 1; }
        finally { cm.Close(); }
        return sc;
    }

    [WebMethod]
    public Server2Client GetYearlyNo(DateTime dt)
    {
        Server2Client sc = new Server2Client();
        MySqlCommand cmd = new MySqlCommand("SELECT MAX(YearlyNo) FROM ecg WHERE YEAR(I_DATE)=" + dt.Date.Year, cm);
        try
        {
            cm.Open();
            sc.count = Convert.ToInt32(cmd.ExecuteScalar());
            sc.count++;
        }
        catch { sc.count = 1; }
        finally { cm.Close(); }
        return sc;
    }

   
}
