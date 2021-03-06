﻿using System;
using System.Collections.Generic;

namespace Petir
{
    public class UserScript
    {
        public enum ValueType
        {
            Script,
            StyleSheet
        }

        public ValueType Type = ValueType.Script;

        public string Name { get; set; } = String.Empty;

        public string Path { get; set; }

        public string Author { get; set; } = String.Empty;

        public string Version { get; set; }

        // Array for require properties
        public Dictionary<string, string> Require { get; set; }

        public string Description { get; set; } = String.Empty;

        public string UpdateUrl { get; set; }

        // URLs for the script to be run on
        public string[] Include { get; set; } = new string[0];

        public string[] Exclude { get; set; } = new string[0];

        // Will be used when checking for updates after ... days after installation
        public DateTime InstallDate { get; set; }

        public bool Enabled { get; set; }

        public bool RequiresApi { get; set; } = true;

        public Dictionary<string, string> SavedValues { get; set; }

        public Dictionary<string, string> Resources { get; set; }

        //public List<NameFunctionPair> MenuCommands { get; set; }

        public bool ShowMenuCommands { get; set; } = true;
    }
}
