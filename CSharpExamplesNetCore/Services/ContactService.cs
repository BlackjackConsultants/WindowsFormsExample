using CSharpExamples;
using System;
using System.Collections.Generic;
using System.Text;
using CSharpExamplesNetCore.Model;

namespace CSharpExamplesNetCore.Services {
    public class ContactService : IContactService {
        public ContactService(IPhoneService phoneService) {
            this.PhoneService = phoneService;
        }
        public Contact Load() {
            return new Contact {
                BirthDate = new DateTime(1969, 7, 5),
                Name = "jorge perez"
            };
        }

        public IPhoneService PhoneService { get; set; }
    }
}
