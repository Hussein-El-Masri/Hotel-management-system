using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace WebApplication8.Models
{
    public partial class WebFormBooking : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                
                DataTable dataTable = new DataTable();
                dataTable.Columns.Add("Room" , typeof(string));
                dataTable.Columns.Add("Nights" ,typeof(string));
                dataTable.Columns.Add("Amount/Night" , typeof (string));
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

            int nbofnights = int.Parse(TextBox2.Text);
            decimal amountpernight = decimal.Parse(TextBox3.Text);

            decimal totalAmmount = nbofnights * amountpernight;
            lblTotalAmount.Text = "Total Ammount : " + totalAmmount.ToString("C");
            lblTotalAmount.Visible = true;


            DataTable dataTable = (DataTable)ViewState["DataTable"];

            DataRow newRow = dataTable.NewRow();
            newRow["Room"] = TextBox1.Text;
            newRow["Nights"] = TextBox2.Text;
            newRow["Amount/Night"] = TextBox3.Text;
            dataTable.Rows.Add(newRow);


            gvData.DataSource = dataTable;
            gvData.DataBind();

            TextBox1.Text = "";
            TextBox2.Text = "";
            TextBox3.Text = "";



            // Retrieve the values from the textboxes
            //   int numberOfNights = int.Parse(TextBox2.Text);
             //   decimal amountPerNight = decimal.Parse(TextBox3.Text);

                // Calculate the total amount
               // decimal totalAmount = numberOfNights * amountPerNight;

                // Set the total amount as the text of the label
                //lblTotalAmount.Text = "Total Amount: " + totalAmount.ToString("C");
                //lblTotalAmount.Visible = true;
            }


        protected void Btn_Cust(object sender, EventArgs e)
        {
            Response.Redirect("WebFormCustomers.aspx");
        }

        
    }

    }