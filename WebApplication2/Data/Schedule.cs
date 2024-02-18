using WebApplication2.Data.SeedWork;

namespace WebApplication2.Data
{
    public class Schedule : Entity
    {
        public TimeSlot TimeSlot { get; private set; }
        public bool IsAsync { get; private set; }
        public Schedule()
        {
            
        }
        public Schedule(TimeSlot timeSlot, bool isAsync)
        {
            TimeSlot = timeSlot;
            IsAsync = isAsync;
        }
    }
}
