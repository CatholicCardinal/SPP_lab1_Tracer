using System;
using System.Collections.Generic;
using System.Text;
using System.Text.Json.Serialization;
using System.Xml.Serialization;

namespace CPP_Tracer
{
    public interface ITracer
    {

        void StartTrace();

        void StopTrace();

        List<List<TraceResult>> GetTraceResult();
    }
}
