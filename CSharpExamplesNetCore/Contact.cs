using CSharpExamplesNetCore;
using System;
using System.Collections.Generic;
using System.Text;

namespace CSharpExamples {
    public class Contact {
        public DateTimeService datetimeService;
        public string Name { get; set; }
        public DateTime BirthDate { get; set; }

        public Contact() {
            this.datetimeService = new DateTimeService();
        }
        public TimeSpan CalculateAge() {
            return this.datetimeService.CalculateAge(this.BirthDate);
        }
    }
}
