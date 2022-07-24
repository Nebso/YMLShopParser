using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace YMLParseStoreDeliver.Parsers
{
    internal interface IParseable
    {
        void Parse(string doc);
    }
}
