using Microsoft.Win32.SafeHandles;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Runtime.InteropServices;

namespace Part1.General
{
    /// <summary>
    /// Represents a strongly typed patient object with methods to dispose, and display text
    /// </summary>
    public class Patient: IDisposable
    {
        [Required]
        public virtual int Id { get; set; }
        [Required]
        public virtual string MedicalRecordNumber { get; set; }
        [Required]
        public virtual string FirstName { get; set; }
        [Required]
        public virtual string LastName { get; set; }
        [Required]
        public virtual string Address { get; set; }
        [Required, MinLength(1)]
        public List<InsurancePolicy> InsurancePolicies { get; set; } = new List<InsurancePolicy>();

        // Step 5. The internet has a lot of varying opinions on the subject of disposing, and I'm struggling to fully understand the positions
        // and what actually helps to clean up unmanaged resources and I'm curious as to your opinions on the matter.
        // What I've done below, I believe is a method that is supposedley a safer way of handling dispose.
        private bool _disposed = false;
        private SafeHandle _safeHandle = new SafeFileHandle(IntPtr.Zero, true);
        public void Dispose() => Dispose(true);
        protected virtual void Dispose(bool disposing)
        {
            if (_disposed)
            {
                return;
            }
            if (disposing)
            {
                _safeHandle?.Dispose();
            }
            _disposed = true;
        }

        public virtual string GetDisplayText1()
        {
            string policyString = "";
            if (InsurancePolicies.Count >= 1)
            {
                InsurancePolicy policy = InsurancePolicies.FirstOrDefault();
                policyString = $" - {policy.ProviderName} {policy.PolicyNumber}";
            }

            return $"{FirstName} {LastName}{policyString}";
        }
        public virtual string GetDisplayText2()
        {
            string nameString = string.Concat(FirstName, " ", LastName);
            string insurancePolicyString = "";
            if (InsurancePolicies.Count >= 1)
            {
                InsurancePolicy policy = InsurancePolicies.FirstOrDefault();
                insurancePolicyString = $" - {policy.ProviderName} {policy.PolicyNumber}";
            }
            string fullDetailsString = string.Concat(nameString, insurancePolicyString);
            return fullDetailsString;
        }
        public virtual string GetDisplayText3()
        {
            string insurancePolicyString = "";
            if (InsurancePolicies.Count >= 1)
            {
                InsurancePolicy policy = InsurancePolicies.FirstOrDefault();
                insurancePolicyString = $" - {policy.ProviderName} {policy.PolicyNumber}";
            }

            string fullDetailsString = string.Format("{0} {1}{2}", FirstName, LastName, insurancePolicyString);

            return fullDetailsString;
        }

    }
}
