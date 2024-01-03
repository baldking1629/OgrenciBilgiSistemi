<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="SifremiUnuttum.aspx.cs" Inherits="WebApplication2.SifremiUnuttum" %>

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

<body style="background-image: url(' logo/2539d05d-da06-4c58-94fe-c6c4b88befb4.jpg');
background-repeat: no-repeat;
             background-attachment: fixed;
             background-size: cover;"">

    <form id="form2" runat="server">

        <div style="width: 370px; margin: auto">


            <div style="margin: auto; text-align: center;">
                <img class="auto-style1" src="logo/Kayseri_Üniversitesi_logo.jpg" />
            </div>

            <br />
            <div>
                <asp:TextBox ID="TxtNumara" runat="server" CssClass="form-control" Width="350px"></asp:TextBox>
            </div>
            <br />
            <asp:Button ID="BtnSifre" runat="server" Text="Sifre Yenile" CssClass="btn btn-danger" OnClick="BtnSifre_Click" Width="350px" />
        </div>
    </form>
</body>
</html>
