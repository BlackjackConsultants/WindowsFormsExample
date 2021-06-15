using CSharpExamplesNetCore.Model;
using System;
using System.Collections.Generic;
using System.Text;
using Contact = CSharpExamplesNetCore.Model.Contact;

namespace CSharpExamplesNetCore.Services {
    public interface IContactService {
        public Contact Load();

        public IPhoneService PhoneService { get; set; }

    }
}
