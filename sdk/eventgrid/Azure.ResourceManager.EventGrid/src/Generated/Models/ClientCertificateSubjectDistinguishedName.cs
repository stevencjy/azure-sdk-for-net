// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

namespace Azure.ResourceManager.EventGrid.Models
{
    /// <summary>
    /// CA certificate subject distinguished name information used by service to authenticate clients.
    /// For more information, see https://docs.microsoft.com/en-us/dotnet/api/system.security.cryptography.x509certificates.x500distinguishedname?view=net-6.0#remarks
    /// </summary>
    public partial class ClientCertificateSubjectDistinguishedName
    {
        /// <summary> Initializes a new instance of <see cref="ClientCertificateSubjectDistinguishedName"/>. </summary>
        public ClientCertificateSubjectDistinguishedName()
        {
        }

        /// <summary> Initializes a new instance of <see cref="ClientCertificateSubjectDistinguishedName"/>. </summary>
        /// <param name="commonName"> The common name field in the subject name. The allowed limit is 64 characters and it should be specified. </param>
        /// <param name="organization"> The organization field in the subject name. If present, the allowed limit is 64 characters. </param>
        /// <param name="organizationUnit"> The organization unit field in the subject name. If present, the allowed limit is 32 characters. </param>
        /// <param name="countryCode"> The country code field in the subject name. If present, the country code should be represented by two-letter code defined in ISO 2166-1 (alpha-2). For example: 'US'. </param>
        internal ClientCertificateSubjectDistinguishedName(string commonName, string organization, string organizationUnit, string countryCode)
        {
            CommonName = commonName;
            Organization = organization;
            OrganizationUnit = organizationUnit;
            CountryCode = countryCode;
        }

        /// <summary> The common name field in the subject name. The allowed limit is 64 characters and it should be specified. </summary>
        public string CommonName { get; set; }
        /// <summary> The organization field in the subject name. If present, the allowed limit is 64 characters. </summary>
        public string Organization { get; set; }
        /// <summary> The organization unit field in the subject name. If present, the allowed limit is 32 characters. </summary>
        public string OrganizationUnit { get; set; }
        /// <summary> The country code field in the subject name. If present, the country code should be represented by two-letter code defined in ISO 2166-1 (alpha-2). For example: 'US'. </summary>
        public string CountryCode { get; set; }
    }
}
