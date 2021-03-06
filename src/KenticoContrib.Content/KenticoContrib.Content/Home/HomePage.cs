﻿using KenticoContrib.Content.Metadata;

namespace KenticoContrib.Content.Home
{
    public class HomePage : IPage
    {
        public PageMetadata Metadata { get; set; }
        public int Id { get; set; }
        public string Name { get; set; }
        public string RelativeUrl { get; set; }
    }
}
