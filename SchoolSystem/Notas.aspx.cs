using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using Model;

namespace SchoolSystem
{
    public partial class Notas : System.Web.UI.Page
    {
        private ModelDataContext mdc;
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                this.PopulateGrid(int.Parse(Request.QueryString["id"]));
                mdc = new ModelDataContext();
                try
                {
                    Model.Turma turma = mdc.Turma.First(tur => tur.idTurma == int.Parse(Request.QueryString["id"]));
                    var turmaDisp = turma.Nome;
                    headerTurma.InnerText = "Todas as Notas da Turma "+turmaDisp;
                    headerTurma.InnerHtml = "<h1>" + headerTurma.InnerText;
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
        private void PopulateGrid(int id = -1)
        {
            mdc = new ModelDataContext();
            try
            {
                var sourceNota = from nota in mdc.Notas
                                 join alu in mdc.Aluno on nota.idAluno equals alu.idAluno
                                 where nota.idTurma == id
                                 select new { alu.Nome, nota.a1, nota.a2,nota.a3,nota.media};



                gwNotas.DataSource = sourceNota;
                
                gwNotas.DataBind();

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

        protected void btnAdd_Click(object sender, EventArgs e)
        {
            Response.Redirect("Notas_Add.aspx?id=" + Request.QueryString["id"]);
        }

        protected void btnEdit_Click(object sender, EventArgs e)
        {

        }
    }
}