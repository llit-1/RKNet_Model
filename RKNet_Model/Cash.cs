using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RKNet_Model
{
    // КАССА
    public class Cash
    {
        public string rkId { get; set; } // Id кассы в Р-Кипер
        public string rkCode { get; set; } // Код кассы в Р-Кипер
        public string Name { get; set; } // Имя кассы 
        public string Ip { get; set; } // Ip кассы
        public string State { get; set; } // Состояние кассы (онлайн, оффлайн, xml ок, и т.п.)
    }
}
