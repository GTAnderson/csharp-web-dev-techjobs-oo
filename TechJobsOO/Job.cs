using System;
namespace TechJobsOO
{
    public class Job
    {
        public int Id { get; }
        private static int nextId = 1;

        public string Name { get; set; }
        public Employer EmployerName { get; set; }
        public Location EmployerLocation { get; set; }
        public PositionType JobType { get; set; }
        public CoreCompetency CoreCompetency { get; set; }

        // TODO: Add the two necessary constructors.

        public Job()
        {
            Id = nextId;
            nextId++;
        }

        public Job(string name, Employer employerName, Location employerLocation, PositionType jobType, CoreCompetency coreCompetency) : this()
        {
            Name = name;
            EmployerName = employerName;
            EmployerLocation = employerLocation;
            JobType = jobType;
            CoreCompetency = coreCompetency;
        }

        // TODO: Generate Equals() and GetHashCode() methods.

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
            if (Name == null)
            {
                Name = "Data not available";
            }
            else if (EmployerName.Value == null || EmployerName.Value == "")
            {
                EmployerName.Value = "Data not available";
            }
            else if (EmployerLocation.Value == null || EmployerLocation.Value == "")
            {
                EmployerLocation.Value = "Data not available";
            }
            else if (JobType.Value == null || JobType.Value == "")
            {
                JobType.Value = "Data not available";
            }
            else if (CoreCompetency.Value == null || CoreCompetency.Value == "")
            {
                CoreCompetency.Value = "Data not available";
            }

            return "\n" + "ID:  " + this.Id + "\n" + "Name:  " + this.Name + "\n" + "Employer:  " + this.EmployerName + "\n" + "Location:  " + this.EmployerLocation + "\n" + "Position Type:  " + this.JobType + "\n" + "Core Competency:  " + this.CoreCompetency + "\n";
        }

    }
}
