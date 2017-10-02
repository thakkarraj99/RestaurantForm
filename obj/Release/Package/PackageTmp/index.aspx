<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="index.aspx.cs" Inherits="RestaurantForm.index" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">

<head runat="server">

    <link rel="stylesheet" href="https://maxcdn.bootstrapcdn.com/font-awesome/4.7.0/css/font-awesome.min.css" />
    <link rel="stylesheet" href="https://cdnjs.cloudflare.com/ajax/libs/bulma/0.5.2/css/bulma.min.css" />
    <title></title>
</head>
<body style="background-color: grey">
    <nav class="navbar" style="background-color: darkorange" role="navigation" aria-label="main navigation">
        <div class="navbar-brand">
            <a class="navbar-item" href="#">
                <img src="https://static2.seekingalpha.com/images/marketing_images/fair_use_logos_products/sacl_mcd_mcdonalds_logo.png" alt="Bulma: a modern CSS framework based on Flexbox" width="50" height="50">McDonalds
            </a>

            <button class="button navbar-burger">
                <span></span>
                <span></span>
                <span></span>
            </button>
        </div>
    </nav>
    <br />
    <div class="columns has-text-white" style="height:100vh">
        <div class="column">&nbsp;</div>
        <div class="column">
        <form id="form1" runat="server">
            <div>
            </div>

            <asp:Label ID="Label1" runat="server" Text="First Name:"></asp:Label><asp:TextBox ID="TextBox1" runat="server"></asp:TextBox>
            <p>
                <asp:Label ID="Label2" runat="server" Text="Last Name;"></asp:Label><asp:TextBox ID="TextBox2" runat="server"></asp:TextBox>
            </p>
            <div class="control">
                <asp:Button ID="Button3" runat="server" OnClick="rememberMeEvent" CssClass="button" Text="Remember Me" />
                <asp:Label ID="Label10" runat="server"></asp:Label>
            </div>
            <asp:Label ID="Label3" runat="server" Text="City:"></asp:Label><asp:TextBox ID="TextBox3" runat="server"></asp:TextBox>
            <p>
                <asp:Label ID="Label4" runat="server" Text="Postal Code:"></asp:Label>
                <asp:TextBox ID="TextBox4" runat="server"></asp:TextBox>
            </p>
            <asp:Label ID="Label5" runat="server" Text="Phone Number:"></asp:Label>
            <asp:TextBox ID="TextBox5" runat="server"></asp:TextBox>
            <p>

                <asp:Label ID="Label6" runat="server" Text="Province:"></asp:Label><asp:DropDownList ID="DropDownList1"
                    runat="server" TabIndex="3">
                    <asp:ListItem>Alberta</asp:ListItem>
                    <asp:ListItem>British Columbia</asp:ListItem>
                    <asp:ListItem>Manitoba</asp:ListItem>
                    <asp:ListItem>New Brunswick</asp:ListItem>
                    <asp:ListItem>Newfoundland</asp:ListItem>
                    <asp:ListItem>Nova Scotia</asp:ListItem>
                    <asp:ListItem>Ontario</asp:ListItem>
                    <asp:ListItem>Quebec</asp:ListItem>
                </asp:DropDownList>
            </p>
           
            <asp:Label ID="Label7" runat="server" Text="Food and Drinks:"></asp:Label>
            <br />
            <p>
             <asp:CheckBox ID="CheckBox1" runat="server" Text="Samosa" />
            </p>
            <p>
                <asp:CheckBox ID="CheckBox2" runat="server" Text="Pav Bhaji" />
            </p>
            <p>
                <asp:CheckBox ID="CheckBox3" runat="server" Text="Biryani" />
            </p>
            <p>
                <asp:CheckBox ID="CheckBox4" runat="server" Text="Paneer Butter Masal" />
            </p>
            <p>
                <asp:CheckBox ID="CheckBox5" runat="server" Text="Naan" />
            </p>
            <p>
                <asp:CheckBox ID="CheckBox6" runat="server" Text="Daal Tadka" />
            </p>
            <p>
                <asp:CheckBox ID="CheckBox7" runat="server" Text="Lassi" />
            </p>
            <br />
            <p>
                <asp:Label ID="Label8" runat="server" Text="Pickup or Deliery:"></asp:Label><asp:RadioButtonList ID="RadioButtonList1" runat="server">
                    <asp:ListItem>Pick-up</asp:ListItem>
                    <asp:ListItem>Delivery</asp:ListItem>
                </asp:RadioButtonList>
               
            <asp:Label ID="Label9" runat="server" Text="Comments:"></asp:Label><asp:TextBox ID="TextBox6" runat="server" Columns="50" Height="100px" Width="200px"></asp:TextBox>
            <p>
                <div class="control">
  <asp:Button ID="Button2" runat="server" CssClass="button" Text="Order Now" OnClick="orderEvent" />
</div>
         </p>
        </form>
    </div>
        <div class="column">&nbsp;</div>
        </div>
</body>
</html>
