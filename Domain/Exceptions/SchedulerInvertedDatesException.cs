namespace Domain.Exceptions;

public class SchedulerInvertedDatesException : Exception
{
    public SchedulerInvertedDatesException(string message = "Schedule should not starts after it ends") : base(message)
    {

    }
}

