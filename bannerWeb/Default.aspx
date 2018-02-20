<%@ Page Title="Home Page" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Default.aspx.cs" Inherits="bannerWeb._Default" %>

<asp:Content ID="BodyContent" ContentPlaceHolderID="MainContent" runat="server">
    <div class="gallery">
        <h1>Carregar Imagem</h1>
        <br>
        <asp:Repeater ID="fotos" runat="server">
            <ItemTemplate>
                <div class="imagens">
                    <a href=""<img src="Imagens/<%# Eval("nomeArquivo") %>" "rel="lightbox" title="Imagem 1" onclick="func(<%# Eval("idFoto") %>)"><img src="Imagens/<%# Eval("nomeArquivo") %>" alt="" title="Img#1" /></a>
                    <span><%# Eval("descricao") %></span>
                </div>
            </ItemTemplate>
        </asp:Repeater>
<%--        <script>
            function func(teste) {
                $("#MainContent_lblIdFoto").attr('Text') = teste; 
            }
        </script>--%>
        <br />
    </div>
    <div class="alteracao">
        <div class="pesquisa">
            <h1>Pesquisar</h1>
            <br />
            <asp:TextBox ID="tbPesquisa" runat="server"></asp:TextBox>
            &nbsp;&nbsp;&nbsp;
        <asp:Button ID="btnProcurar" runat="server" Text="Procurar" OnClick="btnProcurar_Click" />
            &nbsp;&nbsp;&nbsp;
        <asp:CheckBox ID="cbTodasImg" runat="server" />Todas
        <br />
        </div>
        <div class="carregar">
            <h1>Carregar Imagem</h1>
            <asp:FileUpload ID="fImagem" runat="server" AllowMultiple="True" EnableTheming="True" />
            <asp:Label ID="Label1" runat="server" Text="Descrição: "></asp:Label>
            <asp:TextBox ID="txtDescricao" runat="server"></asp:TextBox>
            <asp:CheckBox ID="cbPadrao" runat="server" OnCheckedChanged="ImagemPadrao" />Padrão
        <br />
            <asp:Button ID="btnCarregar" runat="server" Text="Salvar" OnClick="Button1_Click" />
        </div>
        <div class="Agendar">
            <h1>Agendar Imagem</h1>
            <asp:Label ID="lblFotoAgendada" runat="server" Text=""></asp:Label>
            <span>Data de inicio</span>
            <asp:TextBox type="date" ID="txtInicio" runat="server"></asp:TextBox>
            <span>Data de termino</span>
            <asp:TextBox type="date" ID="txtFim" runat="server"></asp:TextBox>
            <asp:CheckBoxList ID="cbDias" runat="server" RepeatDirection="Horizontal">
                <asp:ListItem Value="2">Segunda</asp:ListItem>
                <asp:ListItem Value="3">Terça</asp:ListItem>
                <asp:ListItem Value="4">Quarta</asp:ListItem>
                <asp:ListItem Value="5">Quinta</asp:ListItem>
                <asp:ListItem Value="6">Sexta</asp:ListItem>
                <asp:ListItem Value="7">Sabado</asp:ListItem>
                <asp:ListItem Value="1">Domingo</asp:ListItem>
            </asp:CheckBoxList>
            <asp:Button ID="btnAgendar" runat="server" Text="Agendar" OnClick="btnAgendar_Click" />
        </div>
    </div>


<%--<asp:Label ID="lblIdFoto" runat="server" Text="111111111111111111111111111" Visible="true"></asp:Label>--%>
</asp:Content>

