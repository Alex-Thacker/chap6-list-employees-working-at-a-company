using System;

namespace list_employees_working_at_a_company{
    public class Employee 
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Title { get; set; }
        public DateTime StartDate { get; set; }
        public Employee (string first, string last, string title, DateTime startDate) {
            FirstName = first;
            LastName = last;
            Title = title;
            StartDate = startDate;
        }
    }
}