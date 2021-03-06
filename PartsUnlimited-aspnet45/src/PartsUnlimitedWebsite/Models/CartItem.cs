﻿using System;
using System.ComponentModel.DataAnnotations;

namespace PartsUnlimited.Models
{
    public class CartItem : ILineItem
    {
        //My second attempt to commit a change.
        //Addtional change to check comment added
        [Key]
        public int CartItemId { get; set; }

        [Required]
        public string CartId { get; set; }
        public int ProductId { get; set; }
        public int Count { get; set; }

        [DataType(DataType.DateTime)]
        public DateTime DateCreated { get; set; }

        public virtual Product Product { get; set; }
    }
}