﻿using System;
namespace TechJobsOO
{
    public class CoreCompetency
    {
        // TODO: Change the fields to auto-implemented properties.
        // DONE!
        public int Id { get; set; }
        private static int nextId = 1;
        public string Value { get; set; }


        public CoreCompetency()
        {
            Id = nextId;
            nextId++;
        }

        public CoreCompetency(string value) : this()
        {
            Value = value;
        }

        public override bool Equals(object obj)
        {
            return obj is CoreCompetency competency &&
                   Id == competency.Id;
        }

        public override int GetHashCode()
        {
            return HashCode.Combine(Id);
        }

        public override string ToString()
        {
            return Value;
        }
    }
}

