<%@ Page Title="" Language="C#" MasterPageFile="~/Admin.Master" AutoEventWireup="true" CodeBehind="MessageDetail.aspx.cs" Inherits="CvEntityProject.MessageDetail" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <h4>MESAJ DETAYLARI</h4>
    <asp:TextBox ID="txtAsSoyad" runat="server" CssClass="form-control" Enabled="false"></asp:TextBox>
    <br />
    <asp:TextBox ID="txtMail" runat="server" CssClass="form-control" Enabled="false"></asp:TextBox>
    <br />
    <asp:TextBox ID="txtKonu" runat="server" CssClass="form-control" Enabled="false"></asp:TextBox>
    <br />
    <asp:TextBox ID="txtMessage" TextMode="MultiLine" Height="100" runat="server" CssClass="form-control"></asp:TextBox>
    <br />

</asp:Content>
