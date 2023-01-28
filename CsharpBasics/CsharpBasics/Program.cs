// See https://aka.ms/new-console-template for more information
using CsharpBasics;
using System.Text;

string path = @"C:\source\CSsharpPackages\CsharpFileClassSystemIO\Folders\test.txt";

//File.Create(path, 100, FileOptions.Asynchronous);


//string message = "Alex le BG.";
//await File.WriteAllBytesAsync(path, Encoding.ASCII.GetBytes(message));


//IEnumerable<string> messages = new[]
//{
//    "Follow me on my adventures",
//    "I love to code"
//};
//await File.WriteAllLinesAsync(path, messages);


//var content = await File.ReadAllTextAsync(path);
//Console.WriteLine(content);

//string[] lines = await File.ReadAllLinesAsync(path);
//foreach (var line in lines)
//{
//    Console.WriteLine(line);
//}

//File.Delete(path);

//FileHelper.Append(path, "\n Welcome");

//IEnumerable<string> messages = new[]
//{
//    "Follow me on my adventures",
//    "I love to code"
//};
//FileHelper.AppendAllLines(path, messages.ToArray());

//await FileHelper.AppendAllTextAsync(path, "alexei and his team");

string pathDest = @"C:\source\CSsharpPackages\CsharpFileClassSystemIO\Folders\testCopy.txt";
File.Copy(path, pathDest);

