using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using System.Runtime.Serialization;

namespace RKNet_Model
{
    // БЛЮДО (позиция)
    public class Dish
    {
        [Key]
        public int Id { get; set; }
        public string Name { get; set; } // Название
        public string rkCode { get; set; } // Код в Р-КИпер
        public string Price { get; set; } // Цена
        public string Quantity { get; set; } // Количество
        public string Comment { get; set; } // Комментарий

        public Order order { get; set; }
        public int OrderId { get; set; }

        // Суммарная стоимость блюда
        public string Summ()
        {
            var summ = (int.Parse(Price) * int.Parse(Quantity)).ToString();
            return summ;
        }
    }
}
