using System.Text;
using Spectre.Console;

Console.OutputEncoding = Encoding.UTF8;

var dateTime = DateTime.Now.ToString("dd/MM/yyyy HH:mm:ss");
var figlet = new FigletText(dateTime).Color(Color.White).Centered();

AnsiConsole.Write(figlet);
