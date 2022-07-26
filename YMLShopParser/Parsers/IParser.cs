﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using YMLShopParser.Dto;

namespace YMLShopParser.Parsers
{
    internal interface IParser
    {
        List<OfferDto> Parse(string doc);
    }
}