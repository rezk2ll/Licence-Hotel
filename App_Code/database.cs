using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data;
using System.Data.OleDb;

/// <summary>
/// Summary description for Class1
/// </summary>
public class database
{
    public OleDbConnection connection() {

        string StrCnn = @"Provider=Microsoft.Jet.OLEDB.4.0;Data Source=" + HttpContext.Current.Request.PhysicalApplicationPath + "\\App_code\\hotel.mdb";
        OleDbConnection cnn = new OleDbConnection(StrCnn);
        return cnn;
    }
}