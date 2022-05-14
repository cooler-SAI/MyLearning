double number2;
number2 = double.Parse("34.42", CultureInfo.InvariantCulture);
string invariantNumber2 = number2.ToString(CultureInfo.InvariantCulture);
Console.WriteLine(invariantNumber2);
