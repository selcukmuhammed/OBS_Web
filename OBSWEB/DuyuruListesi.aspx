﻿<%@ Page Title="" Language="C#" MasterPageFile="~/Ogretmen.Master" AutoEventWireup="true" CodeBehind="DuyuruListesi.aspx.cs" Inherits="OBSWEB.DuyuruListesi" %>
<asp:Content ID="Content1" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder2" runat="server">

    <table class="table table-bordered table-hover">
            <tr>
                <th scope="col">ID</th>
                <th scope="col">BAŞLIK</th>
                <th scope="col">İÇERİK</th>
                <th scope="col">ÖĞRETMEN</th>
                <th scope="col">İŞLEMLER</th>

            </tr>
        <tbody>
            <asp:Repeater ID="Repeater1" runat="server">

                <ItemTemplate>

                    <tr>

                        <td><%#Eval("DuyuruId")%></td>
                        <td><%#Eval("DuyuruBaslik")%></td>
                        <td><%#Eval("DuyuruIcerik")%></td>
                        <td><%#Eval("DuyuruOgrt")%></td>
                        <td>

                            <asp:HyperLink ID="HyperLink1" NavigateUrl='<%#"~/DuyuruSil.aspx?DuyuruId="+Eval("DuyuruId") %>' runat="server" CssClass="btn btn-danger">SİL</asp:HyperLink>
                            <asp:HyperLink ID="HyperLink2" NavigateUrl='<%#"~/DuyuruGuncelle.aspx?DuyuruId="+Eval("DuyuruId") %>' runat="server" CssClass="btn btn-success">GÜNCELLE</asp:HyperLink>

                        </td>

                    </tr>

                </ItemTemplate>

            </asp:Repeater>
        </tbody>
    </table>

</asp:Content>
