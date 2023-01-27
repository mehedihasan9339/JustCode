public static string dayOfProgrammer(int year)
{
    int programmerDay;

    if (year >= 1919)
    {
        //gregorian
        var isLeapYear = year % 400 == 0 ? true : year % 4 == 0 && year % 100 != 0 ? true : false;
        int feb = isLeapYear ? 29 : 28;
        int totalDays = DateTime.DaysInMonth(year, 1) +
                        feb +
                        DateTime.DaysInMonth(year, 3) +
                        DateTime.DaysInMonth(year, 4) +
                        DateTime.DaysInMonth(year, 5) +
                        DateTime.DaysInMonth(year, 6) +
                        DateTime.DaysInMonth(year, 7) +
                        DateTime.DaysInMonth(year, 8);

        programmerDay = 256 - totalDays;
    }
    else if (year <= 1917)
    {
        //julian-4
        var isLeapYear = year % 4 == 0 ? true : false;
        int feb = isLeapYear ? 29 : 28;
        int totalDays = DateTime.DaysInMonth(year, 1) +
                        feb +
                        DateTime.DaysInMonth(year, 3) +
                        DateTime.DaysInMonth(year, 4) +
                        DateTime.DaysInMonth(year, 5) +
                        DateTime.DaysInMonth(year, 6) +
                        DateTime.DaysInMonth(year, 7) +
                        DateTime.DaysInMonth(year, 8);

        programmerDay = 256 - totalDays;
    }
    else
    {
        var daysTillAug = 230;//  31 + 15 + 31 + 30 + 31 + 30 + 31 + 31
        var programmerDateInSeptember = 0;
        programmerDateInSeptember = 256 - daysTillAug;
        programmerDay = programmerDateInSeptember;
    }


    return programmerDay.ToString() + ".09." + year.ToString();
}