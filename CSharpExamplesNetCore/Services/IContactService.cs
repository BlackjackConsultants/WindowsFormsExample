using CSharpExamples;
using System;
using System.Collections.Generic;
using System.Text;

namespace CSharpExamplesNetCore.Services {
    interface IContactService {
        public Contact Load();
    }
}
