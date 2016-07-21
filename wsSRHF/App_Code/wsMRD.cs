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
    public Server2Client AddMRD(MRD mrd)
    {
        Server2Client sc = new Server2Client();
        MySqlCommand cmd = new MySqlCommand("INSERT INTO mrd (SlNo, EMRNo, Diagnosis, MRDNo, ICDCode) VALUES (@SLN, @EMR, @DGN, @MRD, @ICD)", cm);
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
    public Server2Client UpdateMRD(MRD mrd)
    {
        Server2Client sc = new Server2Client();
        MySqlCommand cmd = new MySqlCommand("UPDATE mrd SET SlNo=@SLN, EMRNo=@EMR, Diagnosis=@DGN, MRDNo=@MRD, ICDCode=@ICD WHERE ID=" + mrd.ID, cm);
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
