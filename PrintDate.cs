#:package Spectre.Console@0.54.*

using System.Text;
using Spectre.Console;

Console.OutputEncoding = Encoding.UTF8;

var dateTime2 = DateTime.Now.ToString("dd/MM/yyyy HH:mm:ss");
var figlet = new FigletText(dateTime2).Color(Color.White).Centered();

AnsiConsole.Write(figlet);

