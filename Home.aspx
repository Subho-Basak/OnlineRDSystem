<%@ Page Language="C#" AutoEventWireup="true" CodeFile="Home.aspx.cs" Inherits="Home" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
    
<head runat="server">
    <title></title>
    <link href="Styles/HomeUI.css" rel="stylesheet" />

    <link href="https://fonts.googleapis.com/css?family=Open+Sans:300,400,600,700" rel="stylesheet" />
    <script type="text/javascript" src="Script/jquery-2.1.4.js"></script>
    <script src="https://storage.googleapis.com/code.getmdl.io/1.2.1/material.min.js"></script>
   

</head>
<body>
    <header>
        <h1>Online RD Management System</h1>
        <section>
            <h3><iframe src="http://free.timeanddate.com/clock/i5l2q60k/n505/fs18/fcfff/tct/pct" frameborder="0" width="130" height="24" allowTransparency="true"></iframe>

</h3>
            <h4><iframe src="http://free.timeanddate.com/clock/i5l2q60k/n505/fcfff/tct/pct/tt1" frameborder="0" width="213" height="18" allowTransparency="true"></iframe>
</h4>

        </section>
    </header>
    <div class="img-container">
        <asp:Image src="Assets/Cover2.jpg" ID="Image1" runat="server" BackColor="#000555" />
        <h1>Online Recurring Deposit</h1>
            
        <form id="login_form" runat="server">
        <div>
            <h4>Postmaster Login</h4><br />
            <asp:Label ID="Label1" runat="server" Text="Label" BackColor="#FF6666" ForeColor="White"></asp:Label><br />
            
            <label>Username</label><br />
            <asp:TextBox ID="TextBox1" runat="server"></asp:TextBox><br />
            
            <label>Password</label><br />
            <asp:TextBox ID="TextBox2" runat="server" TextMode="Password"></asp:TextBox><br />

            <a href="ForgotPasswordResponse.aspx" target="_blank">Forget Password ? </a><asp:Button ID="LoginBtn" runat="server" Text="LOGIN" Height="37px" Width="89px" BackColor="#0066FF" OnClick="LoginBtn_Click1" OnClientClick="LoginBtn_Click" CssClass="login" />
        </div>
    </form>
    </div>
   


</body>
</html>
