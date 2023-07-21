using System;

public static class PhoneNumber
{
    public static (bool IsNewYork, bool IsFake, string LocalNumber) Analyze(string phoneNumber)
    {
        bool isNewYork = (phoneNumber.StartsWith("212"));
        bool isFake = phoneNumber.Substring(4, 3) == "555";
        string LocalNumber = phoneNumber.Substring(8, 4);
        return (isNewYork, isFake, LocalNumber);
    }

    public static bool IsFake((bool IsNewYork, bool IsFake, string LocalNumber) phoneNumberInfo) => 
        phoneNumberInfo.IsFake;
    
}
