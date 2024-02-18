using WebApplication2.Data.SeedWork;

namespace WebApplication2.Data
{
    public class TimeSlot : Entity
    {
        public DayOfWeek Day { get; private set; }
        public int StartTime { get; private set; }
        public int EndTime { get; private set; }

        public TimeSlot()
        {
            
        }

        public TimeSlot(DayOfWeek day, int startTime, int endTime)
        {
            Day = day;
            StartTime = startTime;
            EndTime = endTime;
        }
    }
}
