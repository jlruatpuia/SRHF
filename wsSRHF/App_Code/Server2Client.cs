using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Web;

/// <summary>
/// Summary description for Server2Client
/// </summary>
public class Server2Client
{
    public int count { get; set; }
    public double value { get; set; }
    public string message { get; set; }
    public bool result { get; set; }
    public DataTable dt { get; set; }
    public DataSet ds { get; set; }
}

public class Patient
{
    public int ID { get; set; }
    public string EMRNo { get; set; }
    public string PName { get; set; }
    public string Address { get; set; }
    public string Sex { get; set; }
    public int Age { get; set; }

}

public class OPD
{
    public int ID { get; set; }
    public DateTime I_Date { get; set; }
    public int DailyNo { get; set; }
    public int MonthlyNo { get; set; }
    public int YearlyNo { get; set; }
    public string EMRNo { get; set; }
    public int OPDNo { get; set; }
    public string Cases { get; set; }

}

public class ECG
{
    public int ID { get; set; }
    public DateTime I_Date { get; set; }
    public int DailyNo { get; set; }
    public int MonthlyNo { get; set; }
    public string EMRNo { get; set; }
    public string Diagnosis { get; set; }
    public string ReceiptNo { get; set; }
    public string Remarks { get; set; }
    public double Charge { get; set; }
}

public class USG
{
    public int ID { get; set; }
    public DateTime I_Date { get; set; }
    public int DailyNo { get; set; }
    public int MonthlyNo { get; set; }
    public string EMRNo { get; set; }
    public string Diagnosis { get; set; }
    public string ReceiptNo { get; set; }
    public string Remarks { get; set; }
    public double Charge { get; set; }
}

public class XRAY
{
    public int ID { get; set; }
    public DateTime I_Date { get; set; }
    public int DailyNo { get; set; }
    public int MonthlyNo { get; set; }
    public string EMRNo { get; set; }
    public string Diagnosis { get; set; }
    public string ReceiptNo { get; set; }
    public string Remarks { get; set; }
    public double Charge { get; set; }
}

public class LAB
{
    public int ID { get; set; }
    public DateTime I_Date { get; set; }
    public int SlNo { get; set; }
    public int DailyNo { get; set; }
    public string ReceiptNo { get; set; }
    public string EMRNo { get; set; }
    public string PatientType { get; set; }
    public string Ward { get; set; }
    public string MRDNo { get; set; }
    public string TestPerformed { get; set; }
    public double Charge { get; set; }
    public string Remarks { get; set; }

}

public class Casualty
{
    public int ID { get; set; }
    public string RegNo { get; set; }
    public int SlNo { get; set; }
    public DateTime RegDate { get; set; }
    public DateTime RegTime { get; set; }
    public string PName { get; set; }
    public string Address { get; set; }
    public int Age { get; set; }
    public string Sex { get; set; }
    public string Diagnosis { get; set; }
    public string Treatment { get; set; }

}

public class OpTheater
{
    public int ID { get; set; }
    public DateTime I_Date { get; set; }
    public int DailyNo { get; set; }
    public int MonthlyNo { get; set; }
    public int YearlyNo { get; set; }
    public string EMRNo { get; set; }
    public string OpName { get; set; }
    public string PatientType { get; set; }
    public int Anaesthesia { get; set; }
    public string OpType { get; set; }
    public string Anaesthetist { get; set; }
    public string Surgeon { get; set; }
    public string Assistant { get; set; }
    public string Remarks { get; set; }
}

public class MRD
{
    public int ID { get; set; }
    public int SlNo { get; set; }
    public string EMRNo { get; set; }
    public string Diagnosis { get; set; }
    public string MRDNo { get; set; }
    public string Ward { get; set; }
    public string ICDCode { get; set; }
    public DateTime AdmissionDate { get; set; }
    public DateTime DischargeDate { get; set; }
    public string Remarks { get; set; }
    public int HospitalDays { get; set; }
    public string Result { get; set; }
    public string Discharged { get; set; }
    public string DischargedAlive { get; set; }
    public string DischargedDeath { get; set; }
    public string CauseOfDeath { get; set; }
    public string DirectCause { get; set; }
    public string AntecedentCause { get; set; }
    public string OtherCause { get; set; }


}

public class RSBY
{
    public int ID { get; set; }
    public int SlNo { get; set; }
    public string MRDNo { get; set; }
    public string PName { get; set; }
    public string Address { get; set; }
    public string FamilyHead { get; set; }
    public string ContactNo { get; set; }
    public string Ward { get; set; }
    public DateTime AdmissionDate { get; set; }
    public DateTime DischargeDate { get; set; }
    public string Packages { get; set; }
    public double TotalBill { get; set; }
    public double ActualAmount { get; set; }
    public double HospitalShare { get; set; }
    public string URN { get; set; }
    public string Remarks { get; set; }
}

