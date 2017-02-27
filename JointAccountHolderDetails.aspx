<%@ Page Title="" Language="C#" MasterPageFile="~/PostmasterDashboard.master" AutoEventWireup="true" CodeFile="JointAccountHolderDetails.aspx.cs" Inherits="JointAccountHolderDetails" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" Runat="Server">
       <link href="Styles/Dashboard.css" rel="stylesheet" />
     <link href="Styles/jointAccountDetails.css" rel="stylesheet" />
     <link href="https://fonts.googleapis.com/css?family=Open+Sans:300,400,600,700" rel="stylesheet" />
    <link href="https://fonts.googleapis.com/icon?family=Material+Icons"
      rel="stylesheet" />
  
    <script src="Script/jquery-2.1.4.js"></script>">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">
    <div class="joint-account-details">
        <h5 runat="server" id="theMsg"><i class="material-icons">announcement</i><br />
            <asp:Label ID="Label3" runat="server" Text="Label">Enter a valid account number to get the payment details.</asp:Label></h5>
            
        
        <asp:panel runat="server" id="accContainer">
            
            <section>
            <button type="button"><i class="material-icons">more_vert</i></button>
            <ul class="overflow-menu">
                <li><a href="#" runat="server" id="pay">Make Payment</a></li>
                <li><a href="#">Check Payment</a></li>
                <li><a href="#">Check Fine</a></li>
                <li><a href="#">Check Due</a></li>
                <li><a href="#">Payment History</a></li>
                <li><a href="#">Update Account</a></li>
                <li><a href="#">Delete Account</a></li>

            </ul>
 
            <div>
            <asp:Image ID="Image1" runat="server" ImageUrl="" Width="80px" Height="80px" /><asp:Label ID="Label4" runat="server" Text="Account Holder Name" Font-Size="Medium" Height="40px"></asp:Label><br />
            <label>Primary account holder</label>
            </div>
                

            <div>
            <asp:Image ID="Image2" runat="server" ImageUrl="" Width="80px" Height="80px" /><asp:Label ID="Label7" runat="server" Text="Account Holder Name" Font-Size="Medium" Height="40px"></asp:Label><br />
            <label>Secondary account holder</label>
             </div>


                <br /><asp:Label ID="Label1" runat="server" Text="Account Number" Font-Bold="True" ForeColor="#666666" Height="30px"></asp:Label><br />
            Account Type :<asp:Label ID="Label2" runat="server" Text="Joint" Font-Bold="True" ForeColor="#666666"  Height="30px"></asp:Label><br />
       
        Openning Date :<asp:Label ID="Label5" ForeColor="#666666" runat="server" Text="Date" Font-Bold="True"  Height="30px"></asp:Label> &nbsp;&nbsp;&nbsp;&nbsp;Closing Date :<asp:Label ID="Label6" runat="server" Text="Date" Font-Bold="True" ForeColor="#666666"></asp:Label>
        
        <button type="button" ><i class="material-icons">mode_edit</i></button>
        </section>


        <table border="0">
             
             <tr>
                 <td colspan="3"> <p>Contact Details - <i>Primary account holder</i></p></td>
             </tr>
             <tr>
                  <td colspan="3"><label>Address</label></td>
                 
             </tr>
             <tr>
                 <td colspan="3">
                     <asp:TextBox ID="TextBox5" runat="server" CssClass=""></asp:TextBox></td>
                 
                 </tr>
             <tr>
                  <td><label>Email ID</label></td>
                 <td><label>Contact Number</label></td>
                 
             </tr>
             
              <tr>
                 <td>
                     <asp:TextBox ID="TextBox7" runat="server" CssClass=""></asp:TextBox></td>
                 <td>
                     <asp:TextBox ID="TextBox8" runat="server" CssClass=""></asp:TextBox></td>
                 
              </tr>
             <tr>
                  <td><label>City</label></td>
                 <td><label>State</label></td>
                 <td><label>Country</label></td>
                 
             </tr>

              <tr>
                 <td>
                     <asp:TextBox ID="TextBox9" runat="server" CssClass=""></asp:TextBox></td>
                 <td>
                     <asp:TextBox ID="TextBox10" runat="server" CssClass=""></asp:TextBox></td>
                 <td>
                     <asp:TextBox ID="TextBox11" runat="server" CssClass=""></asp:TextBox></td>
             </tr>

        
             <tr>
                 <td colspan="2"> <p>Contact Details - <i>Secondary account holder</i></p></td>
                 <td><div class="squaredThree" >
					<input type="radio" value="None" id="same" class="gnd"
						name="check" /> &nbsp;&nbsp;&nbsp;Same as above<label for="same"></label>
				</div></td>
             </tr>
             <tr>
                  <td colspan="3"><label>Address</label></td>
                 
             </tr>
             <tr>
                 <td colspan="3">
                     <asp:TextBox ID="TextBox20" runat="server"></asp:TextBox></td>
                 
                 </tr>
             <tr>
                  <td><label>Email ID</label></td>
                 <td><label>Contact Number</label></td>
                 
             </tr>
             
              <tr>
                 <td>
                     <asp:TextBox ID="TextBox21" runat="server"></asp:TextBox></td>
                 <td>
                     <asp:TextBox ID="TextBox22" runat="server"></asp:TextBox></td>
                 
              </tr>
             <tr>
                  <td><label>City</label></td>
                 <td><label>State</label></td>
                 <td><label>Country</label></td>
                 
             </tr>

              <tr>
                 <td>
                     <asp:TextBox ID="TextBox23" runat="server"></asp:TextBox></td>
                 <td>
                     <asp:TextBox ID="TextBox24" runat="server"></asp:TextBox></td>
                 <td>
                     <asp:TextBox ID="TextBox25" runat="server"></asp:TextBox></td>
             </tr>
         </table>
           <div class="submit-panel">

                <asp:Button ID="submitBtn" runat="server" Text="SAVE UPDATE" BackColor="#005CB9" BorderStyle="None" ForeColor="White" Height="39px" Width="201px" OnClick="submitBtn_Click"  /><asp:Button ID="cancelBtn" runat="server" Text="CANCEL" Height="39px" Width="201px" ForeColor="#CCFFFF" BorderStyle="None" />
           </div>
            </asp:panel>
    </div>




    <script>

        $(document).ready(function () {

            $(".joint-account-details table input").attr('readonly', 'readonly');
            $(".joint-account-details table input").css({ "border": "none" });

            $('.joint-account-details section button:nth-of-type(1)').click(function () {
                $('.overflow-menu').toggleClass("active");
            });


            $('.joint-account-details section button:nth-of-type(2)').click(function () {
                $('.submit-panel').animate({ 'height': '6%', 'padding': '1% 3%' }, "fast");
                $(".joint-account-details table input").removeAttr('readonly');
                $(".joint-account-details table input").css({ "border": "1px solid #ddd" });
            });
            $('#same').change(function () {
                if ($("#same").is(":checked")) {

                    //copy contact details

                    $('.nuadd').val($('.uadd').val());
                    $('.nemail').val($('.uemail').val());
                    $('.ncont').val($('.ucont').val());
                    $('.nct').val($('.uct').val());
                    $('.nst').val($('.ust').val());
                    $('.ncnt').val($('.ucnt').val());


                } else {

                    //undo copying

                    $('.nuadd').val("");
                    $('.nemail').val("");
                    $('.ncont').val("");
                    $('.nct').val("");
                    $('.nst').val("");
                    $('.ncnt').val("");

                }
            })
        
        });
    </script>





</asp:Content>

