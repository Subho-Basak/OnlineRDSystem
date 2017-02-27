<%@ Page Title="" Language="C#" MasterPageFile="~/PostmasterDashboard.master" AutoEventWireup="true" CodeFile="CheckFine.aspx.cs" Inherits="CheckFine" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" Runat="Server">
    <link href="Styles/Dashboard.css" rel="stylesheet" />
     <link href="Styles/Fine.css" rel="stylesheet" />
     <link href="https://fonts.googleapis.com/css?family=Open+Sans:300,400,600,700" rel="stylesheet" />
    <link href="https://fonts.googleapis.com/icon?family=Material+Icons"
      rel="stylesheet"/>
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">
    <div class="fine-form">
        <h2>Check Fine <button type="button" id="accType"><i class="material-icons">supervisor_account</i><i class="material-icons">arrow_drop_down</i></button>
            <asp:TextBox ID="TextBox1" runat="server" placeholder="Account number" OnTextChanged="TextBox1_TextChanged"></asp:TextBox>
            <asp:TextBox ID="TextBox2" runat="server" placeholder="joint Account number" OnTextChanged="TextBox2_TextChanged"></asp:TextBox>
        </h2>

        <ul>
            <li><i class="material-icons">person</i>Single</li>
             <li><i class="material-icons">supervisor_account</i>Joint</li>
        </ul>
       <h5 runat="server" id="theMsg"><i class="material-icons">announcement</i><br />
            <asp:Label ID="Label1" runat="server" Text="Label">No fine in this account</asp:Label></h5>
        

        <asp:Panel ID="tableContainer" runat="server">
        <table>

            <tr>
                
                <td colspan="2">
                    <asp:Label ID="Label3" runat="server" Text="Label"></asp:Label> - <asp:Label ID="Label2" runat="server" Text="Label" ForeColor="Gray"></asp:Label>

                 <br /> <br />  Denomination :<asp:Label ID="Label4" runat="server" Text="Label"></asp:Label>
                 <br />Fine calculated for : <asp:Label ID="Label5" runat="server" Text="Label"></asp:Label> Month
      
                </td>
                
            </tr>

            <tr>
                <td>Fine amount : <asp:Label ID="Label6" runat="server" Text="Label" Font-Size="Medium"></asp:Label></td>
            </tr>
        </table>
            </asp:Panel>
        <script>

        $(document).ready(function () {

            $('#accType').click(function () {
                $('.fine-form ul').css({ 'display': 'block' });
            });
            $('.fine-form ul li').click(function () {
                if ($(this).text() === "supervisor_accountJoint") {
                    $('.fine-form h2 input:nth-of-type(1)').css({ 'z-index': '-1' });
                    $('.fine-form h2 input:nth-of-type(2)').css({ 'z-index': '1' });
                } else {
                    $('.fine-form h2 input:nth-of-type(1)').css({ 'z-index': '1' });
                    $('.fine-form h2 input:nth-of-type(2)').css({ 'z-index': '-1' });
                }
                var n = $(this).find("i").text();
                $('#accType i:nth-of-type(1)').text(n);
                $('.fine-form ul').css({ 'display': 'none' });
            });
        });
    </script>
</asp:Content>

