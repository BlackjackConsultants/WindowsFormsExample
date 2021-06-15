using CSharpExamples;
using System;
using System.Collections.Generic;
using System.Text;
using CSharpExamplesNetCore.Model;
using Contact = CSharpExamplesNetCore.Model.Contact;

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

        Contact IContactService.Load() {
            throw new NotImplementedException();
        }

        public IPhoneService PhoneService { get; set; }
    }
}
