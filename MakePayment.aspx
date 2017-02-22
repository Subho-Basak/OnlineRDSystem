<%@ Page Title="" Language="C#" MasterPageFile="~/PostmasterDashboard.master" AutoEventWireup="true" CodeFile="MakePayment.aspx.cs" Inherits="MakePayment" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" Runat="Server">
        <link href="Styles/Dashboard.css" rel="stylesheet" />
     <link href="Styles/Payment.css" rel="stylesheet" />
     <link href="https://fonts.googleapis.com/css?family=Open+Sans:300,400,600,700" rel="stylesheet" />
    <link href="https://fonts.googleapis.com/icon?family=Material+Icons"
      rel="stylesheet" />
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">
    <div class="payment-form">
        <h2>Make Payment <button type="button" id="accType" value=""><i runat="server" id="acctypeicon" class="material-icons"></i><i class="material-icons">arrow_drop_down</i></button>
            <asp:TextBox ID="TextBox1" runat="server" placeholder="Account number" OnTextChanged="TextBox1_TextChanged"></asp:TextBox></h2>

        <ul>
            <li><i class="material-icons">person</i>Single</li>
             <li><i class="material-icons">supervisor_account</i>Joint</li>
        </ul>
        <h5 runat="server" id="theMsg"><i class="material-icons">announcement</i><br />
            <asp:Label ID="Label1" runat="server" Text="Label">Sorry we couldn't find any account</asp:Label></h5>
     
        <asp:Panel ID="tableContainer" runat="server">
      <table>
          <tr>
              <td>
                  <asp:Label ID="Label2" runat="server" Text="Account holder name"></asp:Label></td>
              <td>
                  <asp:Label ID="Label3" runat="server" Text="account number"></asp:Label></td>
          </tr>

          <tr>
              <td style="padding-top:5%;"><label>Amount</label></td>
              <td style="padding-top:5%;"><label>Payment Date</label></td>
          </tr>

          <tr>
              <td>
                  <asp:TextBox ID="TextBox2" runat="server"></asp:TextBox></td>
              <td>
                  <asp:TextBox ID="TextBox3" runat="server"></asp:TextBox></td>
          </tr>

          <tr>
              <td><label>Fine</label></td>
              <td><label>Paid by</label></td>
          </tr>
          
          <tr>
              <td style="padding-bottom:5%;">
                  
                  <asp:TextBox ID="TextBox4" runat="server" ></asp:TextBox></td>
              <td style="padding-bottom:5%;">
                  <input type="text" id="drop" class="drop" name="Paidby" value="Account Holder" readonly/><i class="dropI"></i>
               
            <ul class="paidby">
            <li>Post Master</li>
            <li>Account Holder </li>
        </ul>
              </td>

          </tr>
          <tr>
              <td></td>
              <td style="text-align:right;padding-top:2%;"><label style="font-size:100%;font-weight:700;color:#555;padding:2%;">Total Amount</label></td>

          </tr>
          <tr>
              <td></td>
              <td>
                  <asp:TextBox ID="TextBox5" runat="server" ReadOnly="True"></asp:TextBox></td>
          </tr>
      </table>
          </asp:Panel>
           <div runat="server" id="paynow" class="submit-panel">
               <asp:Button ID="submitBtn" runat="server" Text="PAY NOW" BackColor="#005CB9" BorderStyle="None" ForeColor="White" Height="39px" Width="201px" OnClick="submitBtn_Click" />
           </div>

   
    </div>


    <script>

        $(document).ready(function () {
           // $("tableContainer").css({ 'display': 'none' });

            $('#accType').click(function () {
                $('.payment-form > ul').css({ 'display': 'block' });
            });
            $('.payment-form > ul li').click(function () {
              
                var n = $(this).find("i").text();
                $('#accType i:nth-of-type(1)').text(n);
               
                $('.payment-form >ul').css({ 'display': 'none' });
            });

            $('.drop').click(function () {
                $('.paidby').css({ 'display': 'block' });
            });
            $('.paidby li').click(function () {
                var n = $(this).text();
                $('.drop').val(n);
                $('.paidby').css({ 'display': 'none' });
            });
      
        });
    </script>
</asp:Content>

