<%@ Page Language="C#" AutoEventWireup="true" CodeFile="ChangePassword.aspx.cs" Inherits="Pages_ChangePassword"  MasterPageFile="~/ShoppingCart.master"%>

<asp:Content ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
<form id="Form1" runat="server" action="Register.aspx"  >
<asp:Panel ID="Panel1" runat="server" Height="200" Width="500"><center><h1 >Change Password</h1></center>
   <center><asp:Table ID="Table1" runat="server">
   <asp:TableRow> 
   <asp:TableCell HorizontalAlign="Left" Width="150" Font-Size="11">
       <asp:Label ID="lbOldPassword" runat="server" Text="Current Password" ></asp:Label>
   </asp:TableCell>
   <asp:TableCell Width="100">
       <asp:TextBox ID="txtOldPassword" runat="server" TextMode="password" Width="180"></asp:TextBox>
   </asp:TableCell>
   </asp:TableRow>
   <asp:TableRow>
   <asp:TableCell HorizontalAlign="left" Font-Size="11">
       <asp:Label ID="lbNewPassword" runat="server" Text="New Password"></asp:Label>
   </asp:TableCell>
   <asp:TableCell>
       <asp:TextBox ID="txtNewPassword" runat="server" TextMode="password" Width="180"></asp:TextBox>
   </asp:TableCell>
   </asp:TableRow>
   <asp:TableRow>
   <asp:TableCell HorizontalAlign="left" Font-Size="11">
       <asp:Label ID="lbConfirmPassword" runat="server" Text="Confirm Password"></asp:Label>
   </asp:TableCell>
   <asp:TableCell>
       <asp:TextBox ID="txtConfirmPassword" runat="server" TextMode="password" Width="180"></asp:TextBox>
   </asp:TableCell>
   </asp:TableRow>
   <asp:TableRow>
   <asp:TableCell>
       <asp:Button ID="btnSubmit" runat="server" Text="Submit" Width="60" />
   </asp:TableCell>
   <asp:TableCell>
       <asp:Button ID="btnCancel" runat="server" Text="Cancel" Width="60" />
   </asp:TableCell>
   </asp:TableRow>
   </asp:Table> 
   </center>
    </asp:Panel>
</form>
</asp:Content>