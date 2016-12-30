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
            string cmdstr = "UPDATE consommation SET Eau = '" + eau.Text + "'  , Cafe = '" + cafe.Text + "' , Boisson = '" + boisson.Text + "' , Bierre = '" + bierre.Text + "' , Balade = '" + balade.Text + "' , Massage = '" + massage.Text + "' , Hamburgueur = '" + hamburgueur.Text + "' , Soin = '" + soin.Text + "' , Pizza = '" + pizza.Text + "' , Spa = '" + spa.Text + "' WHERE idreservation = " + Request.Params["enr"];
            Response.Write(cmdstr);
            try
            {
                cnn.Open();
                OleDbCommand ins = new OleDbCommand(cmdstr, cnn);
                //Response.Write("ok");
                ins.ExecuteNonQuery();
                //Response.Write("ok2");
            }
            catch (Exception ex)
            {
                Response.Write(ex.Message);
                Console.WriteLine(ex.Message);
            }
            //Response.Write("bye");
            cnn.Close();
            //Response.Write("what !!");
        }
        //Response.Redirect("detailsEnregistrement.aspx?enr=" + Request.Params["enr"]);
    }
}