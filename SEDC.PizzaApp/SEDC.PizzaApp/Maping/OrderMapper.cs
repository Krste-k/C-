using SEDC.PizzaApp.Models.Domain;
using SEDC.PizzaApp.Models.ViewModels;
using SEDC.PizzaApp.Models.ViewModels;
namespace SEDC.PizzaApp.Maping
{
	public static class OrderMapper
	{
		public static OrderViewModels ToOrderViewModel(Order order)
		{ 
			return new OrderViewModels()
			     {
			        	PizzaNames = order.Pizza.Name,
						UserFullName = $"{order.User.FirstName} {order.User.LastName}",
						PaymentMethod = order.PaymentMethod,
						Price = order.Pizza.Price + 50,

				};
		}
		}
}
