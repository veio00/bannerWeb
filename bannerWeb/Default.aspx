<%@ Page Title="Home Page" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Default.aspx.cs" Inherits="bannerWeb._Default" %>

<asp:Content ID="BodyContent" ContentPlaceHolderID="MainContent" runat="server">
    <div>
        <br />
        <asp:FileUpload ID="fupImagem" runat="server" AllowMultiple="True" />

        <br />

        <asp:Button ID="Button1" runat="server" Text="Salvar" OnClick="Button1_Click" />

        <div id="gallery">
            <ul>
                <li>
                    <a href=""<img src="Imagens/imagem01.jpg" "rel="lightbox" title="Imagem 1"> <img src="Imagens/imagem01.jpg" width="160" height="160" alt="" title="Img#1" /></a>
                    <a href=""<img src="Imagens/imagem01.jpg" "rel="lightbox" title="Imagem 2"> <img src="Imagens/imagem01.jpg" width="160" height="160" alt="" title="Img#2" /></a>
                    <a href=""<img src="Imagens/imagem01.jpg" "rel="lightbox" title="Imagem 3"> <img src="Imagens/imagem01.jpg" width="160" height="160" alt="" title="Img#3" /></a>
                </li>
                <br />
            </ul>
        </div>
    </div>
</asp:Content>