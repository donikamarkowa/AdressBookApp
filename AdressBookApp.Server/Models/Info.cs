﻿namespace AdressBookApp.Server.Models
{
    public class Info
    {
        public string Seed { get; set; } = null!;
        public int Results { get; set; }
        public int Page { get; set; }
        public string Version { get; set; } = null!;
    }
}
