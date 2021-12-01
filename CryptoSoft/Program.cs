using System;
using System.IO;
using System.Linq;
using System.Configuration;
using System.Collections.Generic;

namespace CryptoSoft
{
    class Program
    {
        static void Main(string[] args)
        {
            

            if (args.Count() != 2 && false)
                Environment.Exit(-1);

            string source = args[0];
            string target = args[1];

            Program app = new Program();
            string key = app.LoadKey();


            
            byte[] content = app.Cipher(source, key);

            app.Save(target, content);

            Environment.Exit(0);
        }

        private void Save(string path, byte[] content)
        {
            try
            {
                File.WriteAllBytes(path,content);
            }
            catch
            {
                Environment.Exit(-1);
            }
        }

        public string LoadKey()
        {

            string key = ConfigurationManager.AppSettings.Get("cipherKey");
            if (key.Length < 64)
                Environment.Exit(-1);

            return key;

        }

        public byte[] GetFileContent(string path)
        {
            try
            {
                return File.ReadAllBytes(path);
            }
            catch  {
                Environment.Exit(-1);
            }
            return null;
        }

        public byte[] Cipher(string path, string key)
        {

            byte[] file = this.GetFileContent(path);
            List<Byte> cipher = new List<Byte>();

            for(int i = 0; i< file.Length; i++)
            {
                byte a = file[i];
                char b = key[i % key.Length];
                byte result = (byte)(a ^ b);

                cipher.Add(result);
            }
            return cipher.ToArray();
        }


    }
}
