using System.Collections.Concurrent;
using VoiceTexterBot.Models;

namespace VoiceTexterBot.Services
{
    internal class MemoryStorage : IStorage
    {
        /// <summary>
        /// Хранилище сессий
        /// </summary>
        private readonly ConcurrentDictionary<long, Session> _sessions;

        public Session GetSession(long chatId)
        {
            //Возвращаем сессию по ключу, если она существует
            if (_sessions.ContainsKey(chatId))
                return _sessions[chatId];

            //Создаем и возвращаем новую, если такой не было
            var newSession = new Session() { LanguageCode = "ru" };
            _sessions.TryAdd(chatId, newSession);
            return newSession;
            
        }
    }
}