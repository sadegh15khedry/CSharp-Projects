// See https://aka.ms/new-console-template for more information
//Console.WriteLine("Hello, World!");

using NodaTime;
using NodaTime.Text;

var timer = new PeriodicTimer(TimeSpan.FromSeconds(1));

/*int count = 0;
while (await timer.WaitForNextTickAsync())
{
    Console.WriteLine(DateTime.Now);
    count++;
    if (count == 10)
    {
        timer.Dispose();
        break;
    }
}

Console.WriteLine("all done");*/

// Define the input format and time zone
var pattern = LocalDateTimePattern.CreateWithInvariantCulture("yyyy/MM/dd HH:mm");
var timeZone = DateTimeZoneProviders.Tzdb["Europe/Warsaw"];
// Parse the input string
var parseResult = pattern.Parse("2023/06/28 16:28");
if (!parseResult.Success)
{
    // Handle parsing error
}
// Get the local date and time value
var localDateTime = parseResult.Value;
// Convert it to a zoned date and time value in the given time zone
var zonedDateTime = localDateTime.InZoneLeniently(timeZone);
// Convert it to an instant, which represents a point in time in UTC
var instant = zonedDateTime.ToInstant();
// Print the results
Console.WriteLine($"Localdateandtime:{localDateTime}");
Console.WriteLine($"Zoned date and time: {zonedDateTime}");
Console.WriteLine($"Instant: {instant}");
