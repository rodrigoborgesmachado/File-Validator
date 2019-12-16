using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Util
{
    /// <summary>
    /// Classe responsável pela verificação do arquivo
    /// </summary>
    public static class Verificador
    {
        /// <summary>
        /// Método que faz a verificação do arquivo
        /// </summary>
        /// <param name="fileVerify">Arquivo a ser verificado</param>
        /// <param name="configuracoes">Configurações a serem consideradas para verificar o arquivo</param>
        /// <param name="erros">Erros encontrados</param>
        /// <param name="mensagemErro">Mensagem de controle caso haja algum erro</param>
        /// <returns>True - Verificado com sucesso; False - Não foi possível verificar</returns>
        public static bool Verifica(FileInfo fileVerify, List<LinhaConfiguracao> configuracoes, ref List<ClassErro> erros, ref string mensagemErro)
        {
            try
            {
                List<LinhaConfiguracao> header = new List<LinhaConfiguracao>();
                List<LinhaConfiguracao> footer = new List<LinhaConfiguracao>();
                List<LinhaConfiguracao> body = new List<LinhaConfiguracao>();

                DefineCongifuracoes(configuracoes, ref header, ref footer, ref body);

                List<string> linhasFile = File.ReadAllLines(fileVerify.FullName).ToList();

                VerificaLinhas(linhasFile, header, footer, body, ref erros);
            }
            catch(Exception e)
            {
                CL_Files.WriteOnTheLog("Erro: " + e.Message);
                mensagemErro = "Houve erros nas verificações!" + Environment.NewLine + "Erro: " + e.Message;
                return false;
            }

            if(erros.Count > 0)
            {
                mensagemErro = "Houve erros em algumas linhas!";
            }

            return true;
        }

        /// <summary>
        /// Método que configura as listas de configurações
        /// </summary>
        /// <param name="configuracoes">Configurações definidas</param>
        /// <param name="header">Cabeçalho da configuração</param>
        /// <param name="footer">Rodapé da configuração</param>
        /// <param name="body">Lista com as regras do body</param>
        private static void DefineCongifuracoes(List<LinhaConfiguracao> configuracoes, ref List<LinhaConfiguracao> header, ref List<LinhaConfiguracao> footer, ref List<LinhaConfiguracao> body)
        {
            foreach (LinhaConfiguracao linha in configuracoes)
            {
                if (linha.TipoConfiguracao == Global.TipoLinhaConfiguracao.HEADER)
                {
                    header.Add(linha);
                }
                else if (linha.TipoConfiguracao == Global.TipoLinhaConfiguracao.FOOTER)
                {
                    footer.Add(linha);
                }
                else
                {
                    body.Add(linha);
                }
            }
        }

        /// <summary>
        /// Método que faz a verificação do arquivo
        /// </summary>
        /// <param name="linhas">Linhas do arquivo para serem verificadas</param>
        /// <param name="header">Cabeçalho do arquivo a ser verificado</param>
        /// <param name="footer">Rodapé do arquivo a ser verificado</param>
        /// <param name="body">Linhas do arquivo consideradas como body</param>
        /// <param name="erros">Lista de erros encontrados passado por referência</param>
        private static void VerificaLinhas(List<string> linhas, List<LinhaConfiguracao> header, List<LinhaConfiguracao> footer, List<LinhaConfiguracao> body, ref List<ClassErro> erros)
        {
            string[] linhasArray = linhas.ToArray();

            for(int i = 0; i < linhas.Count; i++)
            {
                if (i.Equals(0) && header.Count > 0)
                {
                    VerificarRegras(i, linhas[i], header, ref erros);
                }
                else if(i.Equals(linhas.Count - 1))
                {
                    VerificarRegras(i, linhas[i], footer, ref erros);
                }
                else
                {
                    VerificarRegras(i, linhas[i], body, ref erros);
                }
            }
        }

        /// <summary>
        /// Método para verificação das regras
        /// </summary>
        /// <param name="pos">Posição da linha no arquivo de verificação</param>
        /// <param name="linha">Texto da linha</param>
        /// <param name="config">Lista de configurações para a linha</param>
        /// <param name="erros">Lista de erros por referência</param>
        /// <returns></returns>
        private static bool VerificarRegras(int pos, string linha, List<LinhaConfiguracao> config, ref List<ClassErro> erros)
        {
            bool correto = true;
            int posicao = 0;
            LinhaConfiguracao ultimo = null;

            foreach(LinhaConfiguracao conf in config)
            {
                string temp = string.Empty;

                if(posicao + conf.Size <= linha.Length)
                {
                    temp = linha.Substring(posicao, conf.Size);
                    posicao += conf.Size;
                }
                else
                {
                    correto = false;
                    erros.Add(new ClassErro(pos, conf.Name, "Tamanho incorreto"));
                    break;
                }

                decimal temp2 = 0;
                if(conf.Tipo == Global.Type.N)
                {
                    if (!decimal.TryParse(temp, out temp2))
                    {
                        correto = false;
                        erros.Add(new ClassErro(pos, conf.Name, "Erro de conversão para numérico"));
                    }
                }
                ultimo = conf;
            }

            if(posicao != linha.Length)
            {
                correto = false;
                erros.Add(new ClassErro(pos, ultimo.Name, "Tamanho incorreto"));
            }

            return correto;
        }
    }
}
