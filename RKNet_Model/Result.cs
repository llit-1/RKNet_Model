using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace RKNet_Model
{
    // Результат выполнения запроса
    public class Result<T>
    {
        public bool Ok { get; set; } // статус выполнения (успешно или ошибка)
        public string Title { get; set; } // Заголовок ошибки (задается вручную)
        public string ErrorMessage { get; set; } // Сообщение e.Message
        public string ExceptionText { get; set; } // Содержание e.ToString()
        public T Data { get; set; }

        public Result()
        { 
            Ok = true;
        }
    }
}
