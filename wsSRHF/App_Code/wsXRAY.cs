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
    public XRAY GetXRAYByID(int ID)
    {
        XRAY x = new XRAY();
        MySqlCommand cmd = new MySqlCommand("SELECT I_Date, DailyNo, MonthlyNo, EMRNo, Diagnosis, ReceiptNo, Remarks, Charge FROM xray WHERE ID=" + ID, cm);
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
    public Server2Client GetXrayByEMR(string EMRNo)
    {
        Server2Client sc = new Server2Client();
        MySqlCommand cmd = new MySqlCommand("SELECT ID, I_Date, DailyNo, MonthlyNo, EMRNo, Diagnosis, ReceiptNo, Remarks, Charge FROM xray WHERE EMRNo='" + EMRNo + "' ORDER BY I_Date", cm);
        MySqlDataAdapter da = new MySqlDataAdapter(cmd);
        DataSet ds = new DataSet();
        da.Fill(ds);
        sc.count = ds.Tables[0].Rows.Count;
        sc.dt = ds.Tables[0];
        return sc;
    }


    [WebMethod]
    public Server2Client GetXRAYByDate(DateTime dt)
    {
        Server2Client sc = new Server2Client();
        string d = Settings.getDate(dt);
        MySqlCommand cmd = new MySqlCommand("SELECT xray.ID, xray.I_Date, xray.DailyNo, xray.MonthlyNo, xray.EMRNo, patient.PName, patient.Address, patient.Age, CASE WHEN patient.Sex='Male' THEN 'M' ELSE 'F' END AS Sex, xray.Diagnosis, xray.ReceiptNo, xray.Remarks, xray.Charge FROM xray INNER JOIN patient ON xray.EMRNo = patient.EMRNo WHERE DATE(I_DATE)='" + d + "'", cm);
        MySqlDataAdapter da = new MySqlDataAdapter(cmd);
        DataSet ds = new DataSet();
        da.Fill(ds);
        sc.count = ds.Tables[0].Rows.Count;
        sc.dt = ds.Tables[0];
        return sc;
    }

    [WebMethod]
    public Server2Client GetXRAYByDates(DateTime df, DateTime dt)
    {
        Server2Client sc = new Server2Client();
        string d1 = Settings.getDate(df);
        string d2 = Settings.getDate(dt);
        MySqlCommand cmd = new MySqlCommand("SELECT xray.ID, xray.I_Date, xray.DailyNo, xray.MonthlyNo, xray.EMRNo, patient.PName, patient.Address, patient.Age, CASE WHEN patient.Sex='Male' THEN 'M' ELSE 'F' END AS Sex, xray.Diagnosis, xray.ReceiptNo, xray.Remarks, xray.Charge FROM xray INNER JOIN patient ON xray.EMRNo = patient.EMRNo WHERE DATE(I_DATE) BETWEEN '" + d1 + "' AND '" + d2 + "'", cm);
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

    [WebMethod]
    public Server2Client GetDailyNo(DateTime dt)
    {
        Server2Client sc = new Server2Client();
        MySqlCommand cmd = new MySqlCommand("SELECT MAX(DailyNo) FROM xray WHERE DAY(I_Date)=" + dt.Date.Day + " AND MONTH(I_Date)=" + dt.Date.Month + " AND YEAR(I_DATE)=" + dt.Date.Year, cm);
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
        MySqlCommand cmd = new MySqlCommand("SELECT MAX(MonthlyNo) FROM xray WHERE MONTH(I_Date)=" + dt.Date.Month + " AND YEAR(I_DATE)=" + dt.Date.Year, cm);
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
        MySqlCommand cmd = new MySqlCommand("SELECT MAX(YearlyNo) FROM xray WHERE YEAR(I_DATE)=" + dt.Date.Year, cm);
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
