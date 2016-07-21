using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

/// <summary>
/// Summary description for Settings
/// </summary>
public class Settings
{
    public Settings()
    {
        //
        // TODO: Add constructor logic here
        //
    }
    public static string getDate(DateTime dt)
    {
        return dt.Date.Year.ToString("0000") + "-" + dt.Date.Month.ToString("00") + "-" + dt.Date.Day.ToString("00");
    }
}