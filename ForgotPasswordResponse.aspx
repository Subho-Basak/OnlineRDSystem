<%@ Page Language="C#" AutoEventWireup="true" CodeFile="ForgotPasswordResponse.aspx.cs" Inherits="ForgotPasswordResponse" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
       <link href="https://fonts.googleapis.com/icon?family=Material+Icons"
      rel="stylesheet"/>
    <link href="https://fonts.googleapis.com/css?family=Open+Sans:300,400,600,700" rel="stylesheet" />
   <style>
       html,body {
    min-width:100% !important;
    min-height:100% !important;
    height:100%;
    margin:0;
    padding:0;
}
*{
    font-family:'open sans';
}
input{
    outline:none;
}
div{
    padding:2%;
}
h1{
    width:100%;
    text-align:center;
    font-weight:normal;
}
h1 i{
    padding:1%;
    border-radius:50%;
    background:#ddd;
}
input{
    margin:0 38%;
    padding:0.8%;
    width:22%;
    margin-bottom:1%;
    border:none;
    border-radius:2px;
    background:#ccc;
}

.show-error{
    margin:0 38%;
    font-size:80%;
    padding-bottom:2%;
}
   </style>
</head>
<body>
    <form id="form1" runat="server">
    <div>
    <h1>Password recovery gateway</h1>
        <p align="center">For security reasons we will send your password to your email address.</p>
        <h1><i class="material-icons">vpn_key</i></h1>
        <p align="center">Please provide your email id here</p>
        <asp:TextBox ID="TextBox1" runat="server" placeholder="Enter email"></asp:TextBox>
        <asp:Label ID="Label1" runat="server" Text="Label" CssClass="show-error"></asp:Label>
        <asp:Button ID="Button1" runat="server" Text="SEND" Height="45px" Width="100px" OnClick="sendMail" />
    </div>
    </form>
</body>
</html>
