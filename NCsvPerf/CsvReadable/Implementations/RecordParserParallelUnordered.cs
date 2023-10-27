﻿namespace Knapcode.NCsvPerf.CsvReadable
{
    /// <summary>
    /// Package: https://www.nuget.org/packages/recordparser
    /// Source: https://github.com/leandromoh/RecordParser
    /// </summary>
    public class RecordParserParallelUnordered : RecordParser
    {
        public RecordParserParallelUnordered(ActivationMethod activationMethod) : base(activationMethod, parallel: true, ensureOriginalOrdering: false)
        {
        }
    }
}