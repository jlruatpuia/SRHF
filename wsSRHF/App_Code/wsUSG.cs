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
    public USG GetUSGByID(int ID)
    {
        USG x = new USG();
        MySqlCommand cmd = new MySqlCommand("SELECT I_Date, DailyNo, MonthlyNo, EMRNo, Diagnosis, ReceiptNo, Remarks, Charge FROM usg WHERE ID=" + ID, cm);
        try
        {
            cm.Open();
            MySqlDataReader rd = cmd.ExecuteReader();
            rd.Read();
            x.I_Date = DateTime.Parse(rd[0].ToString());
            x.DailyNo = Convert.ToInt32(rd[1]);
            x.MonthlyNo = Convert.ToInt32(rd[2]);
            x.EMRNo = rd[3].ToString();
            x.Diagnosis = rd[4].ToString();
            x.ReceiptNo = rd[5].ToString();
            x.Remarks = rd[6].ToString();
            x.Charge = Convert.ToDouble(rd[7]);
        }
        catch (Exception ex)
        {
            throw ex;
        }
        finally { cm.Close(); }
        return x;
    }

    [WebMethod]
    public Server2Client GetUSGByEMR(string EMRNo)
    {
        Server2Client sc = new Server2Client();
        MySqlCommand cmd = new MySqlCommand("SELECT ID, I_Date, DailyNo, MonthlyNo, EMRNo, Diagnosis, ReceiptNo, Remarks, Charge FROM usg WHERE EMRNo='" + EMRNo + "' ORDER BY I_Date", cm);
        MySqlDataAdapter da = new MySqlDataAdapter(cmd);
        DataSet ds = new DataSet();
        da.Fill(ds);
        sc.count = ds.Tables[0].Rows.Count;
        sc.dt = ds.Tables[0];
        return sc;
    }

    [WebMethod]
    public Server2Client GetUSGByDate(DateTime dt)
    {
        Server2Client sc = new Server2Client();
        string d = Settings.getDate(dt);
        MySqlCommand cmd = new MySqlCommand("SELECT usg.ID, usg.I_Date, usg.DailyNo, usg.MonthlyNo, usg.EMRNo, patient.PName, patient.Address, patient.Age, CASE WHEN patient.Sex = 'Male' THEN 'M' ELSE 'F' END AS Sex, usg.Diagnosis, usg.ReceiptNo, usg.Remarks, usg.Charge FROM usg INNER JOIN patient ON usg.EMRNo = patient.EMRNo WHERE DATE(I_DATE)='" + d + "'", cm);
        MySqlDataAdapter da = new MySqlDataAdapter(cmd);
        DataSet ds = new DataSet();
        da.Fill(ds);
        sc.count = ds.Tables[0].Rows.Count;
        sc.dt = ds.Tables[0];
        return sc;
    }

    [WebMethod]
    public Server2Client GetUSGByDates(DateTime df, DateTime dt)
    {
        Server2Client sc = new Server2Client();
        string d1 = Settings.getDate(df);
        string d2 = Settings.getDate(dt);
        MySqlCommand cmd = new MySqlCommand("SELECT usg.ID, usg.I_Date, usg.DailyNo, usg.MonthlyNo, usg.EMRNo, patient.PName, patient.Address, patient.Age, CASE WHEN patient.Sex = 'Male' THEN 'M' ELSE 'F' END AS Sex, usg.Diagnosis, usg.ReceiptNo, usg.Remarks, usg.Charge FROM usg INNER JOIN patient ON usg.EMRNo = patient.EMRNo WHERE DATE(I_DATE) BETWEEN '" + d1 + "' AND '" + d2 + "'", cm);
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

    [WebMethod]
    public Server2Client GetDailyNo(DateTime dt)
    {
        Server2Client sc = new Server2Client();
        MySqlCommand cmd = new MySqlCommand("SELECT MAX(DailyNo) FROM usg WHERE DAY(I_Date)=" + dt.Date.Day + " AND MONTH(I_Date)=" + dt.Date.Month + " AND YEAR(I_DATE)=" + dt.Date.Year, cm);
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
        MySqlCommand cmd = new MySqlCommand("SELECT MAX(MonthlyNo) FROM usg WHERE MONTH(I_Date)=" + dt.Date.Month + " AND YEAR(I_DATE)=" + dt.Date.Year, cm);
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
        MySqlCommand cmd = new MySqlCommand("SELECT MAX(YearlyNo) FROM usg WHERE YEAR(I_DATE)=" + dt.Date.Year, cm);
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
