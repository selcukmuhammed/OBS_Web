<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="LoginPanel.aspx.cs" Inherits="OBSWEB.LoginPanel" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <link href="Dosyalar1/bootstrap.min.css" rel="stylesheet" />
    <title></title>
    <style type="text/css">
        .auto-style1 {
            display: block;
            padding: 6px 12px;
            font-size: 14px;
            line-height: 1.42857143;
            color: #555;
            background-color: #fff;
            background-image: none;
            border: 1px solid #ccc;
            border-radius: 4px;
            -webkit-box-shadow: inset 0 1px 1px rgba(0,0,0,.075);
            box-shadow: inset 0 1px 1px rgba(0,0,0,.075);
            -webkit-transition: border-color ease-in-out .15s,-webkit-box-shadow ease-in-out .15s;
            -o-transition: border-color ease-in-out .15s,box-shadow ease-in-out .15s;
            transition: border-color ease-in-out .15s,box-shadow ease-in-out .15s;
        }
        .auto-style2 {
            height: 777px;
        }
        .newStyle1 {
            font-family: Arial;
        }
        .auto-style3 {
            font-family: Arial;
            font-size: x-large;
            color: #FFFFFF;
            text-align: center;
        }
        .auto-style5 {
            color: #FFFFFF;
            font-size: small;
        }
    </style>
</head>
<body>
    <form id="form1" runat="server" class="auto-style2" style="background-image: url('BEAUTY-LANDSCAPE-LAKE-1192023.jpg')">
        <div style=" margin:auto; width: 700px; ";" class="text-left">
            <br />
            <h4 class="auto-style3">Öğrenci Bilgilendirme Sistemi</h4>

            <div style="margin: auto; text-align: center;">
            <asp:Image ID="Image1" runat="server" Height="100px" Width="200px" ImageUrl="~/whatsapp-image-2022-09-27-at-105551-1664266143.jpeg" />
            </div>
            <br /> 

            <div>
                <asp:Label for="TxtKullaniciAdi" runat="server" CssClass="auto-style5">Kullanıcı Adı</asp:Label>
                <asp:TextBox ID="TxtKullaniciAdi" runat="server" CssClass="auto-style1" Width="600px"></asp:TextBox>
            </div>
            <br />

            <div>
                <asp:Label for="TxtKullaniciSifre" runat="server" CssClass="auto-style5">Şifre</asp:Label>
                <asp:TextBox ID="TxtKullaniciSifre" runat="server" CssClass="auto-style1" Width="600px" TextMode="Password"></asp:TextBox>
            </div>
            <br />

            <asp:Button ID="Button1" runat="server" Text="Giriş Yapınız" CssClass="btn btn-warning" Width="600px" OnClick="Button1_Click"/>
            <br />
            <br />

            <asp:Button ID="Button2" runat="server" Text="İptal Et" CssClass="btn btn-danger" Width="300px"/>
            <asp:Button ID="Button3" runat="server" Text="Şifremi Unuttum" CssClass="btn btn-default" Width="300px"/>

        </div>
    </form>
</body>
</html>
