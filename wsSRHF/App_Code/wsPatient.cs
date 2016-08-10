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
    public Server2Client GetPatientsByEmrName(string query)
    {
        Server2Client sc = new Server2Client();
        MySqlCommand cmd = new MySqlCommand("SELECT ID, EMRNo, PName, Address, Age, Sex FROM patient WHERE EMRNo LIKE '%" + query + "%' OR PName LIKE '%" + query + "%'", cm);
        MySqlDataAdapter da = new MySqlDataAdapter(cmd);
        DataSet ds = new DataSet();
        da.Fill(ds);
        sc.count = ds.Tables[0].Rows.Count;
        sc.dt = ds.Tables[0];
        return sc;
    }

    [WebMethod]
    public Patient GetPatientByMRD(string MRD)
    {
        Patient p = new Patient();
        MySqlCommand cmd = new MySqlCommand("SELECT patient.PName, patient.Address, patient.Age, patient.Sex, mrd.MRDNo FROM mrd INNER JOIN patient ON patient.EMRNo = mrd.EMRNo WHERE mrd.MRDNo ='" + MRD + "'", cm);
        try
        {
            cm.Open();
            MySqlDataReader rd = cmd.ExecuteReader();
            rd.Read();
            p.PName = rd[0].ToString();
            p.Address = rd[1].ToString();
            p.Age = Convert.ToInt32(rd[2]);
            p.Sex = rd[3].ToString();
        }
        catch {
            p.PName = "";
            p.Address = "";
            p.Age = 0;
            p.Sex = "";
        }
        finally { cm.Close(); }
        return p;
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
        catch (Exception ex)
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
        MySqlCommand cmd = new MySqlCommand("SELECT EMRNo, PName, Address, Age, Sex FROM patient WHERE EMRNo='" + EMR + "'", cm);
        try
        {
            cm.Open();
            MySqlDataReader rd = cmd.ExecuteReader();
            while (rd.Read())
            {
                p.EMRNo = rd[0].ToString();
                p.PName = rd[1].ToString();
                p.Address = rd[2].ToString();
                p.Age = Convert.ToInt32(rd[3]);
                p.Sex = rd[4].ToString();
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
        catch (Exception ex)
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

    [WebMethod]
    public MSB CollectMSB(int Month, int Year)
    {
        MSB b = new MSB();
        MySqlCommand cmd;

        cmd = new MySqlCommand("SELECT ID FROM msb WHERE I_Month=" + Month + " AND I_Year=" + Year, cm);
        try
        {
            cm.Open();
            b.ID = Convert.ToInt32(cmd.ExecuteScalar());
        }
        catch { b.ID = 0; }
        finally { cm.Close(); }

        cmd = new MySqlCommand("SELECT COUNT(*) FROM opd WHERE MONTH(I_Date)=" + Month + " AND YEAR(I_Date)=" + Year, cm);
        try
        {
            cm.Open();
            b.TotalPatientCareOPD = Convert.ToInt32(cmd.ExecuteScalar());
        }
        catch { b.TotalPatientCareOPD = 0; }
        finally { cm.Close(); }

        cmd = new MySqlCommand("SELECT COUNT(*) FROM opd WHERE MONTH(I_Date)=" + Month + " AND YEAR(I_Date)=" + Year + " AND Cases='new'", cm);
        try
        {
            cm.Open();
            b.TotalPatientCareNew = Convert.ToInt32(cmd.ExecuteScalar());
        }
        catch { b.TotalPatientCareNew = 0; }
        finally { cm.Close(); }

        cmd = new MySqlCommand("SELECT COUNT(*) FROM opd WHERE MONTH(I_Date)=" + Month + " AND YEAR(I_Date)=" + Year + " AND Cases='old'", cm);
        try
        {
            cm.Open();
            b.TotalPatientCareOld = Convert.ToInt32(cmd.ExecuteScalar());
        }
        catch { b.TotalPatientCareOld = 0; }
        finally { cm.Close(); }

        cmd = new MySqlCommand("SELECT COUNT(*) FROM casualty WHERE MONTH(RegDate)=" + Month + " AND YEAR(RegDate)=" + Year, cm);
        try
        {
            cm.Open();
            b.TotalPatientCareCAS = Convert.ToInt32(cmd.ExecuteScalar());
        }
        catch { b.TotalPatientCareCAS = 0; }
        finally { cm.Close(); }

        b.TotalAdmissionFromCAS = 0;
        b.TotalAdmissionFromOPD = 0;

        cmd = new MySqlCommand("SELECT COUNT(*) FROM laboratory WHERE MONTH(I_Date)=" + Month + " AND YEAR(I_Date)=" + Year, cm);
        try
        {
            cm.Open();
            b.InvestigationLAB = Convert.ToInt32(cmd.ExecuteScalar());
        }
        catch { b.InvestigationLAB = 0; }
        finally { cm.Close(); }

        cmd = new MySqlCommand("SELECT COUNT(*) FROM xray WHERE MONTH(I_Date)=" + Month + " AND YEAR(I_Date)=" + Year, cm);
        try
        {
            cm.Open();
            b.InvestigationXRAY = Convert.ToInt32(cmd.ExecuteScalar());
        }
        catch { b.InvestigationXRAY = 0; }
        finally { cm.Close(); }

        b.InvestigationENDO = 0;

        cmd = new MySqlCommand("SELECT COUNT(*) FROM usg WHERE MONTH(I_Date)=" + Month + " AND YEAR(I_Date)=" + Year, cm);
        try
        {
            cm.Open();
            b.InvestigationUSG = Convert.ToInt32(cmd.ExecuteScalar());
        }
        catch { b.InvestigationUSG = 0; }
        finally { cm.Close(); }

        cmd = new MySqlCommand("SELECT COUNT(*) FROM ecg WHERE MONTH(I_Date)=" + Month + " AND YEAR(I_Date)=" + Year, cm);
        try
        {
            cm.Open();
            b.InvestigationECG = Convert.ToInt32(cmd.ExecuteScalar());
        }
        catch { b.InvestigationECG = 0; }
        finally { cm.Close(); }

        b.InvestigationBRON = 0;
        b.InvestigationCOLON = 0;
        b.InvestigationRADIO = 0;
        b.InvestigationEEG = 0;
        b.InvestigationECHO = 0;
        b.InvestigationPFT = 0;
        b.InvestigationDIET = 0;
        b.InvestigationDIAL = 0;
        b.InvestigationCTSCAN = 0;
        b.InvestigationCHEMO = 0;
        b.InvestigationPMR = 0;

        cmd = new MySqlCommand("SELECT COUNT(*) FROM optheatre WHERE MONTH(I_Date)=" + Month + " AND YEAR(I_Date)=" + Year + " AND OpType='major'", cm);
        try
        {
            cm.Open();
            b.OperationMajor = Convert.ToInt32(cmd.ExecuteScalar());
        }
        catch { b.OperationMajor = 0; }
        finally { cm.Close(); }

        cmd = new MySqlCommand("SELECT COUNT(*) FROM optheatre WHERE MONTH(I_Date)=" + Month + " AND YEAR(I_Date)=" + Year + " AND OpType='minor'", cm);
        try
        {
            cm.Open();
            b.OperationMinor = Convert.ToInt32(cmd.ExecuteScalar());
        }
        catch { b.OperationMinor = 0; }
        finally { cm.Close(); }

        b.DeliveryLiveMale = 0;
        b.DeliveryLiveFemale = 0;
        b.DeliveryStillMale = 0;
        b.DeliveryStillFemale = 0;
        b.DischargeAlive = 0;
        b.DischargeDeath = 0;
        b.DischargeDeathO48 = 0;
        b.DischargeDeathU48 = 0;
        b.PatientDischargedDays = 0;
        b.AverageLengthOfStay = 0.0;
        b.TotalInPatientCensus = 0.0;
        b.AvgPercOfBedOccupancy = 0.0;
        b.BedTurnOverRate = 0.0;
        b.DailyCensusOfIndoorPatientMAX = 0;
        b.DailyCensusOfIndoorPatientMIN = 0;
        b.NoOfAutopsy = 0;
        b.CaseReferredOutsideMizoram = 0;
        b.HealthCare = 0;
        b.RSBY = 0;

        return b;
    }

    [WebMethod]
    public MSB RecollectMSB(int month, int year)
    {
        MSB b = new MSB();
        MySqlCommand cmd = new MySqlCommand("SELECT ID, I_Month, I_Year, BedStrength, OpCaseTotal, CasCaseTotal, NewCase, OldCase, AdmOPD, AdmCAS, LabTotal, XrayTotal, EndoscopyTotal, USGTotal, ECGTotal, BronchoscopyTotal, ColonoscopyTotal, RadiotherapyTotal, EEGTotal, EchoTotal, PFTTotal, DieticianTotal, DialysisTotal, CTScanTotal, ChemoTotal, PhysiotherapyTotal, OperMajor, OperMinor, DeliveryLiveMale, DeliveryLiveFemale, DeliveryStillMale, DeliveryStillFemale, DischargeAliveTotal, DischargeDeathTotal, DischargeUnder48, DischargeOver48, PatientDischargedDays, AverageLengthOfStay, TotalInPatientCensus, BedTurnOverRate, IPDailyCensusMax, IPDailyCensusMin, NoOfAutopsy, CaseReferred, HealthCare, RSBY FROM msb WHERE I_Month=" + month + " AND I_Year=" + year, cm);
        try
        {
            cm.Open();
            MySqlDataReader rd = cmd.ExecuteReader();
            rd.Read();
            b.ID = Convert.ToInt32(rd["ID"]);
            b.BedStrength = Convert.ToInt32(rd["BedStrength"]);
            b.TotalPatientCareOPD = Convert.ToInt32(rd["OpCaseTotal"]);
            b.TotalPatientCareCAS = Convert.ToInt32(rd["CasCaseTotal"]);
            b.TotalPatientCareNew = Convert.ToInt32(rd["NewCase"]);
            b.TotalPatientCareOld = Convert.ToInt32(rd["OldCase"]);
            b.TotalAdmissionFromCAS = Convert.ToInt32(rd["AdmCAS"]); 
            b.TotalAdmissionFromOPD = Convert.ToInt32(rd["AdmOPD"]); 
            b.InvestigationLAB = Convert.ToInt32(rd["LabTotal"]);
            b.InvestigationXRAY = Convert.ToInt32(rd["XrayTotal"]);
            b.InvestigationENDO = Convert.ToInt32(rd["EndoscopyTotal"]); 
            b.InvestigationUSG = Convert.ToInt32(rd["USGTotal"]);
            b.InvestigationECG = Convert.ToInt32(rd["ECGTotal"]);
            b.InvestigationBRON = Convert.ToInt32(rd["BronchoscopyTotal"]); 
            b.InvestigationCOLON = Convert.ToInt32(rd["ColonoscopyTotal"]); 
            b.InvestigationRADIO = Convert.ToInt32(rd["RadiotherapyTotal"]); 
            b.InvestigationEEG = Convert.ToInt32(rd["EEGTotal"]); 
            b.InvestigationECHO = Convert.ToInt32(rd["EchoTotal"]); 
            b.InvestigationPFT = Convert.ToInt32(rd["PFTTotal"]); 
            b.InvestigationDIET = Convert.ToInt32(rd["DieticianTotal"]); 
            b.InvestigationDIAL = Convert.ToInt32(rd["DialysisTotal"]); 
            b.InvestigationCTSCAN = Convert.ToInt32(rd["CTScanTotal"]); 
            b.InvestigationCHEMO = Convert.ToInt32(rd["ChemoTotal"]); 
            b.InvestigationPMR = Convert.ToInt32(rd["PhysiotherapyTotal"]); 
            b.OperationMajor = Convert.ToInt32(rd["OperMajor"]);
            b.OperationMinor = Convert.ToInt32(rd["OperMinor"]);
            b.DeliveryLiveMale = Convert.ToInt32(rd["DeliveryLiveMale"]); 
            b.DeliveryLiveFemale = Convert.ToInt32(rd["DeliveryLiveFemale"]); 
            b.DeliveryStillMale = Convert.ToInt32(rd["DeliveryStillMale"]); 
            b.DeliveryStillFemale = Convert.ToInt32(rd["DeliveryStillFemale"]); 
            b.DischargeAlive = Convert.ToInt32(rd["DischargeAliveTotal"]); 
            b.DischargeDeath = Convert.ToInt32(rd["DischargeDeathTotal"]); 
            b.DischargeDeathO48 = Convert.ToInt32(rd["DischargeOver48"]); 
            b.DischargeDeathU48 = Convert.ToInt32(rd["DischargeUnder48"]); 
            b.PatientDischargedDays = Convert.ToInt32(rd["PatientDischargedDays"]); 
            b.AverageLengthOfStay = Convert.ToDouble(rd["AverageLengthOfStay"]); 
            b.TotalInPatientCensus = Convert.ToDouble(rd["TotalInPatientCensus"]); 
            b.AvgPercOfBedOccupancy = Convert.ToDouble(rd["ID"]);
            b.BedTurnOverRate = Convert.ToDouble(rd["BedTurnOverRate"]);
            b.DailyCensusOfIndoorPatientMAX = Convert.ToInt32(rd["IPDailyCensusMax"]); 
            b.DailyCensusOfIndoorPatientMIN = Convert.ToInt32(rd["IPDailyCensusMin"]); 
            b.NoOfAutopsy = Convert.ToInt32(rd["NoOfAutopsy"]); 
            b.CaseReferredOutsideMizoram = Convert.ToInt32(rd["CaseReferred"]); 
            b.HealthCare = Convert.ToInt32(rd["HealthCare"]); 
            b.RSBY = Convert.ToInt32(rd["RSBY"]); 
        }
        catch {; }
        finally { cm.Close(); }
        return b;
    }

    [WebMethod]
    public Server2Client AddMSB(MSB b)
    {
        Server2Client sc = new Server2Client();
        MySqlCommand cmd = new MySqlCommand("INSERT INTO msb (I_Month, I_Year, BedStrength, OpCaseTotal, CasCaseTotal, NewCase, OldCase, AdmOPD, AdmCAS, LabTotal, XrayTotal, EndoscopyTotal, USGTotal, ECGTotal, BronchoscopyTotal, ColonoscopyTotal, RadiotherapyTotal, EEGTotal, EchoTotal, PFTTotal, DieticianTotal, DialysisTotal, CTScanTotal, ChemoTotal, PhysiotherapyTotal, OperMajor, OperMinor, DeliveryLiveMale, DeliveryLiveFemale, DeliveryStillMale, DeliveryStillFemale, DischargeAliveTotal, DischargeDeathTotal, DischargeUnder48, DischargeOver48, PatientDischargedDays, AverageLengthOfStay, TotalInPatientCensus, AvgPercOfBedOcc, BedTurnOverRate, IPDailyCensusMax, IPDailyCensusMin, NoOfAutopsy, CaseReferred, HealthCare, RSBY) VALUES (@IMN, @IYR, @BEDSTR, @OPDTT, @CASTT, @CSNEW, @CSOLD, @ADMOPD, @ADMCAS, @LABTOT, @XRAYTOT, @ENDOTOT, @USGTOT, @ECGTOT, @BRONTOT, @COLTOT, @RADTOT, @EEGTOT, @ECHOTOT, @PFTTOT, @DIETOT, @DIATOT, @CTSTOT, @CHETOT, @PHYTOT, @OPERMJ, @OPERMN, @DELLBM, @DELLBF, @DELSBM, @DELSBF, @DCHATOT, @DCHDTOT, @DCHU48, @DCHO48, @PTNDCHD, @AVGLOS, @TOTIPC, @APOBO, @BEDTOR, @IPDCMAX, @IPDCMIN, @NOOFAUTOP, @CASEREF, @HEALTHC, @RSBY)", cm);
        cmd.Parameters.AddWithValue("@IMN", b.Month);
        cmd.Parameters.AddWithValue("@IYR", b.Year);
        cmd.Parameters.AddWithValue("@BEDSTR", b.BedStrength);
        cmd.Parameters.AddWithValue("@OPDTT", b.TotalPatientCareOPD);
        cmd.Parameters.AddWithValue("@CASTT", b.TotalPatientCareCAS);
        cmd.Parameters.AddWithValue("@CSNEW", b.TotalPatientCareNew);
        cmd.Parameters.AddWithValue("@CSOLD", b.TotalPatientCareOld);
        cmd.Parameters.AddWithValue("@ADMOPD", b.TotalAdmissionFromOPD);
        cmd.Parameters.AddWithValue("@ADMCAS", b.TotalAdmissionFromCAS);
        cmd.Parameters.AddWithValue("@LABTOT", b.InvestigationLAB);
        cmd.Parameters.AddWithValue("@XRAYTOT", b.InvestigationXRAY);
        cmd.Parameters.AddWithValue("@ENDOTOT", b.InvestigationENDO);
        cmd.Parameters.AddWithValue("@USGTOT", b.InvestigationUSG);
        cmd.Parameters.AddWithValue("@ECGTOT", b.InvestigationECG);
        cmd.Parameters.AddWithValue("@BRONTOT", b.InvestigationBRON);
        cmd.Parameters.AddWithValue("@COLTOT", b.InvestigationCOLON);
        cmd.Parameters.AddWithValue("@RADTOT", b.InvestigationRADIO);
        cmd.Parameters.AddWithValue("@EEGTOT", b.InvestigationEEG);
        cmd.Parameters.AddWithValue("@ECHOTOT", b.InvestigationECHO);
        cmd.Parameters.AddWithValue("@PFTTOT", b.InvestigationPFT);
        cmd.Parameters.AddWithValue("@DIETOT", b.InvestigationDIET);
        cmd.Parameters.AddWithValue("@DIATOT", b.InvestigationDIAL);
        cmd.Parameters.AddWithValue("@CTSTOT", b.InvestigationCTSCAN);
        cmd.Parameters.AddWithValue("@CHETOT", b.InvestigationCHEMO);
        cmd.Parameters.AddWithValue("@PHYTOT", b.InvestigationPMR);
        cmd.Parameters.AddWithValue("@OPERMJ", b.OperationMajor);
        cmd.Parameters.AddWithValue("@OPERMN", b.OperationMinor);
        cmd.Parameters.AddWithValue("@DELLBM", b.DeliveryLiveMale);
        cmd.Parameters.AddWithValue("@DELLBF", b.DeliveryLiveFemale);
        cmd.Parameters.AddWithValue("@DELSBM", b.DeliveryStillMale);
        cmd.Parameters.AddWithValue("@DELSBF", b.DeliveryStillFemale);
        cmd.Parameters.AddWithValue("@DCHATOT", b.DischargeAlive);
        cmd.Parameters.AddWithValue("@DCHDTOT", b.DischargeDeath);
        cmd.Parameters.AddWithValue("@DCHU48", b.DischargeDeathU48);
        cmd.Parameters.AddWithValue("@DCHO48", b.DischargeDeathO48);
        cmd.Parameters.AddWithValue("@PTNDCHD", b.PatientDischargedDays);
        cmd.Parameters.AddWithValue("@AVGLOS", b.AverageLengthOfStay);
        cmd.Parameters.AddWithValue("@TOTIPC", b.TotalInPatientCensus);
        cmd.Parameters.AddWithValue("@APOBO", b.AvgPercOfBedOccupancy);
        cmd.Parameters.AddWithValue("@BEDTOR", b.BedTurnOverRate);
        cmd.Parameters.AddWithValue("@IPDCMAX", b.DailyCensusOfIndoorPatientMAX);
        cmd.Parameters.AddWithValue("@IPDCMIN", b.DailyCensusOfIndoorPatientMIN);
        cmd.Parameters.AddWithValue("@NOOFAUTOP", b.NoOfAutopsy);
        cmd.Parameters.AddWithValue("@CASEREF", b.CaseReferredOutsideMizoram);
        cmd.Parameters.AddWithValue("@HEALTHC", b.HealthCare);
        cmd.Parameters.AddWithValue("@RSBY", b.RSBY);

        try
        {
            cm.Open();
            cmd.ExecuteNonQuery();
        }
        catch (Exception ex)
        {
            sc.message = ex.Message;
        }
        finally
        {
            cm.Close();
        }
        return sc;
    }

    [WebMethod]
    public Server2Client UpdateMSB(MSB b)
    {
        Server2Client sc = new Server2Client();
        MySqlCommand cmd = new MySqlCommand("UPDATE msb SET I_Month=@IMN, I_Year=@IYR, BedStrength=@BEDSTR, OpCaseTotal=@OPDTT, CasCaseTotal=@CASTT, NewCase=@CSNEW, OldCase=@CSOLD, AdmOPD=@ADMOPD, AdmCAS=@ADMCAS, LabTotal=@LABTOT, XrayTotal=@XRAYTOT, EndoscopyTotal=@ENDOTOT, USGTotal=@USGTOT, ECGTotal=@ECGTOT, BronchoscopyTotal=@BRONTOT, ColonoscopyTotal=@COLTOT, RadiotherapyTotal=@RADTOT, EEGTotal=@EEGTOT, EchoTotal=@ECHOTOT, PFTTotal=@PFTTOT, DieticianTotal=@DIETOT, DialysisTotal=@DIATOT, CTScanTotal=@CTSTOT, ChemoTotal=@CHETOT, PhysiotherapyTotal=@PHYTOT, OperMajor=@OPERMJ, OperMinor=@OPERMN, DeliveryLiveMale=@DELLBM, DeliveryLiveFemale=@DELLBF, DeliveryStillMale=@DELSBM, DeliveryStillFemale=@DELSBF, DischargeAliveTotal=@DCHATOT, DischargeDeathTotal=@DCHDTOT, DischargeUnder48=@DCHU48, DischargeOver48=@DCHO48, PatientDischargedDays=@PTNDCHD, AverageLengthOfStay=@AVGLOS, TotalInPatientCensus=@TOTIPC, AvgPercOfBedOcc=@APOBO, BedTurnOverRate=@BEDTOR, IPDailyCensusMax=@IPDCMAX, IPDailyCensusMin=@IPDCMIN, NoOfAutopsy=@NOOFAUTOP, CaseReferred=@CASEREF, HealthCare=@HEALTHC, RSBY=@RSBY WHERE ID=" + b.ID, cm);
        cmd.Parameters.AddWithValue("@IMN", b.Month);
        cmd.Parameters.AddWithValue("@IYR", b.Year);
        cmd.Parameters.AddWithValue("@BEDSTR", b.BedStrength);
        cmd.Parameters.AddWithValue("@OPDTT", b.TotalPatientCareOPD);
        cmd.Parameters.AddWithValue("@CASTT", b.TotalPatientCareCAS);
        cmd.Parameters.AddWithValue("@CSNEW", b.TotalPatientCareNew);
        cmd.Parameters.AddWithValue("@CSOLD", b.TotalPatientCareOld);
        cmd.Parameters.AddWithValue("@ADMOPD", b.TotalAdmissionFromOPD);
        cmd.Parameters.AddWithValue("@ADMCAS", b.TotalAdmissionFromCAS);
        cmd.Parameters.AddWithValue("@LABTOT", b.InvestigationLAB);
        cmd.Parameters.AddWithValue("@XRAYTOT", b.InvestigationXRAY);
        cmd.Parameters.AddWithValue("@ENDOTOT", b.InvestigationENDO);
        cmd.Parameters.AddWithValue("@USGTOT", b.InvestigationUSG);
        cmd.Parameters.AddWithValue("@ECGTOT", b.InvestigationECG);
        cmd.Parameters.AddWithValue("@BRONTOT", b.InvestigationBRON);
        cmd.Parameters.AddWithValue("@COLTOT", b.InvestigationCOLON);
        cmd.Parameters.AddWithValue("@RADTOT", b.InvestigationRADIO);
        cmd.Parameters.AddWithValue("@EEGTOT", b.InvestigationEEG);
        cmd.Parameters.AddWithValue("@ECHOTOT", b.InvestigationECHO);
        cmd.Parameters.AddWithValue("@PFTTOT", b.InvestigationPFT);
        cmd.Parameters.AddWithValue("@DIETOT", b.InvestigationDIET);
        cmd.Parameters.AddWithValue("@DIATOT", b.InvestigationDIAL);
        cmd.Parameters.AddWithValue("@CTSTOT", b.InvestigationCTSCAN);
        cmd.Parameters.AddWithValue("@CHETOT", b.InvestigationCHEMO);
        cmd.Parameters.AddWithValue("@PHYTOT", b.InvestigationPMR);
        cmd.Parameters.AddWithValue("@OPERMJ", b.OperationMajor);
        cmd.Parameters.AddWithValue("@OPERMN", b.OperationMinor);
        cmd.Parameters.AddWithValue("@DELLBM", b.DeliveryLiveMale);
        cmd.Parameters.AddWithValue("@DELLBF", b.DeliveryLiveFemale);
        cmd.Parameters.AddWithValue("@DELSBM", b.DeliveryStillMale);
        cmd.Parameters.AddWithValue("@DELSBF", b.DeliveryStillFemale);
        cmd.Parameters.AddWithValue("@DCHATOT", b.DischargeAlive);
        cmd.Parameters.AddWithValue("@DCHDTOT", b.DischargeDeath);
        cmd.Parameters.AddWithValue("@DCHU48", b.DischargeDeathU48);
        cmd.Parameters.AddWithValue("@DCHO48", b.DischargeDeathO48);
        cmd.Parameters.AddWithValue("@PTNDCHD", b.PatientDischargedDays);
        cmd.Parameters.AddWithValue("@AVGLOS", b.AverageLengthOfStay);
        cmd.Parameters.AddWithValue("@TOTIPC", b.TotalInPatientCensus);
        cmd.Parameters.AddWithValue("@APOBO", b.AvgPercOfBedOccupancy);
        cmd.Parameters.AddWithValue("@BEDTOR", b.BedTurnOverRate);
        cmd.Parameters.AddWithValue("@IPDCMAX", b.DailyCensusOfIndoorPatientMAX);
        cmd.Parameters.AddWithValue("@IPDCMIN", b.DailyCensusOfIndoorPatientMIN);
        cmd.Parameters.AddWithValue("@NOOFAUTOP", b.NoOfAutopsy);
        cmd.Parameters.AddWithValue("@CASEREF", b.CaseReferredOutsideMizoram);
        cmd.Parameters.AddWithValue("@HEALTHC", b.HealthCare);
        cmd.Parameters.AddWithValue("@RSBY", b.RSBY);

        try
        {
            cm.Open();
            cmd.ExecuteNonQuery();
        }
        catch (Exception ex)
        {
            sc.message = ex.Message;
        }
        finally
        {
            cm.Close();
        }
        return sc;
    }

    [WebMethod]
    public Server2Client DeleteMSB(int month, int year)
    {
        Server2Client sc = new Server2Client();
        MySqlCommand cmd = new MySqlCommand("DELETE FROM msb I_Month=" + month + " AND I_Year=" + year, cm);
        try
        {
            cm.Open();
            cmd.ExecuteNonQuery();
        }
        catch (Exception ex)
        {
            sc.message = ex.Message;
        }
        finally
        {
            cm.Close();
        }
        return sc;
    }

    [WebMethod]
    public Server2Client GetDepartmentWiseData(int month, int year)
    {
        Server2Client sc = new Server2Client();
        MySqlCommand cmd = new MySqlCommand("SELECT ID, DMonth, DYear, DeptNo, DeptName, NewCase, OldCase, Total, Average FROM dwd WHERE DMonth=" + month + " AND DYear=" + year, cm);
        MySqlDataAdapter da = new MySqlDataAdapter(cmd);
        DataSet ds = new DataSet();
        da.Fill(ds);
        sc.dt = ds.Tables[0];
        return sc;
    }

    [WebMethod]
    public Server2Client AddDepartmentWiseDataEntry(DepartmentWiseData d)
    {
        Server2Client sc = new Server2Client();
        MySqlCommand cmd = new MySqlCommand("INSERT INTO dwd (DMonth, DYear, DeptNo, DeptName, NewCase, OldCase, Total, Average) VALUES (@MNO, @YNO, @DNO, @DNM, @NCS, @OCS, @TTL, @AVG)", cm);
        cmd.Parameters.AddWithValue("@MNO", d.DMonth);
        cmd.Parameters.AddWithValue("@YNO", d.DYear);
        cmd.Parameters.AddWithValue("@DNO", d.DeptNo);
        cmd.Parameters.AddWithValue("@DNM", d.DeptName);
        cmd.Parameters.AddWithValue("@NCS", d.NewCase);
        cmd.Parameters.AddWithValue("@OCS", d.OldCase);
        cmd.Parameters.AddWithValue("@TTL", d.Total);
        cmd.Parameters.AddWithValue("@AVG", d.Average);
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
    public Server2Client UpdateDepartmentWiseDataEntry(DepartmentWiseData d)
    {
        Server2Client sc = new Server2Client();
        MySqlCommand cmd = new MySqlCommand("UPDATE dwd SET DMonth=@MNO, DYear=@YNO, DeptNo=@DNO, DeptName=@DNM, NewCase=@NCS, OldCase=@OCS, Total=@TTL, Average=@AVG WHERE ID=" + d.ID, cm);
        cmd.Parameters.AddWithValue("@MNO", d.DMonth);
        cmd.Parameters.AddWithValue("@YNO", d.DYear);
        cmd.Parameters.AddWithValue("@DNO", d.DeptNo);
        cmd.Parameters.AddWithValue("@DNM", d.DeptName);
        cmd.Parameters.AddWithValue("@NCS", d.NewCase);
        cmd.Parameters.AddWithValue("@OCS", d.OldCase);
        cmd.Parameters.AddWithValue("@TTL", d.Total);
        cmd.Parameters.AddWithValue("@AVG", d.Average);
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
    public Server2Client DeleteDepartmentWiseDataEntry(DepartmentWiseData d)
    {
        Server2Client sc = new Server2Client();
        MySqlCommand cmd = new MySqlCommand("DELETE FROM dwd WHERE DMonth=" + d.DMonth + " AND DYear=" + d.DYear, cm);
        
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
    public Server2Client GetWardWiseData(int month, int year)
    {
        Server2Client sc = new Server2Client();
        MySqlCommand cmd = new MySqlCommand("SELECT ID, DMonth, DYear, WardNo, WardName, Bed, Admission, Discharge, Death, AvgStay, BedOccupancy FROM wwd WHERE DMonth=" + month + " AND DYear=" + year, cm);
        MySqlDataAdapter da = new MySqlDataAdapter(cmd);
        DataSet ds = new DataSet();
        da.Fill(ds);
        sc.dt = ds.Tables[0];
        return sc;
    }

    [WebMethod]
    public Server2Client AddWardWiseData(WardWiseData d)
    {
        Server2Client sc = new Server2Client();
        MySqlCommand cmd = new MySqlCommand("INSERT INTO wwd(DMonth, DYear, WardNo, WardName, Bed, Admission, Discharge, Death, AvgStay, BedOccupancy) VALUES (@MNO, @YNO, @WNO, @WNM, @BED, @ADM, @DSC, @DTH, @AVG, @BOC)", cm);
        cmd.Parameters.AddWithValue("@MNO", d.DMonth);
        cmd.Parameters.AddWithValue("@YNO", d.DYear);
        cmd.Parameters.AddWithValue("@WNO", d.WardNo);
        cmd.Parameters.AddWithValue("@WNM", d.WardName);
        cmd.Parameters.AddWithValue("@BED", d.Bed);
        cmd.Parameters.AddWithValue("@ADM", d.Admission);
        cmd.Parameters.AddWithValue("@DSC", d.Discharge);
        cmd.Parameters.AddWithValue("@DTH", d.Death);
        cmd.Parameters.AddWithValue("AVG", d.AvgStay);
        cmd.Parameters.AddWithValue("@BOC", d.BedOccupancy);
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
    public Server2Client UpdateWardWiseData(WardWiseData d)
    {
        Server2Client sc = new Server2Client();
        MySqlCommand cmd = new MySqlCommand("UPDATE wwd SET DMonth=@MNO, DYear=@YNO, WardNo=@WNO, WardName=@WNM, Bed=@BED, Admission=@ADM, Discharge=@DSC, Death=@DTH, AvgStay=@AVG, BedOccupancy=@BOC WHERE ID=" + d.ID, cm);
        cmd.Parameters.AddWithValue("@MNO", d.DMonth);
        cmd.Parameters.AddWithValue("@YNO", d.DYear);
        cmd.Parameters.AddWithValue("@WNO", d.WardNo);
        cmd.Parameters.AddWithValue("@WNM", d.WardName);
        cmd.Parameters.AddWithValue("@BED", d.Bed);
        cmd.Parameters.AddWithValue("@ADM", d.Admission);
        cmd.Parameters.AddWithValue("@DSC", d.Discharge);
        cmd.Parameters.AddWithValue("@DTH", d.Death);
        cmd.Parameters.AddWithValue("AVG", d.AvgStay);
        cmd.Parameters.AddWithValue("@BOC", d.BedOccupancy);
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
    public Server2Client DeleteWardWiseData(WardWiseData d)
    {
        Server2Client sc = new Server2Client();
        MySqlCommand cmd = new MySqlCommand("DELETE FROM wwd WHERE DMonth=" + d.DMonth + " AND DYear=" + d.DYear , cm);
        
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
