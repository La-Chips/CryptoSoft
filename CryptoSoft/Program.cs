using System;
using System.IO;
using System.Linq;
using System.Configuration;


namespace CryptoSoft
{
    class Program
    {
        static void Main(string[] args)
        {
            if (args.Count() != 2)
                Environment.Exit(-1);

            
        }

        public string LoadKey()
        {

            var appSettings = ConfigurationManager.AppSettings;
            return "";

        }

        public FileInfo GetFile(string path)
        {
            FileInfo file = new FileInfo(path);
            if (!file.Exists)
                Environment.Exit(-1);
            return file;
        }

        public string Cipher()
        {
            return "";
        }

        public string Uncipher()
        {
            return "";
        }


    }
}
