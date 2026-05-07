#region task01
//// from claude : decimal is prefered for money ^^
//const decimal smallPrice = 250m;
//const decimal largePrice = 350m;
//const decimal taxRate = 0.14m;  // 14%
//int smallCarpets;
//int largeCarpets;

//Console.Write("Number of small carpets: ");//3
//smallCarpets = Convert.ToInt32(Console.ReadLine());

//Console.Write("Number of large carpets: ");//1
//largeCarpets = Convert.ToInt32(Console.ReadLine());

//Console.WriteLine($"Price per small room: ${smallPrice}");
//Console.WriteLine($"Price per large room: ${largePrice}");

////I made cost (var) because when i change the "smallPrice" to be double -> cost will be casted to double automatically ^^
////var cost = (smallCarpets * smallPrice) + (largeCarpets * largePrice);
//// claude : explicit casting is better
//decimal cost = (smallCarpets * smallPrice) + (largeCarpets * largePrice);
//Console.WriteLine($"Cost : ${cost}");


//decimal tax = cost * taxRate;
//Console.WriteLine($"Tax : ${tax}");
//Console.WriteLine("========================================");
//Console.WriteLine($"Total estimate: ${cost + tax}");
//Console.WriteLine("This estimate is valid for 30 days");




#endregion

#region task02
/// (Standard numeric format)
/// 
/// int X = 10;
/// int Y = 20;
/// Console.WriteLine($"Equation: {X} + {Y} = {X + Y:C}");
/// 
/// 
/// in one(1) pdf page:
/// 1.why the output of this Equation = $30.00?
///      :C   => is applied to (x+y) "currency"
///      it adds a currency symbol "$"
/// 
/// 2. what is its benefit?
///     No need to manually add $, €, £ ...    "C" adds it automatically based on culture.
/// 
/// 3. try another example with a different specifier with a screenshot of the output.
int x = 10;
int y = 20;
Console.WriteLine($"Equation: {x} + {y} = {x + y:F3}"); //30.000
//__________________________________________________
/*
Standard numeric format:
///     standard numeric format strings control how numbers are converted to text
///     {format_specifier}{precision}
C => Currency
D => Decimal (integers only)
E => Scientific
F => fixed-point
G => general
N => Number
P => percent
R => round-trip
X => Hexadecimal
B => binary

 */

//int x = 10;
//int y = 20;
//Console.WriteLine($"Equation: {x} + {y} = {x + y:C}"); //$30.00
//Console.WriteLine(1237647.679.ToString("C2"));//$1,237,647.68  =>  it adds a currency symbol, thousand separators, and fixed decimal places.

//Console.WriteLine($"Equation: {x} + {y} = {x + y:D5}"); //00030  => all num will be represented in 5 digits
//Console.WriteLine($"Equation: {x} + {y} = {x + y:E2}"); //3.00E+001
//Console.WriteLine($"Equation: {x} + {y} = {x + y:F3}"); //30.000
//Console.WriteLine($"Equation: {x} + {y} = {x + y:G}"); //30     => it lets C# decide whether to display the number in fixed-point or scientific notation, whichever is shorter and more readable.

//Console.WriteLine($"Equation: {x} + {y} = {x + y:N4}"); //30.0000
//Console.WriteLine((123456789.92345).ToString("N2"));//123,456,789.92 =>  make the num readable, percision : for num after comma
//Console.WriteLine((123456789.92345).ToString("N0"));//123,456,790    => after comma with rounding

//Console.WriteLine($"Equation: {x} + {y} = {x + y:p}"); //3,000.00%

//Console.WriteLine($"Equation: {x} + {y} = {x + y:R}"); //30
//Console.WriteLine(1.2345678901234567.ToString("R"));//1.2345678901234567
//"R" guarantees that if you convert a number to string → back to number, you get the exact same bits.

//Console.WriteLine($"Equation: {x} + {y} = {x + y:x}"); //1e
//Console.WriteLine($"Equation: {x} + {y} = {x + y:B}"); //11110




#endregion