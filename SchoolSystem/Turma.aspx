<%@ Page Title="" Language="C#" MasterPageFile="~/Master.Master" AutoEventWireup="true" CodeBehind="Turma.aspx.cs" Inherits="SchoolSystem.Turma" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content3" ContentPlaceHolderID="cphContent" runat="server">


    <asp:Panel runat="server" ID="pnlShowData" Visible="true">
        <h1>Todas as Turmas Cadastradas</h1>
        <asp:GridView ID="gwTurmas" runat="server" AutoGenerateColumns="False" EmptyDataText="Não Existem Matérias Cadastradas...">
            <Columns>
                <asp:BoundField DataField="idTurma" HeaderText="Código da Turma" />
                <asp:BoundField DataField="idMateria" HeaderText="Código da Matéria" />
                <asp:BoundField DataField="Nome" HeaderText="Nome" />
                <asp:BoundField DataField="dataCadastro" DataFormatString="{0:dd/MM/yyyy}" ItemStyle-CssClass="Align" HeaderText="Data de Cadastro" >
                <ItemStyle CssClass="Align" />
                </asp:BoundField>
                <asp:HyperLinkField DataNavigateUrlFormatString="Turma_Edit.aspx?id={0}" Text="Editar" DataNavigateUrlFields="idTurma" />
                <asp:HyperLinkField DataNavigateUrlFormatString="Turma_Excluir.aspx?id={0}" Text="Excluir" DataNavigateUrlFields="idTurma" />
                <asp:HyperLinkField DataNavigateUrlFormatString="Notas.aspx?id={0}" Text="Notas" DataNavigateUrlFields="idTurma" />
            </Columns>
        </asp:GridView>
    </asp:Panel>

    <asp:Panel runat="server" ID="pnlSearch" Visible="true">
        <h1>Pesquisa de Turmas(s)</h1>
        <fieldset>
            <legend>Opções de Pesquisa</legend>
            <asp:RadioButtonList ID="rlbTypeSearch" CssClass="rlbTypeSearch" runat="server" RepeatLayout="UnorderedList">
                <asp:ListItem Value="ID" Selected="True">Código</asp:ListItem>
                <asp:ListItem>Nome</asp:ListItem>
            </asp:RadioButtonList>
        </fieldset>
        <ul>
            <li>
                <asp:Label Text="Código da Turma" ID="label1" runat="server"></asp:Label>
                <asp:TextBox ID="tbPesqID" Text="" CssClass="radiusInput" runat="server"></asp:TextBox>
            </li>

            <li>
                <asp:Label Text="Nome" ID="label9" runat="server"></asp:Label>
                <asp:TextBox ID="tbPesqNome" Text="" CssClass="radiusInput" runat="server"></asp:TextBox>
            </li>
            <p>
            <li>
                <asp:Button ID="btnSearch" CssClass="btn btnSearch" runat="server" Text="Pesquisar" OnClick="btnSearch_Click" />
            </li>
            <li>
                <asp:Button ID="btnLimpar" CssClass="btn btnSearch" runat="server" Text="Limpar" OnClick="btnLimpaPesq_Click" />
            </li></p>
        </ul>
    </asp:Panel>

    
</asp:Content>
