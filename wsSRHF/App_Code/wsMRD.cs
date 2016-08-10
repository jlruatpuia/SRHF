using MySql.Data.MySqlClient;
using System;
using System.Configuration;
using System.Data;
using System.Web.Services;

/// <summary>
/// Summary description for wsMRD
/// </summary>
[WebService(Namespace = "http://tempuri.org/")]
[WebServiceBinding(ConformsTo = WsiProfiles.BasicProfile1_1)]
// To allow this Web Service to be called from script, using ASP.NET AJAX, uncomment the following line. 
// [System.Web.Script.Services.ScriptService]
public class wsMRD : System.Web.Services.WebService
{
    MySqlConnection cm = new MySqlConnection(ConfigurationManager.ConnectionStrings["cs"].ConnectionString);

    [WebMethod]
    public MRD GetPatientMRD(string query, string field)
    {
        MRD m = new MRD();
        MySqlCommand cmd = new MySqlCommand("SELECT mrd.EMRNo, mrd.MRDNo, patient.PName, patient.Address, patient.Age, patient.Sex, mrd.Ward, mrd.AdmissionDate, mrd.DischargeDate, mrd.HospitalDays, mrd.Diagnosis, mrd.ICDCode, mrd.Result, mrd.Discharged, mrd.DischargedAlive, mrd.DischargedDeath, mrd.CauseOfDeath, mrd.DirectCause, mrd.AntecedentCause, mrd.OtherCause FROM mrd INNER JOIN patient ON patient.EMRNo = mrd.EMRNo WHERE mrd." + field + "No='" + query + "'", cm);
        try
        {
            cm.Open();
            MySqlDataReader rd = cmd.ExecuteReader();
            rd.Read();
            m.EMRNo = rd[0].ToString();
            m.MRDNo = rd[1].ToString();
            m.Ward = rd[6].ToString();
            m.AdmissionDate = DateTime.Parse(rd[7].ToString());
            m.DischargeDate = DateTime.Parse(rd[8].ToString());
            m.HospitalDays = Convert.ToInt32(rd[9]);
            m.Diagnosis = rd[10].ToString();
            m.ICDCode = rd[11].ToString();
            m.Result = rd[12].ToString();
            m.Discharged = rd[13].ToString();
            m.DischargedAlive = rd[14].ToString();
            m.DischargedDeath = rd[15].ToString();
            m.CauseOfDeath = rd[16].ToString();
            m.DirectCause = rd[17].ToString();
            m.AntecedentCause = rd[18].ToString();
            m.OtherCause = rd[19].ToString();
        }
        catch {; }
        finally { cm.Close(); }
        return m;
    }

    [WebMethod]
    public Server2Client GetMRDByDate(DateTime d, string DateQuery)
    {
        Server2Client sc = new Server2Client();
        string dt = Settings.getDate(d);
        MySqlCommand cmd = new MySqlCommand("SELECT mrd.ID, mrd.MRDNo, mrd.EMRNo, patient.PName, patient.Address, CONCAT_WS('/',CAST(Age As CHAR), CASE WHEN SEX='Male' THEN 'M' ELSE 'F' END) AS AgeSex, mrd.AdmissionDate, mrd.DischargeDate, mrd.HospitalDays, mrd.Diagnosis, mrd.ICDCode, mrd.Result, mrd.Discharged, mrd.DischargedAlive, mrd.DischargedDeath, mrd.CauseOfDeath, mrd.DirectCause, mrd.AntecedentCause, mrd.OtherCause FROM mrd INNER JOIN patient ON patient.EMRNo = mrd.EMRNo WHERE DATE(mrd." + DateQuery + ")='" + dt + "'", cm);
        MySqlDataAdapter da = new MySqlDataAdapter(cmd);
        DataSet ds = new DataSet();
        da.Fill(ds);
        sc.dt = ds.Tables[0];
        return sc;
    }

