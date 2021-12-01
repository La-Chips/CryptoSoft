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
            Program app = new Program();
           string key = app.LoadKey();
           
            if (args.Count() != 2)
                Environment.Exit(0);

            
        }

        public string LoadKey()
        {

            string key = ConfigurationManager.AppSettings.Get("cipherKey");
            return key;

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
