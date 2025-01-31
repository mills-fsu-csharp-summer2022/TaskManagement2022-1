﻿using Library.Standard.ToDo.Utility;
using Newtonsoft.Json;
using System;

namespace Library.TaskManagement.Models
{
    [JsonConverter(typeof(ItemJsonConverter))]
    public partial class ToDo: Item
    {

        public DateTime Deadline { get; set; }
        public int AssignedUser { get; set; }
        public bool Completed { get; set; }

        public ToDo()
        {

        }

        public override string ToString()
        {
            return $"{Id} {Deadline:d} - {Name} :: {Description}";
        }
    }
}