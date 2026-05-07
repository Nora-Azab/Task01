// from claude : decimal is prefered for money ^^
const decimal smallPrice = 250m;
const decimal largePrice = 350m;
const decimal taxRate = 0.14m;  // 14%
int smallCarpets;
int largeCarpets;

Console.Write("Number of small carpets: ");//3
smallCarpets = Convert.ToInt32(Console.ReadLine());

Console.Write("Number of large carpets: ");//1
largeCarpets = Convert.ToInt32(Console.ReadLine());

Console.WriteLine($"Price per small room: ${smallPrice}");
Console.WriteLine($"Price per large room: ${largePrice}");

//I made cost (var) because when i change the "smallPrice" to be double -> cost will be casted to double automatically ^^
//var cost = (smallCarpets * smallPrice) + (largeCarpets * largePrice);
// claude : explicit casting is better
decimal cost = (smallCarpets * smallPrice) + (largeCarpets * largePrice);
Console.WriteLine($"Cost : ${cost}");


decimal tax = cost * taxRate;
Console.WriteLine($"Tax : ${tax}");
Console.WriteLine("========================================");
Console.WriteLine($"Total estimate: ${cost + tax}");
Console.WriteLine("This estimate is valid for 30 days");

