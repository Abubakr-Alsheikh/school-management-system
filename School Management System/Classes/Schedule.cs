using System;

public class Schedule {
    public int ScheduleId { get; set; }
    public int ClassId { get; set; }
    public int ClassroomId { get; set; }
    public int SessionId { get; set; }
    public string DayOfTheWeek { get; set; }
    public TimeSpan StartTime { get; set; }
    public TimeSpan EndTime { get; set; }
}