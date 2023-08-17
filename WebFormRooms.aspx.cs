using System;
using System.Collections.Generic;
using System.Data;
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
        protected void Page_Load(object sender, EventArgs e)
        {
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
                DataTable dataTable = (DataTable)ViewState["DataTable"];

                // Add a new row with the entered data
                DataRow newRow = dataTable.NewRow();
                newRow["TextBox1"] = TextBox1.Text;
                newRow["DropDownList1"] = DropDownList1.SelectedItem.Text;
                newRow["DropDownList2"] = DropDownList2.SelectedItem.Text;
                dataTable.Rows.Add(newRow);

                // Bind the data table to the GridView
                gvData.DataSource = dataTable;
                gvData.DataBind();

                // Clear the controls
                TextBox1.Text = "";
                DropDownList1.SelectedIndex = 0;
                DropDownList2.SelectedIndex = 0;
            }

        protected void BtnDelete_Click(object sender, EventArgs e)
        {
            // Retrieve the existing data table from ViewState
            DataTable dataTable = (DataTable)ViewState["DataTable"];

            // Remove the last row from the data table
            if (dataTable.Rows.Count > 0)
            {
                dataTable.Rows.RemoveAt(dataTable.Rows.Count - 1);
                dataTable.AcceptChanges();
            }

            // Bind the updated data table to the GridView
            gvData.DataSource = dataTable;
            gvData.DataBind();
        }

        protected void BtnBack_Click(object sender ,  EventArgs e)
        {

            Response.Redirect("WebForm2.aspx");
        }

    }
}
