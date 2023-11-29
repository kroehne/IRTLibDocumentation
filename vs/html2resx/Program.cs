using System;
using System.Resources;
using System.IO;
using System.Resources.NetStandard;

namespace ResxFileCreator
{
    class Program
    {
        static void Main(string[] args)
        {

            if (args.Length == 0)
                args = new string[] { "/Users/kroehne/Documents/work/github/IRTLibDocumentation/_site/help/", "/Users/kroehne/Documents/work/github/IRTLibDocumentation/_site/", "branch", "hash" };

            for (int i = 0; i < args.Length; i++)
                Console.WriteLine("Argument " + i + ": " + args[i]);

            string basePath = args[0];
            string outputPath = args[1];

            ResXResourceWriter resx_de_DEU = new ResXResourceWriter(Path.Combine(outputPath, "Help-de-DEU.rex"));
            ResXResourceWriter resx_en_US = new ResXResourceWriter(Path.Combine(outputPath, "Help-en-US.rex"));

            var _files = Directory.GetFiles(basePath);
            foreach (var _f in _files)
            {
                string _filename = Path.GetFileNameWithoutExtension(_f);
                string _key = _filename.Replace("InlineHelp_", "").Replace("_de-DEU", "").Replace("_en-US", "");
                if (_filename.EndsWith("de-DEU"))
                    resx_de_DEU.AddResource(_key, File.ReadAllText(_f));
                else if (_filename.EndsWith("en-US"))
                    resx_en_US.AddResource(_key, File.ReadAllText(_f));
            }

            resx_de_DEU.AddResource("Help-Version-Git-Hash", args[3]);
            resx_en_US.AddResource("Help-Version-Git-Hash", args[3  ]);

            resx_de_DEU.AddResource("Help-Version-Last-Change", DateTime.Now.ToString());
            resx_en_US.AddResource("Help-Version-Last-Change", DateTime.Now.ToString());

            resx_de_DEU.Close();
            resx_en_US.Close();
        }
    }
}