public class HCARE
{
    public int ID { get; set; }
    public int EnrollmentNo { get; set; }
    public string MRDNo { get; set; }
    public string PName { get; set; }
    public string Address { get; set; }
    public string FamilyHead { get; set; }
    public double AmountClaimed { get; set; }
    public string Diagnosis { get; set; }
    public DateTime AdmissionDate { get; set; }
    public DateTime DischargeDate { get; set; }

}

public class Wards
{
    public int ID { get; set; }
    public int WardNo { get; set; }
    public string WardName { get; set; }
    public string WardFullName { get; set; }

}

public class Dept
{
    public int ID { get; set; }
    public int DeptNo { get; set; }
    public string DeptShortName { get; set; }
    public string DeptFullName { get; set; }

}

public class MSB
{
    public int ID { get; set; }
    public string HospitalName { get; set; }
    public int Month { get; set; }
    public int Year { get; set; }
    public int BedStrength { get; set; }
    public int TotalPatientCareOPD { get; set; }
    public int TotalPatientCareCAS { get; set; }
    public int TotalPatientCareNew { get; set; }
    public int TotalPatientCareOld { get; set; }
    public int TotalAdmissionFromOPD { get; set; }
    public int TotalAdmissionFromCAS { get; set; }
    public int InvestigationLAB { get; set; }
    public int InvestigationXRAY { get; set; }
    public int InvestigationENDO { get; set; }
    public int InvestigationUSG { get; set; }
    public int InvestigationECG { get; set; }
    public int InvestigationBRON { get; set; }
    public int InvestigationCOLON { get; set; }
    public int InvestigationRADIO { get; set; }
    public int InvestigationEEG { get; set; }
    public int InvestigationECHO { get; set; }
    public int InvestigationPFT { get; set; }
    public int InvestigationDIET { get; set; }
    public int InvestigationDIAL { get; set; }
    public int InvestigationCTSCAN { get; set; }
    public int InvestigationCHEMO { get; set; }
    public int InvestigationPMR { get; set; }
    public int OperationMajor { get; set; }
    public int OperationMinor { get; set; }
    public int DeliveryLiveMale { get; set; }
    public int DeliveryLiveFemale { get; set; }
    public int DeliveryStillMale { get; set; }
    public int DeliveryStillFemale { get; set; }
    public int DischargeAlive { get; set; }
    public int DischargeDeath { get; set; }
    public int DischargeDeathU48 { get; set; }
    public int DischargeDeathO48 { get; set; }
    public int PatientDischargedDays { get; set; }
    public double AverageLengthOfStay { get; set; }
    public double TotalInPatientCensus { get; set; }
    public double AvgPercOfBedOccupancy { get; set; }
    public double BedTurnOverRate { get; set; }
    public double DailyCensusOfIndoorPatientMAX { get; set; }
    public double DailyCensusOfIndoorPatientMIN { get; set; }
    public int NoOfAutopsy { get; set; }
    public int CaseReferredOutsideMizoram { get; set; }
    public double HealthCare { get; set; }
    public double RSBY { get; set; }
    public int Count { get; set; }
}

public class DepartmentWiseData
{
    public int ID { get; set; }
    public int DMonth { get; set; }
    public int DYear { get; set; }
    public int DeptNo { get; set; }
    public string DeptName { get; set; }
    public int NewCase { get; set; }
    public int OldCase { get; set; }
    public int Total { get; set; }
    public double Average { get; set; }

}

public class WardWiseData
{
    public int ID { get; set; }
    public int DMonth { get; set; }
    public int DYear { get; set; }
    public int WardNo { get; set; }
    public string WardName { get; set; }
    public int Bed { get; set; }
    public int Admission { get; set; }
    public int Discharge { get; set; }
    public int Death { get; set; }
    public double AvgStay { get; set; }
    public double BedOccupancy { get; set; }

}

public class Users
{
    public int ID { get; set; }
    public string UserName { get; set; }
    public string Password { get; set; }
    public string UserType { get; set; }

}

public class ICD
{
    public string Code { get; set; }
    public string Description { get; set; }

}

public class Utils
{
    public string Encrypt(string uname, string pwd)
    {
        SHA256Managed h = new SHA256Managed();
        byte[] b = Encoding.UTF8.GetBytes(string.Concat(pwd, uname));
        byte[] e = h.ComputeHash(b);
        h.Clear();
        return Convert.ToBase64String(e);
    }
}