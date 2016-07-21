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

public class MRD
{
    public int ID { get; set; }
    public int SlNo { get; set; }
    public string EMRNo { get; set; }
    public string Diagnosis { get; set; }
    public string MRDNo { get; set; }
    public string ICDCode { get; set; }
}

public class Users
{
    public int ID { get; set; }
    public string UserName { get; set; }
    public string Password { get; set; }
    public string UserType { get; set; }

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