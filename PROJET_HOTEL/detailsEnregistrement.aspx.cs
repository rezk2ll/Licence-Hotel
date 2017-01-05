using System;
using System.Collections.Generic;
using System.Data.OleDb;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class detailsEnregistrement : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        try
        {
            if (Session["logged"] == null || Session["logged"].ToString().CompareTo("0") == 0)
            {

                Response.Redirect("Default.aspx");
            }

        }
        catch (Exception ex)
        {
            Response.Redirect("Default.aspx");
        }

            database db = new database();
            OleDbConnection cnn = db.connection();
            try
            {
                cnn.Open();
                if (Request.Params["enr"] != null)
                {
                    string slct = "SELECT * FROM reservation where id = " + Request.Params["enr"];
                    OleDbCommand cmd = new OleDbCommand(slct, cnn);
                    OleDbDataReader rd = cmd.ExecuteReader();
                    if (rd != null)
                    {
                        rd.Read();
                        nom.Text = (string)rd["nom"] +" " +(string)rd["prenom"];
                        cin.Text = (string)rd["cin"];
                        datearrivee.Text = (string)rd["date_arrivee"].ToString();
                        nbrpersonnes.Text = rd["nombre"].ToString();
                        if (rd["formule"].ToString() == "pd")
                            {formule.Text = "Petit Déjeuner";}
                        else if (rd["formule"].ToString() == "dp")
                            {formule.Text = "Demi-Pension";}
                        else
                            {formule.Text = "Pension Complète";}
                        nbrnuitees.Text = rd["nbnuits"].ToString();
                        chambre.Text = (string)rd["chambre"];
                       
                        DateTime today = DateTime.Today.Date;
                        string[] date2 = datearrivee.Text.Split('-');
                        string y = date2[2] + "/" + date2[1] + "/" + date2[0];
                        DateTime depart = Convert.ToDateTime(y);

                        if (today >= depart.AddDays(int.Parse(rd["nbnuits"].ToString())))
                        {
                            Checkout.Visible = true;
                        }
                        else
                        {
                             Checkout.Visible = false;
                        }
                    }
                    else
                        {Response.Redirect("Default.aspx");}
                }
                else
                    {Response.Redirect("Default.aspx");}

            }
            catch (Exception ex)
                {Response.Write(ex.Message);}
            cnn.Close();
    }

    protected void Facture_Click(object sender, EventArgs e)
        {Response.Redirect("Facturation.aspx?enr=" + Request.Params["enr"]);}

    protected void Checkout_Click(object sender, EventArgs e)
    {
        database db = new database();
        OleDbConnection connexion = db.connection();
        try
        {
            connexion.Open();
            string sql1 = "SELECT * FROM reservation where id = " + Request.Params["enr"];
            OleDbCommand cmd = new OleDbCommand(sql1, connexion);
            OleDbDataReader rd = cmd.ExecuteReader();
            if (rd != null)
            {
                rd.Read();
                string sql2 = "UPDATE reservation SET etat = 'CheckedOut' where id = " + Request.Params["enr"];
                string sql3 = "UPDATE chambres SET reservee = '0' where numero = " + rd["chambre"].ToString();

                OleDbCommand ins = new OleDbCommand(sql2, connexion);
                ins.ExecuteNonQuery();
                ins = new OleDbCommand(sql3, connexion);
                ins.ExecuteNonQuery();
            }
            else
            {
                Response.Redirect("Default.aspx");
            }
        }
        catch (Exception ex)
        {
            Response.Write(ex.Message);
            Console.WriteLine(ex.Message);
        }
        connexion.Close();
        Response.Redirect("reservations.aspx");
    }

}