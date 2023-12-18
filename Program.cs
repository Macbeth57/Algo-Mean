/*You will be given an array which will include both integers and characters.

Return an array of length 2 with a[0] representing the mean of the ten integers as a floating point number. There will always be 10 integers and 10 characters. Create a single string with the characters and return it as a[1] while maintaining the original order.

lst = ['u', '6', 'd', '1', 'i', 'w', '6', 's', 't', '4', 'a', '6', 'g', '1', '2', 'w', '8', 'o', '2', '0']

Here is an example of your return

[3.6, "udiwstagwo"]

In C# and Java the mean return is a double.
*/

using System;

public class Kata
{
  public static object[] Mean(char[] lst)
  {
    object[] result = new object[2];
    int totalValue = 0;
    string totalChar = ""; 

    foreach(char charac in lst)
    {

        if(char.IsDigit(charac))
        {
            totalValue += int.Parse(charac.ToString());
        }
        else
        {
            totalChar += charac;
        }

    }

    result[0] = Convert.ToDouble(totalValue / 10.0);
    result[1] = totalChar;

    return result;
  }
}

//test
