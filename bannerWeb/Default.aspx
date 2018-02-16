<%@ Page Title="Home Page" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Default.aspx.cs" Inherits="bannerWeb._Default" %>

<asp:Content ID="BodyContent" ContentPlaceHolderID="MainContent" runat="server">
    <div class="gallery">
        <h1>Carregar Imagem</h1>
        <br>
            <ul>
                <asp:Repeater ID="fotos" runat="server">
                    <ItemTemplate>
                        <div class="imagens">
                            <a href=""<img src="Imagens/<%# Eval("nomeArquivo") %>" "rel="lightbox" title="Imagem 1"> <img src="Imagens/<%# Eval("nomeArquivo") %>" alt="" title="Img#1" /></a>
                            <span><%# Eval("descricao") %></span>
                        </div>
                    </ItemTemplate>
                </asp:Repeater>
                <br />
            </ul>
    </div>
    <div class="alteracao">
        <h1>Pesquisar</h1>
        <br />
        <asp:TextBox ID="tbPesquisa" runat="server"></asp:TextBox>
        &nbsp;&nbsp;&nbsp;
        <asp:Button ID="btnProcurar" runat="server" Text="Procurar" OnClick="btnProcurar_Click" />
        &nbsp;&nbsp;&nbsp;
        <asp:CheckBox ID="cbTodasImg" runat="server" />Todas
        <br />
        <h1>Carregar Imagem</h1>
        <asp:FileUpload ID="fImagem" runat="server" AllowMultiple="True" EnableTheming="True" />
        <asp:Label ID="Label1" runat="server" Text="Descrição: "></asp:Label>
        <asp:TextBox ID="txtDescricao" runat="server"></asp:TextBox>
        <asp:CheckBox ID="cbPadrao" runat="server" OnCheckedChanged="ImagemPadrao" />Padrão
        <br />
        <asp:Button ID="Button1" runat="server" Text="Salvar" OnClick="Button1_Click" />
    </div>
    <div>
        <h1>Agendamento</h1>

    </div>



</asp:Content>

