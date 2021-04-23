<%@ Page Title="" Language="C#" MasterPageFile="~/Admin.Master" AutoEventWireup="true" CodeBehind="Contact.aspx.cs" Inherits="CvEntityProject.Contact" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">

<table class="table table-bordered" style="margin-left:20px;margin-right:20px">
        <thead>
            <tr >
            <th>Id</th>
            <th>Ad Soyad</th>
            <th>Mail    </th>
            <th>Konu</th>
            <th>Mesajı Gör</th>
        </tr>
        </thead>
        <tbody>
            <asp:Repeater ID="Repeater1" runat="server">
            <ItemTemplate>
                <tr>
                    <td><%#Eval("Id") %></td>
                    <td><%#Eval("Name") %></td>
                    <td><%#Eval("Email") %></td>
                    <td><%#Eval("Topic") %></td>
                    
                    <td>
                        <asp:HyperLink ID="HyperLink1" 
                            runat="server"
                            NavigateUrl='<%# "MessageDetail.Aspx?Id="+Eval("Id") %>' 
                            CssClass="btn btn-warning">
                            Mesajı Gör</asp:HyperLink>

                    </td>
                </tr>
            </ItemTemplate>
        </asp:Repeater>
        </tbody>
        

        
    </table>

</asp:Content>
