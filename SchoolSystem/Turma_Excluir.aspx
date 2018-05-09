<%@ Page Title="" Language="C#" MasterPageFile="~/Master.Master" AutoEventWireup="true" CodeBehind="Turma_Excluir.aspx.cs" Inherits="SchoolSystem.Turma_Excluir" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="cphContent" runat="server">
    <asp:Panel runat="server" ID="pnlExcluir" Visible="true">
        <h1>Exclusão de Curso</h1>
        <ul>
            <li>
                <asp:Label ID="Label3" runat="server" Text="Cód. Turma"></asp:Label>
                <asp:TextBox ID="tbCodTurma" Enabled="false" CssClass="disable radiusInput" runat="server"></asp:TextBox>
            </li>
            <li>
                <asp:Label ID="Label2" runat="server" Text="Cód. Matéria"></asp:Label>
                <asp:TextBox ID="tbCodMateria" Enabled="false" CssClass="disable radiusInput" runat="server"></asp:TextBox>
            </li>
            <li>
                <asp:Label Text="Nome" ID="label1" runat="server"></asp:Label>
                <asp:TextBox ID="tbNome" Text="" Enabled="false" CssClass="disable radiusInput" runat="server"></asp:TextBox>
            </li>
            
            <li>
                <asp:Button ID="btnExcluir" CssClass="btnAdd btn" runat="server" Text="Excluir" OnClick="BtnExcluir_Click" />
            </li>
        </ul>
    </asp:Panel>
</asp:Content>
