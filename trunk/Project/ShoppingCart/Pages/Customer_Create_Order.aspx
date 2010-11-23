<%@ Page Language="C#" AutoEventWireup="true" CodeFile="Customer_Create_Order.aspx.cs" Inherits="Pages_Customer_Create_Order"  MasterPageFile="~/ShoppingCart.master"%>

<asp:Content ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
<form id="Form1" runat="server" action="Register.aspx"  >
<asp:Panel ID="Panel1" runat="server" Height="200" Width="500"><center><h1 >Order Information</h1></center>
   <center><asp:Table ID="Table1" runat="server">
   <asp:TableRow> 
   <asp:TableCell HorizontalAlign="Left" Width="120" Font-Size="11">
       <asp:Label ID="lbReceiverName" runat="server" Text="Receiver Name" ></asp:Label>
   </asp:TableCell>
   <asp:TableCell Width="80">
       <asp:TextBox ID="txtReceiverName" runat="server" Width="180"></asp:TextBox>
   </asp:TableCell>
   </asp:TableRow>
   <asp:TableRow>
   <asp:TableCell HorizontalAlign="left" Font-Size="11">
       <asp:Label ID="lbReceiverAddress" runat="server" Text="Receiver Address"></asp:Label>
   </asp:TableCell>
   <asp:TableCell>
       <asp:TextBox ID="txtReceiverAddress" runat="server" TextMode="MultiLine" Rows="3" Width="180"></asp:TextBox>
   </asp:TableCell>
   </asp:TableRow>
   <asp:TableRow>
   <asp:TableCell HorizontalAlign="left" Font-Size="11">
       <asp:Label ID="lbReceiverPhone" runat="server" Text="Receiver Phone"></asp:Label>
   </asp:TableCell>
   <asp:TableCell>
       <asp:TextBox ID="txtReveiverPhone" runat="server" Width="180"></asp:TextBox>
   </asp:TableCell>
   </asp:TableRow>
   <asp:TableRow>
   <asp:TableCell HorizontalAlign="left" Font-Size="11">
       <asp:Label ID="lbCountry" runat="server" Text="Country"></asp:Label>
   </asp:TableCell>
   <asp:TableCell HorizontalAlign="left">
       <asp:DropDownList ID="ddlCountry" runat="server" Width="150" >
       </asp:DropDownList>
   </asp:TableCell>
   </asp:TableRow>
   <asp:TableRow>
   <asp:TableCell HorizontalAlign="left" Font-Size="11">
       <asp:Label ID="lbCity" runat="server" Text="City"></asp:Label>
   </asp:TableCell>
   <asp:TableCell>
       <asp:TextBox ID="txtCity" runat="server" Width="180"></asp:TextBox>
   </asp:TableCell>
   </asp:TableRow>
   <asp:TableRow>
   <asp:TableCell HorizontalAlign="left" Font-Size="11">
       <asp:Label ID="lbState" runat="server" Text="State"></asp:Label>
   </asp:TableCell>
   <asp:TableCell>
       <asp:TextBox ID="txtState" runat="server" Width="180"></asp:TextBox>
   </asp:TableCell>
   </asp:TableRow>
   <asp:TableRow>
   <asp:TableCell HorizontalAlign="left" Font-Size="11">
       <asp:Label ID="lbZipCode" runat="server" Text="Zip Code"></asp:Label>
   </asp:TableCell>
   <asp:TableCell>
       <asp:TextBox ID="txtZipCode" runat="server" Width="180"></asp:TextBox>
   </asp:TableCell>
   </asp:TableRow>
   <asp:TableRow>
   <asp:TableCell HorizontalAlign="left" Font-Size="11">
       <asp:Label ID="lbTotalCost" runat="server" Text="Total Cost"></asp:Label>
   </asp:TableCell>
   <asp:TableCell>
       <asp:Label ID="lbTotalCostInfo" runat="server" Text=""></asp:Label>
   </asp:TableCell>
   </asp:TableRow>
   <asp:TableRow>
   <asp:TableCell HorizontalAlign="left" Font-Size="11">
       <asp:Label ID="lbExtraMoney" runat="server" Text="Extra Money"></asp:Label>
   </asp:TableCell>
   <asp:TableCell>
       <asp:TextBox ID="txtExtraMoney" runat="server" Width="180"></asp:TextBox>
   </asp:TableCell>
   </asp:TableRow>
   <asp:TableRow>
   <asp:TableCell HorizontalAlign="left" Font-Size="11">
       <asp:Label ID="lbNote" runat="server" Text="Note"></asp:Label>
   </asp:TableCell>
   <asp:TableCell>
       <asp:TextBox ID="txtNote" runat="server" TextMode="MultiLine" Rows="5" Width="180"></asp:TextBox>
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