using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using System.Runtime.Serialization;

namespace RKNet_Model
{
    // ПРЕДЗАКАЗ
    [DataContract(IsReference = true)]
    public class Order
    {
        [Key]
        [DataMember]
        public int Id { get; set; }
        [DataMember]
        public string OrderNumber { get; set; } // номер заказа, присваеваемый поератором колл-центра
        [DataMember]
        public string CreateDate { get; set; } // дата создания заказа
        [DataMember]
        public string CustomerName { get; set; } // Имя покупатель
        [DataMember]
        public string CustomerPhone { get; set; } // Телефон покупателя
        [DataMember]
        public string PaymentType { get; set; } // Тип оплаты заказа: карта, наличные, предоплата
        [DataMember]
        public string ExtDate { get; set; } // Дата и время выдачи предзаказа
        [DataMember]
        //public Cash Cash { get; set; } // Касса предзаказа
        public string ExtTTName { get; set; } // Точка выдачи заказа (курьеру или покупателю)
        [DataMember]
        public string OrderType { get; set; } // Тип заказа (доставка, самовывоз, интернет-магазин и т.п.)
        [DataMember]
        public string DeliveryStreet { get; set; } // Адрес доставки - улица
        [DataMember]
        public string DeliveryHouse { get; set; } // Адрес доставки - дом
        [DataMember]
        public string DeliveryKvart { get; set; } // Адрес доставки - квартира
        [DataMember]
        public string DeliveryPdzd { get; set; } // Адрес доставки - подъезд
        [DataMember]
        public string DeliveryrEtaz { get; set; } // Адрес доставки - этаж
        [DataMember]
        public string OrderStatus { get; set; } // Статус заказа
        [DataMember]
        public string ChangeDate { get; set; } // Дата и время изменения статуса заказа

        //public string rkGuid { get; set; } // GUID предзаказа в Р-Кипер
        //public string rkVisit { get; set; } // VISIT предзаказа в Р-Кипер
        [DataMember]
        public List<Dish> Dishes { get; set; } // Коллекция блюд (состав) заказа

        //public List<string> Errors = new List<string>(); // Список ошибок при работе с заказом
        //public string result { get; set; } // Результат 

        //public Order()
        //{
            //ExtTT = new TT();
            //Cash = new Cash();
        //}

        public Order()
        {
            Dishes = new List<Dish>();
        }

        // Метод расчёта общей стоимости предзаказа
        public string Total()
        {
            var total = 0;
            foreach (var dish in Dishes)
            {
                total += int.Parse(dish.Summ());
            }

            return total.ToString();
        }
    }
}
