﻿using Microsoft.Azure.Mobile.Server;

namespace MsorLiService.DataObjects
{
    public class ItemImage : EntityData
    {
        public string ItemId { get; set; }
        public string Url { get; set; }
    }
}