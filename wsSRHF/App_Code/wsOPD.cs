using MySql.Data.MySqlClient;
using System;
using System.Configuration;
using System.Data;
using System.Web.Services;


/// <summary>
/// Summary description for wsOPD
/// </summary>
[WebService(Namespace = "http://tempuri.org/")]
[WebServiceBinding(ConformsTo = WsiProfiles.BasicProfile1_1)]
// To allow this Web Service to be called from script, using ASP.NET AJAX, uncomment the following line. 
// [System.Web.Script.Services.ScriptService]
public class wsOPD : System.Web.Services.WebService
{
    MySqlConnection cm = new MySqlConnection(ConfigurationManager.ConnectionStrings["cs"].ConnectionString);
    
    [WebMethod]
    public Server2Client GetOPD()
    {
        Server2Client sc = new Server2Client();
        MySqlCommand cmd = new MySqlCommand("SELECT opd.ID, opd.I_Date, opd.DailyNo, opd.MonthlyNo, opd.YearlyNo, opd.EMRNo, opd.OPDNo, opd.Cases, patient.PName, patient.Address, patient.Age, patient.Sex FROM opd INNER JOIN patient ON patient.EMRNo = opd.EMRNo", cm);
        MySqlDataAdapter da = new MySqlDataAdapter(cmd);
        DataSet ds = new DataSet();
        da.Fill(ds);
        sc.count = ds.Tables[0].Rows.Count;
        sc.dt = ds.Tables[0];
        return sc;
    }

    [WebMethod]
    public OPD GetOPDByID(int ID)
    {
        OPD o = new OPD();
        MySqlCommand cmd = new MySqlCommand("SELECT opd.ID, opd.I_Date, opd.DailyNo, opd.MonthlyNo, opd.YearlyNo, opd.EMRNo, opd.OPDNo, opd.Cases, patient.PName, patient.Address, patient.Age, patient.Sex FROM opd INNER JOIN patient ON patient.EMRNo = opd.EMRNo WHERE opd.ID=" + ID, cm);
        try
        {
            cm.Open();
            MySqlDataReader rd = cmd.ExecuteReader();
            rd.Read();
            o.I_Date = DateTime.Parse(rd[1].ToString());
            o.DailyNo = Convert.ToInt32(rd[2]);
            o.MonthlyNo = Convert.ToInt32(rd[3]);
            o.YearlyNo = Convert.ToInt32(rd[4]);
            o.EMRNo = rd[5].ToString();
            o.OPDNo = Convert.ToInt32(rd[6]);
            o.Cases = rd[7].ToString();
        }
        catch 
        {
            ;
        }
        finally { cm.Close(); }
        return o;
    }

    [WebMethod]
    public Server2Client GetOPDByDate(DateTime dt)
    {
        Server2Client sc = new Server2Client();
        string d = Settings.getDate(dt);
        MySqlCommand cmd = new MySqlCommand("SELECT opd.ID, opd.DailyNo, opd.I_Date, opd.EMRNo, opd.OPDNo, opd.Cases, patient.ID AS PID, patient.PName, patient.Address, patient.Age, CASE WHEN patient.Sex = 'Male' THEN 'M' ELSE 'F' END AS Sex FROM patient INNER JOIN opd ON opd.EMRNo = patient.EMRNo WHERE DATE(opd.I_Date) = '" + d + "' ORDER BY DailyNo", cm);
        MySqlDataAdapter da = new MySqlDataAdapter(cmd);
        DataSet ds = new DataSet();
        da.Fill(ds);
        sc.count = ds.Tables[0].Rows.Count;
        sc.dt = ds.Tables[0];
        return sc;
    }

    [WebMethod]
    public Server2Client GetOPDByEMR(string EMRNo)
    {
        Server2Client sc = new Server2Client();
        MySqlCommand cmd = new MySqlCommand("SELECT I_Date, EMRNo, OPDNo, Cases FROM opd WHERE EMRNo='" + EMRNo + "' ORDER BY I_Date", cm);
        MySqlDataAdapter da = new MySqlDataAdapter(cmd);
        DataSet ds = new DataSet();
        da.Fill(ds);
        sc.count = ds.Tables[0].Rows.Count;
        sc.dt = ds.Tables[0];
        return sc;
    }

