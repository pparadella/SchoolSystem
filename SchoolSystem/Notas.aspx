<%@ Page Title="" Language="C#" MasterPageFile="~/Master.Master" AutoEventWireup="true" CodeBehind="Notas.aspx.cs" Inherits="SchoolSystem.Notas" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="cphContent" runat="server">
    <asp:Panel runat="server" ID="pnlShowData" Visible="true">
        <div runat="server" id="headerTurma"></div>
        
        
        <asp:GridView ID="gwNotas" runat="server" AutoGenerateColumns="False" EmptyDataText="Não Existem Matérias Cadastradas...">
            <Columns>
                <asp:BoundField DataField="Nome" HeaderText="Nome" />
                <asp:BoundField DataField="a1" HeaderText="A1" />
                <asp:BoundField DataField="a2" HeaderText="A2" />
                <asp:BoundField DataField="a3" HeaderText="A3" />
                <asp:BoundField DataField="media" HeaderText="Média" />
            </Columns>
        </asp:GridView>

        <asp:Panel runat="server" ID="pnlSearch" Visible="true">
        <ul>
            
            <li>
               <asp:Button ID="btnAdd" CssClass="btn btnAdd" runat="server" Text="Adicionar Nota" OnClick="btnAdd_Click" />
            </li>
            <li>
               <asp:Button ID="btnLEdit" CssClass="btn btnEdit" runat="server" Text="Editar Nota" OnClick="btnEdit_Click" />
            </li>
        </ul>
    </asp:Panel>
    </asp:Panel>
</asp:Content>
