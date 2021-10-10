using System;
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

        public override string ToString()
        {
            return $"\nID: {this.Id} \n" +
                $"Name: {this.Value} \n" +
                $"Employer: {this.EmployerName.Value} \n" +
                $"Location: {this.EmployerLocation.Value} \n" +
                $"Position Type: {this.JobType.Value} \n" +
                $"Core Competency: {this.JobCoreCompetency.Value} \n"; 
        }

    }
}
