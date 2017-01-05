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

                string sql2 = "SELECT * FROM consommation where idreservation = " + Request.Params["enr"];
                OleDbCommand cmdconsommation = new OleDbCommand(sql2, cnn);
                OleDbDataReader consommation = cmdconsommation.ExecuteReader();
                consommation.Read();

                eau.Text = consommation["Eau"].ToString();

                boisson.Text = consommation["Boisson"].ToString();

                bierre.Text = consommation["Bierre"].ToString();

                cafe.Text = consommation["Cafe"].ToString();

                pizza.Text = consommation["Pizza"].ToString();

                hamburgueur.Text = consommation["Hamburgueur"].ToString();

                massage.Text = consommation["Massage"].ToString();

                spa.Text = consommation["Spa"].ToString();

                soin.Text = consommation["Soin"].ToString();

                balade.Text = consommation["Balade"].ToString();
       
                cnn.Close();
        }
        catch (Exception ex)
        {
            Response.Write(ex);
        }
        cnn.Close();
    }

    protected void Sauvegarder_Click(object sender, EventArgs e)
    {
            database db = new database();
            OleDbConnection cnn = db.connection();
        if (Page.IsValid)
        {
            string cmdstr = "UPDATE consommation SET Eau = " + Request.Params["ctl00$ContentPlaceHolder1$eau"] + "  , Cafe = " + Request.Params["ctl00$ContentPlaceHolder1$cafe"] + " , Boisson = " + Request.Params["ctl00$ContentPlaceHolder1$boisson"] + " , Bierre = " + Request.Params["ctl00$ContentPlaceHolder1$bierre"] + " , Balade = " + Request.Params["ctl00$ContentPlaceHolder1$balade"] + " , Massage = " + Request.Params["ctl00$ContentPlaceHolder1$massage"] + " , Hamburgueur = " + Request.Params["ctl00$ContentPlaceHolder1$hamburgueur"] + " , Soin = " + Request.Params["ctl00$ContentPlaceHolder1$soin"] + " , Pizza = " + Request.Params["ctl00$ContentPlaceHolder1$pizza"] + " , Spa = " + Request.Params["ctl00$ContentPlaceHolder1$spa"] + " WHERE idreservation = " + Request.Params["enr"];
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

        }
        Response.Redirect("detailsEnregistrement.aspx?enr=" + Request.Params["enr"]);
    }
}