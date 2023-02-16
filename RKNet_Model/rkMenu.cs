using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using System.Runtime.Serialization;


namespace RKNet_Model
{
    public class rkMenu
    {
        // Категории Меню
        [DataContract(IsReference = true)]
        public class MenuCategory
        {
            [Key]
            [DataMember]
            public int Id { get; set; }
            [DataMember]
            public string Name { get; set; }
            [DataMember]
            public string rkCode { get; set; }


            // Связи
            [DataMember]
            public ICollection<MenuItem> MenuItems { get; set; }
            [DataMember]
            public ICollection<MenuCategory> MenuCategories { get; set; }
            
            public MenuCategory()
            {
                MenuItems = new List<MenuItem>();
                MenuCategories = new List<MenuCategory>();
            }
            
            public MenuCategory parentCategory { get; set; }
            public int CategoryId { get; set; }
        }

        // Позиции Меню (блюда)
        public class MenuItem
        {
            [Key]
            public int Id { get; set; }
            public string Name { get; set; } // Название
            public string rkCode { get; set; } // Код в Р-КИпер
            public string Price { get; set; } // Цена

            // Связи
            //public int? CategoryId { get; set; }
            public MenuCategory parentCategory { get; set; }
            public int CategoryId { get; set; }
        }

        // Исключения меню (то, что не нужно показывать)
        public class MenuException
        {
            [Key]
            public int Id { get; set; }
            public string rkCode { get; set; } // Код в Р-Кипер
            public string Comment { get; set; } // Комментарий (название, причина исключения)

        }
    }
}
