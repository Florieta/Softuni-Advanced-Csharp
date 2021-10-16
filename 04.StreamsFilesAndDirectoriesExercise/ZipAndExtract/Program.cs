using System;
using System.IO.Compression;

namespace ZipAndExtract
{
    class Program
    {
        static void Main(string[] args)
        {
            ZipFile.CreateFromDirectory(@"C:\Users\Aspire\source\repos\StreamsFilesAndDirectories\resourceLab",
                @"C:\Users\Aspire\source\repos\StreamsFilesAndDirectories\Test\Archive.zip");

            ZipFile.ExtractToDirectory(@"C:\Users\Aspire\source\repos\StreamsFilesAndDirectories\Test\Archive.zip", 
                @"C:\Users\Aspire\source\repos\StreamsFilesAndDirectories\Test");
        }
    }
}
