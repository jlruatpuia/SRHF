using MySql.Data.MySqlClient;
using System;
using System.Configuration;
using System.Data;
using System.Web.Services;

/// <summary>
/// Summary description for wsCasualty
/// </summary>
[WebService(Namespace = "http://tempuri.org/")]
[WebServiceBinding(ConformsTo = WsiProfiles.BasicProfile1_1)]
// To allow this Web Service to be called from script, using ASP.NET AJAX, uncomment the following line. 
// [System.Web.Script.Services.ScriptService]
public class wsCasualty : System.Web.Services.WebService
{
    MySqlConnection cm = new MySqlConnection(ConfigurationManager.ConnectionStrings["cs"].ConnectionString);
    
    [WebMethod]
    public Server2Client GetCasualty()
    {
        Server2Client sc = new Server2Client();
        MySqlCommand cmd = new MySqlCommand("SELECT ID, RegNo, SlNo, RegDate, TIME_FORMAT(casualty.RegTime, '%h:%i %p') AS RegTime, PName, Address, Age, CASE WHEN Sex='Male' THEN 'M' ELSE 'F' END AS Sex, Treatment, Diagnosis FROM casualty", cm);
        MySqlDataAdapter da = new MySqlDataAdapter(cmd);
        DataSet ds = new DataSet();
        da.Fill(ds);
        sc.dt = ds.Tables[0];
        return sc;
    }

    [WebMethod]
    public Casualty GetCasualtyByID(int ID)
    {
        Casualty c = new Casualty();
        MySqlCommand cmd = new MySqlCommand("SELECT ID, RegNo, SlNo, RegDate, TIME_FORMAT(casualty.RegTime, '%h:%i %p') AS RegTime, PName, Address, Age, CASE WHEN Sex='Male' THEN 'M' ELSE 'F' END AS Sex, Treatment, Diagnosis FROM casualty WHERE ID=" + ID, cm);
        try
        {
            cm.Open();
            MySqlDataReader rd = cmd.ExecuteReader();
            rd.Read();
            c.RegNo = rd[1].ToString();
            c.SlNo = Convert.ToInt32(rd[2]);
            c.RegDate = DateTime.Parse(rd[3].ToString());
            c.RegTime = DateTime.Parse(rd[4].ToString());
            c.PName = rd[5].ToString();
            c.Address = rd[6].ToString();
            c.Age = Convert.ToInt32( rd[7]);
            c.Sex = rd[8].ToString();
            c.Treatment = rd[9].ToString();
            c.Diagnosis = rd[10].ToString();
        }
        catch {; }
        finally { cm.Close(); }
        return c;
    }

    [WebMethod]
    public Server2Client GetCasualtyByDate(DateTime dt)
    {
        string d = Settings.getDate(dt);
        Server2Client sc = new Server2Client();
        MySqlCommand cmd = new MySqlCommand("SELECT ID, RegNo, SlNo, RegDate, TIME_FORMAT(casualty.RegTime, '%h:%i %p') AS RegTime, PName, Address, Age, CASE WHEN Sex='Male' THEN 'M' ELSE 'F' END AS Sex, Treatment, Diagnosis FROM casualty WHERE RegDate='" + d + "'", cm);
        MySqlDataAdapter da = new MySqlDataAdapter(cmd);
        DataSet ds = new DataSet();
        da.Fill(ds);
        sc.dt = ds.Tables[0];
        return sc;
    }

    [WebMethod]
    public Server2Client GetCasualtyByDates(DateTime df, DateTime dt)
    {
        string d1 = Settings.getDate(df);
        string d2 = Settings.getDate(dt);
        Server2Client sc = new Server2Client();
        MySqlCommand cmd = new MySqlCommand("SELECT ID, RegNo, SlNo, RegDate, TIME_FORMAT(casualty.RegTime, '%h:%i %p') AS RegTime, PName, Address, Age, CASE WHEN Sex='Male' THEN 'M' ELSE 'F' END AS Sex, Treatment, Diagnosis FROM casualty WHERE RegDate BETWEEN '" + d1 + "' AND '" + d2 + "'", cm);
        MySqlDataAdapter da = new MySqlDataAdapter(cmd);
        DataSet ds = new DataSet();
        da.Fill(ds);
        sc.dt = ds.Tables[0];
        return sc;
    }

    [WebMethod]
    public Server2Client AddCasualty(Casualty c)
    {
        Server2Client sc = new Server2Client();
        MySqlCommand cmd = new MySqlCommand("INSERT INTO casualty (RegNo, SlNo, RegDate, RegTime, PName, Address, Age, Sex, Treatment, Diagnosis) VALUES (@RNO, @SNO, @RDT, @RTM, @PNM, @ADR, @AGE, @SEX, @TRM, @DGN)", cm);
        cmd.Parameters.AddWithValue("@RNO", c.RegNo);
        cmd.Parameters.AddWithValue("@SNO", c.SlNo);
        cmd.Parameters.AddWithValue("@RDT", c.RegDate);
        cmd.Parameters.AddWithValue("@RTM", c.RegTime);
        cmd.Parameters.AddWithValue("@PNM", c.PName);
        cmd.Parameters.AddWithValue("@ADR", c.Address);
        cmd.Parameters.AddWithValue("@AGE", c.Age);
        cmd.Parameters.AddWithValue("@SEX", c.Sex);
        cmd.Parameters.AddWithValue("@TRM", c.Treatment);
        cmd.Parameters.AddWithValue("@DGN", c.Diagnosis);
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
    public Server2Client UpdateCasualty(Casualty c)
    {
        Server2Client sc = new Server2Client();
        MySqlCommand cmd = new MySqlCommand("UPDATE casualty SET RegNo=@RNO, SlNo=@SNO, RegDate=@RDT, RegTime=@RTM, PName=@PNM, Address=@ADR, Age=@AGE, Sex=@SEX, Treatment=@TRM, Diagnosis=@DGN WHERE ID=" + c.ID, cm);
        cmd.Parameters.AddWithValue("@RNO", c.RegNo);
        cmd.Parameters.AddWithValue("@SNO", c.SlNo);
        cmd.Parameters.AddWithValue("@RDT", c.RegDate);
        cmd.Parameters.AddWithValue("@RTM", c.RegTime);
        cmd.Parameters.AddWithValue("@PNM", c.PName);
        cmd.Parameters.AddWithValue("@ADR", c.Address);
        cmd.Parameters.AddWithValue("@AGE", c.Age);
        cmd.Parameters.AddWithValue("@SEX", c.Sex);
        cmd.Parameters.AddWithValue("@TRM", c.Treatment);
        cmd.Parameters.AddWithValue("@DGN", c.Diagnosis);
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
    public Server2Client DeleteCasualty(Casualty c)
    {
        Server2Client sc = new Server2Client();
        MySqlCommand cmd = new MySqlCommand("DELETE FROM casualty WHERE ID=" + c.ID, cm);
        
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
    public Server2Client RegdNo(DateTime dt)
    {
        Server2Client sc = new Server2Client();
        MySqlCommand cmd = new MySqlCommand("SELECT MAX(YearlyNo) FROM casualty WHERE YEAR(I_DATE)=" + dt.Date.Year, cm);
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
    public Server2Client SerialNo(DateTime dt)
    {
        Server2Client sc = new Server2Client();
        MySqlCommand cmd = new MySqlCommand("SELECT MAX(SlNo) FROM casualty WHERE YEAR(RegDate)=" + dt.Date.Year, cm);
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
