using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Security.Policy;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Xml.Linq;

namespace $safeprojectname$.Models
{
    public partial class WebFormBooking : System.Web.UI.Page
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

            if (!IsPostBack)
            {
                
                DataTable dataTable = new DataTable();
                dataTable.Columns.Add("Room" , typeof(string));
                dataTable.Columns.Add("Nights" ,typeof(string));
                dataTable.Columns.Add("Amount/Night" , typeof(string));
                ViewState["DataTable"] = dataTable;

                string data = Request.QueryString["data"];
               if (!string.IsNullOrEmpty(data))
                {
                    DropDownList1.Items.Add(new ListItem(data, data));
                    DropDownList1.SelectedValue = data;
                }

            }
        }

        protected void Btn_Book(object sender, EventArgs e)
        {

 
            SqlCommand cmd = con.CreateCommand();
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = "INSERT INTO reservations (room_id, customer_id, nights, amount_per_night, total_amount) " +
                              "VALUES (@RoomId, @CustomerId, @Nights, @AmountPerNight, @TotalAmount)";
            cmd.Parameters.AddWithValue("@RoomId", TextBox1.Text);
            cmd.Parameters.AddWithValue("@CustomerId", DropDownList1.SelectedValue);
            cmd.Parameters.AddWithValue("@Nights", decimal.Parse(TextBox2.Text));
            cmd.Parameters.AddWithValue("@AmountPerNight", decimal.Parse(TextBox3.Text));

            decimal totalAmount = decimal.Parse(TextBox3.Text) * decimal.Parse(TextBox2.Text);
            cmd.Parameters.AddWithValue("@TotalAmount", totalAmount);

            cmd.ExecuteNonQuery();

            disp_data();
        }
       
        


        public void disp_data()
        {
            SqlCommand cmd = con.CreateCommand();
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = " select * from reservations";
            cmd.ExecuteNonQuery();
            DataTable dataTable = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            da.Fill(dataTable);
            GridView1.DataSource = dataTable;
            GridView1.DataBind();
        }

        protected void Btn_Cust(object sender, EventArgs e)
        {
            Response.Redirect("WebFormCustomers.aspx");
        }

        
    }

    }