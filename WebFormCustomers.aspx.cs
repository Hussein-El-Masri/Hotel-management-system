using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Emit;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;



namespace WebApplication8.Models
{
    public partial class WebFormCustomers : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

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
    }
}