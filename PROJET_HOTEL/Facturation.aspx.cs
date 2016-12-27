using System;
using System.Collections.Generic;
using System.Data.OleDb;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class Facturation : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        database db = new database();
        OleDbConnection cnn = db.connection();
        try
        {
            cnn.Open();
            if (Request.Params["enr"] != null)
            {
                string slct = "SELECT * FROM enregistrement where id = " + Request.Params["enr"] ;
                OleDbCommand cmdenregistrement = new OleDbCommand(slct, cnn);
                OleDbDataReader enregistrement = cmdenregistrement.ExecuteReader();
                if (enregistrement != null)
                {
                    enregistrement.Read();
                    string sql = "SELECT * FROM reservation where id = " + enregistrement["idreservation"];
                    OleDbCommand cmdreservation= new OleDbCommand(sql, cnn);
                    OleDbDataReader reservation = cmdreservation.ExecuteReader();
                    reservation.Read();
                    string nom = reservation["nom"].ToString() + " " + reservation["prenom"].ToString();
                    string chambre = enregistrement ["idchambre"].ToString();
                    //
                    //rechercher les consommation relative à cet enregistrement
                    //
                    string sql2 = "SELECT * FROM consommation c , produit p where c.idarticle = p.id and c.idenregistrement = " + enregistrement["id"];
                    OleDbCommand cmdconsommation = new OleDbCommand(sql2, cnn);
                    OleDbDataReader consommation = cmdconsommation.ExecuteReader();
                    while(consommation.Read())
                    {
                        //
                        //
                        //Afficher les consommations et calculer le total des prix
                        //
                        //
                    }
                        
                    
                }
            else
            {
                 //
                 //afficher toutes les enregistrements
                 //
                 Response.Redirect("Default.aspx");
            }
        }
            else
            { Response.Redirect("Default.aspx"); }

    }
        catch (Exception ex)
        { Response.Write(ex.Message); }
        cnn.Close();
    }
}