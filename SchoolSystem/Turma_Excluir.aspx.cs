using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using Model;

namespace SchoolSystem
{
    public partial class Turma_Excluir : System.Web.UI.Page
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

        protected void BtnExcluir_Click(object sender, EventArgs e)
        {
            this.OnDelete();
        }

        private void OnDelete()
        {
            mdc = new ModelDataContext();
            try
            {

                Model.Turma turma = mdc.Turma.First(tur => tur.idTurma == int.Parse(tbCodTurma.Text.Trim()));

                mdc.Turma.DeleteOnSubmit(turma);
                mdc.SubmitChanges();

                Response.Redirect("Turma.aspx");
            }
            catch (Exception)
            {
                Response.Redirect("Turma.aspx");

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
                    Model.Turma turma = mdc.Turma.First(tur => tur.idTurma == pGetID);

                    tbCodTurma.Text = pGetID.ToString();
                    tbCodMateria.Text = turma.idMateria.ToString().Trim();
                    tbNome.Text = turma.Nome.Trim();

                }
                else
                {
                    Response.Redirect("Turma.aspx");
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