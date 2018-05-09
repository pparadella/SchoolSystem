﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using Model;

namespace SchoolSystem
{
    public partial class Aluno : System.Web.UI.Page
    {
        private ModelDataContext mdc;

        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                this.PopulateGrid();
            }
        }

        private void PopulateGrid(int pIndex = -1)
        {
            mdc = new ModelDataContext();
            try
            {
                var sourceAluno = from alu in mdc.Aluno
                                    select alu;

                switch (pIndex)
                {
                    case 0:
                        {
                            sourceAluno = from alu in mdc.Aluno
                                            where alu.idAluno == int.Parse(tbPesqID.Text.Trim())
                                            select alu;
                            break;
                        }
                    case 1:
                        {
                            sourceAluno = from alu in mdc.Aluno
                                            where alu.Nome.Contains(tbPesqNome.Text.Trim())
                                            select alu;
                            break;
                        }

                }

                gwDados.DataSource = sourceAluno;
                gwDados.DataBind();

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

        protected void btnSearch_Click(object sender, EventArgs e)
        {
            this.PopulateGrid(rlbTypeSearch.SelectedIndex);
        }
        protected void btnLimpaPesq_Click(object sender, EventArgs e)
        {
            this.PopulateGrid();
        }
    }
}