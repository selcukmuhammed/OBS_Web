<%@ Page Title="" Language="C#" MasterPageFile="~/Ogrenci.Master" AutoEventWireup="true" CodeBehind="ProfilGuncelle.aspx.cs" Inherits="OBSWEB.ProfilGuncelle" %>
<asp:Content ID="Content1" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder2" runat="server">

    <form id="Form1" runat="server">

        <div class="form-group">
            <div>
                <asp:TextBox ID="TxtSay1" runat="server" CssClass="form-control" Enabled="False">Numara : </asp:TextBox>
            </div>
            <br />

            <div>
                <asp:TextBox ID="TxtSay2" runat="server" CssClass="form-control">Şifre : </asp:TextBox>
            </div>
            <br />

            <div>
                <asp:TextBox ID="TxtSay3" runat="server" CssClass="form-control">Şifre Tekrar : </asp:TextBox>
            </div>
            
        </div>

        <asp:Button ID="Button1" runat="server" Text="Güncelle" CssClass="btn btn-success" OnClick="Button1_Click" />

    </form>

</asp:Content>
