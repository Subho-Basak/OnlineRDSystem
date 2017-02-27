<%@ Page Title="" Language="C#" MasterPageFile="~/PostmasterDashboard.master" AutoEventWireup="true" CodeFile="DeleteAccounts.aspx.cs" Inherits="DeleteAccounts" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" Runat="Server">

    <script src="Script/jquery-2.1.4.js"></script>
    <link href="Styles/Delete.css" rel="stylesheet" />

</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">

    <div class="delete-panel">

    <div id='progress'><div id='progress-complete'></div></div>

        <fieldset>
            <h2>Confirm password</h2>
            <p align="center">Please enter your account password to continue</p>
            <asp:TextBox ID="TextBox1" runat="server" CssClass="pwd" TextMode="Password"></asp:TextBox>
            <asp:Label ID="Label1" runat="server" Text="Label" CssClass="label"></asp:Label><button type="button">NEXT</button>
        </fieldset>

       

        <fieldset>
            <h2>Enter account number</h2>
            <p align="center">Please enter the account number of the account holder</p>
            <asp:TextBox ID="TextBox3" runat="server" CssClass="accNo" MaxLength="10"></asp:TextBox>
            <asp:Label ID="Label3" runat="server" Text="Label" CssClass="label"></asp:Label><button type="button">NEXT</button>
        </fieldset>

         <fieldset>
            <h2>Are you sure you want to delete this account ?</h2>
             <p align="center">After clicking on the YES,I DO button the account holder will be removed from the record.</p>
           <button type="button">YES,I DO</button><button>NO </button>
        </fieldset>
 </div>

    <script>

        $(document).ready(function () {
            $('fieldset:not(:nth-of-type(1)').hide();
            var completion = 33.3;
            
            //checking password

            $('fieldset:nth-of-type(1) button').click(function () {
               
                var currentForm = $(this);
                    var data = JSON.stringify({pass:$('.pwd').val()});
                    var url = "DeleteAccounts.aspx/checkPassword";
                    
                    $.ajax({
                        type: "post",
                        url: url,
                        contentType: 'application/json;charset=UTF-8',
                        datatype: "json",
                        data: data,

                        success: function (response) {
                           

                            if (response.d === "true") {
                                currentForm.parent().hide();
                                currentForm.parent().next().show();
                                completion += 33.3;
                                $('#progress-complete').animate({ 'width': completion + '%' }, "fast");
                            } else
                                alert("cant proceed");
                        }
                    });

            });

            //checking account no

            $('fieldset:nth-of-type(2) button').click(function () {
                var currentForm = $(this);
                var data = JSON.stringify({ accountno: $('.accNo').val() });
                var url = "DeleteAccounts.aspx/validateAccountNo";
               
                $.ajax({
                    type: "post",
                    url: url,
                    contentType: 'application/json;charset=UTF-8',
                    datatype: "json",
                    data: data,

                    success: function (response) {
                        
                        if (response.d === "true") {
                            currentForm.parent().hide();
                            currentForm.parent().next().show();
                            completion += 33.3;
                            $('#progress-complete').animate({ 'width': completion + '%' }, "fast");
                        }
                        else
                            alert("cant proceed");
                    }
                });
            });

            //finally deleting accout no

           $('fieldset:nth-of-type(3) button:nth-of-type(1)').click(function () {
                var currentForm = $(this);
                var data = JSON.stringify({ accountno: $('.accNo').val() });
                var url = "DeleteAccounts.aspx/deleteAccount";
                alert("deleted");
                $.ajax({
                    type: "post",
                    url: url,
                    contentType: 'application/json;charset=UTF-8',
                    datatype: "json",
                    data: data,

                    success: function (response) {
                        alert("deleted");
                        if (response.d === "true") {
                            alert("deleted");
                            completion += 33.3;
                            $('#progress-complete').animate({ 'width': completion + '%' }, "fast");
                        }
                        else
                            alert("cant proceed");
                    }
                });
            });
        });
    </script>
</asp:Content>

