<%@ Page Title="" Language="C#" MasterPageFile="~/Ogrenci.Master" AutoEventWireup="true" CodeBehind="OgrenciDefault.aspx.cs" Inherits="OBSWEB.OgrenciDefault" %>
<asp:Content ID="Content1" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder2" runat="server">

    <form id="Form1" runat="server">

        <div class="form-group">
            <div>
                <asp:TextBox ID="TxtSay1" runat="server" CssClass="form-control" Enabled="false">Numara : </asp:TextBox>
            </div>
            <br />

            <div>
                <asp:TextBox ID="TxtSay2" runat="server" CssClass="form-control" Enabled="false">Ad : </asp:TextBox>
            </div>
            <br />

            <div>
                <asp:TextBox ID="TxtSay3" runat="server" CssClass="form-control" Enabled="false">Telefon : </asp:TextBox>
            </div>
            <br />

            <div>
                <asp:TextBox ID="TxtSay4" runat="server" CssClass="form-control" Enabled="false">Mail : </asp:TextBox>
            </div>
            <br />

            <div>
                <asp:TextBox ID="TxtSay5" runat="server" CssClass="form-control" Enabled="false">Şifre : </asp:TextBox>
            </div>
            <br />

            <div>
                <asp:TextBox ID="TxtSay6" runat="server" CssClass="form-control" Enabled="false">Cinsiyet : </asp:TextBox>
            </div>
            <br />

            <div>
                <asp:TextBox ID="TxtSay7" runat="server" CssClass="form-control" Enabled="false">Fotoğraf : </asp:TextBox>
            </div>

        </div>

        <asp:Button ID="Button1" runat="server" Text="Şifre Değiştir" CssClass="btn btn-primary" OnClick="Button1_Click" />

    </form>

</asp:Content>
