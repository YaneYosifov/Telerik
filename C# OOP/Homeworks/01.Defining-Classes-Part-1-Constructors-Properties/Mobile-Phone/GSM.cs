using System;
using System.Collections.Generic;
using System.Linq;

// Task 1
public class GSM
{
    private string model;
    private string manufacturer;
    private decimal price;
    private string owner;
    private Battery battery;
    private Display display;
    // Task 9
    private List<Call> callHistory;

    // Task 6
    private static GSM IPhone = new GSM("iPhone 4S", "Apple", 550.90m, "Steve Jobs", "LiPoly", 410, 0.8, BatteryType.LiIon, 3.5, 16000000, null);

    public GSM(string model, string manufacturer)
    {
        this.Model = model;
        this.Manufacturer = manufacturer;
        this.Battery = new Battery();
        this.Display = new Display();
        this.CallHistory = new List<Call>();
    }

    public GSM(string model, string manufacturer, decimal price, string owner, string batteryModel, double batteryHoursIdle, double batteryHoursTalk, BatteryType batteryType, double displaySize, int displayColors, List<Call> callHistory)
        : this(model, manufacturer)
    {
        this.Price = price;
        this.Owner = owner;
        this.Battery.Model = batteryModel;
        this.Battery.HoursIdle = batteryHoursIdle;
        this.Battery.HoursTalk = batteryHoursTalk;
        this.Display.Size = displaySize;
        this.Display.Colors = displayColors;
        this.CallHistory = callHistory;
    }

    // Task 4
    public override string ToString()
    {
        string info = string.Format("Model: {0} \nManufacturer: {1} \nPrice: ${2} \nOwner: {3} \nBattery model: {4} \nBattery hours idle: {5} \nBattery hours talk: {6} \nDisplay size: {7} inches \nNumber of colors: {8}", Model, Manufacturer, Price, Owner, Battery.Model, Battery.HoursIdle, Battery.HoursTalk, Display.Size, Display.Colors);
        return info;
    }

    // Task 5
    public string Model
    {
        get { return this.model; }
        set
        {
            if (String.IsNullOrEmpty(value))
                throw new ArgumentException("Invalid GSM model!");
            this.model = value;
        }
    }

    public string Manufacturer
    {
        get { return this.manufacturer; }
        set
        {
            if (String.IsNullOrEmpty(value))
                throw new ArgumentException("Invalid GSM manufacturer!");
            this.manufacturer = value;
        }
    }

    public decimal Price
    {
        get { return this.price; }
        set
        {
            if (value < 0 || value > Int32.MaxValue)
                throw new ArgumentException("Invalid GSM price!");
            this.price = value;
        }
    }

    public string Owner
    {
        get { return this.owner; }
        set { this.owner = value; }
    }

    public Battery Battery
    {
        get { return this.battery; }
        set { this.battery = value; }
    }

    public Display Display
    {
        get { return this.display; }
        set { this.display = value; }
    }

    public static GSM IPhone4S
    {
        get { return IPhone; }
    }

    // Task 9
    public List<Call> CallHistory
    {
        get { return this.callHistory; }
        set { this.callHistory = value; }
    }

    // Task 10
    public void AddCall(Call newCall)
    {
        callHistory.Add(newCall);
    }

    public void RemoveCall(Call call)
    {
        callHistory.Remove(call);
    }

    public void ClearCallHistory()
    {
        CallHistory.Clear();
    }

    // Task 11
    public decimal CallPriceCalculate(decimal pricePerMinute)
    {
        decimal totalPrice = 0m;
        foreach (var call in CallHistory)
        {
            totalPrice += pricePerMinute * call.CallDuration / 60;
        }
        return totalPrice;
    }
}