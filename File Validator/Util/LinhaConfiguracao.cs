using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Util
{
    /// <summary>
    /// Classe que define as configurações de uma linha do arquivo
    /// </summary>
    public class LinhaConfiguracao
    {
        #region Atributos e Propriedades

        private Global.TipoLinhaConfiguracao tipoConfiguracao = Global.TipoLinhaConfiguracao.BODY;
        /// <summary>
        /// Identifica qual é a configuração
        /// </summary>
        public Global.TipoLinhaConfiguracao TipoConfiguracao
        {
            get
            {
                return tipoConfiguracao;
            }
            set
            {
                tipoConfiguracao = value;
            }
        }

        private string name = string.Empty;
        /// <summary>
        /// Nome da configuração
        /// </summary>
        public string Name
        {
            get
            {
                return name;
            }
            set
            {
                this.name = value;
            }
        }

        private Global.Type tipo = Global.Type.N;
        /// <summary>
        /// Tipo do dado para verificação
        /// </summary>
        public Global.Type Tipo
        {
            get
            {
                return tipo;
            }
            set
            {
                tipo = value;
            }
        }

        private string observacao = string.Empty;
        /// <summary>
        /// Observação da regra
        /// </summary>
        public string Observacao
        {
            get
            {
                return observacao;
            }
            set
            {
                observacao = value;
            }
        }

        int size = 0;
        /// <summary>
        /// Tamanho do campo
        /// </summary>
        public int Size
        {
            get
            {
                return size;
            }
            set
            {
                size = value;
            }
        }

        #endregion Atributos e Propriedades

        #region Construtores

        /// <summary>
        /// Construtor pincipal da classe
        /// </summary>
        public LinhaConfiguracao()
        {

        }

        /// <summary>
        /// Construtor secundário da classe
        /// </summary>
        /// <param name="tipoConfiguracao"></param>
        /// <param name="name"></param>
        /// <param name="tipo"></param>
        /// <param name="observacao"></param>
        /// <param name="size"></param>
        public LinhaConfiguracao(Global.TipoLinhaConfiguracao tipoConfiguracao, string name, Global.Type tipo, string observacao, int size)
        {
            this.tipoConfiguracao = tipoConfiguracao;
            this.name = name;
            this.tipo = tipo;
            this.observacao = observacao;
            this.size = size;
        }

        #endregion Construtores
    }
}
