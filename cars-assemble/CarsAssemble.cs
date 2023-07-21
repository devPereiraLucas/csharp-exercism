using System;

static class AssemblyLine
{
    private readonly static int _carsPerHour = 221;

    public static double SuccessRate(int speed)
    {
        if (speed >= 1 && speed <= 4)
        {
            return 1.0;
        } else if (speed >= 5 && speed <= 8)
        {
            return 0.9;
        } else if (speed == 9)
        {
            return 0.8;
        } else if (speed == 10)
        {
            return 0.77;
        } else
        {
            return 0;
        }
    }

    public static double ProductionRatePerHour(int speed)
    {
        double successRate = SuccessRate(speed);
        return _carsPerHour * successRate * speed;
    }

    public static int WorkingItemsPerMinute(int speed)
    {
        int workingItemsPerHour = (int)ProductionRatePerHour(speed);
        int workingItemsPerMinute = workingItemsPerHour / 60;
        return workingItemsPerMinute;
    }
}
