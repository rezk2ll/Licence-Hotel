﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;
using System.Data.OleDb;

public partial class reservation : System.Web.UI.Page
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

    }

    protected void reserver(object sender, EventArgs e)
    {
        if (Page.IsValid)
        {
            database db = new database();
            OleDbConnection cnn = db.connection();
            string cmdstr = "INSERT INTO reservation ( nom , prenom , cin , nombre , date_arrivee , date_reservation , nbnuits , formule ) VALUES ( '" + nom.Text + "' , '" + prenom.Text + "' ,'" + cin.Text + "' ,'" + nbpers.Value + "' , '" + date_arrivee.Value + "' , '" + DateTime.Now.ToString("dd/MM/yyyy") + "' , '"+nbnuits.Value+"' , '"+ formule.SelectedValue +"' )";
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
            Response.Redirect("reservations.aspx");
        }
    }

}