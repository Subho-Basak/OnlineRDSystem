<%@ Page Title="" Language="C#" MasterPageFile="~/PostmasterDashboard.master" AutoEventWireup="true" CodeFile="ClearDue.aspx.cs" Inherits="ClearDue" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" Runat="Server">
    <link href="Styles/Dashboard.css" rel="stylesheet" />
     <link href="Styles/CheckDue.css" rel="stylesheet" />
     <link href="https://fonts.googleapis.com/css?family=Open+Sans:300,400,600,700" rel="stylesheet" />
    <link href="https://fonts.googleapis.com/icon?family=Material+Icons"
      rel="stylesheet"/>
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">
    <div class="due-form">
        <h2>Check Due <button type="button" id="accType"><i class="material-icons">supervisor_account</i><i class="material-icons">arrow_drop_down</i></button>
            <asp:TextBox ID="TextBox1" runat="server" placeholder="Account number"></asp:TextBox></h2>

        <ul>
            <li><i class="material-icons">person</i>Single</li>
             <li><i class="material-icons">supervisor_account</i>Joint</li>
        </ul>
        <h5>
            <asp:Label ID="Label1" runat="server" Text="Label">Sorry we couldn't find any account</asp:Label></h5>
         <asp:PlaceHolder ID="PlaceHolder1" runat="server"></asp:PlaceHolder>
       </div>
</asp:Content>

