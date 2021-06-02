using CSharpExamples;
using CSharpExamplesNetCore.Model;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Moq;

namespace CSharpExamplesNetCoreTest {
    [TestClass]
    public class ContactTest {
        [TestMethod]
        public void ShouldGetTimeSpanWhenCalculateDate() {
            // without mocking
            Contact contact = new Contact();
            contact.BirthDate = new System.DateTime(1969, 7, 5);
            var span = contact.CalculateAge();
            Assert.IsNotNull(span);
            Assert.AreEqual(span.Days, 18681);

            ////mocking the datetime service
            //var mockContact = new Mock<Contact>() { CallBase = true };
            //mockContact.Setup()
            //span = mockContact.Object.CalculateAge();
            //Assert.IsNotNull(span);
            //Assert.AreEqual(span.Days, 18681);
        }
    }
}
