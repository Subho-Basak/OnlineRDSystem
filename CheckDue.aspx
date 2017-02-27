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
             <asp:Button ID="Button1" runat="server" Text="JOINT" CssClass="tab" OnClick="Button1_Click" /><asp:Button ID="Button2" runat="server" Text="SINGLE" CssClass="tab" OnClick="Button2_Click" />
             <asp:TextBox ID="TextBox2" runat="server" placeholder="Search history" CssClass="srch"></asp:TextBox>
         </section>
         <h5 runat="server" id="theMsg"><i class="material-icons">announcement</i><br />
            <asp:Label ID="Label1" runat="server" Text="Label">Sorry we couldn't find any account</asp:Label></h5>
             <asp:PlaceHolder ID="PlaceHolder1" runat="server"></asp:PlaceHolder>
       </div>
     <div class="submit-panel">
         
                <asp:Button ID="submitBtn" runat="server" Text="PAY NOW" BackColor="#005CB9" BorderStyle="None" ForeColor="White" Height="39px" Width="201px" OnClick="submitBtn_Click"  /><asp:Button ID="cancelBtn" runat="server" Text="CANCEL" Height="39px" Width="201px" ForeColor="#CCFFFF" BorderStyle="None" />
         <label>Selected</label> <asp:TextBox ID="TextBox1" runat="server" BackColor="#256ae6" CssClass="td1" Height="40px" Font-Size="Medium" Width="20px" ForeColor="White" ReadOnly="True"></asp:TextBox><label>Payment ID :</label>
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
            $(".submit-panel input:nth-of-type(1)").click(function () {

                $(".submit-panel").animate({ 'height': '0%', 'padding': '0% 3%' }, "fast");
            });

            $(".srch").on("keyup", function () {
                var value = $(this).val();
                var value1 = value.toUpperCase();
                var noData;

                $("table tbody tr").each(function (index) {
                    $("#noRec").css({ 'display': 'none' });
                    if (index !== -1) {
                        noData = true;
                        //row = $(this);

                        var id = $(this).find("td:nth-child(4)").text().toUpperCase();
                        if (id.indexOf(value1) !== 0) {
                            $('table tr th').show();
                            $(this).hide();
                        }
                        else {
                            $('table tr th').show();
                            $(this).show();

                        }
                    }

                });

            });


        });
    </script>
</asp:Content>

