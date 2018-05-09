<%@ Page Title="" Language="C#" MasterPageFile="~/Master.Master" AutoEventWireup="true" CodeBehind="Notas_Add.aspx.cs" Inherits="SchoolSystem.Notas_Add" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="cphContent" runat="server">
    <asp:Panel runat="server" ID="pnlCadastro" Visible="true">
        <h1>Adicionar Nota</h1>
        <ul>
            <li>
                <asp:Label Text="Código da Turma" ID="label4" runat="server"></asp:Label>
                <asp:TextBox ID="tbCodTurma" Text="" CssClass="disable radiusInput" Enabled="false" runat="server"></asp:TextBox>
            </li>
            <li>
                <asp:Label Text="Código do Aluno" ID="label1" runat="server"></asp:Label>
                <asp:TextBox ID="tbCodAluno" Text="" CssClass="radiusInput" runat="server"></asp:TextBox>
            </li>
            <li>
                <asp:Label Text="A1" ID="label2" runat="server"></asp:Label>
                <asp:TextBox ID="tbA1" Text="" CssClass="radiusInput" runat="server"></asp:TextBox>
            </li>
            <li>
                <asp:Label Text="A2" ID="label3" runat="server"></asp:Label>
                <asp:TextBox ID="tbA2" Text="" CssClass="radiusInput" runat="server"></asp:TextBox>
            </li>
            <li>
                <asp:Label Text="A3" ID="label5" runat="server"></asp:Label>
                <asp:TextBox ID="tbA3" Text="" CssClass="radiusInput" runat="server"></asp:TextBox>
            </li>
            <li>
                <asp:Button ID="btnCadastrar" CssClass="btnAdd btn" runat="server" Text="Adicionar" OnClick="btnCadastrar_Click" />
            </li>
        </ul>
    </asp:Panel>    
</asp:Content>
