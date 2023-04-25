using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RKNet_Model.MSSQL
{
    public class MarketOrder
    {
        public int Id { get; set; }
        public DateTime Created { get; set; }
        public string TTName { get; set; }           
        public int TTCode { get; set; }
        public int FirstMidserver { get; set; }
        public double OrderSum { get; set; }
        public string OrderTypeName { get; set; }
        public int OrderTypeCode { get; set; }
        public string OrderNumber { get; set; }
        public string StatusName { get; set; }
        public int StatusCode { get; set; }
        public string StatusComment { get; set; }
        public DateTime? StatusUpdatedAt { get; set; }
        public string CancelReason { get; set; }
        public string OrderItems { get; set; } // JSON объект List<RKNET_Model.MSSQL.OrderItem>
        public string YandexOrder { get; set; } // JSON объект RKNET_ApiServer.Api.Yandex.Models.OrderPost
        public string DeliveryOrder { get; set; } // JSON объект RKNET_ApiServer.Api.DeliveyClub.Models.OrderWithId
        public string DeliveryAdjustments { get; set; } // JSON массив объектов Api.DeliveryClub.Models.Adjustment
        public string DeliveryNotifications { get; set; } // JSON массив объектов Api.DeliveryClub.Models.Notification



        //-----------------------------------------------------------------------------------------
        // типы заказов
        public static class OrderTypes
        {
            public static MarketOrderType Test = new MarketOrderType { Name = "Тестовый заказ", Code = 0 };
            public static MarketOrderType Yandex = new MarketOrderType { Name = "Яндекс Еда", Code = 1 };
            public static MarketOrderType DeliveryClub = new MarketOrderType { Name = "Delivery Club", Code = 2 };

            public class MarketOrderType
            {
                public string Name;
                public int Code;
            }
        }


        // статусы заказа
        public static class OrderStatuses
        {
            public static class Yandex
            {
                public static MarketOrderStatus NEW = new MarketOrderStatus { Name = "новый", Code = 1, Value = "NEW" };
                public static MarketOrderStatus ACCEPTED_BY_RESTAURANT = new MarketOrderStatus { Name = "принят", Code = 2, Value = "ACCEPTED_BY_RESTAURANT" };
                public static MarketOrderStatus POSTPONED = new MarketOrderStatus { Name = "изменён агрегатором", Code = 3, Value = "POSTPONED" };
                public static MarketOrderStatus COOKING = new MarketOrderStatus { Name = "готовится", Code = 4, Value = "COOKING" };
                public static MarketOrderStatus READY = new MarketOrderStatus { Name = "готов к выдаче", Code = 5, Value = "READY" };
                public static MarketOrderStatus TAKEN_BY_COURIER = new MarketOrderStatus { Name = "выдан", Code = 6, Value = "TAKEN_BY_COURIER" };
                public static MarketOrderStatus DELIVERED = new MarketOrderStatus { Name = "доставлен", Code = 7, Value = "DELIVERED" };
                public static MarketOrderStatus CANCELLED = new MarketOrderStatus { Name = "отменён", Code = 8, Value = "CANCELLED" };
            }

            public static class DeliveryClub
            {
                public static DeliveryClubOrderStatus created = new DeliveryClubOrderStatus { Name = "новый", Code = 1, Value = "created" };
                public static DeliveryClubOrderStatus accepted = new DeliveryClubOrderStatus { Name = "принят", Code = 2, Value = "accepted" };
                public static MarketOrderStatus POSTPONED = new MarketOrderStatus { Name = "изменён агрегатором", Code = 3, Value = "created" }; // у деливери нет такого статуса, это нужно только для клиента
                public static DeliveryClubOrderStatus cooking = new DeliveryClubOrderStatus { Name = "готовится", Code = 4, Value = "cooking" };
                public static DeliveryClubOrderStatus ready = new DeliveryClubOrderStatus { Name = "готов к выдаче", Code = 5, Value = "ready" };
                public static DeliveryClubOrderStatus picked_up = new DeliveryClubOrderStatus { Name = "выдан", Code = 6, Value = "picked_up" };
                public static DeliveryClubOrderStatus delivered = new DeliveryClubOrderStatus { Name = "доставлен", Code = 7, Value = "delivered" };
                public static DeliveryClubOrderStatus restaurant_cancelled = new DeliveryClubOrderStatus { Name = "отменён тт", Code = 8, Value = "restaurant_cancelled" };
                public static DeliveryClubOrderStatus customer_cancelled = new DeliveryClubOrderStatus { Name = "отменён агрегатором", Code = 9, Value = "customer_cancelled" };                               
                public static DeliveryClubOrderStatus on_the_way = new DeliveryClubOrderStatus { Name = "доставляется", Code = 10, Value = "on_the_way" };                                               
            }

            public class MarketOrderStatus
            {
                public string Name;
                public int Code;
                public string Value;
            }

            public class DeliveryClubOrderStatus
            {
                public string Name;
                public int Code;
                public string Value;
            }

            public static List<MarketOrderStatus> YandexStatuses = new List<MarketOrderStatus>()
            {
               new MarketOrderStatus { Name = "новый", Code = 1, Value = "NEW" },
               new MarketOrderStatus { Name = "принят", Code = 2, Value = "ACCEPTED_BY_RESTAURANT" },
               new MarketOrderStatus { Name = "изменён агрегатором", Code = 3, Value = "POSTPONED" },
               new MarketOrderStatus { Name = "готовится", Code = 4, Value = "COOKING" },
               new MarketOrderStatus { Name = "готов к выдаче", Code = 5, Value = "READY" },
               new MarketOrderStatus { Name = "выдан", Code = 6, Value = "TAKEN_BY_COURIER" },
               new MarketOrderStatus { Name = "доставлен", Code = 7, Value = "DELIVERED" },
               new MarketOrderStatus { Name = "отменён", Code = 8, Value = "CANCELLED" }
            };

            public static List<MarketOrderStatus> DeliveryClubStatuses = new List<MarketOrderStatus>()
            {
               new MarketOrderStatus { Name = "новый", Code = 1, Value = "created" },
               new MarketOrderStatus { Name = "принят", Code = 2, Value = "accepted" },
               new MarketOrderStatus { Name = "изменён агрегатором", Code = 3, Value = "created" }, // у деливери нет такого статуса, это нужно только для клиента
               new MarketOrderStatus { Name = "готовится", Code = 4, Value = "cooking" },
               new MarketOrderStatus { Name = "готов к выдаче", Code = 5, Value = "ready" },
               new MarketOrderStatus { Name = "выдан", Code = 6, Value = "picked_up" },
               new MarketOrderStatus { Name = "доставлен", Code = 7, Value = "delivered" },
               new MarketOrderStatus { Name = "отменён тт", Code = 8, Value = "restaurant_cancelled" },               
               new MarketOrderStatus { Name = "отменён агрегатором", Code = 9, Value = "customer_cancelled" },                             
               new MarketOrderStatus { Name = "доставляется", Code = 10, Value = "on_the_way" },                              
            };
        }
        
        // позиция заказа
        public class OrderItem
        {
            public int MenuItemId { get; set; }
            public int RkCode { get; set; }
            public string RkName { get; set; }
            public string MarketName { get; set; }
            public int MenuPrice { get; set; }
            public int MarketPrice { get; set; }
            public int Quantity { get; set; }
            public int TotalCost { get; set; }
        }
        


        //public enum OrderStates : int
        //{
        //    // яндекс
        //    NEW = 1, 
        //    ACCEPTED_BY_RESTAURANT = 2, 
        //    POSTPONED = 3, 
        //    COOKING = 4, 
        //    READY = 5, 
        //    TAKEN_BY_COURIER = 6, 
        //    DELIVERED = 7, 
        //    CANCELLED = 8
        //}
    }
}
