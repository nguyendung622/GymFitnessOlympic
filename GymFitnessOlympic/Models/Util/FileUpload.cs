using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;

namespace GymFitnessOlympic.Models.Util
{
    class FileUpload
    {
        public static string uploadImage(string fileName) { 
            string dest =Directory.GetCurrentDirectory()+"\\image\\"+RandomString(20)+".jpg";
            
            var output = File.Open(dest, FileMode.OpenOrCreate);
            Stream outputStream = new FileStream(dest, FileMode.Create);
            StreamUtilities.CopyFromFile(fileName, outputStream);
            StreamUtilities.CopyToFile(outputStream, output.Name);
            
            return dest;
        }
        
        public static string RandomString(int length)
        {
            const string chars = "ABCDEFGHIJKLMNOPQRSTUVWXYZ0123456789";
            var random = new Random();
            return new string(Enumerable.Repeat(chars, length)
              .Select(s => s[random.Next(s.Length)]).ToArray());
        }
    }
}
