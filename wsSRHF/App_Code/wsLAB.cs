using MySql.Data.MySqlClient;
using System;
using System.Configuration;
using System.Data;
using System.Web.Services;

/// <summary>
/// Summary description for wsLAB
/// </summary>
[WebService(Namespace = "http://tempuri.org/")]
[WebServiceBinding(ConformsTo = WsiProfiles.BasicProfile1_1)]
// To allow this Web Service to be called from script, using ASP.NET AJAX, uncomment the following line. 
// [System.Web.Script.Services.ScriptService]
public class wsLAB : System.Web.Services.WebService
{
    MySqlConnection cm = new MySqlConnection(ConfigurationManager.ConnectionStrings["cs"].ConnectionString);

    [WebMethod]
    public Server2Client GetLabRecord()
    {
        Server2Client sc = new Server2Client();
        MySqlCommand cmd = new MySqlCommand("SELECT ID, I_Date, SlNo, DailyNo, ReceiptNo, EMRNo, PatientType, Ward, MRDNo, TestPerformed, Charge, Remarks FROM laboratory", cm);
        MySqlDataAdapter da = new MySqlDataAdapter(cmd);
        DataSet ds = new DataSet();
        da.Fill(ds);
        sc.dt = ds.Tables[0];
        return sc;
    }

    [WebMethod]
    public LAB GetLabRecordByID(int ID)
    {
        LAB l = new LAB();
        MySqlCommand cmd = new MySqlCommand("SELECT ID, I_Date, SlNo, DailyNo, ReceiptNo, EMRNo, PatientType, Ward, TestPerformed, Charge, Remarks FROM laboratory WHERE ID=" + ID, cm);
        try
        {
            cm.Open();
            MySqlDataReader rd = cmd.ExecuteReader();
            rd.Read();
            l.ID = Convert.ToInt32(rd[0]);
            l.I_Date = DateTime.Parse(rd[1].ToString());
            l.SlNo = Convert.ToInt32(rd[2]);
            l.DailyNo = Convert.ToInt32(rd[3]);
            l.ReceiptNo = rd[4].ToString();
            l.EMRNo = rd[5].ToString();
            l.PatientType = rd[6].ToString();
            l.Ward = rd[7].ToString();
            l.TestPerformed = rd[8].ToString();
            l.Charge = Convert.ToDouble(rd[9]);
            l.ReceiptNo = rd[10].ToString();
        }
        catch {; }
        finally { cm.Close(); }
        return l;
    }

    [WebMethod]
    public Server2Client GetLabRecordByDate(DateTime dt)
    {
        Server2Client sc = new Server2Client();
        string d = Settings.getDate(dt);
        MySqlCommand cmd = new MySqlCommand("SELECT ID, I_Date, SlNo, DailyNo, ReceiptNo, EMRNo, PatientType, Ward, MRDNo, TestPerformed, Charge, Remarks FROM laboratory WHERE DATE(I_Date)='" + d + "'", cm);
        MySqlDataAdapter da = new MySqlDataAdapter(cmd);
        DataSet ds = new DataSet();
        da.Fill(ds);
        sc.dt = ds.Tables[0];
        return sc;
    }

    [WebMethod]
    public Server2Client GetLabRecordByDates(DateTime df, DateTime dt)
    {
        Server2Client sc = new Server2Client();
        string d1 = Settings.getDate(df);
        string d2 = Settings.getDate(dt);
        MySqlCommand cmd = new MySqlCommand("SELECT ID, I_Date, SlNo, DailyNo, ReceiptNo, EMRNo, PatientType, Ward, MRDNo, TestPerformed, Charge, Remarks FROM laboratory WHERE DATE(I_Date) BETWEEN '" + d1 + "' AND '" + d2 + "'", cm);
        MySqlDataAdapter da = new MySqlDataAdapter(cmd);
        DataSet ds = new DataSet();
        da.Fill(ds);
        sc.dt = ds.Tables[0];
        return sc;
    }

    [WebMethod]
    public Server2Client GetLabRecordByEMR(string EMR)
    {
        Server2Client sc = new Server2Client();
        MySqlCommand cmd = new MySqlCommand("SELECT ID, I_Date, SlNo, DailyNo, ReceiptNo, EMRNo, PatientType, Ward, MRDNo, TestPerformed, Charge, Remarks FROM laboratory WHERE EMRNo='" + EMR + "' ORDER BY I_Date", cm);
        MySqlDataAdapter da = new MySqlDataAdapter(cmd);
        DataSet ds = new DataSet();
        da.Fill(ds);
        sc.dt = ds.Tables[0];
        return sc;
    }

