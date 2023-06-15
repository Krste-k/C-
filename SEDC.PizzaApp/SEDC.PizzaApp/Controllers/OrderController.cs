using Microsoft.AspNetCore.Mvc;
using SEDC.PizzaApp.Maping;
using SEDC.PizzaApp.Models.Domain;
using SEDC.PizzaApp.Models.ViewModels;

namespace SEDC.PizzaApp.Controllers
{
	public class OrderController : Controller
	{
		public IActionResult Index()
		{

			List<Order> ordersFromDb = StaticDb.Orders;


			List<OrderViewModels> orderViewModels = new List<OrderViewModels>();
			foreach (Order order in ordersFromDb)
			{
				//var temporaryOrderViewModels = new OrderViewModels()
				//{
				//	PizzaNames = order.Pizza.Name,
				//	UserFullName = $"{order.User.FirstName} {order.User.LastName}",
				//	PaymentMethod = order.PaymentMethod,
				//	Price = order.Pizza.Price,

				//};

				//orderViewModels.Add(OrderMapper);
			}


			//----Manual Maping With LINQ---\\

			//List<OrderViewModels> orderViewModels = ordersFromDb.Select((order) => new OrderViewModels
			//{
			//	PizzaNames = order.Pizza.Name,
			//	UserFullName = $"{order.User.FirstName} {order.User.LastName}",
			//	PaymentMethod = order.PaymentMethod,
			//	Price = order.Pizza.Price

			//}).ToList();

			List<OrderViewModels> orderViewModels1 = ordersFromDb.Select(order => OrderMapper.ToOrderViewModel(order)).ToList();

			return View(orderViewModels);
		}

	}

}
