﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;


namespace RKNet_Model
{
    public class OrderType
    {
        [Key]
        public int Id { get; set; }
        public string Name { get; set; }
    }
}