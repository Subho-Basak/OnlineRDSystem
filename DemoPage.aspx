<%@ Page Title="" Language="C#" MasterPageFile="~/PostmasterDashboard.master" AutoEventWireup="true" CodeFile="DemoPage.aspx.cs" Inherits="DemoPage" %>
<%@ import Namespace="System.Web.Services" %>
<%@ import Namespace="System.Data.SqlClient" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" Runat="Server">

     <link href="Styles/Dashboard.css" rel="stylesheet" />
     <link href="Styles/NewAccount.css" rel="stylesheet" />
     <link href="https://fonts.googleapis.com/css?family=Open+Sans:300,400,600,700" rel="stylesheet" />
     <link href="https://fonts.googleapis.com/icon?family=Material+Icons"
      rel="stylesheet" />
 

    <script src="Script/jquery-2.1.4.js"></script>">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">

    <div class="account-form">
        <h2>Add Account <span>Single</span><button type="button"><i class="material-icons">more_vert</i></button></h2>
        <ul>
           <li><a href="DemoPage.aspx">Single account</a></li>
           <li><a href="NewJointAccount.aspx">Joint account</a></li>
       </ul>
         <table border="0">
             <tr>
                 <td colspan="3"> <p>Personal Details</p></td>
             </tr>

             <tr>
                 <td><label>Account number</label></td>

             </tr>
             <tr>
                 <td>
                     <asp:TextBox ID="TextBox1" runat="server" CssClass="accNum" MaxLength="10"></asp:TextBox></td>
                 <td colspan="2"><i>i</i><span></span></td>
             </tr>
             <tr>
                 <td><label>First name</label></td>
                 <td><label>Middle name</label></td>
                 <td><label>Last name</label></td>
             </tr>
             <tr>
                 <td>
                     <asp:TextBox ID="TextBox2" runat="server"></asp:TextBox></td>
                 <td>
                     <asp:TextBox ID="TextBox3" runat="server"></asp:TextBox></td>
                 <td>
                     <asp:TextBox ID="TextBox4" runat="server"></asp:TextBox></td>
             </tr>
             <tr>
                 <td ><label>Gender</label> </td>
                 <td><label>Date of Birth</label></td>
             </tr>
             <tr>
                 <td>
                     <div class="squaredThree">
					<input type="radio" value="Male" id="male" class="gnd"
						name="UGender" /> &nbsp;&nbsp;&nbsp;Male<label for="male"></label>
				</div>
                     <div class="squaredThree">
					<input type="radio" value="Female" id="female" class="gnd"
						name="UGender" /> &nbsp;&nbsp;&nbsp;Female<label for="female"></label>
				</div>

                     </td>
                 <td>
                     <asp:TextBox ID="TextBox6" runat="server" CssClass="calendar"></asp:TextBox>
                     

                 </td>
             </tr>
             <tr>
                 <td colspan="3"> <p>Contact Details</p></td>
             </tr>
             <tr>
                  <td colspan="3"><label>Address</label></td>
                 
             </tr>
             <tr>
                 <td colspan="3">
                     <asp:TextBox ID="TextBox5" runat="server" CssClass="uadd"></asp:TextBox></td>
                 
                 </tr>
             <tr>
                  <td><label>Email ID</label></td>
                 <td><label>Contact Number</label></td>
                 
             </tr>
             
              <tr>
                 <td>
                     <asp:TextBox ID="TextBox7" runat="server" CssClass="uemail"></asp:TextBox></td>
                 <td>
                     <asp:TextBox ID="TextBox8" runat="server" MaxLength="10" CssClass="ucont"></asp:TextBox></td>
                 
              </tr>
             <tr>
                  <td><label>City</label></td>
                 <td><label>State</label></td>
                 <td><label>Country</label></td>
                 
             </tr>

              <tr>
                 <td>
                     <asp:TextBox ID="TextBox9" runat="server" CssClass="uct"></asp:TextBox></td>
                 <td>
                     <asp:TextBox ID="TextBox10" runat="server" CssClass="ust"></asp:TextBox></td>
                 <td>
                     <asp:TextBox ID="TextBox11" runat="server" CssClass="ucnt"></asp:TextBox></td>
             </tr>

             <tr>
                 <td colspan="3"> <p>Account Details</p></td>
             </tr>
              <tr>
                  <td><label>Date of Open</label></td>
                 <td><label>Date of Close</label></td>
 
             </tr>
             <tr>
                 <td>
                     <asp:TextBox ID="TextBox12" runat="server" ReadOnly="True"></asp:TextBox></td>
                 <td>
                     <asp:TextBox ID="TextBox13" runat="server" ReadOnly="True"></asp:TextBox></td>
                
             </tr>
             <tr>
                  <td><label>Opening Amount</label></td>
                 <td><label>Signature type</label></td>
 
             </tr>
             <tr>
                 <td>
                     <asp:TextBox ID="TextBox14" runat="server"></asp:TextBox></td>
                 <td>
                     <asp:TextBox ID="TextBox15" runat="server"></asp:TextBox></td>
                
             </tr>
             <tr>
                  <td><label>Signature Proof</label></td>
                 <td><label>Photo Proof</label></td>
 
             </tr>
             <tr>
                 <td>
                     <asp:FileUpload ID="FileUpload1" runat="server" /></td>
                 <td>
                     <asp:FileUpload ID="FileUpload2" runat="server" /></td>

             </tr>

        
             <tr>
                  <td><label>Paid through</label></td>
             </tr>
             <tr>
                 <td>
                    <div class="squaredThree">
					<input type="radio" value="Male" id="cash" class="gnd"
						name="pthr" /> &nbsp;&nbsp;&nbsp;Cash<label for="cash"></label>
				</div>
                   <div class="squaredThree">
					<input type="radio" value="Female" id="mis" class="gnd"
						name="pthr" /> &nbsp;&nbsp;&nbsp;MIS<label for="mis"></label>
				</div>

                 </td>
             </tr>
              <tr>
                 <td colspan="3"> <p>Nominee Details</p></td>
             </tr>

              <tr>
                 <td><label>First name</label></td>
                 <td><label>Middle name</label></td>
                 <td><label>Last name</label></td>
             </tr>
             <tr>
                 <td>
                     <asp:TextBox ID="TextBox16" runat="server"></asp:TextBox></td>
                 <td>
                     <asp:TextBox ID="TextBox17" runat="server"></asp:TextBox></td>
                 <td>
                     <asp:TextBox ID="TextBox18" runat="server"></asp:TextBox></td>
             </tr>
             <tr>
                 <td ><label>Gender</label> </td>
                 <td><label>Date of Birth</label></td>
             </tr>
             <tr>
                 <td>
                     <div class="squaredThree">
					<input type="radio" value="Male" id="nmale" class="gnd"
						name="NGender" /> &nbsp;&nbsp;&nbsp;Male<label for="nmale"></label>
				</div>
            
                     <div class="squaredThree">
					<input type="radio" value="Female" id="nfemale" class="gnd"
						name="NGender" /> &nbsp;&nbsp;&nbsp;Female<label for="nfemale"></label>
				</div>
                     </td>

                 <td>
                     <asp:TextBox ID="TextBox19" runat="server"></asp:TextBox></td>
             </tr>
             <tr>
                 <td colspan="2"> <p>Nominee Contact Details</p></td>
                 <td><div class="squaredThree" >

					<input type="checkbox" value="None" id="same" class="gnd"
						name="check" /> &nbsp;&nbsp;&nbsp;Same as above<label for="same"></label>
				</div></td>
             </tr>
             <tr>
                  <td colspan="3"><label>Address</label></td>
                 
             </tr>
             <tr>
                 <td colspan="3">
                     <asp:TextBox ID="TextBox20" runat="server" CssClass="nuadd"></asp:TextBox></td>
                 
                 </tr>
             <tr>
                  <td><label>Email ID</label></td>
                 <td><label>Contact Number</label></td>
                 
             </tr>
             
              <tr>
                 <td>
                     <asp:TextBox ID="TextBox21" runat="server" CssClass="nemail"></asp:TextBox></td>
                 <td>
                     <asp:TextBox ID="TextBox22" runat="server" MaxLength="10" CssClass="ncont"></asp:TextBox></td>
                 
              </tr>
             <tr>
                  <td><label>City</label></td>
                 <td><label>State</label></td>
                 <td><label>Country</label></td>
                 
             </tr>

              <tr>
                 <td>
                     <asp:TextBox ID="TextBox23" runat="server" CssClass="nct"></asp:TextBox></td>
                 <td>
                     <asp:TextBox ID="TextBox24" runat="server" CssClass="nst"></asp:TextBox></td>
                 <td>
                     <asp:TextBox ID="TextBox25" runat="server" CssClass="ncnt"></asp:TextBox></td>
             </tr>
         </table>
           <div runat="server" id="submitpanel" class="submit-panel">

               <asp:panel runat="server" id="errPanel" CssClass="error">
                   <i class="material-icons">clear</i><label id="errMsg" runat="server"></label>
               </asp:panel>
              
               <asp:Button ID="submitBtn" runat="server" Text="CREATE ACCOUNT" BackColor="#005CB9" BorderStyle="None" ForeColor="White" Height="39px" Width="201px" OnClick="submitBtn_Click" />
           </div>

        
    </div>

    <script type="text/javascript">
        $(document).ready(function () {

            $('.account-form h2 button').click(function () {
                $('.account-form ul').toggleClass("active");
            });

            $('.accNum').blur(function () {
                if ($('.accNum').val() == "") {
                    $('.account-form table tr td i').css({ 'visibility': 'hidden', 'background': '#e23131' });
                 
                    $('.account-form table tr td span').text("");

                } else {

                    var data = JSON.stringify({ accountno: $('.accNum').val() });
                    //var accountno=$('.accNum').val();
                    $.ajax({
                        type: "post",
                        url: 'DemoPage.aspx/validateAccountNo',
                        contentType: 'application/json;charset=UTF-8',
                        datatype: "json",
                        data: data,

                        success: function (response) {

                            if (response.d === "false") {
                                $('.account-form table tr:nth-child(3) td input').val("");
                                $('.account-form table tr td i').css({ 'visibility': 'visible', 'background': '#e23131' });
                                $('.account-form table tr td span').css({ 'color': '#e23131' });
                                $('.account-form table tr td span').text("The account number already exists.Try a different one.")
                            } else {
                                $('.account-form table tr td i').css({ 'visibility': 'visible', 'background': '#28c422' });
                                $('.account-form table tr td span').css({ 'color': '#28c422' });
                                $('.account-form table tr td span').text("The account number is available");
                            }
                        }

                    });
                }
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

