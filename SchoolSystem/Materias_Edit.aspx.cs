using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using Model;

namespace SchoolSystem
{
    public partial class Materias_edit : System.Web.UI.Page
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

        protected void BntAtualizar_Click(object sender, EventArgs e)
        {
            this.OnUpdate();
        }

        private void OnUpdate()
        {
            mdc = new ModelDataContext();
            try
            {

                Materia materia = mdc.Materia.First(mat => mat.idMateria == int.Parse(tbCodMateria.Text.Trim()));
                materia.Nome = tbNome.Text.Trim();
                materia.Descricao = tbDescricao.Text.Trim();
                materia.dataAtualizacao = DateTime.Parse(DateTime.Now.ToShortDateString());

                mdc.SubmitChanges();
                Response.Redirect("Materias.aspx");
            }
            catch (Exception)
            {


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