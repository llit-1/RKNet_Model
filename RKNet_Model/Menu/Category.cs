using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RKNet_Model.Menu
{
    public class Category
    {
        // поля
        public int Id { get; set; }
        public string Name { get; set; }        
        public byte[] Image { get; set; }
        public string ImageUpdated { get; set; }       
        
        // связи
        public int? ParentCategoryId { get; set; }
        public List<Item> Items { get; set; }
        public List<Category> Categories { get; set; }

        // конструктор
        public Category()
        {
            Items = new List<Item>();
            Categories = new List<Category>();
        }

        // дата и время в формате RFC3339 изменения картинки категории меню
        public void UpdateImageDate ()
        {
            ImageUpdated = DateTime.Now.ToString("yyy-MM-ddTHH:mm:ss.ffffff+03:00");
        }
    }
}
