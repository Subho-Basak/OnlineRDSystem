<%@ Page Title="" Language="C#" MasterPageFile="~/PostmasterDashboard.master" AutoEventWireup="true" CodeFile="CheckPayment.aspx.cs" Inherits="CheckPayment" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" Runat="Server">
        <link href="Styles/Dashboard.css" rel="stylesheet" />
     <link href="Styles/Fine.css" rel="stylesheet" />
     <link href="https://fonts.googleapis.com/css?family=Open+Sans:300,400,600,700" rel="stylesheet" />
    <link href="https://fonts.googleapis.com/icon?family=Material+Icons"
      rel="stylesheet">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">
    <div class="fine-form">
        <h2>Check Payment <button type="button" id="accType"><i class="material-icons">supervisor_account</i><i class="material-icons">arrow_drop_down</i></button>
            <asp:TextBox ID="TextBox1" runat="server" placeholder="Account number" OnTextChanged="TextBox1_TextChanged"></asp:TextBox></h2>

        <ul>
            <li><i class="material-icons">person</i>Single</li>
             <li><i class="material-icons">supervisor_account</i>Joint</li>
        </ul>
        <h5>
            <asp:Label ID="Label1" runat="server" Text="Label">Sorry we couldn't find any account</asp:Label></h5>
          
        <table>
            <tr>
                <td>Account number</td>
                <td>
                    <asp:Label ID="Label2" runat="server" Text="Label"></asp:Label></td>
            </tr>

            
            <tr>
                <td>Account name</td>
                <td>
                    <asp:Label ID="Label3" runat="server" Text="Label"></asp:Label></td>
            </tr>

            
            <tr>
                <td>Denomination</td>
                <td>
                    <asp:Label ID="Label4" runat="server" Text="Label"></asp:Label></td>
            </tr>

            
            <tr>
                <td>Month paid upto</td>
                <td>
                    <asp:Label ID="Label5" runat="server" Text="Label"></asp:Label> Month</td>
            </tr>

            
            <tr>
                <td>Next RD installment date</td>
                <td>
                    <asp:Label ID="Label6" runat="server" Text="Label" Font-Size="X-Large"></asp:Label></td>
            </tr>
        </table>



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

