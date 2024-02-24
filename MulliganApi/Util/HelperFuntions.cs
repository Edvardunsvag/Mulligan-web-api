using System.Globalization;

namespace MulliganApi.Util;

public interface IHelperFunctions
{
    string FormatNorwegianDate(DateTime date);
}

public class HelperFuntions : IHelperFunctions
{
    public HelperFuntions()
    {
        
    }
    
    public string FormatNorwegianDate(DateTime date)
    {
        var month = date.Month;
        var day = date.Day;
        var monthName = CultureInfo.GetCultureInfo("no").DateTimeFormat.GetMonthName(month);
        monthName = char.ToUpper(monthName[0]) + monthName.Substring(1);
        var formattedDate = $"{day}. {monthName}";

        return formattedDate;
    }
}

