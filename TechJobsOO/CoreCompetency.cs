﻿using System;
namespace TechJobsOO
{
    public class CoreCompetency
    {
        // TODO: Change the fields to auto-implemented properties.
        // DONE!
        private int id { get; set; }
        private static int nextId = 1;
        private string value { get; set; }


        public CoreCompetency()
        {
            id = nextId;
            nextId++;
        }

        public CoreCompetency(string v) : this()
        {
            value = v;
        }

        public override bool Equals(object obj)
        {
            return obj is CoreCompetency competency &&
                   id == competency.id;
        }

        public override int GetHashCode()
        {
            return HashCode.Combine(id);
        }

        public override string ToString()
        {
            return value;
        }
    }
    }
}
