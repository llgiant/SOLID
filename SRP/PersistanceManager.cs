using System;
using System.Collections.Generic;
using System.IO;
using System.Text;

namespace SRP
{
    public class PersistanceManager
    {
        public void SaveToFile(Journal journal, string FileName, bool overwrite = false)
        {
            if (overwrite || !File.Exists(FileName))
            {
                journal.ToString();
            }
        }
    }
}