    [WebMethod]
    public Server2Client GetMRDByDates(DateTime df, DateTime dt, string DateQuery)
    {
        Server2Client sc = new Server2Client();
        string d1 = Settings.getDate(df);
        string d2 = Settings.getDate(dt);
        MySqlCommand cmd = new MySqlCommand("SELECT mrd.ID, mrd.MRDNo, mrd.EMRNo, patient.PName, patient.Address, CONCAT_WS('/',CAST(Age As CHAR), CASE WHEN SEX='Male' THEN 'M' ELSE 'F' END) AS AgeSex, mrd.HospitalDays, mrd.Diagnosis, mrd.ICDCode, mrd.Result, mrd.Discharged, mrd.DischargedAlive, mrd.DischargedDeath, mrd.CauseOfDeath, mrd.DirectCause, mrd.AntecedentCause, mrd.OtherCause FROM mrd INNER JOIN patient ON patient.EMRNo = mrd.EMRNo WHERE DATE(mrd." + DateQuery + ") BETWEEN '" + d1 + "' AND '" + d2 + "'", cm);
        MySqlDataAdapter da = new MySqlDataAdapter(cmd);
        DataSet ds = new DataSet();
        da.Fill(ds);
        sc.dt = ds.Tables[0];
        return sc;
    }

    [WebMethod]
    public MRD GetMRDByID(int ID)
    {
        MRD m = new MRD();
        Server2Client sc = new Server2Client();
        MySqlCommand cmd = new MySqlCommand("SELECT ID, SlNo, MRDNo, EMRNo, ICDCode, AdmissionDate, DischargeDate, HospitalDays, Diagnosis, Result, Discharged, DischargedAlive, DischargedDeath, CauseOfDeath, DirectCause, AntecedentCause, OtherCause, Ward FROM mrd WHERE mrd.ID = " + ID, cm);
        try
        {
            cm.Open();
            MySqlDataReader rd = cmd.ExecuteReader();
            rd.Read();
            m.ID = Convert.ToInt32(rd[0]);
            m.SlNo = Convert.ToInt32(rd[1]);
            m.MRDNo = rd[2].ToString();
            m.EMRNo = rd[3].ToString();
            m.ICDCode = rd[4].ToString();
            m.AdmissionDate = DateTime.Parse(rd[5].ToString());
            m.DischargeDate = DateTime.Parse(rd[6].ToString());
            m.HospitalDays = Convert.ToInt32(rd[7]);
            m.Diagnosis = rd[8].ToString();
            m.Result = rd[9].ToString();
            m.Discharged = rd[10].ToString();
            m.DischargedAlive = rd[11].ToString();
            m.DischargedDeath = rd[12].ToString();
            m.CauseOfDeath = rd[13].ToString();
            m.DirectCause = rd[14].ToString();
            m.AntecedentCause = rd[15].ToString();
            m.OtherCause = rd[16].ToString();
            m.Ward = rd[17].ToString();
        }
        catch {; }
        finally { cm.Close(); }
        return m;
    }

    [WebMethod]
    public Server2Client GetMRDByEMR(string EMRNo)
    {
        Server2Client sc = new Server2Client();
        MySqlCommand cmd = new MySqlCommand("SELECT mrd.MRDNo, mrd.EMRNo, patient.PName, patient.Address, patient.Age, patient.Sex, mrd.ICDCode, mrd.AdmissionDate, mrd.DischargeDate FROM mrd INNER JOIN patient ON patient.EMRNo = mrd.EMRNo WHERE mrd.EMRNo = '" + EMRNo + "'", cm);
        MySqlDataAdapter da = new MySqlDataAdapter(cmd);
        DataSet ds = new DataSet();
        da.Fill(ds);
        sc.dt = ds.Tables[0];
        return sc;
    }

