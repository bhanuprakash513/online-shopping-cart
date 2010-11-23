<%@ Page Language="C#" AutoEventWireup="true" CodeFile="Login.aspx.cs" Inherits="Pages_Login"  MasterPageFile ="~/ShoppingCart.master"%>

<asp:Content ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
<form id="Form1"  action="Login.aspx" runat="server">
<asp:Panel ID="Panel1" runat="server" Height="200" Width="500"><center><h1 >Login</h1></center>
<center>
<asp:Table runat="server" >
 <asp:TableRow> 
   <asp:TableCell HorizontalAlign="Left" Width="100" Font-Size="11">
       <asp:Label ID="lbUsername" runat="server" Text="Username" ></asp:Label>
   </asp:TableCell>
   <asp:TableCell Width="100">
       <asp:TextBox ID="txtUsername" runat="server" Width="150"></asp:TextBox>
   </asp:TableCell>
   </asp:TableRow>
   <asp:TableRow>
   <asp:TableCell HorizontalAlign="left" Font-Size="11">
       <asp:Label ID="lbPassword" runat="server" Text="Password"></asp:Label>
   </asp:TableCell>
   <asp:TableCell>
       <asp:TextBox ID="txtPassword" runat="server" TextMode="password" Width="150"></asp:TextBox>
   </asp:TableCell>
   </asp:TableRow>
<asp:TableRow>
   <asp:TableCell HorizontalAlign="center">
       <asp:Button ID="btnOk" runat="server" Text="Ok" Width="60" />
   </asp:TableCell>
   <asp:TableCell HorizontalAlign="center">
       <asp:Button ID="btnCancel" runat="server" Text="Cancel" Width="60" />
   </asp:TableCell>
   </asp:TableRow>
</asp:Table>
</center>
</asp:Panel>
</form>
</asp:Content>