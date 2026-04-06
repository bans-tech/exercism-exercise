public static class Leap
{
    public static bool IsLeapYear(int year) => ((year % 100) == 0 && (year % 400) != 0) ? false : ((year % 4) == 0);
    // {
    //     if ((year % 100) == 0 && (year % 400) != 0)
    //     {
    //         return false;
    //     }
    //     else if ((year % 4) == 0)
    //     {
    //         return true;
    //     }
    //     else 
    //     {
    //         return false;
    //     }            
    // }
}