    [WebMethod]
    public Server2Client AddMRD(MRD mrd)
    {
        Server2Client sc = new Server2Client();
        MySqlCommand cmd = new MySqlCommand("INSERT INTO mrd (SlNo, EMRNo, Diagnosis, MRDNo, Ward, ICDCode, AdmissionDate, DischargeDate, HospitalDays, Result, Discharged, DischargedAlive, DischargedDeath, CauseOfDeath, DirectCause, AntecedentCause, OtherCause) VALUES (@SLN, @EMR, @DGN, @MRD, @WRD, @ICD, @ADT, @DDT, @HPD, @RST, @DSC, @DCA, @DCD, @COD, @DRC, @ANC, @OTC)", cm);
        cmd.Parameters.AddWithValue("@SLN", mrd.SlNo);
        cmd.Parameters.AddWithValue("@EMR", mrd.EMRNo);
        cmd.Parameters.AddWithValue("@DGN", mrd.Diagnosis);
        cmd.Parameters.AddWithValue("@MRD", mrd.MRDNo);
        cmd.Parameters.AddWithValue("@WRD", mrd.Ward);
        cmd.Parameters.AddWithValue("@ICD", mrd.ICDCode);
        cmd.Parameters.AddWithValue("@ADT", mrd.AdmissionDate);
        cmd.Parameters.AddWithValue("@DDT", mrd.DischargeDate);
        cmd.Parameters.AddWithValue("@HPD", mrd.HospitalDays);
        cmd.Parameters.AddWithValue("@RST", mrd.Result);
        cmd.Parameters.AddWithValue("@DSC", mrd.Discharged);
        cmd.Parameters.AddWithValue("@DCA", mrd.DischargedAlive);
        cmd.Parameters.AddWithValue("@DCD", mrd.DischargedDeath);
        cmd.Parameters.AddWithValue("@COD", mrd.CauseOfDeath);
        cmd.Parameters.AddWithValue("@DRC", mrd.DirectCause);
        cmd.Parameters.AddWithValue("@ANC", mrd.AntecedentCause);
        cmd.Parameters.AddWithValue("@OTC", mrd.OtherCause);
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
    public Server2Client UpdateMRD(MRD mrd)
    {
        Server2Client sc = new Server2Client();
        MySqlCommand cmd = new MySqlCommand("UPDATE mrd SET SlNo=@SLN, EMRNo=@EMR, Diagnosis=@DGN, MRDNo=@MRD, Ward=@WRD, ICDCode=@ICD, AdmissionDate=@ADT, DischargeDate=@DDT, HospitalDays=@HPD, Result=@RST, Discharged=@DSC, DischargedAlive=@DCA, DischargedDeath=@DCD, CauseOfDeath=@COD, DirectCause=@DRC, AntecedentCause=@ANC, OtherCause=@OTC WHERE ID=" + mrd.ID, cm);
        cmd.Parameters.AddWithValue("@SLN", mrd.SlNo);
        cmd.Parameters.AddWithValue("@EMR", mrd.EMRNo);
        cmd.Parameters.AddWithValue("@DGN", mrd.Diagnosis);
        cmd.Parameters.AddWithValue("@MRD", mrd.MRDNo);
        cmd.Parameters.AddWithValue("@WRD", mrd.Ward);
        cmd.Parameters.AddWithValue("@ICD", mrd.ICDCode);
        cmd.Parameters.AddWithValue("@ADT", mrd.AdmissionDate);
        cmd.Parameters.AddWithValue("@DDT", mrd.DischargeDate);
        cmd.Parameters.AddWithValue("@HPD", mrd.HospitalDays);
        cmd.Parameters.AddWithValue("@RST", mrd.Result);
        cmd.Parameters.AddWithValue("@DSC", mrd.Discharged);
        cmd.Parameters.AddWithValue("@DCA", mrd.DischargedAlive);
        cmd.Parameters.AddWithValue("@DCD", mrd.DischargedDeath);
        cmd.Parameters.AddWithValue("@COD", mrd.CauseOfDeath);
        cmd.Parameters.AddWithValue("@DRC", mrd.DirectCause);
        cmd.Parameters.AddWithValue("@ANC", mrd.AntecedentCause);
        cmd.Parameters.AddWithValue("@OTC", mrd.OtherCause);
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
    public Server2Client DeleteMRD(MRD mrd)
    {
        Server2Client sc = new Server2Client();
        MySqlCommand cmd = new MySqlCommand("DELETE FROM mrd WHERE ID=" + mrd.ID, cm);
        cmd.Parameters.AddWithValue("@SLN", mrd.SlNo);
        cmd.Parameters.AddWithValue("@EMR", mrd.EMRNo);
        cmd.Parameters.AddWithValue("@DGN", mrd.Diagnosis);
        cmd.Parameters.AddWithValue("@MRD", mrd.MRDNo);
        cmd.Parameters.AddWithValue("@ICD", mrd.ICDCode);
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
    public int GetSerialNo()
    {
        int i = 0;
        MySqlCommand cmd = new MySqlCommand("SELECT MAX(SlNo) FROM mrd", cm);
        try
        {
            cm.Open();
            i = Convert.ToInt32(cmd.ExecuteScalar());
        }
        catch
        {
            i = 0;
        }
        finally { cm.Close(); }
        return i + 1;
    }
}
