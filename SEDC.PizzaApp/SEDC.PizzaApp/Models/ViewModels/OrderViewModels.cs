using SEDC.PizzaApp.Models.Enums;
using SEDC.PizzaApp.Models.Domain;
namespace SEDC.PizzaApp.Models.ViewModels
{
    public class OrderViewModels
    {
        public string PizzaNames { get; set; }
        public string UserFullName { get; set; }
        public int Price { get; set; }
        public PaymentMethod PaymentMethod { get; set; }
    }
}
