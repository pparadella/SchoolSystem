using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using Model;

namespace SchoolSystem
{
    public partial class Turma_Add : System.Web.UI.Page
    {
        private ModelDataContext mdc;
        protected void Page_Load(object sender, EventArgs e)
        {
            tbDataCadastro.Text = DateTime.Now.ToShortDateString();
           
        }


        private void OnInsert()
        {
            mdc = new ModelDataContext();
            try
            {
                Model.Turma turma = new Model.Turma();

                turma.idMateria = int.Parse(tbCodMaterias.Text.Trim());
                turma.Nome = tbNome.Text.Trim();
                turma.dataCadastro = Convert.ToDateTime(tbDataCadastro.Text.Trim());

                mdc.Turma.InsertOnSubmit(turma);
                mdc.SubmitChanges();

                Response.Redirect("Turma.aspx");
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

        protected void btnCadastrar_Click(object sender, EventArgs e)
        {
            this.OnInsert();
        }

        
    }
}