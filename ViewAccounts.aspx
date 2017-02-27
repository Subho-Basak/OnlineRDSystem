<%@ Page Title="" Language="C#" MasterPageFile="~/PostmasterDashboard.master" AutoEventWireup="true" CodeFile="ViewAccounts.aspx.cs" Inherits="ViewAccounts" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" Runat="Server">
        <link href="Styles/Dashboard.css" rel="stylesheet" />
     <link href="Styles/ViewAccount.css" rel="stylesheet" />
     <link href="https://fonts.googleapis.com/css?family=Open+Sans:300,400,600,700" rel="stylesheet" />
    <link href="https://fonts.googleapis.com/icon?family=Material+Icons"
      rel="stylesheet" />
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">
    <div class="view-account">
        <h2>Account Details <asp:Button ID="Label2" runat="server" Text="JOINT" CssClass="Tab" OnClick="Label2_Click"></asp:Button><asp:Button ID="Label3" runat="server" Text="SINGLE" CssClass="Tab" OnClick="Label3_Click"></asp:Button></h2>

        <h5 runat="server" id="theMsg"><i class="material-icons">announcement</i><br />
            <asp:Label ID="Label1" runat="server" Text="Label">Sorry we couldn't find any account</asp:Label></h5>
        

        <asp:PlaceHolder ID="PlaceHolder1" runat="server"></asp:PlaceHolder>

    </div>


    <script>

        $(document).ready(function () {

            $('#accType').click(function () {
                $('.payment-form ul').css({ 'display': 'block' });
            });
            $('.payment-form ul li').click(function () {
              
                var n = $(this).find("i").text();
                $('#accType i:nth-of-type(1)').text(n);
                $('.payment-form ul').css({ 'display': 'none' });
            });
        });
    </script>
</asp:Content>

