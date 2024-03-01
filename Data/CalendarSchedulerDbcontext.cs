
using Microsoft.EntityFrameworkCore;
using ZencareLTE.Models;

namespace ZencareLTE.Data
{
    public class CalendarSchedulerDbcontext : DbContext
    {


        public CalendarSchedulerDbcontext(DbContextOptions<CalendarSchedulerDbcontext> options)
               : base(options)
        {
        }
        public DbSet<CalendarSchedulerEvent> Events { get; set; } = null!;
    }
}
