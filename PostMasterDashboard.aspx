﻿<%@ Page Title="" Language="C#" MasterPageFile="~/PostmasterDashboard.master" AutoEventWireup="true" CodeFile="PostMasterDashboard.aspx.cs" Inherits="PostMasterDashboard" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" Runat="Server">
     <link href="Styles/Dashboard.css" rel="stylesheet" />
     <link href="Styles/PostmasterHome.css" rel="stylesheet" />
     <link href="https://fonts.googleapis.com/css?family=Open+Sans:300,400,600,700" rel="stylesheet" />
     <link href="https://fonts.googleapis.com/icon?family=Material+Icons"
      rel="stylesheet"/>
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">
    <div class="serach-result-container">

 <h5 runat="server" id="theMsg"><i class="material-icons">announcement</i><br />
            <asp:Label ID="Label1" runat="server" Text="Label">Sorry we couldn't find any account</asp:Label></h5>
        <asp:PlaceHolder ID="PlaceHolder1" runat="server"></asp:PlaceHolder>
    </div>
</asp:Content>

