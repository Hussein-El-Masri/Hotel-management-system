using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Xml.Linq;

namespace $safeprojectname$.Models
{
    public partial class WebForm1 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            
                if (!IsPostBack)
                {
                // This block will only execute when the page is first loaded, not on postbacks.
                // Clear the textbox's value to hide the old entered data.
                txtUsername.Text = "";
                txtEmail.Text = "";
                }
            
        }

        protected void BtnRegister_Click(object sender, EventArgs e)
        {


            // Get user input from textboxes
            string username = txtUsername.Text;
            string password = txtPassword.Text;
            string email = txtEmail.Text;

            // Perform validation on user input
            if (string.IsNullOrWhiteSpace(username) || string.IsNullOrWhiteSpace(password) || string.IsNullOrWhiteSpace(email))
            {
                // Display error message if any of the required fields are empty
                lblMessage.Visible = true;
                lblMessage.Text = "Please fill in all required fields.";
                return; // Exit the method to prevent further processing
            }

            // TODO: Store user information in the database

            // Display success message
            lblMessage.Visible = true;
            lblMessage.Text = "Registration successful!";
       //   Response.Redirect("WebForm2.aspx");
            string name = txtUsername.Text.Trim();
            if (!string.IsNullOrEmpty(name))
            {
                Session["Name"] = name; // Store the name in a session variable
                Response.Redirect("WebForm2.aspx"); // Redirect to the second web form
            }
        }

    }
}