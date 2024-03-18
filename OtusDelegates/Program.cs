// See https://aka.ms/new-console-template for more information
using OtusDelegates;
using System.Globalization;

Console.WriteLine("Hello, World!");

//File search
FileFinder ff = new FileFinder();
ff.FileFound += (s, e) =>
{
    Console.WriteLine($"File has been found. File name: {e.FileName}");
};

string directory = @"C:\";

ff.SearchFiles("directory");



//Max element search
List<string> numbersAsString = new()
{
  "3.54", "45.88", "-45.788", "5654.08", "5667.5", "0"
};

Func<string, float> convertToNumber = (n) =>
{
    return float.Parse(n, CultureInfo.InvariantCulture.NumberFormat);
};

string maxElem = numbersAsString.GetMax(convertToNumber);