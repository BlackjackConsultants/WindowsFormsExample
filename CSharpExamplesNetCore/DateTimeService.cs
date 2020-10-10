using System;
using System.Collections.Generic;
using System.Text;

namespace CSharpExamplesNetCore {
    public class DateTimeService {
        public TimeSpan CalculateAge(DateTime birthdate) {
            return DateTime.Now - birthdate;
        }
    }
}
