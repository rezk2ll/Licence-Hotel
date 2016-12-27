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
            database db = new database();
            OleDbConnection cnn = db.connection();
            try
            {
                cnn.Open();
                if (Request.Params["res"] != null)
                {
                    string slct = "SELECT * FROM reservation where id = " + Request.Params["res"] + " ORDER BY id DESC";
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
                        //string today = DateTime.Today.Date.ToString();
                        //string[] date2 = datearrivee.Text.Split('-');
                        //string y = date2[2] + "/" + date2[1] + "/" + date2[0];
                        //DateTime dt = Convert.ToDateTime(y);
                        //Response.Write(dt);
                        //Response.Write(dt.AddDays(int.Parse(nbrnuitees.Text)));
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
}