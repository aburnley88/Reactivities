using Domain.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Persistence;

namespace API.Controllers
{
    public class ActivitiesController : BaseApiController
    {
        private readonly ApplicationDbContext _context;
        public ActivitiesController(ApplicationDbContext context)
        {
            _context = context;
        }

        [HttpGet]
        public async Task<ActionResult<List<Activity>>> GetActivities() => await _context.Activities.ToListAsync();

        [HttpGet("{id:guid}")]
        public async Task<ActionResult<Activity?>> GetActivityById(Guid id) => await _context.Activities.FindAsync(id);

    }
}
