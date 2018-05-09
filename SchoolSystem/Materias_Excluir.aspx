<%@ Page Title="" Language="C#" MasterPageFile="~/Master.Master" AutoEventWireup="true" CodeBehind="Materias_Excluir.aspx.cs" Inherits="SchoolSystem.Materias_Excluir" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="cphContent" runat="server">
    <asp:Panel runat="server" ID="pnlExcluir" Visible="true">
        <h1>Exclusão de Matérias</h1>
        <ul>
            <li>
                <asp:Label ID="Label3" runat="server" Text="Código"></asp:Label>
                <asp:TextBox ID="tbCodMateria" Enabled="false" CssClass="disable radiusInput" runat="server"></asp:TextBox>
            </li>
            <li>
                <asp:Label Text="Nome" ID="label1" runat="server"></asp:Label>
                <asp:TextBox ID="tbNome" Text="" Enabled="false" CssClass="disable radiusInput" runat="server"></asp:TextBox>
            </li>
            <li>
                <asp:Label ID="Label2" runat="server" Text="Descrição"></asp:Label>
                <asp:TextBox ID="tbDescricao" Enabled="false" CssClass="disable radiusInput" runat="server"></asp:TextBox>
            </li>
            

            <li>
                <asp:Button ID="btnExcluir" CssClass="btnAdd btn" runat="server" Text="Excluir" OnClick="BtnExcluir_Click" />
            </li>
        </ul>
    </asp:Panel>
</asp:Content>
