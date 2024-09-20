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
    public class ScheduleController : ControllerBase
    {
        readonly DataContext _context;

        public ScheduleController(DataContext context)
        {
            _context = context;
        }

        [HttpPost("{id}")]
        public async Task<ActionResult<List<Schedule>>> AddSchedule(ScheduleDto request, int id)
        {
            var Store = _context.Stores.FirstOrDefault(s => s.Id == id);
            var Schedule = new Schedule
            {
                DayOfWeek = request.DayOfWeek,
                OpenTime = new TimeOnly(request.OpenTimeHour,request.OpenTimeMinute),
                CloseTime = new TimeOnly(request.CloseTimeHour, request.CloseTimeMinute),
                CreateTimestamp = DateTime.Now,
                UpdateTimestamp = DateTime.Now,
                Store = Store
            };


            _context.Schedules.Add(Schedule);
            await _context.SaveChangesAsync();
            return Ok(await _context.Schedules.ToListAsync());
            
        }

        [HttpDelete("{id}")]
        public async Task<ActionResult<List<Schedule>>> DeleteSchedule(int id)
        {
            var scheduleToDelete = _context.Schedules.FirstOrDefault(x => x.Id == id);
            _context.Remove(scheduleToDelete);
            await _context.SaveChangesAsync();
            return Ok(await _context.Schedules.ToListAsync());
        }

    }
}
