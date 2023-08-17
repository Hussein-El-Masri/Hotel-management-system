
<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="WebFormCustomers.aspx.cs" Inherits="$safeprojectname$.Models.WebFormCustomers" %>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
           <style>
    body {
        background-image: url('https://previews.123rf.com/images/jirsak/jirsak1511/jirsak151100060/48801043-marketing-segmentation-target-audience-customers-care-customer-relationship-management-crm.jpg');
        background-repeat: no-repeat;
        background-size: cover;
    }

    h1{
        text-align: center;
        color: blue;
    }

    .drop{
       border:5px solid blue;

    }

    .t1{
       border:5px solid blue;

    }
    .t2{
       border:5px solid blue;

    }
    .button{
      border:5px solid blue;

    }
    .Message {
       position: fixed;
       text-transform:capitalize;
        bottom: 20px;
        left: 50%;
        transform: translateX(-50%);
        background-color: blue;
        color: white;
        border: 2px solid black;
        padding: 10px;
        text-align: center;
        display: none;
    }
               

               </style>
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
           <div>
               <h1> Manage Customers </h1>
            <p> &nbsp;</p>
            <p> &nbsp;</p>
            <p> &nbsp;</p>

            &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;

            <asp:TextBox ID="Name" autocomplete ="off" runat="server" placeholder="Name" CssClass="t1" Height="73px" Width="180px" ></asp:TextBox>
            &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
            <asp:DropDownList ID="DropDownList1" runat="server" Height="77px" Width="153px" CssClass="drop" >
                <asp:ListItem Value="Gender" Text="Gender" Selected="True" ></asp:ListItem>
                <asp:ListItem Value="Male" Text="Male" ></asp:ListItem>
                <asp:ListItem Value="Female" Text="Female" ></asp:ListItem>
            </asp:DropDownList>
            &nbsp;&nbsp;&nbsp;
            &nbsp;&nbsp;&nbsp;&nbsp;&nbsp; &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
            <asp:TextBox ID="Phone" autocomplete ="off"  runat="server" placeholder="Phone" CssClass="t2" Height="70px" Width="178px" ></asp:TextBox>
            <br />
            <br />
            <br />
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; 
               <br />
               <br />
               <br />
               <br />
               <br />
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; &nbsp;
            <asp:Button ID="Save"  runat="server" Text="Save" Width="149px" OnClick="Btn_Save" Height="91px" CssClass="button" />
               <asp:Button ID="Add"  runat="server" Text="Add" Width="149px" OnClick="Btn_Add" Height="91px" CssClass="button" />
                   <asp:Label ID="lblMessage" runat="server" Text="Label"></asp:Label>
        </div>
        <<asp:GridView ID="GridView1" runat="server"></asp:GridView>
    </form>
</body>
</html>
