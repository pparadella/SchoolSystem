﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using Model;

namespace SchoolSystem
{
    public partial class Aluno_Edit : System.Web.UI.Page
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

        protected void BtnAtualizar_Click(object sender, EventArgs e)
        {
            this.OnUpdate();
        }

        private void OnUpdate()
        {
            mdc = new ModelDataContext();
            try
            {
                Model.Aluno aluno = mdc.Aluno.First(alu => alu.idAluno == int.Parse(tbCodAluno.Text.Trim()));
                aluno.Nome = tbNome.Text.Trim();
                aluno.Endereco = tbEndereco.Text.Trim();
                aluno.Cep = tbCep.Text.Trim();
                aluno.Telefone = tbTelefone.Text.Trim();
                aluno.Celular = tbCelular.Text.Trim();
                aluno.dataNascimento = DateTime.Parse(tbDataNasc.Text.Trim());
                aluno.dataAtualizacao = DateTime.Parse(DateTime.Now.ToShortDateString());

                mdc.SubmitChanges();
                Response.Redirect("Aluno.aspx");
            }
            catch (Exception)
            {
                throw;

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
                    tbDataNasc.Text = aluno.dataNascimento.ToString();

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