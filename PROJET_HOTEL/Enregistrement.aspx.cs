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
        OleDbConnection cnn = db.connection();
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
                            rd.Read();
                            String Efface = "<a href='reservations.aspx?delete=" + rd["id"].ToString() + "'><span class='glyphicon glyphicon-remove'></span></a>";
                            nom.Text = (string)rd["nom"];
                            prenom.Text = (string)rd["prenom"];
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
                            string today = DateTime.Today.Date.ToString();
                            string[] date_comps = today.Split(' ');
                            string[] date1 = date_comps[0].Split('/');
                            string[] date2 = datearrivee.Text.Split('-');
                            string s=date1[0] + "=" + date1[1] + "=" + date1[2];
                            string y=date2[2] + "=" + date2[1] + "=" + date2[0];
                            if (s.Equals(y))
                            {
                                Checkin.Visible = true;
                                room.Visible = true;
                                Label4.Visible = true;
                                string str = "SELECT * FROM chambres where reservee like "+0+" and personnes like " + rd["nombre"].ToString() + " ORDER BY numero";
                                OleDbCommand comm = new OleDbCommand(str, cnn);
                                OleDbDataReader c = comm.ExecuteReader();
                                if (c != null)
                                {
                                    while (c.Read())
                                    {
                                        ListItem l = new ListItem();
                                        l.Text = c["numero"].ToString();
                                        l.Value = c["numero"].ToString();
                                        room.Items.Add(l);
                                    }
                                }
                            }
                            else
                            {
                                Checkin.Visible = false;
                                room.Visible = false;
                                Label4.Visible = false;
                            }
                       
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


    protected void Sauvegarder_Click(object sender, EventArgs e)
    {   
        if (Page.IsValid)
        {
            database db = new database();
            OleDbConnection cnn = db.connection();
            string cmdstr = "UPDATE reservation SET nom = '"+ nom.Text +"'  , prenom = '"+ prenom.Text +"' , cin = '"+cin.Text+"' , nombre = '"+nbrpersonnes.Text+"' , nbnuits = '"+ nbrnuit.Text +"' , formule = '"+ formule.SelectedValue +"' , date_arrivee = '"+ datearrivee.Text +"' WHERE id = "+Request.Params["enr"];
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
            Response.Redirect("Enregistrement.aspx?enr=" + Request.Params["enr"]);
        }
    }

    protected void Checkin_Click(object sender, EventArgs e)
    {
        if (room.SelectedValue!="-1")
        {

            database db = new database();
            OleDbConnection connexion = db.connection();
            string sql1 = "INSERT INTO consommation ( idreservation ) VALUES ( '" + Request.Params["enr"] + "' )";
            string sql2 = "UPDATE chambres SET reservee = '1' where numero = "+ room.SelectedValue;
            string sql3 = "UPDATE reservation SET etat = 'CheckedIn' , chambre = "+ room.SelectedValue +" where id = " + Request.Params["enr"];
            try
            {
                connexion.Open();
                OleDbCommand ins = new OleDbCommand(sql1, connexion);
                ins.ExecuteNonQuery();
                ins = new OleDbCommand(sql2, connexion);
                ins.ExecuteNonQuery();
                ins = new OleDbCommand(sql3, connexion);
                ins.ExecuteNonQuery();
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
}