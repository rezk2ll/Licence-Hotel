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
            string req = "SELECT * FROM produit";
            OleDbCommand com = new OleDbCommand(req, cnn);
            OleDbDataReader produit = com.ExecuteReader();
            while (produit.Read())
            {
                corps.Controls.Add(new Label()
                                    {
                                        Text = produit["nom"].ToString()
                                    } 
                                  );

                string sql2 = "SELECT * FROM consommation c , produit p where c.idarticle = p.id and c.idreservation = " + Request.Params["enr"];
                OleDbCommand cmdconsommation = new OleDbCommand(sql2, cnn);
                OleDbDataReader consommation = cmdconsommation.ExecuteReader();
                int x = 0;
                while (consommation.Read())
                {
                    if (consommation[4].ToString() == produit["nom"].ToString())
                    {
                        x += 1;
                    }
                }
                corps.Controls.Add(new TextBox()
                                    {
                                        ID = produit["nom"].ToString() , Text=x.ToString() , 
                                    }
                                  );
            }
            string sql = "SELECT * FROM reservation where id = " + Request.Params["enr"];
            OleDbCommand cmdreservation = new OleDbCommand(sql, cnn);
            OleDbDataReader reservation = cmdreservation.ExecuteReader();
            reservation.Read();
            string nom = reservation["nom"].ToString() + " " + reservation["prenom"].ToString();
            string chambre = reservation["chambre"].ToString();
            cnn.Close();
        }
        catch (Exception ex)
        {
            Response.Write(ex);
        }
        cnn.Close();
    }
}