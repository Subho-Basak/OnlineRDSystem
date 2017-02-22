<%@ Page Title="" Language="C#" MasterPageFile="~/PostmasterDashboard.master" AutoEventWireup="true" CodeFile="CheckDue.aspx.cs" Inherits="CheckDue" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" Runat="Server">
    <link href="Styles/Dashboard.css" rel="stylesheet" />
     <link href="Styles/CheckDue.css" rel="stylesheet" />
     <link href="https://fonts.googleapis.com/css?family=Open+Sans:300,400,600,700" rel="stylesheet" />
    <link href="https://fonts.googleapis.com/icon?family=Material+Icons"
      rel="stylesheet"/>
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">
     <div class="due-form">
         <section>
        <h2>Check Due </h2>
             <asp:Button ID="Button1" runat="server" Text="Joint" CssClass="tab" OnClick="Button1_Click" /><asp:Button ID="Button2" runat="server" Text="Single" CssClass="tab" OnClick="Button2_Click" />
        
         </section>
         <h5 runat="server" id="theMsg"><i class="material-icons">announcement</i><br />
            <asp:Label ID="Label1" runat="server" Text="Label">Sorry we couldn't find any account</asp:Label></h5>
             <asp:PlaceHolder ID="PlaceHolder1" runat="server"></asp:PlaceHolder>
       </div>
     <div class="submit-panel">
         <asp:TextBox ID="TextBox1" runat="server" BackColor="White" CssClass="td1"></asp:TextBox>
                <asp:Button ID="submitBtn" runat="server" Text="PAY NOW" BackColor="#005CB9" BorderStyle="None" ForeColor="White" Height="39px" Width="201px" OnClick="submitBtn_Click"  /><asp:Button ID="cancelBtn" runat="server" Text="CANCEL" Height="39px" Width="201px" ForeColor="#CCFFFF" BorderStyle="None" />
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

            $(".due-form table tr").click(function () {
                $(".due-form table tr").css({ 'background': '#fff' });
                $(this).css({ 'background': '#aaa' });
                $('.submit-panel').animate({ 'height': '6%', 'padding': '1% 3%' }, "fast");
                
                var id = $(this).find("h3").text();
                $(".td1").val(id);
                
            });
        });
    </script>
</asp:Content>

