﻿

namespace parser.Core.Habra
{
    class SiteSettings : IParserSettings
    {
        public SiteSettings(int start, int end)
        {
            StartPoint = start;
            EndPoint = end;
        }

        public string BaseUrl { get; set; } = "https://habr.com/ru/all";
        
        public string Prefix { get; set; } = "page{CurrentId}";
        
        public int StartPoint { get; set; }
        
        public int EndPoint { get; set; }
    }
}
