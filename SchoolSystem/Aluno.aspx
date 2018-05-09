<%@ Page Title="" Language="C#" MasterPageFile="~/Master.Master" AutoEventWireup="true" CodeBehind="Aluno.aspx.cs" Inherits="SchoolSystem.Aluno" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="cphContent" runat="server">
    <asp:Panel runat="server" ID="pnlShowData" Visible="true">
        <h1>Todos os Alunos Cadastrados</h1>
        <asp:GridView ID="gwDados" runat="server" AutoGenerateColumns="False" EmptyDataText="Não Existem Matérias Cadastradas...">
            <Columns>
                <asp:BoundField DataField="idAluno" HeaderText="Código" />
                <asp:BoundField DataField="nome" HeaderText="Nome" />
                <asp:BoundField DataField="endereco" HeaderText="Endereço" />
                <asp:BoundField DataField="cep" HeaderText="Cep" />
                <asp:BoundField DataField="telefone" HeaderText="Telefone" />
                <asp:BoundField DataField="celular" HeaderText="Celular" />
                <asp:BoundField DataField="dataNascimento" DataFormatString="{0:dd/MM/yyyy}" ItemStyle-CssClass="Align" HeaderText="Data de Nascimento" >
                <ItemStyle CssClass="Align" />
                </asp:BoundField>
                <asp:BoundField DataField="dataCadastro" DataFormatString="{0:dd/MM/yyyy}" ItemStyle-CssClass="Align" HeaderText="Data de Cadastro" >
                <ItemStyle CssClass="Align" />
                </asp:BoundField>
                <asp:HyperLinkField DataNavigateUrlFormatString="Aluno_Edit.aspx?id={0}" Text="Editar" DataNavigateUrlFields="idAluno" />
                <asp:HyperLinkField DataNavigateUrlFormatString="Aluno_Excluir.aspx?id={0}" Text="Excluir" DataNavigateUrlFields="idAluno" />
            </Columns>
        </asp:GridView>
    </asp:Panel>

    <asp:Panel runat="server" ID="pnlSearch" Visible="true">
        <h1>Pesquisa de Aluno(s)</h1>
        <fieldset>
            <legend>Opções de Pesquisa</legend>
            <asp:RadioButtonList ID="rlbTypeSearch" CssClass="rlbTypeSearch" runat="server" RepeatLayout="UnorderedList">
                <asp:ListItem Value="ID" Selected="True">Código</asp:ListItem>
                <asp:ListItem>Nome</asp:ListItem>
            </asp:RadioButtonList>
        </fieldset>
        <ul>
            <li>
                <asp:Label Text="Código" ID="label1" runat="server"></asp:Label>
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
