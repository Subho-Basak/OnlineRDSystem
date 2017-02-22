<%@ Page Title="" Language="C#" MasterPageFile="~/PostmasterDashboard.master" AutoEventWireup="true" CodeFile="PaymentHistory.aspx.cs" Inherits="PaymentHistory" %>

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
            <h2>Payment History</h2>
            <asp:TextBox ID="TextBox1" runat="server" placeholder="Search history" CssClass="srch"></asp:TextBox>
        </section>
        <asp:PlaceHolder ID="PlaceHolder1" runat="server"></asp:PlaceHolder>
        <h5 id="noRec"><i class="material-icons">announcement</i><br /><label>no record</label></h5>
    </div>

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

                        var id = $(this).find("td:nth-child(3)").text().toUpperCase();
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

