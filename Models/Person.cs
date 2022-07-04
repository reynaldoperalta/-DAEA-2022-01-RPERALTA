using System;

namespace persons.Models
{
    public class person
    {
        public int? PersonID {get; set;}
        public string? LastName {get;set;}
        public string? FirstName {get; set;}
        public DateTime? HireDate {get; set;}
        public DateTime? EnrollmentDate {get; set;}
    }
}