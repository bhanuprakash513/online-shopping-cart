<%@ Page Language="C#" AutoEventWireup="true" CodeFile="Admin_Answer_Feedback.aspx.cs" Inherits="Pages_Admin_Answer_Feedback"  MasterPageFile="~/ShoppingCart.master"%>

<asp:Content ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
<form id="Form1" runat="server" action="Admin_Answer_Feedback.aspx" >
<asp:Panel ID="Panel1" runat="server" Height="200" Width="500"><center><h1 >Answer Feedback</h1></center>
   <center><asp:Table ID="Table1" runat="server">
   <asp:TableRow> 
   <asp:TableCell HorizontalAlign="Left" Width="100" Font-Size="11">
       <asp:Label ID="lbFeedback" runat="server" Text="Feedback" ></asp:Label>
   </asp:TableCell>
   <asp:TableCell Width="100">
       <asp:TextBox ID="txtFeedback" runat="server" Width="180" TextMode="multiLine" Rows="5"></asp:TextBox>
   </asp:TableCell>
   </asp:TableRow>
   <asp:TableRow><asp:TableCell><br /></asp:TableCell></asp:TableRow>
   <asp:TableRow>
   <asp:TableCell HorizontalAlign="left" Font-Size="11">
       <asp:Label ID="lbAnswer" runat="server" Text="Answer"></asp:Label>
   </asp:TableCell>
   <asp:TableCell>
       <asp:TextBox ID="txtAnswer" runat="server" TextMode="MultiLine" Width="180" Rows="5"></asp:TextBox>
   </asp:TableCell>
   </asp:TableRow>
   <asp:TableRow>
   <asp:TableCell>
       <asp:Button ID="btnSendFeedback" runat="server" Text="Send" Width="60" />
   </asp:TableCell>
   <asp:TableCell>
       <asp:Button ID="btnReset" runat="server" Text="Reset" Width="60" />
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