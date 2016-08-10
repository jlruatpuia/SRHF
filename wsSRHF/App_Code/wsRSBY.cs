using MySql.Data.MySqlClient;
using System;
using System.Configuration;
using System.Data;
using System.Web.Services;

/// <summary>
/// Summary description for wsRSBY
/// </summary>
[WebService(Namespace = "http://tempuri.org/")]
[WebServiceBinding(ConformsTo = WsiProfiles.BasicProfile1_1)]
// To allow this Web Service to be called from script, using ASP.NET AJAX, uncomment the following line. 
// [System.Web.Script.Services.ScriptService]
public class wsRSBY : System.Web.Services.WebService
{
    MySqlConnection cm = new MySqlConnection(ConfigurationManager.ConnectionStrings["cs"].ConnectionString);
    
    [WebMethod]
    public int GetSerialNo()
    {
        int i = 0;
        MySqlCommand cmd = new MySqlCommand("SELECT MAX(SlNo) FROM rsby", cm);
        try
        {
            cm.Open();
            i = Convert.ToInt32(cmd.ExecuteScalar());
        }
        catch { i = 0; }
        finally { cm.Close(); }
        return i + 1;
    }

    [WebMethod]
    public RSBY GetRSBYByID(int ID)
    {
        RSBY r = new RSBY();
        MySqlCommand cmd = new MySqlCommand("SELECT ID, SlNo, MRDNo, PName, Address, FamilyHead, ContactNo, Ward, AdmissionDate, DischargeDate, Packages, TotalBill, ActualAmount, HospitalShare, URN, Remarks FROM rsby WHERE ID=" + ID, cm);
        try
        {
            cm.Open();
            MySqlDataReader rd = cmd.ExecuteReader();
            rd.Read();
            r.SlNo = Convert.ToInt32(rd[1]);
            r.MRDNo = rd[2].ToString();
            r.PName = rd[3].ToString();
            r.Address = rd[4].ToString();
            r.FamilyHead = rd[5].ToString();
            r.ContactNo = rd[6].ToString();
            r.Ward = rd[7].ToString();
            r.AdmissionDate = DateTime.Parse(rd[8].ToString());
            r.DischargeDate = DateTime.Parse(rd[9].ToString());
            r.Packages = rd[10].ToString();
            r.TotalBill = Convert.ToDouble(rd[11]);
            r.ActualAmount = Convert.ToDouble(rd[12]);
            r.HospitalShare = Convert.ToDouble(rd[13]);
            r.URN = rd[14].ToString();
            r.Remarks = rd[15].ToString();
        }
        catch {; }
        finally { cm.Close(); }
        return r;
    }

    [WebMethod]
    public Server2Client GetAllRSBY()
    {
        Server2Client sc = new Server2Client();
        MySqlCommand cmd = new MySqlCommand("SELECT ID, SlNo, MRDNo, PName, Address, FamilyHead, ContactNo, Ward, AdmissionDate, DischargeDate, Packages, TotalBill, ActualAmount, HospitalShare, URN, Remarks FROM rsby", cm);
        MySqlDataAdapter da = new MySqlDataAdapter(cmd);
        DataSet ds = new DataSet();
        da.Fill(ds);
        sc.dt = ds.Tables[0];
        return sc;
    }

    [WebMethod]
    public Server2Client GetRSBYByMRD(string MRDNo)
    {
        Server2Client sc = new Server2Client();
        MySqlCommand cmd = new MySqlCommand("SELECT ID, SlNo, MRDNo, PName, Address, FamilyHead, ContactNo, Ward, AdmissionDate, DischargeDate, Packages, TotalBill, ActualAmount, HospitalShare, URN, Remarks FROM rsby WHERE MRDNo='" + MRDNo + "'", cm);
        MySqlDataAdapter da = new MySqlDataAdapter(cmd);
        DataSet ds = new DataSet();
        da.Fill(ds);
        sc.dt = ds.Tables[0];
        return sc;
    }

    [WebMethod]
    public Server2Client GetRSBYByRemarks(string Remarks)
    {
        Server2Client sc = new Server2Client();
        MySqlCommand cmd = new MySqlCommand("SELECT ID, SlNo, MRDNo, PName, Address, FamilyHead, ContactNo, Ward, AdmissionDate, DischargeDate, Packages, TotalBill, ActualAmount, HospitalShare, URN, Remarks FROM rsby WHERE Remarks='" + Remarks + "'", cm);
        MySqlDataAdapter da = new MySqlDataAdapter(cmd);
        DataSet ds = new DataSet();
        da.Fill(ds);
        sc.dt = ds.Tables[0];
        return sc;
    }

