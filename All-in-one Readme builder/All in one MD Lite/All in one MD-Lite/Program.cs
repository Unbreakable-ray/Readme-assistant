using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello, MD lite");


string[] files = new string[] { @"C:\Users\max\Desktop\tst combine\2.md", @"C:\Users\max\Desktop\tst combine\5.txt.ink" };

string fileContent = string.Empty;
foreach (var fileName in files)
{
    using (System.IO.StreamReader Reader = new System.IO.StreamReader(fileName))
    {
        fileContent += Reader.ReadToEnd();
    }
}
//fileContent = fileContent.Replace(',', '.');

System.IO.File.WriteAllText(@"C:\Users\max\Desktop\tst combine\4.md", fileContent);

Console.WriteLine("done");