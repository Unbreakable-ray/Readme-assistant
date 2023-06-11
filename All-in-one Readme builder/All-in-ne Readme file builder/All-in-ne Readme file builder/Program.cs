// See https://aka.ms/new-console-template for more information
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace MergeTwoFiles
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string path = @"C:\Users\max\Documents\xx" ;
            

            string[] txtfiles = Directory.GetFiles(path, "*.txt", SearchOption.TopDirectoryOnly);
            using(var txtOutput = File.Create(path+"mergedTxtFile.txt"))
            {
                foreach(var txtfile in txtfiles)
                {
                    using(var txtData = File.OpenRead(txtfile))
                    {
                        txtData.CopyTo(txtOutput);
                        System.IO.File.WriteAllText(@"C:\Users\max\Documents\xx\ff.txt", Convert.ToString(txtOutput));
                    }
                }
            }
        }
    }
}
