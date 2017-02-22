<%@ Page Title="" Language="C#" MasterPageFile="~/PostmasterDashboard.master" AutoEventWireup="true" CodeFile="DueHistory.aspx.cs" Inherits="DueHistory" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" Runat="Server">
     <link href="Styles/Dashboard.css" rel="stylesheet" />
     <link href="Styles/PaymentHistory.css" rel="stylesheet" />
     <link href="https://fonts.googleapis.com/css?family=Open+Sans:300,400,600,700" rel="stylesheet" />
     <link href="https://fonts.googleapis.com/icon?family=Material+Icons"
      rel="stylesheet" />
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">
    <div class="history-container">
        <section>
            <h2>Due History</h2>
            <asp:Button ID="Button1" runat="server" Text="Joint" CssClass="tab" OnClick="Button1_Click" /><asp:Button ID="Button2" runat="server" Text="Single" CssClass="tab" OnClick="Button2_Click" />
            <asp:TextBox ID="TextBox1" runat="server" placeholder="Search history" CssClass="srch"></asp:TextBox>
        </section>
        <h5 runat="server" id="theMsg"><i class="material-icons">announcement</i><br />
            <asp:Label ID="Label1" runat="server" Text="Label">Sorry we couldn't find any account</asp:Label></h5>
        <asp:PlaceHolder ID="PlaceHolder1" runat="server"></asp:PlaceHolder>

    </div>

    //local search
    <script>
        $(document).ready(function () {


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
