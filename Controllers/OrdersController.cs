using Microsoft.AspNetCore.Mvc;
using WebApplication3.Data;
using WebApplication3.Models;
using System.Linq;

namespace WebApplication3.Controllers
{
    public class OrdersController : Controller
    {
        private readonly ApplicationDbContext _context;

        /// <summary>
        /// Конструктор
        /// </summary>
        /// <param name="context">контекст базы данных</param>
        public OrdersController(ApplicationDbContext context)
        {
            _context = context;
        }

        // GET: Orders/Create
        /// <summary>
        /// Метод для отображения формы создания заказа
        /// </summary>
        /// <returns></returns>
        public IActionResult Create()
        {
            return View();
        }

        /// <summary>
        ///  Метод для создания записи заказа
        /// </summary>
        /// <param name="order">данные о заказе</param>
        /// <returns></returns>
        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Create(Order order)
        {
            if (ModelState.IsValid)
            {
                // Установите PickupDate в UTC
                order.PickupDate = DateTime.SpecifyKind(order.PickupDate, DateTimeKind.Utc);

                _context.Orders.Add(order);
                _context.SaveChanges();
                return RedirectToAction(nameof(Index));
            }
            return View(order);
        }

        // GET: Orders
        /// <summary>
        /// Метод для отображения списка всех заказов
        /// </summary>
        /// <returns></returns>
        public IActionResult Index()
        {
            var orders = _context.Orders.ToList();
            return View(orders);
        }

        // GET: Orders/Details/5
        /// <summary>
        /// Метод для отображения деталей конкретного заказа по его ID
        /// </summary>
        /// <param name="id">номер заказа</param>
        /// <returns></returns>
        public IActionResult Details(int id)
        {
            var order = _context.Orders.FirstOrDefault(o => o.Id == id);
            if (order == null)
            {
                return NotFound();
            }
            return View(order);
        }
    }
}