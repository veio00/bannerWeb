<%@ Page Title="Home Page" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Default.aspx.cs" Inherits="bannerWeb._Default" %>

<asp:Content ID="BodyContent" ContentPlaceHolderID="MainContent" runat="server">
    <div>
        <br />
        <asp:TextBox ID="tbPesquisa" runat="server"></asp:TextBox>

&nbsp;&nbsp;&nbsp;

        <asp:Button ID="btnProcurar" runat="server" Text="Procurar" OnClick="btnProcurar_Click" />

        <br />
        
        <asp:FileUpload ID="fImagem" runat="server" AllowMultiple="True" />

        <br />

        <asp:Button ID="Button1" runat="server" Text="Salvar" OnClick="Button1_Click" />

        <div id="gallery">
            *<%# Eval("fotos") %>*
            <ul>
                <asp:Repeater id="fotos" runat="server">
                    <ItemTemplate>
                      <li>
                        <a href=""<img src="Imagens/<%# Eval("nomeArquivo") %>" "rel="lightbox" title="Imagem 1"> <img src="Imagens/<%# Eval("nomeArquivo") %>" width="160" height="160" alt="" title="Img#1" /></a>
                          
                          <span> <%# Eval("descricao") %></span>
                      </li>
                    </ItemTemplate>
                </asp:Repeater>
                <br />
            </ul>
        </div>
    </div>

</asp:Content>

