using System;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;

namespace Al_Shop
{
    public partial class Login : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        string patron = "1414";

        protected void btnIngresar_Click (object sender,EventArgs e)
        {
            string conectar = ConfigurationManager.ConnectionStrings["conexion"].ConnectionString;
            SqlConnection sqlConectar = new SqlConnection(conectar);
            SqlCommand cmd = new SqlCommand("SP_ValidarUsuario", sqlConectar)
            {
                CommandType = CommandType.StoredProcedure
            };
            cmd.Connection.Open();
            cmd.Parameters.Add("@email", SqlDbType.VarChar, 80).Value = tbEmail.Text;
            cmd.Parameters.Add("@pass", SqlDbType.VarChar, 80).Value = tbPassword.Text;
            cmd.Parameters.Add("@patron", SqlDbType.VarChar, 80).Value = patron;
            SqlDataReader dr = cmd.ExecuteReader();
            if (dr.Read())
            {
                Session["usuariologueado"] = tbEmail.Text;
                Response.Redirect("index.aspx");
            }
            else
            {
                lblError.Text = "Correo o Contraseña es incorrecta";
            }
            cmd.Connection.Close();
        }
    }
}