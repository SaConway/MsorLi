﻿using Microsoft.Azure.Mobile.Server;

namespace MsorLiService.DataObjects
{
    public class ItemSubCategory : EntityData
    {
        public string Name { get; set; }
        public string MainCategory { get; set; }
        public int Order { get; set; }
    }
}