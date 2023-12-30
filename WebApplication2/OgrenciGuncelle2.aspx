<%@ Page Title="" Language="C#" MasterPageFile="~/Ogrenci.Master" AutoEventWireup="true" CodeBehind="OgrenciGuncelle2.aspx.cs" Inherits="WebApplication2.OgrenciGuncelle2" %>

<asp:Content ID="Content1" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder2" runat="server">
    <form id="Form1" runat="server">
        <div class="form-group">
            <div>
                <label>Öğrenci Numara</label>
                <asp:TextBox ID="TxtNumara" runat="server" CssClass="form-control" Enabled="false"></asp:TextBox>
            </div>
            <br />
            <div>
                <label>Öğrenci Ad Soyad</label>
                <asp:TextBox ID="TxtAdSoyad" runat="server" CssClass="form-control" Enabled="false"></asp:TextBox>
            </div>
            <br />
            <div>
                <label>Öğrenci Mail</label>
                <asp:TextBox ID="TxtMail" runat="server" CssClass="form-control" Enabled="true"></asp:TextBox>
            </div>
            <br />
            <div>
                <label>Öğrenci Telefon no</label>
                <asp:TextBox ID="TxtTelefon" runat="server" CssClass="form-control" Enabled="true"></asp:TextBox>
            </div>
            <br />
            <div>
                <label>Öğrenci Şifre</label>
                <asp:TextBox ID="TxtSifre" runat="server" CssClass="form-control" Enabled="true"></asp:TextBox>
            </div>
        </div>
        <asp:Button ID="Button4" runat="server" Text="GÜNCELLE" CssClass="btn btn-success" OnClick="Button4_Click" />
    </form>
</asp:Content>
