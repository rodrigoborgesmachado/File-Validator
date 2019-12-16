using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Util
{
    public static class Global
    {
        // Caminho principal da aplicação
        public static string app_main_directory = System.IO.Directory.GetCurrentDirectory() + "\\";

        // Caminho da pasta de logs do sistema
        public static string app_logs_directoty = app_main_directory + "Log\\";

        // Caminho da pasta temporária do sistema
        public static string app_temp_directoty = app_main_directory + "Temp\\";

        // Caminho do arquivo html gerado
        public static string htmlFileTemp = app_temp_directoty + "htmlFile.html";


        /// <summary>
        /// Tipo da linha de configuração
        /// </summary>
        public enum TipoLinhaConfiguracao
        {
            // Cabeçalho
            HEADER = 0,
            // Corpo
            BODY = 1,
            // rodapé
            FOOTER = 2
        }

        /// <summary>
        /// Tipo do dado
        /// </summary>
        public enum Type
        {
            // numérico
            N = 0,
            // textual
            NA = 1
        }
        
    }
}
