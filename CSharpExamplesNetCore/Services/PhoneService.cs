using CSharpExamples;
using System;
using System.Collections.Generic;
using System.Text;

namespace CSharpExamplesNetCore.Services {
    public class PhoneService : IPhoneService {
        public Phone Load() {
            return new Phone {
                Number = "305.555.5533"
            };
        }
    }
}
