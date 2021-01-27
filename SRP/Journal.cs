using System;
using System.Collections.Generic;
using System.IO;
using System.Text;

namespace SRP
{
    public class Journal
    {
        private readonly List<string> entries = new List<string>();
        private static int count = 0;

        public void AddEntry(string text)
        {
            entries.Add($"{++count} : {text}");
        }
        public void RemoveEntry(int index)
        {
            entries.RemoveAt(index);
        }
        
        public void Save(string FileName, bool overwrite = false)
        {
            File.WriteAllText(FileName, ToString());
        }
    }
}
