
namespace RKNet_Model
{
    public class ApiServerSettings
    {
        public int Id { get; set; }
        public bool CashClientsAutoUpdate { get; set; } = false;
        public string DeliveryClubLogin { get; set; }
        public string DeliveryClubPassword { get; set; }
        public string YandexEdaLogin { get; set; }
        public string YandexEdaPassword { get; set; }
    }
}
