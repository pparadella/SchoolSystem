<%@ Page Title="" Language="C#" MasterPageFile="~/Master.Master" AutoEventWireup="true" CodeBehind="Aluno_Edit.aspx.cs" Inherits="SchoolSystem.Aluno_Edit" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="cphContent" runat="server">
    <asp:Panel runat="server" ID="pnlUpdate" Visible="true">
        <h1>Atualização de Alunos</h1>
        <ul>
            <li>
                <asp:Label ID="Label8" runat="server" Text="Cód. Aluno"></asp:Label>
                <asp:TextBox ID="tbCodAluno" Text="2013" Enabled="false" CssClass="radiusInput disable" runat="server"></asp:TextBox>
            </li>
            <li>
                <asp:Label Text="Nome" ID="label1" runat="server"></asp:Label>
                <asp:TextBox ID="tbNome" Text="" CssClass="radiusInput" runat="server"></asp:TextBox>
            </li>
            <li>
                <asp:Label ID="Label2" runat="server" Text="Endereço"></asp:Label>
                <asp:TextBox ID="tbEndereco" CssClass="radiusInput" runat="server"></asp:TextBox>
            </li>
            <li>
                <asp:Label ID="Label4" runat="server" Text="CEP"></asp:Label>
                <asp:TextBox ID="tbCep" CssClass="radiusInput" runat="server"></asp:TextBox>
            </li>
            <li>
                <asp:Label ID="Label5" runat="server" Text="Telefone"></asp:Label>
                <asp:TextBox ID="tbTelefone" CssClass="radiusInput" runat="server"></asp:TextBox>
            </li>
            <li>
                <asp:Label ID="Label6" runat="server" Text="Celular"></asp:Label>
                <asp:TextBox ID="tbCelular" CssClass="radiusInput" runat="server"></asp:TextBox>
            </li>
            <li>
                <asp:Label ID="Label7" runat="server" Text="Data de Nascimento"></asp:Label>
                <asp:TextBox ID="tbDataNasc" CssClass="radiusInput" runat="server"></asp:TextBox>
            </li>

            <li>
                <asp:Button ID="btnAtualizar" CssClass="btnAdd btn" OnClick="BtnAtualizar_Click" runat="server" Text="Atualizar" />
            </li>
        </ul>
    </asp:Panel>
</asp:Content>
