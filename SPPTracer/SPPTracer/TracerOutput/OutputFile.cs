using System;
using System.Collections.Generic;
using System.IO;
using System.Text;

namespace SPPTracer
{
    public class OutputFile : IOutput
    {
        public void output(string xmlRes, string jsonRes)
        {
            File.WriteAllText(@"F:\path.json", jsonRes);
            File.WriteAllText(@"F:\path.xml", xmlRes);
        }
    }
}
