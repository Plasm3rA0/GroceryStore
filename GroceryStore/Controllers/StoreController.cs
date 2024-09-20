using GroceryStore.Data;
using GroceryStore.DTOs;
using GroceryStore.Entities;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace GroceryStore.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class StoreController : ControllerBase
    {
        private readonly DataContext _context;

        public StoreController(DataContext context)
        {
            _context = context;
        }

        [HttpPost]
        public async Task<ActionResult<List<Store>>> CreateStore(StoreDto request)
        {
            var newStore = new Store
            {
                Name = request.Name,
                Place = request.Place,
                CreateTimestamp = DateTime.Now,
                UpdateTimestamp = DateTime.Now,
            };
            _context.Stores.Add(newStore);
            await _context.SaveChangesAsync();

            return Ok(await _context.Stores.Include(x => x.Schedules).ToListAsync());
        }

        [HttpGet]
        public async Task<ActionResult<List<Store>>> GetAllStores()
        {
            return Ok(await _context.Stores.Include(x => x.Schedules).ToListAsync());
        }
    }
}
