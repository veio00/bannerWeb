﻿<%@ Page Title="Home Page" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Default.aspx.cs" Inherits="bannerWeb._Default" %>

<asp:Content ID="BodyContent" ContentPlaceHolderID="MainContent" runat="server">
    <div class="gallery">
        <h1>Carregar Imagem</h1>
        <br>
        <asp:Repeater ID="fotos" runat="server">
            <ItemTemplate>
                <div class="imagens">
                    <a href=""<img src="Imagens/<%# Eval("nomeArquivo") %>" "rel="lightbox" title="Imagem 1"> <img src="Imagens/<%# Eval("nomeArquivo") %>" alt="" title="Img#1" /></a>--%>
                    <span><%# Eval("descricao") %></span>
                </div>
            </ItemTemplate>
        </asp:Repeater>
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
            <span>Data de inicio</span>
            <asp:TextBox type="date" ID="txtInicio" runat="server"></asp:TextBox>
            <span>Data de inicio</span>
            <asp:TextBox type="date" ID="txtFim" runat="server"></asp:TextBox>
            <asp:CheckBoxList ID="CheckBoxList1" runat="server" RepeatDirection="Horizontal">
                <asp:ListItem Value="Segunda">Segunda</asp:ListItem>
                <asp:ListItem Value="Terça">Terça</asp:ListItem>
                <asp:ListItem Value="Quarta">Quarta</asp:ListItem>
                <asp:ListItem>Quinta</asp:ListItem>
                <asp:ListItem>Sexta</asp:ListItem>
                <asp:ListItem>Sabado</asp:ListItem>
                <asp:ListItem>Domingo</asp:ListItem>
            </asp:CheckBoxList>
            <asp:Button ID="btnAgendar" runat="server" Text="Button" />
        </div>
    </div>
    <div>
        <h1>Agendamento</h1>

    </div>



</asp:Content>

