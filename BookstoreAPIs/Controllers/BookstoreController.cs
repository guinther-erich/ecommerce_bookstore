using BookstoreAPIs.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Bookstore.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class BookstoreController : ControllerBase
    {
        private readonly ToDoContext _context;

        public BookstoreController(ToDoContext context)
        {
            _context = context;

            _context.todoProducts.Add(new Book { ID = "1", Title = "Libertados!", Price = 12.0, Quantity = 1, Category = "Best Seller", Img = "img1" });
            _context.todoProducts.Add(new Book { ID = "2", Title = "Vai Corinthians!", Price = 19.0, Quantity = 3, Category = "Best Seller", Img = "img2" });
            _context.todoProducts.Add(new Book { ID = "3", Title = "É o Time do Povo!", Price = 19.0, Quantity = 10, Category = "Best Seller", Img = "img3" });
            _context.todoProducts.Add(new Book { ID = "4", Title = "Corinthians minha vida, minha história, meu amor!", Price = 20.0, Quantity = 5, Category = "Best Seller", Img = "img4" });
            _context.todoProducts.Add(new Book { ID = "5", Title = "Contra todo ditador!", Price = 69.0, Quantity = 2, Category = "Best Seller", Img = "img5" });

            _context.SaveChanges();
        }

        [HttpGet]
        public async Task<ActionResult<IEnumerable<Book>>> GetProducts()
        {
            return await _context.todoProducts.ToListAsync();
        }
    }
}
