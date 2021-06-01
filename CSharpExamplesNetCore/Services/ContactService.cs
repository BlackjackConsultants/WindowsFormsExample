using CSharpExamples;
using System;
using System.Collections.Generic;
using System.Text;

namespace CSharpExamplesNetCore.Services {
    public class ContactService : IContactService {
        public Contact Load() {
            return new Contact {
                BirthDate = new DateTime(1969, 7, 5),
                Name = "jorge perez"
            };
        }
    }
}