    [WebMethod]
    public Server2Client InsertRSBY(RSBY r)
    {
        Server2Client sc = new Server2Client();
        MySqlCommand cmd = new MySqlCommand("INSERT INTO rsby (SlNo, MRDNo, PName, Address, FamilyHead, ContactNo, Ward, AdmissionDate, DischargeDate, Packages, TotalBill, ActualAmount, HospitalShare, URN, Remarks) VALUES (@SNO, @MRD, @PNM, @ADR, @FHD, @CNO, @WRD, @DOA, @DOD, @PKG, @TBL, @AMT, @HSH, @URN, @RMK)", cm);
        cmd.Parameters.AddWithValue("@SNO", r.SlNo);
        cmd.Parameters.AddWithValue("@MRD", r.MRDNo);
        cmd.Parameters.AddWithValue("@PNM", r.PName);
        cmd.Parameters.AddWithValue("@ADR", r.Address);
        cmd.Parameters.AddWithValue("@FHD", r.FamilyHead);
        cmd.Parameters.AddWithValue("@CNO", r.ContactNo);
        cmd.Parameters.AddWithValue("@WRD", r.Ward);
        cmd.Parameters.AddWithValue("@DOA", r.AdmissionDate);
        cmd.Parameters.AddWithValue("@DOD", r.DischargeDate);
        cmd.Parameters.AddWithValue("@PKG", r.Packages);
        cmd.Parameters.AddWithValue("@TBL", r.TotalBill);
        cmd.Parameters.AddWithValue("@AMT", r.ActualAmount);
        cmd.Parameters.AddWithValue("@HSH", r.HospitalShare);
        cmd.Parameters.AddWithValue("@URN", r.URN);
        cmd.Parameters.AddWithValue("@RMK", r.Remarks);
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
    public Server2Client UpdateRSBY(RSBY r)
    {
        Server2Client sc = new Server2Client();
        MySqlCommand cmd = new MySqlCommand("UPDATE rsby SET SlNo=@SNO, MRDNo=@MRD, PName=@PNM, Address=@ADR, FamilyHead=@FHD, ContactNo=@CNO, Ward=@WRD, AdmissionDate=@DOA, DischargeDate=@DOD, Packages=@PKG, TotalBill=@TBL, ActualAmount=@AMT, HospitalShare=@HSH, URN=@URN, Remarks=@RMK WHERE ID=" + r.ID, cm);
        cmd.Parameters.AddWithValue("@SNO", r.SlNo);
        cmd.Parameters.AddWithValue("@MRD", r.MRDNo);
        cmd.Parameters.AddWithValue("@PNM", r.PName);
        cmd.Parameters.AddWithValue("@ADR", r.Address);
        cmd.Parameters.AddWithValue("@FHD", r.FamilyHead);
        cmd.Parameters.AddWithValue("@CNO", r.ContactNo);
        cmd.Parameters.AddWithValue("@WRD", r.Ward);
        cmd.Parameters.AddWithValue("@DOA", r.AdmissionDate);
        cmd.Parameters.AddWithValue("@DOD", r.DischargeDate);
        cmd.Parameters.AddWithValue("@PKG", r.Packages);
        cmd.Parameters.AddWithValue("@TBL", r.TotalBill);
        cmd.Parameters.AddWithValue("@AMT", r.ActualAmount);
        cmd.Parameters.AddWithValue("@HSH", r.HospitalShare);
        cmd.Parameters.AddWithValue("@URN", r.URN);
        cmd.Parameters.AddWithValue("@RMK", r.Remarks);
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
    public Server2Client DeleteRSBY(int ID)
    {
        Server2Client sc = new Server2Client();
        MySqlCommand cmd = new MySqlCommand("DELETE FROM rsby WHERE ID=" + ID, cm);
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
    public Server2Client GetAllHealthCare()
    {
        Server2Client sc = new Server2Client();
        MySqlCommand cmd = new MySqlCommand("SELECT ID, EnrollmentNo, MRDNo, PName, Address, FamilyHead, AmountClaimed, Diagnosis, AdmissionDate, DischargeDate FROM hcare", cm);
        MySqlDataAdapter da = new MySqlDataAdapter(cmd);
        DataSet ds = new DataSet();
        da.Fill(ds);
        sc.dt = ds.Tables[0];
        return sc;
    }

    [WebMethod]
    public HCARE GetHealthCareByID(int ID)
    {
        HCARE h = new HCARE();
        MySqlCommand cmd = new MySqlCommand("SELECT EnrollmentNo, MRDNo, PName, Address, FamilyHead, AmountClaimed, Diagnosis, AdmissionDate, DischargeDate FROM hcare WHERE ID=" + ID, cm);
        try
        {
            cm.Open();
            MySqlDataReader rd = cmd.ExecuteReader();
            rd.Read();
            h.EnrollmentNo = Convert.ToInt32(rd[0]);
            h.MRDNo = rd[1].ToString();
            h.PName = rd[2].ToString();
            h.Address = rd[3].ToString();
            h.FamilyHead = rd[4].ToString();
            h.AmountClaimed = Convert.ToDouble(rd[5]);
            h.Diagnosis = rd[6].ToString();
            h.AdmissionDate = DateTime.Parse(rd[7].ToString());
            h.DischargeDate = DateTime.Parse(rd[8].ToString());
        }
        catch
        {
            h.EnrollmentNo = 0;
            h.MRDNo = "";
            h.PName = "";
            h.Address = "";
            h.FamilyHead = "";
            h.AmountClaimed = 0;
            h.Diagnosis = "";
            //h.AdmissionDate = "";
            //h.DischargeDate = DateTime.Parse(rd[8].ToString());
        }
        finally { cm.Close(); }
        return h;
    }

    [WebMethod]
    public Server2Client InsertHCare(HCARE h)
    {
        Server2Client sc = new Server2Client();
        MySqlCommand cmd = new MySqlCommand("INSERT INTO hcare (EnrollmentNo, MRDNo, PName, Address, FamilyHead, AmountClaimed, Diagnosis, AdmissionDate, DischargeDate) VALUES (@ENO, @MRD, @PNM, @ADR, @FHD, @AMC, @DGN, @DOA, @DOD)", cm);
        cmd.Parameters.AddWithValue("@ENO", h.EnrollmentNo);
        cmd.Parameters.AddWithValue("@MRD", h.MRDNo);
        cmd.Parameters.AddWithValue("@PNM", h.PName);
        cmd.Parameters.AddWithValue("@ADR", h.Address);
        cmd.Parameters.AddWithValue("@FHD", h.FamilyHead);
        cmd.Parameters.AddWithValue("@AMC", h.AmountClaimed);
        cmd.Parameters.AddWithValue("@DGN", h.Diagnosis);
        cmd.Parameters.AddWithValue("@DOA", h.AdmissionDate);
        cmd.Parameters.AddWithValue("@DOD", h.DischargeDate);
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
    public Server2Client UpdateHCare(HCARE h)
    {
        Server2Client sc = new Server2Client();
        MySqlCommand cmd = new MySqlCommand("UPDATE hcare SET EnrollmentNo=@ENO, MRDNo=@MRD, PName=@PNM, Address=@ADR, FamilyHead=@FHD, AmountClaimed=@AMC, Diagnosis=@DGN, AdmissionDate=@DOA, DischargeDate=@DOD WHERE ID=" + h.ID, cm);
        cmd.Parameters.AddWithValue("@ENO", h.EnrollmentNo);
        cmd.Parameters.AddWithValue("@MRD", h.MRDNo);
        cmd.Parameters.AddWithValue("@PNM", h.PName);
        cmd.Parameters.AddWithValue("@ADR", h.Address);
        cmd.Parameters.AddWithValue("@FHD", h.FamilyHead);
        cmd.Parameters.AddWithValue("@AMC", h.AmountClaimed);
        cmd.Parameters.AddWithValue("@DGN", h.Diagnosis);
        cmd.Parameters.AddWithValue("@DOA", h.AdmissionDate);
        cmd.Parameters.AddWithValue("@DOD", h.DischargeDate);
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
    public Server2Client DeleteHCare(int ID)
    {
        Server2Client sc = new Server2Client();
        MySqlCommand cmd = new MySqlCommand("DELETE FROM hcare WHERE ID=" + ID, cm);
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
