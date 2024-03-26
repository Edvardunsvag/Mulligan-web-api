using System.Globalization;

namespace MulliganApi.Util;

public interface IHelperFunctions
{
    string FormatNorwegianDate(DateTime date);
    string ScoreBasedOnCoursePar(int numStrokes, int par);
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

    public string ScoreBasedOnCoursePar(int numStrokes, int par)
    {
        var score = Math.Abs(numStrokes - par);
        string formattedScore;
        if (numStrokes > par)
        {
            formattedScore = $"+{score}";
        }
        else if (numStrokes < par)
        {
            formattedScore = $"-{score}";
        }
        else
        {
            formattedScore = "E";
        }

        return formattedScore;
    }
}

