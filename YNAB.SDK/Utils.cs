using System;
using System.Text;

namespace YNAB.SDK
{
  public class Utils
  {
    /// <summary>
    /// Returns the current month (system timezone) in ISO 8601 format (i.e. '2015-12-01')
    /// </summary>
    /// <returns>date as a string</returns>
    public static string GetCurrentMonthInISOFormat()
    {
      return DateTime.Now.ToString("yyyy-MM-01");
    }

    /// <summary>
    /// Returns the current date (system timezone) in ISO 8601 format (i.e. '2015-12-15')
    /// </summary>
    /// <returns>date as a string</returns>
    public static string GetCurrentDateInISOFormat()
    {
      return DateTime.Now.ToString("yyyy-MM-dd");
    }

    /// <summary>
    /// Converts a milliunits amount to a currency amount.static See <a href="https://api.youneedabudget.com/#formats">YNAB API Docs<a/> for more detail.
    /// </summary>
    /// <param name="milliunits"> The milliunits amount (i.e. 293294)</parameter>
    /// <param name="currencyDecimalDigits"> The number of decimals in the currency (i.e. 2 for USD)</parameter>
    /// <returns>currency amount.static</returns>
    public static string ConvertMilliUnitsToCurrencyAmount(long milliunits, int currencyDecimalDigits = 2) {
      var formatString = new StringBuilder("{0:0.");
      for(int i=0; i<currencyDecimalDigits; i++) { formatString.Append("0"); }
      formatString.Append("}");
      var numberToRoundTo = Math.Pow(10, 3 - Math.Min(3, currencyDecimalDigits));
      numberToRoundTo = 1 / numberToRoundTo;
      var rounded = Math.Round(milliunits * numberToRoundTo) / numberToRoundTo;
      var currencyAmount = rounded * (0.1 / Math.Pow(10, 2));
      return string.Format(formatString.ToString(), currencyAmount);
    }
  }
}
