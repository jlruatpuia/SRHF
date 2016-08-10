using MySql.Data.MySqlClient;
using System;
using System.Configuration;
using System.Data;
using System.Web.Services;

/// <summary>
/// Summary description for wsOTH
/// </summary>
[WebService(Namespace = "http://tempuri.org/")]
[WebServiceBinding(ConformsTo = WsiProfiles.BasicProfile1_1)]
// To allow this Web Service to be called from script, using ASP.NET AJAX, uncomment the following line. 
// [System.Web.Script.Services.ScriptService]
public class wsOTH : System.Web.Services.WebService
{
    MySqlConnection cm = new MySqlConnection(ConfigurationManager.ConnectionStrings["cs"].ConnectionString);
    
    [WebMethod]
    public Server2Client GetOpTheater()
    {
        Server2Client sc = new Server2Client();
        MySqlCommand cmd = new MySqlCommand("SELECT ID, I_Date, DailyNo, MonthlyNo, YearlyNo, EMRNo, OpName, PatientType, Anaesthesia, OpType, Anaesthetist, Surgeon, Assistant, Remarks FROM optheatre", cm);
        MySqlDataAdapter da = new MySqlDataAdapter(cmd);
        DataSet ds = new DataSet();
        da.Fill(ds);
        sc.dt = ds.Tables[0];
        return sc;
    }

    [WebMethod]
    public Server2Client GetOpTheaterByEMR(string EMRNo)
    {
        Server2Client sc = new Server2Client();
        MySqlCommand cmd = new MySqlCommand("SELECT I_Date, EMRNo, OpName, PatientType, CASE WHEN Anaesthesia=1 THEN 'YES' ELSE 'NO' END AS Anaesthesia, OpType, Anaesthetist, Surgeon, Assistant, Remarks FROM optheatre WHERE EMRNo='" + EMRNo + "' ORDER BY I_Date", cm);
        MySqlDataAdapter da = new MySqlDataAdapter(cmd);
        DataSet ds = new DataSet();
        da.Fill(ds);
        sc.dt = ds.Tables[0];
        return sc;
    }

    [WebMethod]
    public Server2Client GetOpTheaterByDate(DateTime dt)
    {
        string d = Settings.getDate(dt);
        Server2Client sc = new Server2Client();
        MySqlCommand cmd = new MySqlCommand("SELECT ID, I_Date, DailyNo, MonthlyNo, YearlyNo, EMRNo, OpName, PatientType, CASE WHEN Anaesthesia=1 THEN 'Yes' ELSE 'No' END AS Anaesthesia, OpType, Anaesthetist, Surgeon, Assistant, Remarks FROM optheatre WHERE DATE(I_Date)='" + d + "'", cm);
        MySqlDataAdapter da = new MySqlDataAdapter(cmd);
        DataSet ds = new DataSet();
        da.Fill(ds);
        sc.dt = ds.Tables[0];
        return sc;
    }

    [WebMethod]
    public Server2Client GetOpTheaterByDates(DateTime df, DateTime dt)
    {
        string d1 = Settings.getDate(df);
        string d2 = Settings.getDate(dt);
        Server2Client sc = new Server2Client();
        MySqlCommand cmd = new MySqlCommand("SELECT ID, I_Date, DailyNo, MonthlyNo, YearlyNo, EMRNo, OpName, PatientType, CASE WHEN Anaesthesia=1 THEN 'Yes' ELSE 'No' END AS Anaesthesia, OpType, Anaesthetist, Surgeon, Assistant, Remarks FROM optheatre WHERE DATE(I_Date) BETWEEN '" + d1 + "' AND '" + d2 + "'", cm);
        MySqlDataAdapter da = new MySqlDataAdapter(cmd);
        DataSet ds = new DataSet();
        da.Fill(ds);
        sc.dt = ds.Tables[0];
        return sc;
    }

    [WebMethod]
    public OpTheater GetOpTheaterByID(int ID)
    {
        OpTheater op = new OpTheater();
        MySqlCommand cmd = new MySqlCommand("SELECT I_Date, DailyNo, MonthlyNo, YearlyNo, EMRNo, OpName, PatientType, Anaesthesia, OpType, Anaesthetist, Surgeon, Assistant, Remarks FROM optheatre WHERE ID=" + ID, cm);
        try
        {
            cm.Open();
            MySqlDataReader rd = cmd.ExecuteReader();
            rd.Read();
            op.I_Date = DateTime.Parse(rd[0].ToString());
            op.DailyNo = Convert.ToInt32(rd[1]);
            op.MonthlyNo = Convert.ToInt32(rd[2]);
            op.YearlyNo = Convert.ToInt32(rd[3]);
            op.EMRNo = rd[4].ToString();
            op.OpName = rd[5].ToString();
            op.PatientType = rd[6].ToString();
            op.Anaesthesia = Convert.ToInt32(rd[7]);
            op.OpType = rd[8].ToString();
            op.Anaesthetist = rd[9].ToString();
            op.Surgeon = rd[10].ToString();
            op.Assistant = rd[11].ToString();
            op.Remarks = rd[12].ToString();
        }
        catch {; }
        finally { cm.Close(); }
        return op;
    }

