using System;
using System.Collections.Generic;
using System.Text;

namespace CRPG
{
    public class LootItem
    {
        public Item Details;
        public int DropPercentage;
        public bool isDefaultItem;

        public LootItem(Item details, int dropPercentage, bool isDefaultItem)
        {
            Details = details;
            DropPercentage = dropPercentage;
            this.isDefaultItem = isDefaultItem;
        }
    }
}