    [WebMethod]
    public Server2Client GetOPDByDates(DateTime dtFr, DateTime dtTo)
    {
        Server2Client sc = new Server2Client();
        string d1 = Settings.getDate(dtFr);
        string d2 = Settings.getDate(dtTo);
        MySqlCommand cmd = new MySqlCommand("SELECT opd.ID, opd.DailyNo, opd.I_Date, opd.EMRNo, opd.OPDNo, opd.Cases, patient.ID AS PID, patient.PName, patient.Address, patient.Age, CASE WHEN patient.Sex = 'Male' THEN 'M' ELSE 'F' END AS Sex FROM patient INNER JOIN opd ON opd.EMRNo = patient.EMRNo WHERE DATE(opd.I_Date) BETWEEN '" + d1 + "' AND '" + d2 + "' ORDER BY DailyNo", cm);
        MySqlDataAdapter da = new MySqlDataAdapter(cmd);
        DataSet ds = new DataSet();
        da.Fill(ds);
        sc.count = ds.Tables[0].Rows.Count;
        sc.dt = ds.Tables[0];
        return sc;
    }

    [WebMethod]
    public Server2Client AddOPD(OPD opd)
    {
        Server2Client sc = new Server2Client();
        MySqlCommand cmd = new MySqlCommand("INSERT INTO opd (I_Date, DailyNo, MonthlyNo, YearlyNo, EMRNo, OPDNo, Cases) VALUES (@IDT, @DNO, @MNO, @YNO, @EMR, @OPD, @CSE)", cm);
        cmd.Parameters.AddWithValue("@IDT", opd.I_Date);
        cmd.Parameters.AddWithValue("@DNO", opd.DailyNo);
        cmd.Parameters.AddWithValue("@MNO", opd.MonthlyNo);
        cmd.Parameters.AddWithValue("@YNO", opd.YearlyNo);
        cmd.Parameters.AddWithValue("@EMR", opd.EMRNo);
        cmd.Parameters.AddWithValue("@OPD", opd.OPDNo);
        cmd.Parameters.AddWithValue("@CSE", opd.Cases);
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
    public Server2Client UpdateOPD(OPD opd)
    {
        Server2Client sc = new Server2Client();
        MySqlCommand cmd = new MySqlCommand("UPDATE opd SET I_Date=@IDT, DailyNo=@DNO, MonthlyNo=@MNO, YearlyNo=@YNO, EMRNo=@EMR, OPDNo=@OPD, Cases=@CSE WHERE ID=" + opd.ID, cm);
        cmd.Parameters.AddWithValue("@IDT", opd.I_Date);
        cmd.Parameters.AddWithValue("@DNO", opd.DailyNo);
        cmd.Parameters.AddWithValue("@MNO", opd.MonthlyNo);
        cmd.Parameters.AddWithValue("@YNO", opd.YearlyNo);
        cmd.Parameters.AddWithValue("@EMR", opd.EMRNo);
        cmd.Parameters.AddWithValue("@OPD", opd.OPDNo);
        cmd.Parameters.AddWithValue("@CSE", opd.Cases);
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
    public Server2Client DeleteOPD(OPD opd)
    {
        Server2Client sc = new Server2Client();
        MySqlCommand cmd = new MySqlCommand("DELETE FROM opd WHERE ID=" + opd.ID, cm);
        
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
        MySqlCommand cmd = new MySqlCommand("SELECT MAX(DailyNo) FROM opd WHERE DAY(I_Date)=" + dt.Date.Day + " AND MONTH(I_Date)=" + dt.Date.Month + " AND YEAR(I_DATE)=" + dt.Date.Year, cm);
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
        MySqlCommand cmd = new MySqlCommand("SELECT MAX(MonthlyNo) FROM opd WHERE MONTH(I_Date)=" + dt.Date.Month + " AND YEAR(I_DATE)=" + dt.Date.Year, cm);
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
        MySqlCommand cmd = new MySqlCommand("SELECT MAX(YearlyNo) FROM opd WHERE YEAR(I_DATE)=" + dt.Date.Year, cm);
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
    public Server2Client GetEMRNo(DateTime dt)
    {
        Server2Client sc = new Server2Client();
        MySqlCommand cmd = new MySqlCommand("SELECT MAX(YearlyNo) FROM opd WHERE YEAR(I_DATE)=" + dt.Date.Year, cm);
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