    [WebMethod]
    public int GetYearlySerialNo(DateTime dt)
    {
        int i = 0;
        MySqlCommand cmd = new MySqlCommand("SELECT MAX(SlNo) FROM laboratory WHERE YEAR(I_Date)=" + dt.Date.Year, cm);
        try
        {
            cm.Open();
            i = Convert.ToInt32(cmd.ExecuteScalar());
        }
        catch { i = 0; }
        finally { cm.Clone(); }
        return i + 1;
    }

    [WebMethod]
    public int GetDailySerialNo(DateTime dt)
    {
        int i = 0;
        MySqlCommand cmd = new MySqlCommand("SELECT MAX(DailyNo) FROM laboratory WHERE DAY(I_Date)=" + dt.Day, cm);
        try
        {
            cm.Open();
            i = Convert.ToInt32(cmd.ExecuteScalar());
        }
        catch { i = 0; }
        finally { cm.Clone(); }
        return i + 1;
    }

    [WebMethod]
    public Server2Client GetWardAutoComplete()
    {
        Server2Client sc = new Server2Client();
        MySqlCommand cmd = new MySqlCommand("SELECT DISTINCT Ward FROM laboratory", cm);
        MySqlDataAdapter da = new MySqlDataAdapter(cmd);
        DataSet ds = new DataSet();
        da.Fill(ds);
        sc.dt = ds.Tables[0];
        return sc;
    }

    [WebMethod]
    public Server2Client GetTestsAutoComplete()
    {
        Server2Client sc = new Server2Client();
        MySqlCommand cmd = new MySqlCommand("SELECT DISTINCT TestPerformed FROM laboratory", cm);
        MySqlDataAdapter da = new MySqlDataAdapter(cmd);
        DataSet ds = new DataSet();
        da.Fill(ds);
        sc.dt = ds.Tables[0];
        return sc;
    }

    [WebMethod]
    public Server2Client AddLabRecord(LAB b)
    {
        Server2Client sc = new Server2Client();
        MySqlCommand cmd = new MySqlCommand("INSERT INTO laboratory (I_Date, SlNo, DailyNo, ReceiptNo, EMRNo, PatientType, Ward, MRDNo, TestPerformed, Charge, Remarks) VALUES (@IDT, @SNO, @DNO, @RNO, @EMR, @PTP, @WRD, @MRD, @TPF, @CRG, @RMK)", cm);
        cmd.Parameters.AddWithValue("@IDT", b.I_Date);
        cmd.Parameters.AddWithValue("@SNO", b.SlNo);
        cmd.Parameters.AddWithValue("@DNO", b.DailyNo);
        cmd.Parameters.AddWithValue("@RNO", b.ReceiptNo);
        cmd.Parameters.AddWithValue("@EMR", b.EMRNo);
        cmd.Parameters.AddWithValue("@PTP", b.PatientType);
        cmd.Parameters.AddWithValue("@WRD", b.Ward);
        cmd.Parameters.AddWithValue("@MRD", b.MRDNo);
        cmd.Parameters.AddWithValue("@TPF", b.TestPerformed);
        cmd.Parameters.AddWithValue("@CRG", b.Charge);
        cmd.Parameters.AddWithValue("@RMK", b.Remarks);
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
    public Server2Client UpdateLabRecord(LAB b)
    {
        Server2Client sc = new Server2Client();
        MySqlCommand cmd = new MySqlCommand("UPDATE laboratory SET I_Date=@IDT, SlNo=@SNO, DailyNo=@DNO, ReceiptNo=@RNO, EMRNo=@EMR, PatientType=@PTP, Ward=@WRD, MRDNo=@MRD, TestPerformed=@TPF, Charge=@CRG, Remarks=@RMK WHERE ID=" + b.ID, cm);
        cmd.Parameters.AddWithValue("@IDT", b.I_Date);
        cmd.Parameters.AddWithValue("@SNO", b.SlNo);
        cmd.Parameters.AddWithValue("@DNO", b.DailyNo);
        cmd.Parameters.AddWithValue("@RNO", b.ReceiptNo);
        cmd.Parameters.AddWithValue("@EMR", b.EMRNo);
        cmd.Parameters.AddWithValue("@PTP", b.PatientType);
        cmd.Parameters.AddWithValue("@WRD", b.Ward);
        cmd.Parameters.AddWithValue("@MRD", b.MRDNo);
        cmd.Parameters.AddWithValue("@TPF", b.TestPerformed);
        cmd.Parameters.AddWithValue("@CRG", b.Charge);
        cmd.Parameters.AddWithValue("@RMK", b.Remarks);
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
    public Server2Client DeleteLabRecord(LAB b)
    {
        Server2Client sc = new Server2Client();
        MySqlCommand cmd = new MySqlCommand("DELETE FROM laboratory WHERE ID=" + b.ID, cm);
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
