using System;
using System.Collections.Generic;
using System.Data.OleDb;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class Enregistrement : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        database db = new database();
        System.Data.OleDb.OleDbConnection cnn = db.connection();
        try
        {
                cnn.Open();
                if (Request.Params["enr"] != null)
                {
                    string slct = "SELECT * FROM reservation where id = "+ Request.Params["enr"]+" ORDER BY id DESC";
                    OleDbCommand cmd = new OleDbCommand(slct, cnn);
                    OleDbDataReader rd = cmd.ExecuteReader();
                    if (rd != null)
                    {
                        while (rd.Read())
                        {
                            String Efface = "<a href='reservations.aspx?delete=" + rd["id"].ToString() + "'><span class='glyphicon glyphicon-remove'></span></a>";
                            nom.Text = (string)rd["nom"];
                            prenom.Text= (string)rd["prenom"];
                            cin.Text = (string)rd["cin"];
                            datereservation.Text = rd["date_reservation"].ToString();
                            datearrivee.Text = (string)rd["date_arrivee"].ToString();
                            nbrpersonnes.Text = rd["nombre"].ToString();
                            if (rd["formule"].ToString() == "pd")
                            {
                                formule.Text = "Petit Déjeuner";
                            }
                            else if (rd["formule"].ToString() == "dp")
                            {
                                formule.Text = "Demi-Pension";
                            }
                            else
                            {
                                formule.Text = "Pension Complète";
                            }
                            nbrnuit.Text = rd["nbnuits"].ToString();
                        }
                    }
                }
                else
                {
                    Response.Redirect("Default.aspx");
                }
        }
        catch (Exception ex)
        {
            Response.Write(ex.Message);
        }
        cnn.Close();
    }

}