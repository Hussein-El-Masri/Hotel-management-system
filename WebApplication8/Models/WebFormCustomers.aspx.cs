using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Reflection.Emit;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;



namespace WebApplication8.Models
{
    public partial class WebFormCustomers : System.Web.UI.Page
    {
        SqlConnection con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=|DataDirectory|\Database1.mdf;Integrated Security=True");

        protected void Page_Load(object sender, EventArgs e)
        {
            if (con.State == ConnectionState.Open)
            {
                con.Close();
            }
            con.Open();
            disp_data();

        }
        protected void Btn_Save(object sender, EventArgs e)
        {
            // Get user input from textboxes
            string username = Name.Text;
            string PhoneNumber = Phone.Text;

            // Perform validation on user input
            if (string.IsNullOrWhiteSpace(username) || string.IsNullOrWhiteSpace(PhoneNumber))
            {
                // Display error message if any of the required fields are empty
                lblMessage.Visible = true;
                lblMessage.Text = "Please fill in all required fields.";
                return; // Exit the method to prevent further processing
            }

            // TODO: Store user information in the database

            // Display success message
            lblMessage.Visible = true;
            lblMessage.Text = "Customer added!!";


            string data = Name.Text;
            Response.Redirect("WebFormBooking.aspx?data=" + Server.UrlEncode(data));

          
        }
        protected void Btn_Add(object sender, EventArgs e){

            SqlCommand cmd = con.CreateCommand();
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = "insert into customers values ('" + Name.Text + "','" + DropDownList1.SelectedValue + "', '" + Phone.Text + "')";
            cmd.ExecuteNonQuery();

            disp_data();
        }

   

        public void disp_data()
        {
            SqlCommand cmd = con.CreateCommand();
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = " select * from customers";
            cmd.ExecuteNonQuery();
            DataTable dataTable = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            da.Fill(dataTable);
            GridView1.DataSource = dataTable;
            GridView1.DataBind();
        }
    }
}