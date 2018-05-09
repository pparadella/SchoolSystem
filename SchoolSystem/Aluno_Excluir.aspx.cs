using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using Model;

namespace SchoolSystem
{
    public partial class Aluno_Excluir : System.Web.UI.Page
    {
        private ModelDataContext mdc;
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                try
                {
                    this.PopulateFields(int.Parse(Request.QueryString["id"]));
                }
                catch (Exception)
                {

                    this.PopulateFields();
                }
            }
        }

        protected void BtnExcluir_Click(object obj, EventArgs e)
        {
            this.OnDelete();

        }

        private void OnDelete()
        {
            mdc = new ModelDataContext();
            try
            {

                Model.Aluno aluno = mdc.Aluno.First(alu => alu.idAluno == int.Parse(tbCodAluno.Text.Trim()));

                mdc.Aluno.DeleteOnSubmit(aluno);
                mdc.SubmitChanges();

                Response.Redirect("Aluno.aspx");
            }
            catch (Exception)
            {
                Response.Redirect("Aluno.aspx");

            }
            finally
            {
                mdc.Dispose();
            }
        }

        private void PopulateFields(int pGetID = 0)
        {
            mdc = new ModelDataContext();
            try
            {
                if (pGetID > 0)
                {
                    
                    Model.Aluno aluno = mdc.Aluno.First(alu => alu.idAluno == pGetID);

                    tbCodAluno.Text = pGetID.ToString();
                    tbNome.Text = aluno.Nome.Trim();
                    tbEndereco.Text = aluno.Endereco.Trim();
                    tbCep.Text = aluno.Cep.Trim();
                    tbTelefone.Text = aluno.Telefone.Trim();
                    tbCelular.Text = aluno.Celular.Trim();
                    tbDataNasc.Text = aluno.dataNascimento.ToString().Trim();
                    tbDataCadastro.Text = aluno.dataCadastro.ToString().Trim();

                }
                else
                {
                    Response.Redirect("Aluno.aspx");
                }
            }
            catch (Exception)
            {


            }
            finally
            {
                mdc.Dispose();
            }
        }
    }
}