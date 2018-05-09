<%@ Page Title="" Language="C#" MasterPageFile="~/Master.Master" AutoEventWireup="true" CodeBehind="Turma_Add.aspx.cs" Inherits="SchoolSystem.Turma_Add" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="cphContent" runat="server">
    <asp:Panel runat="server" ID="pnlCadastro" Visible="true">
        <h1>Cadastro de Turma</h1>
        <ul>
            <li>
                <asp:Label Text="Código da Matéria" ID="label4" runat="server"></asp:Label>
                <asp:TextBox ID="tbCodMaterias" Text="" CssClass="radiusInput" runat="server"></asp:TextBox>
            </li>
            <li>
                <asp:Label Text="Nome" ID="label1" runat="server"></asp:Label>
                <asp:TextBox ID="tbNome" Text="" CssClass="radiusInput" runat="server"></asp:TextBox>
            </li>
            <li>
                <asp:Label ID="Label3" runat="server" Text="Data de Cadastro"></asp:Label>
                <asp:TextBox ID="tbDataCadastro" Enabled="false" CssClass="radiusInput disable" runat="server"></asp:TextBox>
            </li>

            <li>
                <asp:Button ID="btnCadastrar" CssClass="btnAdd btn" runat="server" Text="Cadastrar" OnClick="btnCadastrar_Click" />
            </li>
        </ul>
    </asp:Panel>    
</asp:Content>
