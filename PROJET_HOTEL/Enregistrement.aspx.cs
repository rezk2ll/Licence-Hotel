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
        if (!IsPostBack)
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
                                formule.SelectedValue = "pd";
                            }
                            else if (rd["formule"].ToString() == "dp")
                            {
                                formule.SelectedValue = "dp";
                            }
                            else
                            {
                                formule.SelectedValue = "pc";
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


    protected void Sauvegarder_Click(object sender, EventArgs e)
    {   
        if (Page.IsValid)
        {
            database db = new database();
            OleDbConnection cnn = db.connection();
            string cmdstr = "UPDATE reservation SET nom = '"+ nom.Text +"'  , prenom = '"+ prenom.Text +"' , cin = '"+cin.Text+"' , nombre = '"+nbrpersonnes.Text+"' , nbnuits = '"+ nbrnuit.Text +"' , formule = '"+ formule.SelectedValue +"' , date_arrivee = '"+ datearrivee.Text +"' WHERE id = "+Request.Params["enr"];
            try
            {
                Response.Write(cmdstr);
                cnn.Open();
                OleDbCommand ins = new OleDbCommand(cmdstr, cnn);
                Response.Write("prob avant execturion");
                ins.ExecuteNonQuery();
                Response.Write("prob apres execturion");

            }
            catch (Exception ex)
            {
                Response.Write(ex.Message);
                Console.WriteLine(ex.Message);
            }
            cnn.Close();
           // Response.Redirect("reservations.aspx");
        }
    }
}