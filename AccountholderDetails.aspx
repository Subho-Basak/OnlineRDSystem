<%@ Page Title="" Language="C#" MasterPageFile="~/PostmasterDashboard.master" AutoEventWireup="true" CodeFile="AccountholderDetails.aspx.cs" Inherits="AccountholderDetails" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" Runat="Server">
   
     <link href="Styles/Dashboard.css" rel="stylesheet" />
     <link href="Styles/AccountDetails.css" rel="stylesheet" />
     <link href="https://fonts.googleapis.com/css?family=Open+Sans:300,400,600,700" rel="stylesheet" />
    <link href="https://fonts.googleapis.com/icon?family=Material+Icons"
      rel="stylesheet" />
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">

    <div class="account-form">
        <section>
            <button type="button"><i class="material-icons">more_vert</i></button>
            <ul class="overflow-menu">
                <li><a href="#">Make Payment</a></li>
                <li><a href="#">Check Payment</a></li>
                <li><a href="#">Check Fine</a></li>
                <li><a href="#">Check Due</a></li>
                <li><a href="#">Payment History</a></li>
                <li><a href="#">Update Account</a></li>
                <li><a href="#">Delete Account</a></li>

            </ul>
            <asp:Image ID="Image1" runat="server" ImageUrl="" Width="150px" Height="150px" /><asp:Label ID="Label4" runat="server" Text="Account Holder Name" Font-Size="X-Large" Height="40px"></asp:Label><br />
            <asp:Label ID="Label1" runat="server" Text="Account Number" Font-Bold="True" ForeColor="#666666" Height="30px"></asp:Label><br />
            Account Type :<asp:Label ID="Label2" runat="server" Text="Single" Font-Bold="True" ForeColor="#666666"  Height="30px"></asp:Label><br />
            Gender : <asp:Label ID="Label3" runat="server" Text=" Male" Font-Bold="True" ForeColor="#666666"  Height="30px"></asp:Label><br />
        Openning Date :<asp:Label ID="Label5" ForeColor="#666666" runat="server" Text="Date" Font-Bold="True"  Height="30px"></asp:Label> &nbsp;&nbsp;&nbsp;&nbsp;Closing Date :<asp:Label ID="Label6" runat="server" Text="Date" Font-Bold="True" ForeColor="#666666"></asp:Label>
        
        <button type="button" ><i class="material-icons">mode_edit</i></button>
        </section>

         <table border="0">
             
             <tr>
                 <td colspan="3"> <p>Contact Details</p></td>
             </tr>
             <tr>
                  <td colspan="3"><label>Address</label></td>
                 
             </tr>
             <tr>
                 <td colspan="3">
                     <asp:TextBox ID="TextBox5" runat="server"></asp:TextBox></td>
                 
                 </tr>
             <tr>
                  <td><label>Email ID</label></td>
                 <td><label>Contact Number</label></td>
                 
             </tr>
             
              <tr>
                 <td>
                     <asp:TextBox ID="TextBox7" runat="server"></asp:TextBox></td>
                 <td>
                     <asp:TextBox ID="TextBox8" runat="server"></asp:TextBox></td>
                 
              </tr>
             <tr>
                  <td><label>City</label></td>
                 <td><label>State</label></td>
                 <td><label>Country</label></td>
                 
             </tr>

              <tr>
                 <td>
                     <asp:TextBox ID="TextBox9" runat="server"></asp:TextBox></td>
                 <td>
                     <asp:TextBox ID="TextBox10" runat="server"></asp:TextBox></td>
                 <td>
                     <asp:TextBox ID="TextBox11" runat="server"></asp:TextBox></td>
             </tr>

              <tr>
                 <td colspan="3"> <p>Nominee Details</p></td>
             </tr>

              <tr>
                 <td><label>Full name</label></td>
            
             </tr>
             <tr>
                 <td>
                     <asp:Label ID="Label7" runat="server" Text="Label" CssClass="nomineeLbl"></asp:Label><asp:Label ID="Label8" runat="server" Text="Label" CssClass="nomineeLbl"></asp:Label><asp:Label ID="Label9" runat="server" Text="Label" CssClass="nomineeLbl"></asp:Label>
                </td>
             </tr>
             <tr>
                 <td ><label>Gender</label> </td>
                 <td><label>Date of Birth</label></td>
             </tr>
             <tr>
                 <td>
                     <asp:Label ID="Label10" runat="server" Text="Label" CssClass="nomineeLbl"></asp:Label>
                     </td>

                 <td>
                     <asp:Label ID="Label11" runat="server" Text="Label" Font-Size="15px" Font-Bold="True" ForeColor="#333333" CssClass="nomineeLbl"></asp:Label></td>
             </tr>
             <tr>
                 <td colspan="2"> <p>Nominee Contact Details</p></td>
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
                <asp:Button ID="submitBtn" runat="server" Text="SAVE UPDATE" BackColor="#005CB9" BorderStyle="None" ForeColor="White" Height="39px" Width="201px" OnClick="submitBtn_Click" /><asp:Button ID="cancelBtn" runat="server" Text="CANCEL" Height="39px" Width="201px" ForeColor="#CCFFFF" BorderStyle="None" />
           </div>

        
    </div>

     <script>

        $(document).ready(function () {

            $(".account-form table input").attr('readonly', 'readonly');
            $(".account-form table input").css({ "border": "none" });

            $('.account-form section button:nth-of-type(1)').click(function () {
                $('.overflow-menu').toggleClass("active");
            });


            $('.account-form section button:nth-of-type(2)').click(function () {
                $('.submit-panel').animate({ 'height': '6%', 'padding': '1% 3%' }, "fast");
                $(".account-form table input").removeAttr('readonly');
                $(".account-form table input").css({ "border": "1px solid #ddd" });
            });
         
        
        });
    </script>
</asp:Content>

