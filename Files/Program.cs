// See https://aka.ms/new-console-template for more information


using System.Globalization;
using System.Text;


var stringDate = "2023-04-12";
DateTime.TryParseExact(stringDate, "YYYY-MM-DD", CultureInfo.InvariantCulture, DateTimeStyles.None, out var date);


DateTime d = DateTime.Now;
DateTime d1 = DateTime.UtcNow;

File.WriteAllText("test.txt", d.ToString());

// Console.Write($"{d:}");
// dsfsdf

Console.Write(d);