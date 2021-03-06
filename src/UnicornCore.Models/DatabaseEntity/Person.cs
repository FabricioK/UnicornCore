﻿using System;
using UnicornCore.Models.Interfaces;

namespace UnicornCore.Models.DatabaseEntity
{
    public class Person : BaseEntity
    {
        public string Name { get; set; }
        public DateTime Birthday { get; set; }
    }
}