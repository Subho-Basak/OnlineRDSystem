<%@ Page Language="C#" AutoEventWireup="true" CodeFile="SuccessResponse.aspx.cs" Inherits="SuccessResponse" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
       <link href="https://fonts.googleapis.com/css?family=Open+Sans:300,400,600,700" rel="stylesheet" />
    <link href="https://fonts.googleapis.com/icon?family=Material+Icons"
      rel="stylesheet">
    <style>
        html,body {
    min-width:100% !important;
    min-height:100% !important;
    height:100%;
    margin:0;
    padding:0;
}
*{
    font-family:'open sans';
}
        #Panel1{
            margin:10% 20%;
            padding:2%;
            height:250px;
            box-shadow:0 1px 2px 1px #ccc;
        }
        #Panel1 h1{
            padding:0;
            margin:0;
            font-weight:normal;
        }
        #Panel1 p{
            color:gray;
        }
        #Panel1 a{
            float:right;
            padding:1.5% 3%;
            border-radius:2px;
            text-decoration:none;
            margin:2% 6%;
        }
    </style>
</head>
<body>

    <form id="form1" runat="server">
        <asp:Panel ID="Panel1" runat="server">
            <h1>Account created successfully</h1>
            <p>Before continuing with your account we recommend you to update your previous payment details.You can find all your previous payment
                details from our <b>Payment History</b> tab.Also we recommend you to update your contact details in case you change it.<br />
                <b>Do you want to update your previous payment details ?</b>
            </p>

           
            <a href="#" style="background-color: #0066FF; color: #FFFFFF;">UPDATE PAYMENT</a>
            <a href="#" style="color: #0066FF">SKIP NOW</a>
        </asp:Panel>
    </form>

</body>
</html>
