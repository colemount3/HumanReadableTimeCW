// See https://aka.ms/new-console-template for more inform
using System;
//limit 99:59:59 or 359999 seconds
public static class TimeFormat
{
    public static void Main()
    {

        //input time in seconds
        int seconds = 59;
        string output = GetReadableTime(seconds);

        Console.WriteLine(output);
    }

    public static string GetReadableTime(int seconds)
    {
        //seconds to hours
        int hours = (seconds / 3600);
       //remaining seconds to min
       int minutes = ((seconds - (hours * 3600)) / 60);
      //Calc remaining seconds
        int sec = (seconds - (hours*3600) - (minutes*60));


        //Convert to string to add leading 0 if needed
        string stringHours = hours.ToString();
        string stringMinutes = minutes.ToString();
        string stringsec = sec.ToString();
        char zero = '0';

        //detect if leading 0 is needed
        if (hours < 10)
        {
           stringHours =  zero + stringHours; ;
        }
        if (minutes < 10) 
        {
           stringMinutes = zero + stringMinutes;
        }
        if (sec < 10) 
        {
            stringsec = zero + stringsec;
        }

        //format result
        string result =$"{stringHours}:{stringMinutes}:{stringsec}";


        //return result
        return result;
    }
  

}