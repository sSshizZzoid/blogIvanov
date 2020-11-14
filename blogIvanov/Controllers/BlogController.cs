using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace blogIvanov.Controllers
{
    /// <summary>
    /// Контроллер для работы с блогом
    /// </summary>
    public class BlogController : Controller
    {
        /// <summary>
        /// Переход на раздел блога
        /// </summary>
        /// <returns></returns>
        public IActionResult Index()
        {
            return View();
        }
    }
}
