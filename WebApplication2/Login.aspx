<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Login.aspx.cs" Inherits="WebApplication2.Login" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <link href="Dosyalar1/bootstrap.min.css" rel="stylesheet" />
    <style type="text/css">
        .auto-style1 {
            width: 201px;
            height: 201px;
        }
    </style>
</head>
                <br />

            <br />
<body style="background-image: url('logo/2539d05d-da06-4c58-94fe-c6c4b88befb4.jpg');
             background-repeat: no-repeat;
             background-attachment: fixed;
             background-size: cover;">

    <form id="form1" runat="server">

        <div style="width: 370px; margin: auto">
            

            <div style="margin: auto; text-align: center;">
                <img class="auto-style1"  src="logo/Kayseri_Üniversitesi_logo.jpg"  /></div>

            <br />
            <div>
                
                <asp:TextBox ID="TxtNumara" runat="server" CssClass="form-control" Width="350px" placeholder="Kullanıcı Adı"></asp:TextBox>
            </div>
            <br />
            <div>
                
                <asp:TextBox ID="TxtSifre" runat="server" CssClass="form-control" Width="350px" placeholder="Şifre" TextMode="Password"></asp:TextBox>
            </div>
            <br />
            <asp:Button ID="Button1" runat="server" Text="GİRİŞ YAP" CssClass="btn btn-info" Width="350px" OnClick="Button1_Click"   />
            <br />
            <br />
            <asp:Button ID="Button2" runat="server" Text="ŞİFREMİ UNUTTUM" CssClass="btn btn-default  " Width="170px" OnClick="Button2_Click"/>
            <asp:Button ID="Button3" runat="server" Text="ÖĞRETMEN GİRİŞİ" CssClass="btn btn-info  " Width="170px" OnClick="Button3_Click" />
            

        </div>

    </form>
</body>
</html>

