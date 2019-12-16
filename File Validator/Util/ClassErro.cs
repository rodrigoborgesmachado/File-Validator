using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Util
{
    public class ClassErro
    {
        #region Atributos e Propriedades

        private int linha;
        /// <summary>
        /// Linha em que há o erro
        /// </summary>
        public int Linha
        {
            get
            {
                return linha;
            }
            set
            {
                linha = value;
            }
        }

        private string campoErro = string.Empty;
        /// <summary>
        /// Campo que há o erro
        /// </summary>
        public string CampoErro
        {
            get
            {
                return campoErro;
            }
            set
            {
                campoErro = value;
            }
        }

        private string mensagemErro = string.Empty;
        /// <summary>
        /// Mensagem de erro
        /// </summary>
        public string MensagemErro
        {
            get
            {
                return mensagemErro;
            }
            set
            {
                mensagemErro = value;
            }
        }

        #endregion Atributos e Propriedades

        #region Construtores

        /// <summary>
        /// Construtor principal da classe
        /// </summary>
        /// <param name="linha">Linha que há o erro</param>
        /// <param name="campo">Campo que está errado</param>
        /// <param name="mensagem">Mensagem de erro</param>
        public ClassErro(int linha, string campo, string mensagem)
        {
            this.linha = linha;
            this.campoErro = campo;
            this.mensagemErro = mensagem;
        }

        #endregion Construtores
    }
}
