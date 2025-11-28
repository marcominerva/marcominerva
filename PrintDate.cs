#:package Spectre.Console@0.54.*

using Spectre.Console;

Console.OutputEncoding = System.Text.Encoding.UTF8;

var formatted = DateTime.Now.ToString("dd/MM/yyyy HH:mm:ss");
var figlet = new FigletText(formatted).Color(Color.White).Centered(); 

AnsiConsole.Write(figlet);
