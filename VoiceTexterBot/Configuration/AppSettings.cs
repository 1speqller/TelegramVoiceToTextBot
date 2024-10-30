using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VoiceTexterBot.Configuration
{
    public class AppSettings
    {
        // Tокен Telegram API
        public string BotToken { get; set; }

        // Папка загрузки файлов
        public string DownloadsFolder { get; set; }

        // Имя файла при загрузке
        public string AudioFileName { get; set; }

        // Формат аудио при загрузке
        public string InputAudioFormat { get; set; }

        // Формат аудио при выгрузке
        public string OutputAudioFormat { get; set; }

        // Битрейт аудио при загрузке
        public float InputAudioBitrate { get; set; }
    }
}
