using System;
using System.Collections.Generic;
using System.Text;

namespace CPP_Tracer
{
    public interface ITraceResultSerializer
    {
        string Serialize(List<Threade> traceResult);
    }
}
