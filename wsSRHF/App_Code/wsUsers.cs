using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Data.OleDb;
using System.Linq;
using System.Web;
using System.Web.Services;

/// <summary>
/// Summary description for wsUsers
/// </summary>
[WebService(Namespace = "http://tempuri.org/")]
[WebServiceBinding(ConformsTo = WsiProfiles.BasicProfile1_1)]
// To allow this Web Service to be called from script, using ASP.NET AJAX, uncomment the following line. 
// [System.Web.Script.Services.ScriptService]
public class wsUsers : System.Web.Services.WebService
{

    OleDbConnection cm = new OleDbConnection(ConfigurationManager.ConnectionStrings["csu"].ConnectionString);

    [WebMethod]
    public Server2Client GetUsers()
    {
        Server2Client sc = new Server2Client();
        OleDbCommand cmd = new OleDbCommand("SELECT ID, UserName, Password, UserType FROM users", cm);
        OleDbDataAdapter da = new OleDbDataAdapter(cmd);
        DataSet ds = new DataSet();
        da.Fill(ds);
        sc.count = ds.Tables[0].Rows.Count;
        sc.dt = ds.Tables[0];
        return sc;
    }

    [WebMethod]
    public Server2Client Login(Users u)
    {
        Server2Client sc = new Server2Client();
        Utils utl = new Utils();
        OleDbCommand cmd = new OleDbCommand("SELECT ID, UserType FROM users WHERE UserName=@UNM AND Password=@PWD", cm);
        cmd.Parameters.AddWithValue("@UNM", u.UserName);
        cmd.Parameters.AddWithValue("@PWD", utl.Encrypt(u.UserName, u.Password));
        try
        {
            cm.Open();
            OleDbDataReader rd = cmd.ExecuteReader();
            if (rd.HasRows)
            {
                rd.Read();
                sc.count = Convert.ToInt32(rd[0]);
                sc.message = rd[1].ToString();
                sc.result = true;
            }
            else { sc.message = "Username/Password incorrect!"; }
        }
        catch(Exception ex) { sc.message = ex.Message; }
        finally { cm.Close(); }
        return sc;
    }

    [WebMethod]
    public Server2Client AddUser(Users u)
    {
        Server2Client sc = new Server2Client();
        OleDbCommand cmd = new OleDbCommand("INSERT INTO users (UserName, Password, UserType) VALUES ('" + u.UserName + "', '" + u.Password + "', '" + u.UserType + "')", cm);
        //cmd.Parameters.AddWithValue("@UNM", u.UserName);
        //cmd.Parameters.AddWithValue("@PWD", u.Password);
        //cmd.Parameters.AddWithValue("@UTP", u.UserType);
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
    public Server2Client UpdateUser(Users u)
    {
        Server2Client sc = new Server2Client();
        OleDbCommand cmd = new OleDbCommand("UPDATE users SET UserName=@UNM, Password=@PWD, UserType=@UTP WHERE ID=" + u.ID, cm);
        cmd.Parameters.AddWithValue("@UNM", u.UserName);
        cmd.Parameters.AddWithValue("@PWD", u.Password);
        cmd.Parameters.AddWithValue("@UTP", u.Password);
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
    public Server2Client DeleteUser(Users u)
    {
        Server2Client sc = new Server2Client();
        OleDbCommand cmd = new OleDbCommand("DELETE FROM users WHERE ID=" + u.ID, cm);
        try
        {
            cm.Open();
            cmd.ExecuteNonQuery();
        }
        catch (Exception ex) { sc.message = ex.Message; }
        finally { cm.Close(); }
        return sc;
    }
}
