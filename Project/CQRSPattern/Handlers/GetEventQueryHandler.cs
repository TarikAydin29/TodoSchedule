using Microsoft.EntityFrameworkCore;
using Project.CQRSPattern.Results;
using Project.Models;

namespace Project.CQRSPattern.Handlers
{
    public class GetEventQueryHandler
    {
        private readonly CalendarContext context;

        public GetEventQueryHandler(CalendarContext context)
        {
            this.context = context;
        }
        public IQueryable<Event> Handle(DateTime start,DateTime end)
        {
            var values = context.Events.Where(e => !((e.End <= start) || (e.Start >= end)));
          

            return values;
        }
    }
}
