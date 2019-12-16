using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace View
{
    public partial class TalaErros : Form
    {
        #region Atributos e Propriedades

        /// <summary>
        /// Lista de erros
        /// </summary>
        List<Util.ClassErro> erros = new List<Util.ClassErro>();

        #endregion Atributos e Propriedades

        #region Eventos

        /// <summary>
        /// Evento disparado no clique do botão copiar
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btn_copiar_Click(object sender, EventArgs e)
        {
            Copiar();
        }

        #endregion Eventos

        #region Construtores

        /// <summary>
        /// Construtor principal da classe
        /// </summary>
        /// <param name="erros"></param>
        public TalaErros(List<Util.ClassErro> erros)
        {
            InitializeComponent();
            this.erros = erros;
            Inicia();
        }

        #endregion Construtores


        #region Métodos

        /// <summary>
        /// Método que monta o html para apresentação dos dados
        /// </summary>
        private void Inicia()
        {
            string html_start = "<!DOCTYPE html><html lang=\"pt-br\">";
            string head = "<head> " +
                            "  <title></title> " +
                            "  <meta charset=\"UTF-8\"> " +
                            "  <meta name=\"viewport\" content=\"width=device-width, initial-scale=1\"> " +
                            "  <link rel=\"stylesheet\" href=\"https://maxcdn.bootstrapcdn.com/bootstrap/3.3.7/css/bootstrap.min.css\"> " +
                            "</head> ";
            string styles = @"<style>
                                        .titulo{
                                        	margin-bottom: 20px;
                                        	text-align: left;
                                        	float: left;
                                        }
                                        .informacoes{
                                        	text-align: right;
                                        	float: right;
                                        }
                                  </style>";
            string html = html_start + head + styles +
                              "<body>" +
                              " <div class=\"container\">" +
                              "  <div id=\"menu\"> " +
                              "     <table class=\"table table-striped\">" +
                              "         <thead>" +
                              "             <tr>" +
                              "                 <th scope=\"col\">Linha</th>" +
                              "                 <th scope=\"col\">Campo</th>" +
                              "             </tr>" +
                              "         </thead>" +
                              "         <tbody>";

            foreach (Util.ClassErro err in erros)
            {
                html += " <tr><td>" + err.Linha + "</td><td>" + err.CampoErro + "</td></tr>";
            }

            html +=           "         </tbody>" +
                              "     </table>" +
                              "   </div>" +
                              "</div>" +
                              "</body>" +
                              "</html>";

            File.Delete(Util.Global.htmlFileTemp);
            File.AppendAllText(Util.Global.htmlFileTemp, html);

            web_view.Navigate(new Uri(Util.Global.htmlFileTemp));
        }

        /// <summary>
        /// Método que copia para a memória de transferência o texto com os erros
        /// </summary>
        private void Copiar()
        {
            string texto = string.Empty;
            foreach(Util.ClassErro err in erros)
            {
                texto += err.Linha + " - " + err.CampoErro + Environment.NewLine;
            }

            Clipboard.SetText(texto, TextDataFormat.Text);
            MessageBox.Show("Texto copiado para a área de transferência!", "Sucesso");
        }

        #endregion Métodos
    }
}
