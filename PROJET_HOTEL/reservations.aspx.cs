using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;
using System.Data.OleDb;
public partial class reservations : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        database db = new database();
        OleDbConnection cnn = db.connection();
        try
        {
            cnn.Open();

            if (Request.Params["delete"] == null)
            {
                string slct = "SELECT * FROM reservation ORDER BY id DESC";
                OleDbCommand cmd = new OleDbCommand(slct, cnn);
                OleDbDataReader rd = cmd.ExecuteReader();
                if (rd != null)
                {
                    while (rd.Read())
                    {
                        TableRow r1 = new TableRow();
                        TableCell c1 = new TableCell();
                        TableCell c2 = new TableCell();
                        TableCell c3 = new TableCell();
                        TableCell c4 = new TableCell();
                        TableCell c5 = new TableCell();
                        TableCell c6 = new TableCell();
                        TableCell c7 = new TableCell();
                        TableCell c8 = new TableCell();
                        c1.Text = "<a href='reservations.aspx?delete=" + rd["id"].ToString() + "'><span class='glyphicon glyphicon-remove'></span></a>";
                        c2.Text = (string)rd["nom"];
                        c3.Text = (string)rd["prenom"];
                        c4.Text = (string)rd["cin"];
                        c5.Text = (string)rd["date_reservation"].ToString();
                        c6.Text = rd["nombre"].ToString();
                        c7.Text = rd["nbchambre"].ToString();
                        c8.Text = rd["nbnuits"].ToString();
                        r1.Cells.Add(c1);
                        r1.Cells.Add(c2);
                        r1.Cells.Add(c3);
                        r1.Cells.Add(c4);
                        r1.Cells.Add(c5);
                        r1.Cells.Add(c6);
                        r1.Cells.Add(c7);
                        r1.Cells.Add(c8);
                        listreserv.Rows.Add(r1);
                    }
                }
            }
            else 
            {
                string strdl = "DELETE FROM reservation WHERE id = "+Request.Params["delete"];
                OleDbCommand cmd = new OleDbCommand(strdl, cnn);
                cmd.ExecuteNonQuery();
                Response.Redirect("reservations.aspx");
            }

        }
        catch (Exception ex)
        {
            Response.Write(ex.Message);
        }
        cnn.Close();
    }
}