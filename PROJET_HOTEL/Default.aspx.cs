using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Security;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data.OleDb;
using System.Data;
using System.Security.Authentication;

public partial class _Default : System.Web.UI.Page
{

    protected void Page_Load(object sender, EventArgs e) {

        if (Session["loggedIN"] != null) {
            Server.Transfer("~/reservations.aspx", true);
        }
    
    }


    protected void Unnamed_Click(object sender, EventArgs e)
    {
        database db = new database();
        OleDbConnection cnn = db.connection();
        cnn.Open();
        string req = "SELECT * FROM USERS WHERE login ='"+username.Text+"' AND password ='"+password.Text+"' ;";
        OleDbCommand cmd = new OleDbCommand(req, cnn);
        OleDbDataReader rd = cmd.ExecuteReader();
        
        if (rd != null) {
            if (rd.Read())
            {
                if (rd["login"].ToString().CompareTo(username.Text) == 0)
                {
                    cnn.Close();
                    Session["loggedIN"] = true;
                    logstat.InnerText = "Welcome";
                    homee.Attributes["class"] = "panel panel-success";
                    logview.InnerText = "Welcome " + username.Text;
                    // redirect tfassa5 fel session
                    //Response.Redirect("~/reservations.aspx", false);
                    Server.Transfer("~/reservations.aspx", true);
                }
            }
            else {
                logstat.InnerText = "Wrong username or password";
                homee.Attributes["class"] = "panel panel-danger";
            }
        }
            
        cnn.Close();
    }
}