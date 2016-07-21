using MySql.Data.MySqlClient;
using System;
using System.Configuration;
using System.Data;
using System.Web.Services;

/// <summary>
/// Summary description for wsPatient
/// </summary>
[WebService(Namespace = "http://tempuri.org/")]
[WebServiceBinding(ConformsTo = WsiProfiles.BasicProfile1_1)]
// To allow this Web Service to be called from script, using ASP.NET AJAX, uncomment the following line. 
// [System.Web.Script.Services.ScriptService]
public class wsPatient : System.Web.Services.WebService
{
    MySqlConnection cm = new MySqlConnection(ConfigurationManager.ConnectionStrings["cs"].ConnectionString);

    [WebMethod]
    public Server2Client GetPatients()
    {
        Server2Client sc = new Server2Client();
        MySqlCommand cmd = new MySqlCommand("SELECT ID, EMRNo, PName, Address, Age, Sex FROM patient", cm);
        MySqlDataAdapter da = new MySqlDataAdapter(cmd);
        DataSet ds = new DataSet();
        da.Fill(ds);
        sc.count = ds.Tables[0].Rows.Count;
        sc.dt = ds.Tables[0];
        return sc;
    }

    [WebMethod]
    public Patient GetPatientByID(int ID)
    {
        Patient p = new Patient();
        MySqlCommand cmd = new MySqlCommand("SELECT EMRNo, PName, Address, Age, Sex FROM patient WHERE ID=" + ID, cm);
        try
        {
            cm.Open();
            MySqlDataReader rd = cmd.ExecuteReader();
            rd.Read();
            p.EMRNo = rd[0].ToString();
            p.PName = rd[1].ToString();
            p.Address = rd[2].ToString();
            p.Age = Convert.ToInt32(rd[3]);
            p.Sex = rd[4].ToString();
        }
        catch(Exception ex)
        {
            throw ex;
        }
        finally { cm.Close(); }
        return p;
    }

    [WebMethod]
    public Patient GetPatientByEMR(string EMR)
    {
        Patient p = new Patient();
        MySqlCommand cmd = new MySqlCommand("SELECT PName, Address, Age, Sex FROM patient WHERE EMRNo='" + EMR + "'", cm);
        try
        {
            cm.Open();
            MySqlDataReader rd = cmd.ExecuteReader();
            while (rd.Read())
            {
                //p.EMRNo = rd[0].ToString();
                p.PName = rd[0].ToString();
                p.Address = rd[1].ToString();
                p.Age = Convert.ToInt32(rd[2]);
                p.Sex = rd[3].ToString();
            }
        }
        catch (Exception ex)
        {
            throw ex;
        }
        finally { cm.Close(); }
        return p;
    }

    [WebMethod]
    public Server2Client GetAddressAutoComplete()
    {
        Server2Client sc = new Server2Client();
        MySqlCommand cmd = new MySqlCommand("SELECT DISTINCT Address FROM patient", cm);
        MySqlDataAdapter da = new MySqlDataAdapter(cmd);
        DataSet ds = new DataSet();
        da.Fill(ds);
        sc.count = ds.Tables[0].Rows.Count;
        sc.dt = ds.Tables[0];
        return sc;
    }

    [WebMethod]
    public Server2Client AddPatient(Patient p)
    {
        Server2Client sc = new Server2Client();
        MySqlCommand cmd = new MySqlCommand("INSERT INTO patient (EMRNo, PName, Address, Age, Sex) VALUES (@EMR, @PNM, @ADR, @AGE, @SEX)", cm);
        cmd.Parameters.AddWithValue("@EMR", p.EMRNo);
        cmd.Parameters.AddWithValue("@PNM", p.PName);
        cmd.Parameters.AddWithValue("@ADR", p.Address);
        cmd.Parameters.AddWithValue("@AGE", p.Age);
        cmd.Parameters.AddWithValue("@SEX", p.Sex);

        try
        {
            cm.Open();
            cmd.ExecuteNonQuery();
        }
        catch(Exception ex)
        {
            sc.message = ex.Message;
        }
        finally { cm.Close(); }
        return sc;
    }

    [WebMethod]
    public Server2Client UpdatePatient(Patient p)
    {
        Server2Client sc = new Server2Client();
        MySqlCommand cmd = new MySqlCommand("UPDATE patient SET EMRNo=@EMR, PName=@PNM, Address=@ADR, Age=@AGE, Sex=@SEX WHERE ID=" + p.ID, cm);
        cmd.Parameters.AddWithValue("@EMR", p.EMRNo);
        cmd.Parameters.AddWithValue("@PNM", p.PName);
        cmd.Parameters.AddWithValue("@ADR", p.Address);
        cmd.Parameters.AddWithValue("@AGE", p.Age);
        cmd.Parameters.AddWithValue("@SEX", p.Sex);

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
    public Server2Client DeletePatient(Patient p)
    {
        Server2Client sc = new Server2Client();
        MySqlCommand cmd = new MySqlCommand("DELETE FROM patient WHERE ID=" + p.ID, cm);
        
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
