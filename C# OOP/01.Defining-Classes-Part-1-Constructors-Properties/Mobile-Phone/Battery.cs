using System;

// Task 3
public enum BatteryType
{
    LiPoly, LiIon, NiCd, NiMH
}

public class Battery
{
    private string model;
    private double hoursIdle;
    private double hoursTalk;
    // Task 3
    private BatteryType batteryType;

    internal Battery()
    {
    }

    public Battery(string model, double hoursIdle, double hoursTalk, BatteryType batteryType) 
    {
        this.Model = model;
        this.HoursIdle = hoursIdle;
        this.HoursTalk = hoursTalk;
        this.BatteryType = batteryType;
    }

    // Task 5
    public string Model
    {
        get { return this.model; }
        set
        {
            if (String.IsNullOrEmpty(value))
                throw new ArgumentException("Invalid battery model!");
            this.model = value;
        }
    }

    public double HoursIdle
    {
        get { return this.hoursIdle; }
        set
        {
            if (value < 0 || value > Int32.MaxValue)
                throw new ArgumentException("Invalid hours of idling!");
            this.hoursIdle = value;
        }
    }

    public double HoursTalk
    {
        get { return this.hoursTalk; }
        set
        {
            if (value < 0 || value > Int32.MaxValue)
                throw new ArgumentException("Invalid hours of talking!");
            this.hoursTalk = value;
        }
    }

    // Task 3
    public BatteryType BatteryType {
        get { return this.batteryType; }
        set
        {
            if (value.ToString() != "LiPoly" && value.ToString() != "LiIon" && value.ToString() != "NiCd" && value.ToString() != "NiMH")
                throw new ArgumentException("Invalid battery type!");
            this.batteryType = value;
        }
    }
}