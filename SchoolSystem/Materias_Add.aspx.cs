﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using Model;

namespace SchoolSystem
{
    public partial class Materias_Add : System.Web.UI.Page
    {
        ModelDataContext mdc;
        protected void Page_Load(object sender, EventArgs e)
        {
            tbDataCadastro.Text = DateTime.Now.ToShortDateString();
        }

        protected void BtnCadastrar_Click(object obj, EventArgs e)
        {
            this.OnInsert();
        }

        private void OnInsert()
        {
            mdc = new ModelDataContext();
            try
            {
                Materia materia = new Materia();
                

                materia.Nome = tbNome.Text.Trim();
                materia.Descricao = tbDescriao.Text.Trim();
                materia.dataCadastro = Convert.ToDateTime(tbDataCadastro.Text.Trim());

                mdc.Materia.InsertOnSubmit(materia);
                mdc.SubmitChanges();

                Response.Redirect("Materias.aspx");
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
    }
}