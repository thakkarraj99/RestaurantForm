<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="index.aspx.cs" Inherits="RestaurantForm.index" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">

<head runat="server">

    <link rel="stylesheet" href="https://maxcdn.bootstrapcdn.com/bootstrap/4.0.0-beta.2/css/bootstrap.min.css" integrity="sha384-PsH8R72JQ3SOdhVi3uxftmaW6Vc51MKb0q5P2rRUpPvrszuE4W1povHYgTpBfshb" crossorigin="anonymous" />
    <link rel="stylesheet" href="https://maxcdn.bootstrapcdn.com/font-awesome/4.7.0/css/font-awesome.min.css" />
    <title></title>
    <style>
        html, body {
            height: 100%;
        }
    </style>
</head>
<body data-spy="scroll" data-target=".navbar" data-offset="50">

    <nav class="navbar navbar-toggleable-md navbar-light bg-faded">
        <button class="navbar-toggler navbar-toggler-right" type="button" data-toggle="collapse" data-target="#navbarNav" aria-controls="navbarNav" aria-expanded="false" aria-label="Toggle navigation">
            <span class="navbar-toggler-icon"></span>
        </button>
        <a class="navbar-brand" href="#">FoodFood.com</a>
        <div class="collapse navbar-collapse" id="navbarNav">
            <ul class="navbar-nav">
                <li class="nav-item active">
                    <a class="nav-link" href="#carouselExampleSlidesOnly">Home <span class="sr-only">(current)</span></a>
                </li>
                <li class="nav-item">
                    <a class="nav-link" href="#section2">Menu</a>
                </li>
                <li class="nav-item">
                    <a class="nav-link" href="#section3">Order Now</a>
                </li>
            </ul>
        </div>
    </nav>
    <div id="carouselExampleSlidesOnly" class="carousel slide" data-ride="carousel">
        <div class="carousel-inner" role="listbox">
            <div class="carousel-item active">
                <img class="d-block img-fluid" src="https://static.pexels.com/photos/390403/pexels-photo-390403.jpeg" alt="First slide" />
            </div>
            <div class="carousel-item">
                <img class="d-block img-fluid" src="https://static.pexels.com/photos/132694/pexels-photo-132694.jpeg" alt="Second slide" />
            </div>
            <div class="carousel-item">
                <img class="d-block img-fluid" src="https://static.pexels.com/photos/262918/pexels-photo-262918.jpeg" alt="Third slide" />
            </div>
        </div>
    </div>
    <div style="height: 50%; background-color: lightblue; vertical-align: central; text-align: center" id="section2">
        <h2>Menu</h2>
        <p>
            We have selected our dishes from India's famous kitchens and they are prepared by the way it is done in India. Every bite you take from our variaties will remind you the authantic taste.<br />
            <div class="container">
                <br />
                <br />

                <a href="https://storage.googleapis.com/restaurant_raj/webpage_images/FoodFoodMenu.pdf" target="_blank">
                    <button type="button" class="btn btn-outline-dark btn-lg btn-block">See the Menu</button></a>
            </div>
        </p>
    </div>
    <form id="form1" runat="server" method="post" enctype="multipart/form-data">
        <div class="container" id="section3">
            <header>
                <h2>Order Now</h2>
            </header>
            <p>
                Start building your order. Select our delicious dishes from the indian chefs. If you have any question, feel free to call us.<br />
                The normal delivery time is 30 mins, but it may be more than that in rush hours. 
            </p>
            <div class="row">
                <div class="col-md-6">
                    <div class="form-group">
                        <label for="exampleFormControlInput1">First Name</label>
                        <asp:TextBox ID="TextBox1" CssClass="form-control" runat="server"></asp:TextBox>
                    </div>
                </div>
                <div class="col-md-6">
                    <div class="form-group">
                        <label for="exampleFormControlInput1">Last Name</label>
                        <asp:TextBox ID="TextBox2" CssClass="form-control" runat="server"></asp:TextBox>
                    </div>
                </div>
                <asp:Label ID="Label10" runat="server" Text=""></asp:Label>
                <div class="col-md-12">
                    <asp:Button ID="Button3" runat="server" OnClick="rememberMeEvent" CssClass="btn btn-dark" Text="Remember Me" />
                </div>
                <div class="col-md-6">
                    <div class="form-group">
                        <label for="exampleFormControlInput1">City</label>
                        <asp:TextBox ID="TextBox3" CssClass="form-control" runat="server"></asp:TextBox>
                    </div>
                </div>
                <div class="col-md-6">
                    <div class="form-group">
                        <label for="exampleFormControlInput1">Pin Code</label>
                        <asp:TextBox ID="TextBox4" CssClass="form-control" runat="server"></asp:TextBox>
                    </div>
                </div>
                <div class="col-md-6">
                    <div class="form-group">
                        <label for="exampleFormControlInput1">Phone Number</label>
                        <asp:TextBox ID="TextBox5" CssClass="form-control" runat="server"></asp:TextBox>
                    </div>
                </div>
                <div class="col-md-6">
                    <div class="form-group">
                        <label for="exampleFormControlInput1">Province</label>
                        <asp:DropDownList ID="DropDownList1"
                            runat="server" TabIndex="3" CssClass="form-control">
                            <asp:ListItem>Alberta</asp:ListItem>
                            <asp:ListItem>British Columbia</asp:ListItem>
                            <asp:ListItem>Manitoba</asp:ListItem>
                            <asp:ListItem>New Brunswick</asp:ListItem>
                            <asp:ListItem>Newfoundland</asp:ListItem>
                            <asp:ListItem>Nova Scotia</asp:ListItem>
                            <asp:ListItem>Ontario</asp:ListItem>
                            <asp:ListItem>Quebec</asp:ListItem>
                        </asp:DropDownList>
                    </div>
                </div>
                <div class="col-md-6">
                    <div class="form-group">
                        <label for="exampleFormControlInput1">Food</label><br />
                        <div id="samosa">
                            <asp:CheckBox ID="CheckBox1" runat="server" Text="Samosa" />
                        </div>
                        <br />
                        <div id="pavbhaji">
                            <asp:CheckBox ID="CheckBox2" runat="server" Text="Pav Bhaji" />
                        </div>
                        <br />
                        <div id="biryani">
                            <asp:CheckBox ID="CheckBox3" runat="server" Text="Biryani" />
                        </div>
                        <br />
                        <div id="paneer">
                            <asp:CheckBox ID="CheckBox4" runat="server" Text="Paneer Butter Masala" />
                        </div>
                        <br />
                        <div id="naan">
                            <asp:CheckBox ID="CheckBox5" runat="server" Text="Naan" />
                        </div>
                        <br />
                        <div id="dal">
                            <asp:CheckBox ID="CheckBox6" runat="server" Text="Dal Tadka" />
                        </div>
                        <br />
                        <div id="lassi">
                            <asp:CheckBox ID="CheckBox7" runat="server" Text="Lassi" />
                        </div>
                    </div>
                </div>

                <div class="col-md-6">
                    <div id="carouselMenu" class="carousel slide" data-ride="carousel">
                        <div class="carousel-inner" role="listbox">
                            <div class="carousel-item active">
                                <img class="d-block img-fluid" src="https://storage.googleapis.com/restaurant_raj/webpage_images/Veg-Samosa.jpg" alt="First slide" />
                            </div>
                            <div class="carousel-item">
                                <img class="d-block img-fluid" src="https://storage.googleapis.com/restaurant_raj/webpage_images/pav-bhaji-mumbai-pav-bhaji-recipe-3-1024x768.jpg" alt="Second slide" />
                            </div>
                            <div class="carousel-item">
                                <img class="d-block img-fluid" src="https://storage.googleapis.com/restaurant_raj/webpage_images/veg-biryani-recipe-step-by-step-instructions.jpg" alt="Third slide" />
                            </div>
                            <div class="carousel-item">
                                <img class="d-block img-fluid" src="https://storage.googleapis.com/restaurant_raj/webpage_images/paneer-butter-masala-recipe-step-by-step-instructions.jpg" alt="Third slide" />
                            </div>
                            <div class="carousel-item">
                                <img class="d-block img-fluid" src="https://storage.googleapis.com/restaurant_raj/webpage_images/Homemade-Naan-close-1.jpg" alt="Third slide" />
                            </div>
                            <div class="carousel-item">
                                <img class="d-block img-fluid" src="https://storage.googleapis.com/restaurant_raj/webpage_images/dal_tadka.jpg" alt="Third slide" />
                            </div>
                            <div class="carousel-item">
                                <img class="d-block img-fluid" src="https://storage.googleapis.com/restaurant_raj/webpage_images/big_lassi-10551.jpg" alt="Third slide" />
                            </div>
                        </div>
                    </div>
                </div>
                <div class="col-md-12">
                    <div class="form-group">
                        <label for="exampleFormControlInput1">Order Type</label>
                        <br />
                        <asp:RadioButtonList ID="RadioButtonList1" runat="server">
                            <asp:ListItem>Pick-up</asp:ListItem>
                            <asp:ListItem>Delivery</asp:ListItem>
                        </asp:RadioButtonList>
                    </div>
                </div>
                <div class="col-md-6">
                    <div class="form-group">
                        <label for="exampleFormControlInput1">Special Instructions</label>
                        <asp:TextBox ID="TextBox6" CssClass="form-control" runat="server" Columns="50" Height="100px"></asp:TextBox>
                    </div>
                </div>
                <div class="col-md-12">
                    <asp:Button ID="Button2" runat="server" CssClass="btn btn-dark" Text="Order Now" OnClick="orderEvent" />
                </div>
            </div>
        </div>

        <div style="height: 50%; background-color: lightblue; vertical-align: central; text-align: center" id="section2">
            <h2>Gallery</h2>
            <div class="container">
                <br />
                <br />

                <asp:FileUpload ID="FileUpload1" runat="server" /><br />
                <asp:Button Text="Upload" runat="server" OnClick="UploadFile" />
                <br />
                <br />
                <div class="col-md-12 mx-auto d-block">
                    <asp:GridView ID="GridView1" runat="server" AutoGenerateColumns="false" OnRowDataBound="OnRowDataBound">
                        <Columns>

                            <asp:TemplateField HeaderText="Image">
                                <ItemTemplate>
                                    <asp:Image ID="Image1" runat="server" Height="80" Width="80" />
                                </ItemTemplate>
                            </asp:TemplateField>
                        </Columns>
                    </asp:GridView>
                </div>
            </div>
        </div>
    </form>

    <script src="https://code.jquery.com/jquery-3.2.1.slim.min.js" integrity="sha384-KJ3o2DKtIkvYIK3UENzmM7KCkRr/rE9/Qpg6aAZGJwFDMVNA/GpGFF93hXpG5KkN" crossorigin="anonymous"></script>
    <script src="https://cdnjs.cloudflare.com/ajax/libs/popper.js/1.12.3/umd/popper.min.js" integrity="sha384-vFJXuSJphROIrBnz7yo7oB41mKfc8JzQZiCq4NCceLEaO4IHwicKwpJf9c9IpFgh" crossorigin="anonymous"></script>
    <script src="https://maxcdn.bootstrapcdn.com/bootstrap/4.0.0-beta.2/js/bootstrap.min.js" integrity="sha384-alpBpkh1PFOepccYVYDB4do5UnbKysX5WZXm3XxPqe5iKTfUKjNkCk9SaVuEZflJ" crossorigin="anonymous"></script>
    <script>
        $("#samosa").click(function () {
            $("#carouselMenu").carousel(0);
        });
        $("#pavbhaji").click(function () {
            $("#carouselMenu").carousel(1);
        });
        $("#biryani").click(function () {
            $("#carouselMenu").carousel(2);
        });
        $("#paneer").click(function () {
            $("#carouselMenu").carousel(3);
        });
        $("#naan").click(function () {
            $("#carouselMenu").carousel(4);
        });
        $("#dal").click(function () {
            $("#carouselMenu").carousel(5);
        });
        $("#lassi").click(function () {
            $("#carouselMenu").carousel(6);
        });
    </script>
</body>
</html>
