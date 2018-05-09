using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using Model;

namespace SchoolSystem
{
    public partial class Materias_Excluir : System.Web.UI.Page
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

                Materia materia = mdc.Materia.First(mat => mat.idMateria == int.Parse(tbCodMateria.Text.Trim()));

                mdc.Materia.DeleteOnSubmit(materia);
                mdc.SubmitChanges();

                Response.Redirect("Materias.aspx");
            }
            catch (Exception)
            {
                Response.Redirect("Materias.aspx");

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
                    Materia materia = mdc.Materia.First(mat => mat.idMateria == pGetID);

                    tbCodMateria.Text = pGetID.ToString();
                    tbNome.Text = materia.Nome.Trim();
                    tbDescricao.Text = materia.Descricao.Trim();

                }
                else
                {
                    Response.Redirect("Materias.aspx");
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