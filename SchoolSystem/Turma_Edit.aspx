<%@ Page Title="" Language="C#" MasterPageFile="~/Master.Master" AutoEventWireup="true" CodeBehind="Turma_Edit.aspx.cs" Inherits="SchoolSystem.Turma_Edit" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="cphContent" runat="server">
    <asp:Panel runat="server" ID="pnlUpdate" Visible="true">
        <h1>Atualizar Curso</h1>
        <ul>
            <li>
                <asp:Label ID="Label6" runat="server" Text="Cód. Turma"></asp:Label>
                <asp:TextBox ID="tbCodTurma" Text="2013" Enabled="false" CssClass="radiusInput disable" runat="server"></asp:TextBox>
            </li>
            <li>
                <asp:Label Text="Cód. Matéria" ID="label1" runat="server"></asp:Label>
                <asp:TextBox ID="tbCodMateria" Text="" CssClass="radiusInput" runat="server"></asp:TextBox>
            </li>
            <li>
                <asp:Label Text="Nome" ID="label4" runat="server"></asp:Label>
                <asp:TextBox ID="tbNome" Text="" CssClass="radiusInput" runat="server"></asp:TextBox>
            </li>
            <li>
                <asp:Button ID="bntAtualizar" CssClass="btn btnEdit" runat="server" Text="Atualizar" OnClick="bntAtualizar_Click" />
            </li>
        </ul>
    </asp:Panel>
</asp:Content>
