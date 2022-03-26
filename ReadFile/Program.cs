var textFromFile = File.ReadAllText(@"C:\Users\John Sartain\Documents\visualcodereference\How to read a file with C#\test.txt");

Console.WriteLine(textFromFile);

var allLinesFromFile = File.ReadAllLines(@"C:\Users\John Sartain\Documents\visualcodereference\How to read a file with C#\test.txt");

foreach (var line in allLinesFromFile)
    Console.WriteLine(line);