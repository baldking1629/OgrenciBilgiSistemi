<%@ Page Title="" Language="C#" MasterPageFile="~/Ogrenci.Master" AutoEventWireup="true" CodeBehind="OgrenciDefault.aspx.cs" Inherits="WebApplication2.OgrenciDefault" %>

<asp:Content ID="Content1" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder2" runat="server">
    <form id="Form1" runat="server">
        <div class="form-group">
            <div>
                <label>Öğrenci Numara</label>
                <asp:TextBox ID="TxtNumara" runat="server" CssClass="form-control" Enabled="false">Numara</asp:TextBox>
            </div>
            <br />
            <div>
                <label>Öğrenci Ad Soyad</label>
                <asp:TextBox ID="TxtAdSoyad" runat="server" CssClass="form-control" Enabled="false">Ad Soyad</asp:TextBox>
            </div>
            <br />
            <div>
                <label>Öğrenci Mail</label>
                <asp:TextBox ID="TxtMail" runat="server" CssClass="form-control" Enabled="false">Mail</asp:TextBox>
            </div>
            <br />
            <div>
                <label>Öğrenci Telefon no</label>
                <asp:TextBox ID="TxtTelefon" runat="server" CssClass="form-control" Enabled="false">Telefon</asp:TextBox>
            </div>
            <br />
            <div>
                <label>Öğrenci Şifre</label>
                <asp:TextBox ID="TxtSifre" runat="server" CssClass="form-control" Enabled="false">Şifre</asp:TextBox>
            </div>
        </div>
        <asp:Button ID="Button4" runat="server" Text="GÜNCELLE" CssClass="btn btn-primary" OnClick="Button4_Click"/>
    </form>
</asp:Content>
