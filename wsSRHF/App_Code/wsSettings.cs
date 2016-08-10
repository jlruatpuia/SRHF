using MySql.Data.MySqlClient;
using System;
using System.Configuration;
using System.Data;
using System.Web.Services;

/// <summary>
/// Summary description for wrSettings
/// </summary>
[WebService(Namespace = "http://tempuri.org/")]
[WebServiceBinding(ConformsTo = WsiProfiles.BasicProfile1_1)]
// To allow this Web Service to be called from script, using ASP.NET AJAX, uncomment the following line. 
// [System.Web.Script.Services.ScriptService]
public class wsSettings : System.Web.Services.WebService
{
    MySqlConnection cm = new MySqlConnection(ConfigurationManager.ConnectionStrings["cs"].ConnectionString);
    
    [WebMethod]
    public Server2Client GetDepartments()
    {
        Server2Client sc = new Server2Client();
        MySqlCommand cmd = new MySqlCommand("SELECT ID, DeptNo, DeptShortName, DeptFullName FROM dept ORDER BY DeptNo", cm);
        MySqlDataAdapter da = new MySqlDataAdapter(cmd);
        DataSet ds = new DataSet();
        da.Fill(ds);
        sc.dt = ds.Tables[0];
        return sc;
    }

    [WebMethod]
    public Server2Client SetDepartments(Dept dept)
    {
        Server2Client sc = new Server2Client();
        MySqlCommand cmd;
        cmd = new MySqlCommand("INSERT INTO dept (DeptNo, DeptShortName, DeptFullName) VALUES (@DNO, @DSN, @DFN)", cm);
        cmd.Parameters.AddWithValue("@DNO", dept.DeptNo);
        cmd.Parameters.AddWithValue("@DSN", dept.DeptShortName);
        cmd.Parameters.AddWithValue("@DFN", dept.DeptFullName);
        try
        {
            cm.Open();
            cmd.ExecuteNonQuery();
        }
        catch (Exception ex) { sc.message = ex.Message; }
        finally { cm.Close(); }

        cmd = new MySqlCommand("SELECT DeptNo FROM dept WHERE DeptShortName='" + dept.DeptShortName + "' AND DeptFullName='" + dept.DeptFullName + "'", cm);
        try
        {
            cm.Open();
            sc.count = Convert.ToInt32(cmd.ExecuteScalar());
        }
        catch { sc.count = 0; }
        finally { cm.Close(); }
        return sc;
    }

    [WebMethod]
    public Server2Client UpdateDepartments(Dept dept)
    {
        Server2Client sc = new Server2Client();
        MySqlCommand cmd = new MySqlCommand("UPDATE dept SET DeptNo=@DNO, DeptShortName=@DSN, DeptFullName=@DFN WHERE ID=" + dept.ID, cm);
        cmd.Parameters.AddWithValue("@DNO", dept.DeptNo);
        cmd.Parameters.AddWithValue("@DSN", dept.DeptShortName);
        cmd.Parameters.AddWithValue("@DFN", dept.DeptFullName);
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
    public Server2Client GetWards()
    {
        Server2Client sc = new Server2Client();
        MySqlCommand cmd = new MySqlCommand("SELECT ID, WardNo, WardName, WardFullName FROM ward", cm);
        MySqlDataAdapter da = new MySqlDataAdapter(cmd);
        DataSet ds = new DataSet();
        da.Fill(ds);
        sc.dt = ds.Tables[0];
        return sc;
    }

    [WebMethod]
    public Server2Client AddWard(Wards w)
    {
        Server2Client sc = new Server2Client();
        MySqlCommand cmd;
        cmd = new MySqlCommand("INSERT INTO ward (WardNo, WardName, WardFullName) VALUES (@WNO, @WSN, @WFN)", cm);
        cmd.Parameters.AddWithValue("@WNO", w.WardNo);
        cmd.Parameters.AddWithValue("@WSN", w.WardName);
        cmd.Parameters.AddWithValue("@WFN", w.WardFullName);
        try
        {
            cm.Open();
            cmd.ExecuteNonQuery();
        }
        catch(Exception ex) { sc.message = ex.Message; }
        finally { cm.Close(); }
        cmd = new MySqlCommand("SELECT WardNo FROM ward WHERE WardName='" + w.WardName + "' AND WardFullName='" + w.WardFullName + "'", cm);
        try
        {
            cm.Open();
            sc.count = Convert.ToInt32(cmd.ExecuteScalar());
        }
        catch { sc.count = 0; }
        finally { cm.Close(); }
        return sc;
    }

    [WebMethod]
    public Server2Client UpdateWard(Wards w)
    {
        Server2Client sc = new Server2Client();
        MySqlCommand cmd;
        cmd = new MySqlCommand("UPDATE ward SET WardNo=@WNO, WardName=@WSN, WardFullName=@WFN WHERE ID=" + w.ID, cm);
        cmd.Parameters.AddWithValue("@WNO", w.WardNo);
        cmd.Parameters.AddWithValue("@WSN", w.WardName);
        cmd.Parameters.AddWithValue("@WFN", w.WardFullName);
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
    public Server2Client DeleteWard(Wards w)
    {
        Server2Client sc = new Server2Client();
        MySqlCommand cmd;
        cmd = new MySqlCommand("DELETE FROM ward WHERE ID=" + w.ID, cm);
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
    public void BackUpDatabase(string Path)
    {
        //Server2Client sc = new Server2Client();
        string constring = ConfigurationManager.ConnectionStrings["cs"].ConnectionString;
        string file = Path;
        using (MySqlConnection conn = new MySqlConnection(constring))
        {
            using (MySqlCommand cmd = new MySqlCommand())
            {
                using (MySqlBackup mb = new MySqlBackup(cmd))
                {
                    cmd.Connection = conn;
                    conn.Open();
                    mb.ExportToFile(file);
                    conn.Close();
                }
            }
        }
    }

    [WebMethod]
    public void RestoreDatabase(string path)
    {
        string constring = ConfigurationManager.ConnectionStrings["cs"].ConnectionString;
        string file = path;
        using (MySqlConnection conn = new MySqlConnection(constring))
        {
            using (MySqlCommand cmd = new MySqlCommand())
            {
                using (MySqlBackup mb = new MySqlBackup(cmd))
                {
                    cmd.Connection = conn;
                    conn.Open();
                    mb.ImportFromFile(file);
                    conn.Close();
                }
            }
        }
    }

}