    [WebMethod]
    public Server2Client AddOpTheater(OpTheater op)
    {
        Server2Client sc = new Server2Client();
        MySqlCommand cmd = new MySqlCommand("INSERT INTO optheatre (I_Date, DailyNo, MonthlyNo, YearlyNo, EMRNo, OpName, PatientType, Anaesthesia, OpType, Anaesthetist, Surgeon, Assistant, Remarks) VALUES (@IDT, @DNO, @MNO, @YNO, @EMR, @OPN, @PTP, @ANE, @OPT, @ANT, @SRG, @AST, @RMK)", cm);
        cmd.Parameters.AddWithValue("@IDT", op.I_Date);
        cmd.Parameters.AddWithValue("@DNO", op.DailyNo);
        cmd.Parameters.AddWithValue("@MNO", op.MonthlyNo);
        cmd.Parameters.AddWithValue("@YNO", op.YearlyNo);
        cmd.Parameters.AddWithValue("@EMR", op.EMRNo);
        cmd.Parameters.AddWithValue("@OPN", op.OpName);
        cmd.Parameters.AddWithValue("@PTP", op.PatientType);
        cmd.Parameters.AddWithValue("@ANE", op.Anaesthesia);
        cmd.Parameters.AddWithValue("@OPT", op.OpType);
        cmd.Parameters.AddWithValue("@ANT", op.Anaesthetist);
        cmd.Parameters.AddWithValue("@SRG", op.Surgeon);
        cmd.Parameters.AddWithValue("@AST", op.Assistant);
        cmd.Parameters.AddWithValue("@RMK", op.Remarks);
        try
        {
            cm.Open();
            cmd.ExecuteNonQuery();
        }
        catch(Exception ex) { sc.message = ex.Message; }
        finally { cm.Close(); }
        return sc;
    }

    [WebMethod]
    public Server2Client UpdateOpTheater(OpTheater op)
    {
        Server2Client sc = new Server2Client();
        MySqlCommand cmd = new MySqlCommand("UPDATE optheatre SET I_Date=@IDT, DailyNo=@DNO, MonthlyNo=@MNO, YearlyNo=@YNO, EMRNo=@EMR, OpName=@OPN, PatientType=@PTP, Anaesthesia=@ANE, OpType=@OPT, Anaesthetist=@ANT, Surgeon=@SRG, Assistant=@AST, Remarks=@RMK WHERE ID=" + op.ID, cm);
        cmd.Parameters.AddWithValue("@IDT", op.I_Date);
        cmd.Parameters.AddWithValue("@DNO", op.DailyNo);
        cmd.Parameters.AddWithValue("@MNO", op.MonthlyNo);
        cmd.Parameters.AddWithValue("@YNO", op.YearlyNo);
        cmd.Parameters.AddWithValue("@EMR", op.EMRNo);
        cmd.Parameters.AddWithValue("@OPN", op.OpName);
        cmd.Parameters.AddWithValue("@PTP", op.PatientType);
        cmd.Parameters.AddWithValue("@ANE", op.Anaesthesia);
        cmd.Parameters.AddWithValue("@OPT", op.OpType);
        cmd.Parameters.AddWithValue("@ANT", op.Anaesthetist);
        cmd.Parameters.AddWithValue("@SRG", op.Surgeon);
        cmd.Parameters.AddWithValue("@AST", op.Assistant);
        cmd.Parameters.AddWithValue("@RMK", op.Remarks);
        try
        {
            cm.Open();
            cmd.ExecuteNonQuery();
        }
        catch (Exception ex) { sc.message = ex.Message; }
        finally { cm.Close(); }
        return sc;
    }

    [WebMethod]
    public Server2Client DeleteOpTheater(OpTheater op)
    {
        Server2Client sc = new Server2Client();
        MySqlCommand cmd = new MySqlCommand("DELETE FROM optheatre WHERE ID=" + op.ID, cm);
        
        try
        {
            cm.Open();
            cmd.ExecuteNonQuery();
        }
        catch (Exception ex) { sc.message = ex.Message; }
        finally { cm.Close(); }
        return sc;
    }

    [WebMethod]
    public Server2Client AnaesthetistAutoComplete()
    {
        Server2Client sc = new Server2Client();
        MySqlCommand cmd = new MySqlCommand("SELECT DISTINCT Anaesthetist FROM optheatre", cm);
        MySqlDataAdapter da = new MySqlDataAdapter(cmd);
        DataSet ds = new DataSet();
        da.Fill(ds);
        sc.dt = ds.Tables[0];
        return sc;
    }

    [WebMethod]
    public Server2Client SurgeonAutoComplete()
    {
        Server2Client sc = new Server2Client();
        MySqlCommand cmd = new MySqlCommand("SELECT DISTINCT Surgeon FROM optheatre", cm);
        MySqlDataAdapter da = new MySqlDataAdapter(cmd);
        DataSet ds = new DataSet();
        da.Fill(ds);
        sc.dt = ds.Tables[0];
        return sc;
    }

    [WebMethod]
    public Server2Client AssistantAutoComplete()
    {
        Server2Client sc = new Server2Client();
        MySqlCommand cmd = new MySqlCommand("SELECT DISTINCT Assistant FROM optheatre", cm);
        MySqlDataAdapter da = new MySqlDataAdapter(cmd);
        DataSet ds = new DataSet();
        da.Fill(ds);
        sc.dt = ds.Tables[0];
        return sc;
    }

    [WebMethod]
    public Server2Client GetDailyNo(DateTime dt)
    {
        Server2Client sc = new Server2Client();
        MySqlCommand cmd = new MySqlCommand("SELECT MAX(DailyNo) FROM optheatre WHERE DAY(I_Date)=" + dt.Date.Day + " AND MONTH(I_Date)=" + dt.Date.Month + " AND YEAR(I_DATE)=" + dt.Date.Year, cm);
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
        MySqlCommand cmd = new MySqlCommand("SELECT MAX(MonthlyNo) FROM optheatre WHERE MONTH(I_Date)=" + dt.Date.Month + " AND YEAR(I_DATE)=" + dt.Date.Year, cm);
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
        MySqlCommand cmd = new MySqlCommand("SELECT MAX(YearlyNo) FROM optheatre WHERE YEAR(I_DATE)=" + dt.Date.Year, cm);
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
