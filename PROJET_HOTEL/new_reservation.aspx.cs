using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;
using System.Data.OleDb;

public partial class reservation : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
       
    }

    protected void reserver(object sender, EventArgs e)
    {
        if (Page.IsValid)
        {
            database db = new database();
            OleDbConnection cnn = db.connection();
            string cmdstr = "INSERT INTO reservation ( nom , prenom , cin , nombre , date_arrivee , date_reservation , nbchambre , nbnuits ) VALUES ( '" + nom.Text + "' , '" + prenom.Text + "' ,'" + cin.Text + "' ,'" + nbpers.Value + "' , '" + date_reservation.Value + "' , '" + DateTime.Now.ToString("dd/MM/yyyy") + "' , '"+nbchambres.Value+"', '"+nbnuits.Value+"')";
            try
            {
                cnn.Open();
                OleDbCommand ins = new OleDbCommand(cmdstr, cnn);
                ins.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                Response.Write(ex.Message);
                Console.WriteLine(ex.Message);
            }
            cnn.Close();
            Response.Redirect("reservations.aspx");
        }
    }
}