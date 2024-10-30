using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VoiceTexterBot.Extensions
{
    public class DirectoryExtensions
    {
        /// <summary>
        /// Получаем путь до каталога с .sln файлом
        /// </summary>

        public static string GetSolutionRoot()
        {
            var dir = Path.GetDirectoryName(Directory.GetCurrentDirectory());
            var fullName = Directory.GetParent(dir).FullName;
            var projectRoot = fullName.Substring(0, fullName.Length - 4);

            return Directory.GetParent(projectRoot)?.FullName;
        }
    }
}
