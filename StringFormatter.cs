using System.Text;

namespace PointsBet_Backend_Online_Code_Test
{

    /*
    Improve a block of code as you see fit in C#.
    You may make any improvements you see fit, for example:
      - Cleaning up code
      - Removing redundancy
      - Refactoring / simplifying
      - Fixing typos
      - Any other light-weight optimisation
    */
    public static string ToCommaSeparatedList(string[] items, string quote)
    {
        ArgumentNullException.ThrowIfNull(items);
        ArgumentNullException.ThrowIfNull(quote);

        if (items.Length < 1)
        {
            return string.Empty;
        }

        StringBuilder stringBuilder = new($"{quote}{items[0]}{quote}");

        for (int i = 1; i < items.Length; i++)
        {
					//Using separate append statements instead of string interpolation to avoid the slight overhead of creating a string for each item in memory
            stringBuilder
              .Append(", ")
              .Append(quote)
              .Append(items[i])
              .Append(quote);
        }

        return stringBuilder.ToString();
    }
}