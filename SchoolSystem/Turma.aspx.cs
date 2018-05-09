using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using Model;

namespace SchoolSystem
{
    public partial class Turma : System.Web.UI.Page
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
                var sourceTurma = from tur in mdc.Turma
                                    select tur;

                switch (pIndex)
                {
                    case 0:
                        {
                            sourceTurma = from tur in mdc.Turma
                                            where tur.idTurma == int.Parse(tbPesqID.Text.Trim())
                                            select tur;
                            break;
                        }
                    case 1:
                        {
                            sourceTurma = from tur in mdc.Turma
                                            where tur.Nome.Contains(tbPesqNome.Text.Trim())
                                            select tur;
                            break;
                        }
                }

                gwTurmas.DataSource = sourceTurma;
                gwTurmas.DataBind();

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