﻿<%@ Page Title="" Language="C#" MasterPageFile="~/PostmasterDashboard.master" AutoEventWireup="true" CodeFile="NewJointAccount.aspx.cs" Inherits="NewJointAccount" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" Runat="Server">
   
     <link href="Styles/Dashboard.css" rel="stylesheet" />
     <link href="Styles/NewAccount.css" rel="stylesheet" />
     <link href="https://fonts.googleapis.com/css?family=Open+Sans:300,400,600,700" rel="stylesheet" />
    <link href="https://fonts.googleapis.com/icon?family=Material+Icons"
      rel="stylesheet" />
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">

    <div class="account-form">
        <h2>Add Account <span>Joint</span><button type="button"><i class="material-icons">more_vert</i></button></h2>
       <ul>
           <li><a href="DemoPage.aspx">Single account</a></li>
           <li><a href="NewJointAccount.aspx">Joint account</a></li>
       </ul>
         <table border="0">
             <tr>
                 <td colspan="3"> <p>Personal Details - <span>Primary account holder</span></p></td>
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
						name="psex" /> &nbsp;&nbsp;&nbsp;Male<label for="male"></label>
				</div>
                     <div class="squaredThree">
					<input type="radio" value="Female" id="female" class="gnd"
						name="psex" /> &nbsp;&nbsp;&nbsp;Female<label for="female"></label>
				</div>

                     </td>
                 <td>
                     <asp:TextBox ID="TextBox6" runat="server"></asp:TextBox></td>
             </tr>
             <tr>
                 <td colspan="3"> <p>Contact Details - <span>Primary account holder</span></p></td>
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
                     <asp:TextBox ID="TextBox8" runat="server" MaxLength="10"></asp:TextBox></td>
                 
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

           <!-- secondary account holder details -->

                     <tr>
                 <td colspan="3"> <p>Personal Details - <span>Secondary account holder</span></p></td>
             </tr>

             
             <tr>
                 <td><label>First name</label></td>
                 <td><label>Middle name</label></td>
                 <td><label>Last name</label></td>
             </tr>
             <tr>
                 <td>
                     <asp:TextBox ID="TextBox28" runat="server"></asp:TextBox></td>
                 <td>
                     <asp:TextBox ID="TextBox29" runat="server"></asp:TextBox></td>
                 <td>
                     <asp:TextBox ID="TextBox30" runat="server"></asp:TextBox></td>
             </tr>
             <tr>
                 <td ><label>Gender</label> </td>
                 <td><label>Date of Birth</label></td>
             </tr>
             <tr>
                 <td>
                     <div class="squaredThree">
					<input type="radio" value="Male" id="smale" class="gnd"
						name="ssex" /> &nbsp;&nbsp;&nbsp;Male<label for="smale"></label>
				</div>
                     <div class="squaredThree">
					<input type="radio" value="Female" id="sfemale" class="gnd"
						name="ssex" /> &nbsp;&nbsp;&nbsp;Female<label for="sfemale"></label>
				</div>

                     </td>
                 <td>
                     <asp:TextBox ID="TextBox31" runat="server"></asp:TextBox></td>
             </tr>
             <tr>
                 <td colspan="3"> <p>Contact Details - <span>Secondary account holder</span></p></td>
             </tr>
             <tr>
                  <td colspan="3"><label>Address</label></td>
                 
             </tr>
             <tr>
                 <td colspan="3">
                     <asp:TextBox ID="TextBox32" runat="server"></asp:TextBox></td>
                 
                 </tr>
             <tr>
                  <td><label>Email ID</label></td>
                 <td><label>Contact Number</label></td>
                 
             </tr>
             
              <tr>
                 <td>
                     <asp:TextBox ID="TextBox33" runat="server"></asp:TextBox></td>
                 <td>
                     <asp:TextBox ID="TextBox34" runat="server" MaxLength="10"></asp:TextBox></td>
                 
              </tr>
             <tr>
                  <td><label>City</label></td>
                 <td><label>State</label></td>
                 <td><label>Country</label></td>
                 
             </tr>

              <tr>
                 <td>
                     <asp:TextBox ID="TextBox35" runat="server"></asp:TextBox></td>
                 <td>
                     <asp:TextBox ID="TextBox36" runat="server"></asp:TextBox></td>
                 <td>
                     <asp:TextBox ID="TextBox37" runat="server"></asp:TextBox></td>
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
                     <asp:TextBox ID="TextBox12" runat="server" ReadOnly="True"></asp:TextBox>
                 </td>
                 <td>
                     <asp:TextBox ID="TextBox13" runat="server" ReadOnly="True"></asp:TextBox>
                 </td>
                
             </tr>
             <tr>
                  <td><label>Opening Amount</label></td>
                 <td><label>Signature type(Primary)</label></td>
                 <td><label>Signature type(Secondary)</label></td>
 
             </tr>
             <tr>
                 <td>
                     <asp:TextBox ID="TextBox14" runat="server"></asp:TextBox></td>
                 <td>
                     <asp:TextBox ID="TextBox15" runat="server"></asp:TextBox></td>
                 <td><asp:TextBox ID="TextBox16" runat="server"></asp:TextBox></td>
                
             </tr>
             <tr>
                  <td><label>Signature Proof(Primary)</label></td>
                 <td><label>Photo Proof(Primary)</label></td>
 
             </tr>
             <tr>
                 <td>
                     <asp:FileUpload ID="FileUpload1" runat="server" /></td>
                 <td>
                     <asp:FileUpload ID="FileUpload2" runat="server" /></td>

             </tr>

               <tr>
                  <td><label>Signature Proof(Secondary)</label></td>
                 <td><label>Photo Proof(Secondary)</label></td>
 
             </tr>
             <tr>
                 <td>
                     <asp:FileUpload ID="FileUpload3" runat="server" /></td>
                 <td>
                     <asp:FileUpload ID="FileUpload4" runat="server" /></td>

             </tr>
        
             <tr>
                  <td><label>Paid through</label></td>
             </tr>
             <tr>
                 <td>
                     <div class="squaredThree">
					<input type="radio" value="cash" id="cash" class="gnd"
						name="paid" /> &nbsp;&nbsp;&nbsp;Cash<label for="cash"></label>
				</div>
                     <div class="squaredThree">
					<input type="radio" value="mis" id="mis" class="gnd"
						name="paid" /> &nbsp;&nbsp;&nbsp;MIS<label for="mis"></label>
				</div></td>
             </tr>
              
         </table>
           <div runat="server" id="submitpanel" class="submit-panel">

                   
               <asp:panel runat="server" id="errPanel" CssClass="error">
                   <i class="material-icons">clear</i><label id="Label1" runat="server"></label>
               </asp:panel>

               <asp:label runat="server" id="errMsg" text=""></asp:label>
               <asp:Button ID="submitBtn" runat="server" Text="CREATE ACCOUNT" BackColor="#005CB9" BorderStyle="None" ForeColor="White" Height="39px" Width="201px" OnClick="submitBtn_Click" />
           </div>

        
    </div>

    <script>

        $(document).ready(function () {

 

            $('.account-form h2 button').click(function () {
                $('.account-form ul').toggleClass("active");
            });

            
            $('.accNum').blur(function () {
                var data = JSON.stringify({ accountno: $('.accNum').val() });
                //var accountno=$('.accNum').val();
                $.ajax({
                    type: "post",
                    url: 'NewJointAccount.aspx/validateAccountNo',
                    contentType: 'application/json;charset=UTF-8',
                    datatype: "json",
                    data: data,

                    success: function (response) {

                        if (response.d === "false") {
                            $('.account-form table tr:nth-child(3) td input').val("");
                            $('.account-form table tr td i').css({ 'visibility': 'visible', 'background': '#e23131' });
                            $('.account-form table tr td span:nth-child(2)').css({ 'color': '#e23131' });
                            $('.account-form table tr td span:nth-child(2)').text("The account number already exists.Try a different one.")
                        } else {
                            $('.account-form table tr td i').css({ 'visibility': 'visible', 'background': '#28c422' });
                            $('.account-form table tr td span:nth-child(2)').css({ 'color': '#28c422' });
                            $('.account-form table tr td span:nth-child(2)').text("The account number is available");
                        }
                    }

                });
            });
        });
    </script>
</asp:Content>

