using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Reflection.Emit;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Xml.Linq;




namespace WebApplication8.Models
{
    public partial class WebFormRooms : System.Web.UI.Page
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
                // Initialize the data table to store the entered data
                DataTable dataTable = new DataTable();
                dataTable.Columns.Add("TextBox1", typeof(string));
                dataTable.Columns.Add("DropDownList1", typeof(string));
                dataTable.Columns.Add("DropDownList2", typeof(string));
                ViewState["DataTable"] = dataTable;

            
            }
        }


             

        protected void BtnRegister_Save(object sender, EventArgs e)
            {
            // Retrieve the existing data table from ViewState
            //    DataTable dataTable = (DataTable)ViewState["DataTable"];

            // Add a new row with the entered data
            // DataRow newRow = dataTable.NewRow();
            // newRow["TextBox1"] = TextBox1.Text;
            //     newRow["DropDownList1"] = DropDownList1.SelectedItem.Text;
            //   newRow["DropDownList2"] = DropDownList2.SelectedItem.Text;
            //  dataTable.Rows.Add(newRow);

            // Bind the data table to the GridView
            // gvData.DataSource = dataTable;
            // gvData.DataBind();

            // Clear the controls
            // TextBox1.Text = "";
            //DropDownList1.SelectedIndex = 0;
            // DropDownList2.SelectedIndex = 0;
            SqlCommand cmd = con.CreateCommand();
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = "insert into rooms values('" + TextBox1.Text + "', '" + DropDownList1.SelectedValue + "', '" + DropDownList2.SelectedValue + "')";
            cmd.ExecuteNonQuery();

            disp_data();
        }
        public void disp_data()
        {
            SqlCommand cmd = con.CreateCommand();
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = " select * from rooms";
            cmd.ExecuteNonQuery();
            DataTable dataTable = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            da.Fill(dataTable);
            GridView1.DataSource = dataTable;
            GridView1.DataBind();
        }
        protected void BtnDelete_Click(object sender, EventArgs e)
        {
            SqlCommand cmd = con.CreateCommand();
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = " DELETE FROM rooms";
            cmd.ExecuteNonQuery();
            disp_data();
        }

        protected void BtnBack_Click(object sender ,  EventArgs e)
        {

            Response.Redirect("WebForm2.aspx");
        }

    }
}
