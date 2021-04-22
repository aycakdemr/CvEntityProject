<%@ Page Title="" Language="C#" MasterPageFile="~/Admin.Master" AutoEventWireup="true" CodeBehind="Abilities.aspx.cs" Inherits="CvEntityProject.WebForm1" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">

    <table class="table table-bordered" style="margin-left:20px;margin-right:20px">
        <thead>
            <tr >
            <th>Id</th>
            <th>Yetenek</th>
            <th>Sil</th>
            <th>Güncelle</th>
        </tr>
        </thead>
        <tbody>
            <asp:Repeater ID="Repeater1" runat="server">
            <ItemTemplate>
                <tr>
                    <td><%#Eval("Id") %></td>
                    <td><%#Eval("Ability") %></td>
                    <td><a href="#" class="btn btn-danger">Sil</a></td>
                    <td><a href="#" class="btn btn-success">Güncelle</a></td>
                </tr>
            </ItemTemplate>
        </asp:Repeater>
        </tbody>
        

        
    </table>
    <a href="NewAbility.Aspx" class="btn btn-primary" style="margin-left:20px">Yeni Yetenek Ekle</a>
</asp:Content>
