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
        if (!IsPostBack)
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
                        nbrnuitees.Text = rd["nbnuits"].ToString();
                        //string today = DateTime.Today.Date.ToString();
                        //string[] date_comps = today.Split(' ');
                        //string[] date1 = date_comps[0].Split('/');
                        //string[] date2 = datearrivee.Text.Split('-');
                        //string s = date1[0] + "=" + date1[1] + "=" + date1[2];
                        //string y = date2[2] + "=" + date2[1] + "=" + date2[0];
                        //if (s.Equals(y))
                        //{
                        //    Checkin.Visible = true;
                        //    room.Visible = true;
                        //    Label4.Visible = true;
                        //    string str = "SELECT * FROM chambres where reservee like " + 0 + " and personnes like " + rd["nombre"].ToString() + " ORDER BY numero";
                        //    OleDbCommand comm = new OleDbCommand(str, cnn);
                        //    OleDbDataReader c = comm.ExecuteReader();
                        //    if (c != null)
                        //    {
                        //        while (c.Read())
                        //        {
                        //            ListItem l = new ListItem();
                        //            l.Text = c["numero"].ToString();
                        //            l.Value = c["numero"].ToString();
                        //            room.Items.Add(l);
                        //        }
                        //    }
                        //}
                        //else
                        //{
                        //    Checkin.Visible = false;
                        //    room.Visible = false;
                        //    Label4.Visible = false;
                        //}

                    }
                    else
                    {
                        Response.Redirect("Default.aspx");
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
}