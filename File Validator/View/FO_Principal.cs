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
    public partial class FO_Principal : Form
    {
        #region Enumeradores

        /// <summary>
        /// Enumerador para controlar qual arquivo está sendo selecionado
        /// </summary>
        private enum TipoArquivo
        {
            XML = 0,
            VERIFICACAO = 1
        }

        #endregion Enumeradores

        #region Atributos e Propriedades

        /// <summary>
        /// Atributo para validar se o formulário já está preenchido corretamente
        /// </summary>
        bool formularioValido = false;

        #endregion Atributos e Propriedades

        #region Construtores

        /// <summary>
        /// Construtor principal da classe
        /// </summary>
        public FO_Principal()
        {
            InitializeComponent();
        }

        #endregion Construtores

        #region Eventos

        /// <summary>
        /// Evento lançado no clique do botão xmlFile para seleção do arquivo xml de configuração
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btn_xmlFile_Click(object sender, EventArgs e)
        {
            this.AdicionarArquivo(TipoArquivo.XML);
        }

        /// <summary>
        /// Evento lançado no clique do botão File para seleção do arquivo xml de verificação
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btn_file_Click(object sender, EventArgs e)
        {
            this.AdicionarArquivo(TipoArquivo.VERIFICACAO);
        }

        /// <summary>
        /// Evento lançado no clique do botão confirmar
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btn_confirmar_Click(object sender, EventArgs e)
        {
            this.Verificar();
        }

        #endregion Eventos

        #region Métodos

        /// <summary>
        /// Método que seleciona o arquivo
        /// </summary>
        /// <param name="tipo">Identifica qual arquivo deve ser selecionado</param>
        private void AdicionarArquivo(TipoArquivo tipo)
        {
            OpenFileDialog dialog_f = new OpenFileDialog();

            if (tipo == TipoArquivo.XML)
            {
                dialog_f.DefaultExt = ".xml";
            }

            dialog_f.Title = "Seleção do arquivo " + (tipo == TipoArquivo.XML ? "de configuração" : " para verificação") + "!";

            if (dialog_f.ShowDialog() == DialogResult.OK)
            {
                if(tipo == TipoArquivo.XML)
                {
                    this.tbx_xml.Text = dialog_f.FileName.ToString();
                }
                else
                {
                    this.tbx_file.Text = dialog_f.FileName.ToString();
                }
            }

            // Valida se os arquivos existem
            if(!string.IsNullOrEmpty(this.tbx_file.Text) && !string.IsNullOrEmpty(this.tbx_xml.Text))
            {
                formularioValido = File.Exists(this.tbx_file.Text) && File.Exists(this.tbx_xml.Text);
            }
        }

        /// <summary>
        /// Método que faz a verificação do arquivo
        /// </summary>
        private void Verificar()
        {
            // Se o  formulário estiver válido
            if (formularioValido)
            {
                FileInfo xmlFile = new FileInfo(this.tbx_xml.Text);
                FileInfo fileVerify = new FileInfo(this.tbx_file.Text);

                string mensagemErro = string.Empty;

                List<Util.LinhaConfiguracao> listaConfig = Util.XMLReader.RetornaConfiguracoes(xmlFile, ref mensagemErro);

                if (!string.IsNullOrEmpty(mensagemErro))
                {
                    MessageBox.Show(mensagemErro, "Alerta");
                }
                else
                {
                    List<Util.ClassErro> erros = new List<Util.ClassErro>();
                    Util.Verificador.Verifica(fileVerify, listaConfig, ref erros, ref mensagemErro);

                    if (!string.IsNullOrEmpty(mensagemErro))
                    {
                        MessageBox.Show(mensagemErro, "Alerta");
                    }

                    if(erros.Count > 0)
                    {
                        View.TalaErros tabela = new TalaErros(erros);
                        tabela.Show();
                    }
                    else
                    {
                        MessageBox.Show("Arquivo validado com sucesso!", "Sucesso");
                    }
                }
            }
        }

        #endregion Métodos

    }
}
