using EventEaseApp.Models; // Import your Event model

namespace EventEaseApp.Services
{
    public class EventService
    {
        private readonly List<Event> _events = new();

        public Task<List<Event>> GetEventsAsync()
        {
            // Return a copy to prevent external modification
            return Task.FromResult(_events.ToList());
        }

        public Task<Event?> GetEventByIdAsync(Guid eventId)
        {
            var evt = _events.FirstOrDefault(e => e.Id == eventId);
            return Task.FromResult(evt);
        }

        public Task<Event> CreateEventAsync(Event newEvent)
        {
            newEvent.Id = Guid.NewGuid();
            _events.Add(newEvent);
            return Task.FromResult(newEvent);
        }

        public Task<bool> DeleteEventAsync(Guid eventId)
        {
            var evt = _events.FirstOrDefault(e => e.Id == eventId);
            if (evt != null)
            {
                _events.Remove(evt);
                return Task.FromResult(true);
            }
            return Task.FromResult(false);
        }
    }
}
