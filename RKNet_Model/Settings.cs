using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace RKNet_Model
{
    // Настройки
    public class Settings
    {
        [Key]
        public int Id { get; set; }
        public string rkIp { get; set; } // ip адрес сервера справочнико Р-КИпер
        public string rkPort { get; set; } // HTTP порт подключения к серверу справочников и всем кассам
        public string rkUser { get; set; } // Пользователь РК с правами доступа к XML интерфейсу, менеджерской станции и всем кассам
        public string rkPass { get; set; } // Пароль пользователя РК
    }
}
