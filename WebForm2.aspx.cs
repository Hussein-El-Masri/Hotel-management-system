using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace WebApplication8.Models
{
    public partial class WebForm2 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
                if (!IsPostBack)
                {
                    if (Session["Name"] != null)
                    {
                        string name = Session["Name"].ToString();
                        litName.Text = name; // Display the name in the <h1> heading
                    }
                    else
                    {
                        Response.Redirect("WebForm1.aspx"); // Redirect back to the first web form if the name is not found
                    }
                }
            

        }

        protected void BtnRegister_Rooms(object sender, EventArgs e)
        {
            Response.Redirect("WebFormRooms.aspx");

        }


        protected void BtnRegister_Customers(object sender, EventArgs e)
        {
            Response.Redirect("WebFormCustomers.aspx");

        }

        protected void BtnRegister_Booking(object sender, EventArgs e)
        {
            Response.Redirect("WebFormBooking.aspx");

        }
    }
}