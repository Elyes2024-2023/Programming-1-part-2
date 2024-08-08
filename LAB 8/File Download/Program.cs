using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace File_Download
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string webUrlFile = "http://uniduna.com/file.txt"; 
            string localFilePath = "C:\\Downloads\\file.txt"; 

            FileDownloader fileDownloader = new FileDownloader(webUrlFile, localFilePath);
            fileDownloader.StartFileDownload();

            Console.ReadLine();
        }
    }
}
