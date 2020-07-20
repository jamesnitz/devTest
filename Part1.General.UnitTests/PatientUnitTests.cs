using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;

namespace Part1.General.UnitTests
{
    [TestClass]
    public class PatientUnitTests
    {
        [TestMethod]
        public void PatientMedicalRecordNumberIsString()
        {
            Patient patient = new Patient();
            patient.MedicalRecordNumber = "455555555555";
            string value = patient.MedicalRecordNumber;
            ValidationContext context = new ValidationContext(patient) { MemberName = "MedicalRecordNumber" };
            List<ValidationResult> results = new List<ValidationResult>();
            bool valid = Validator.TryValidateProperty(value, context, results);
           
            Assert.IsTrue(valid);
        }
        [TestMethod]
        public void PatientAddressIsString()
        {
            Patient patient = new Patient();
            patient.Address = "308 Negra Arroyo Lane";
            string value = patient.Address;
            ValidationContext context = new ValidationContext(patient) { MemberName = "Address" };
            List<ValidationResult> results = new List<ValidationResult>();
            bool valid = Validator.TryValidateProperty(value, context, results);

            Assert.IsTrue(valid);
        }
        //Having difficulties writing the test to confirm at least one policy is present
        //throwing error that value for property 'InsurancePolicies' must be of type 'System.Collections.Generic.List`1'
        [TestMethod]
        public void PatientHasInsurancePolicy()
        {
            Patient patient = new Patient();
            InsurancePolicy policy = new InsurancePolicy() { PolicyNumber = "111111", ProviderName = "Insurance" };
            patient.InsurancePolicies.Add(policy);

            List<InsurancePolicy> value = patient.InsurancePolicies;
            ValidationContext context = new ValidationContext(patient) { MemberName = "InsurancePolicies" };
            List<ValidationResult> results = new List<ValidationResult>();
            var valid = Validator.TryValidateProperty(value, context, results); 

            Assert.IsTrue(valid);
        }

    }
}
