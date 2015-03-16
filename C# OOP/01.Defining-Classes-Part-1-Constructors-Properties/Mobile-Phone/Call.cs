using System;

// Task 8
public class Call
{
    private DateTime callDateTime;
    private string calledNumber;
    private int callDuration;

    public Call()
    {
    }

    public Call(DateTime callDateTime, string calledNumber, int callDuration)
    {
        this.CallDateTime = callDateTime;
        this.CalledNumber = calledNumber;
        this.CallDuration = callDuration;
    }

    public DateTime CallDateTime
    {
        get { return this.callDateTime; }
        set { this.callDateTime = value; }
    }

    public string CalledNumber
    {
        get { return this.calledNumber; }
        set { this.calledNumber = value; }
    }

    public int CallDuration
    {
        get { return this.callDuration; }
        set { this.callDuration = value; }
    }
}