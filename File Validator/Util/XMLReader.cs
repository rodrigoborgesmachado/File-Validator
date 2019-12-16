using System;
using System.Collections.Generic;
using System.IO;
using System.Xml;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Util
{
    public static class XMLReader
    {
        /// <summary>
        /// Método que faz a leitura do arquivo xml com as configurações e retorna uma lista das mesmas 
        /// </summary>
        /// <param name="xmlFile">Arquivo xml de configuração</param>
        /// <param name="mensagemErro">Mensagem de erro</param>
        /// <returns></returns>
        public static List<LinhaConfiguracao> RetornaConfiguracoes(FileInfo xmlFile, ref string mensagemErro)
        {
            List<LinhaConfiguracao> lista = new List<LinhaConfiguracao>();

            try
            {
                PopulaLista(xmlFile, ref lista);
            }
            catch(Exception e)
            {
                CL_Files.WriteOnTheLog("Erro: " + e.Message);
                mensagemErro = "Erro ao montar as configurações a partir do arquivo XML. Erro: " + e.Message;
            } 

            return lista;
        }

        /// <summary>
        /// Método que popula a lista a partir do arquivo xml
        /// </summary>
        /// <param name="xmlFile">Arquivo xml para leitura</param>
        /// <param name="lista">lista para preencher</param>
        private static void PopulaLista(FileInfo xmlFile, ref List<LinhaConfiguracao> lista)
        {
            XmlTextReader reader = new XmlTextReader(xmlFile.FullName);
            bool header = false;
            bool body = false;
            bool footer = false;

            while (reader.Read())
            {
                switch (reader.NodeType)
                {
                    case XmlNodeType.Element: // The node is an element.
                        if (reader.Name.ToUpper().Equals("HEADER"))
                        {
                            header = true;
                        }
                        else if (reader.Name.ToUpper().Equals("BODY"))
                        {
                            body = true;
                        }
                        else if (reader.Name.ToUpper().Equals("FOOTER"))
                        {
                            footer = true;
                        }
                        else if (reader.Name.ToUpper().Equals("FIELD"))
                        {
                            LinhaConfiguracao conf = new LinhaConfiguracao();
                            conf.TipoConfiguracao = header ? Global.TipoLinhaConfiguracao.HEADER : (body ? Global.TipoLinhaConfiguracao.BODY : Global.TipoLinhaConfiguracao.FOOTER);
                            conf.Name = reader["name"];
                            conf.Tipo = reader["type"].Equals("N") ? Global.Type.N : Global.Type.NA;
                            conf.Observacao= reader["obs"];
                            conf.Size = int.Parse(reader["size"]);
                            lista.Add(conf);
                        }
                        break;
                    case XmlNodeType.EndElement:
                        if (reader.Name.ToUpper().Equals("HEADER"))
                        {
                            header = false;
                        }
                        else if (reader.Name.ToUpper().Equals("BODY"))
                        {
                            body = false;
                        }
                        else if (reader.Name.ToUpper().Equals("FOOTER"))
                        {
                            footer = false;
                        }
                        break;
                }
            }
        }
    }
}
