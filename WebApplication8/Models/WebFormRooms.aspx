<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="WebFormRooms.aspx.cs" Inherits="WebApplication8.Models.WebFormRooms" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
     <style>
         .error-message {
             font-weight: bold;
             border: 1px solid white;
       
             background-color: beige;
             color: black;
         }
          body {
        background-image : url('https://images.pexels.com/photos/271639/pexels-photo-271639.jpeg?cs=srgb&dl=pexels-pixabay-271639.jpg&fm=jpg');
        background-repeat: no-repeat;
        background-size: cover;
    }
          .form-container div {
        text-align: center;
        display: flex;
        flex-direction: column;
        align-items: center;
        justify-content: center;
        height: 100%;
    }
         h1 {
                     text-align: center;
                    height: 100%;
                    color:black;
                    font-weight:bold;
                      text-transform: uppercase; 
                      background-color:beige;
                      border: 5px solid white;

         }
        .table-border {
            border: 3px solid white;
            background-color:beige;
            color:black;
        }


     </style>

        <div class="form-container" >
            <h1>
                Manage Rooms
            </h1>
            <div>
                <asp:TextBox ID="TextBox1" autocomplete ="off" runat="server" Height="42px" Width="137px" placeholder="Name"></asp:TextBox>
                &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
                <asp:DropDownList ID="DropDownList1" runat="server" Height="39px" style="margin-left: 1px" Width="156px">
                    <asp:ListItem Value="Single" Text="Single" Selected="True"></asp:ListItem>
                    <asp:ListItem Value="Standard" Text="Standard" ></asp:ListItem>
                    <asp:ListItem Value="VIP" Text="VIP"></asp:ListItem>
                </asp:DropDownList>
                &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
                <asp:DropDownList ID="DropDownList2" runat="server" Height="40px" style="margin-bottom: 3px" Width="136px">
                    <asp:ListItem Value="Status" Text="Status" Selected="True"></asp:ListItem>
                    <asp:ListItem Value="Available" Text="Available"></asp:ListItem>
                    <asp:ListItem Value="Booked" Text="Booked" ></asp:ListItem>
                </asp:DropDownList>
                <br />
                <br />
                <br />
            </div>
            <br />
            <div>
                &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
                <asp:Button ID="Button1" runat="server" Text="Save"  Height="51px" Width="93px" OnClick="BtnRegister_Save" />
                &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
                &nbsp;&nbsp;&nbsp;
                <asp:Button ID="btnDelete" runat="server" Text="Delete" OnClick="BtnDelete_Click" Height="52px" Width="98px" />
                &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
                <asp:Button ID="Button2" runat="server" Text="Back" OnClick="BtnBack_Click" Height="52px" Width="98px" />

                <br />
                <br />
                <br />
                <br />
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
                <asp:Label ID="lblMessage" runat="server" CssClass="error-message"  ></asp:Label>
                <asp:Label ID="Label1" runat="server" CssClass="error-message"  ></asp:Label>


            &nbsp;<br />
                <br />
                <br />

            </div>
            <div>
                 <asp:GridView ID="gvData" runat="server" AutoGenerateColumns="false" CssClass="table-border">
                <Columns>
                    <asp:BoundField DataField="TextBox1" HeaderText="TextBox1" />
                    <asp:BoundField DataField="DropDownList1" HeaderText="DropDownList1" />
                    <asp:BoundField DataField="DropDownList2" HeaderText="DropDownList2" />
                </Columns>
            </asp:GridView>
                                     <asp:GridView ID="GridView1" runat="server"></asp:GridView>

            </div>
        </div>
           
        
    </form>
</body>
</html>
