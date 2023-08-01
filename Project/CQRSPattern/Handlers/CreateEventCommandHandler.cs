using Project.Models;

namespace Project.CQRSPattern.Handlers
{
    public class CreateEventCommandHandler
    {
        private readonly CalendarContext context;

        public CreateEventCommandHandler(CalendarContext context)
        {
            this.context = context;
        }
        public void Handle(Event command)
        {
            context.Events.Add(new Event
            {
               Start=command.Start,
               End=command.End,
               Text=command.Text,
               Color=command.Text
            });
            context.SaveChanges();
        }
    }
}
