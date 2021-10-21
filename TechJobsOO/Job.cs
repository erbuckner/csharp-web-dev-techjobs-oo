using System;
using System.Reflection;

namespace TechJobsOO
{
    public class Job
    {
        public int Id { get; }
        private static int nextId = 1;

        public string Value { get; set; }
        public Employer EmployerName { get; set; }
        public Location EmployerLocation { get; set; }
        public PositionType JobType { get; set; }
        public CoreCompetency JobCoreCompetency { get; set; }

        // TODO: Add the two necessary constructors.
        // Done!
        public Job()
        {
            Id = nextId;
            nextId++;
        }

        public Job (string value, Employer employerName, Location employerLocation, PositionType jobType, CoreCompetency jobCompetency) : this()
        {
            Value = value;
            EmployerName = employerName;
            EmployerLocation = employerLocation;
            JobType = jobType;
            JobCoreCompetency = jobCompetency;
        }

        // TODO: Generate Equals() and GetHashCode() methods.
        // Done!
        public override bool Equals(object obj)
        {
            return obj is Job job &&
                   Id == job.Id;
        }

        public override int GetHashCode()
        {
            return HashCode.Combine(Id);
        }


        //function to check for null or "" and replace with "Data not available"
        private static string defaultValue(string str)
        {
            return str != null && str != "" ? str : "Data not available";
        }

        //override of ToString to print a formatted list while using the above function to check for null or ""
        //BONUS: Checks to see if job postings have any values other than ID, returns message if no
        public override string ToString()
        {

            if (this.Id != 0 && this.Value == "Data not available" && this.EmployerName.Value == "Data not available" && this.EmployerLocation.Value == "Data not available" && this.JobType.Value == "Data not available" && this.JobCoreCompetency.Value == "Data not available")
            {
                return "OOPS! This job does not seem to exist.";
            }

            return $"\nID: {this.Id} \n" +
                $"Name: {defaultValue(this.Value)} \n" +
                $"Employer: {defaultValue(this.EmployerName.Value)} \n" +
                $"Location: {defaultValue(this.EmployerLocation.Value)} \n" +
                $"Position Type: {defaultValue(this.JobType.Value)} \n" +
                $"Core Competency: {defaultValue(this.JobCoreCompetency.Value)} \n"; 
        }

    }
}
