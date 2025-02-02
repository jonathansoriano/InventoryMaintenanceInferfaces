﻿using System;
using System.Collections.Generic;
using System.Text;

namespace InventoryMaintenance
{
    public class InvItem : IDisplayable
    {
        public InvItem() { } 

        public InvItem(int itemNo, string description, decimal price)
        {
            ItemNo = itemNo;
            Description = description;
            Price = price;
        }

        public int ItemNo { get; set; }
        public string Description { get; set; }
        public decimal Price { get; set; }
        //Jonathan Soriano Sanjuan
        public virtual string GetDisplayText()
        {
            return $"{ItemNo}    {Description} ({Price:c})";
        }

        //public virtual string GetDisplayText() => $"{ItemNo}    {Description} ({Price:c})";
    }
}
