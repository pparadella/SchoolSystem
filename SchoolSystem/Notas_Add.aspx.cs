using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using Model;

namespace SchoolSystem
{
    public partial class Notas_Add : System.Web.UI.Page
    {
        private ModelDataContext mdc;
        protected void Page_Load(object sender, EventArgs e)
        {
            tbCodTurma.Text = Request.QueryString["id"];
        }

        protected void btnCadastrar_Click(object sender, EventArgs e)
        {
            this.OnInsert();
        }
        private void OnInsert()
        {
            mdc = new ModelDataContext();
            try
            {
                Model.Notas notas = new Model.Notas();


                notas.idTurma = int.Parse(tbCodTurma.Text.Trim());
                notas.idAluno = int.Parse(tbCodAluno.Text.Trim());

                if (tbA1.Text.Length > 0)
                {
                    notas.a1 = float.Parse(tbA1.Text.Trim());
                }

                if (tbA2.Text.Length > 0)
                {
                    notas.a2 = float.Parse(tbA2.Text.Trim());
                }

                if (tbA3.Text.Length > 0)
                {
                    notas.a3 = float.Parse(tbA3.Text.Trim());
                }


                mdc.Notas.InsertOnSubmit(notas);
                mdc.SubmitChanges();

                

                
            }
            catch (Exception)
            {

                throw;
            }
            finally
            {
                mdc.Dispose();
            }
            //CalculaMedia();
        }
        private void CalculaMedia()
        {
            mdc = new ModelDataContext();
            try
            {
                Model.Notas notas = new Model.Notas();
                if (notas.a3 != null)
                {
                    var media = (notas.a1 + notas.a2 + notas.a3) / 3;
                    notas.media = media;
                }
                else if (notas.a2 != null)
                {
                    var media = (notas.a1 + notas.a2) / 2;
                    notas.media = media;
                }


                mdc.Notas.InsertOnSubmit(notas);
                mdc.SubmitChanges();
                Response.Redirect("Notas.aspx?id=" + Request.QueryString["id"]);
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