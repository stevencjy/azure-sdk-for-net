// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using Azure.Core;

namespace Azure.ResourceManager.Sql.Models
{
    /// <summary> Contains the information necessary to perform export database operation. </summary>
    public partial class DatabaseExportDefinition
    {
        /// <summary> Initializes a new instance of <see cref="DatabaseExportDefinition"/>. </summary>
        /// <param name="storageKeyType"> Storage key type. </param>
        /// <param name="storageKey"> Storage key. </param>
        /// <param name="storageUri"> Storage Uri. </param>
        /// <param name="administratorLogin"> Administrator login name. </param>
        /// <param name="administratorLoginPassword"> Administrator login password. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="storageKey"/>, <paramref name="storageUri"/>, <paramref name="administratorLogin"/> or <paramref name="administratorLoginPassword"/> is null. </exception>
        public DatabaseExportDefinition(StorageKeyType storageKeyType, string storageKey, Uri storageUri, string administratorLogin, string administratorLoginPassword)
        {
            Argument.AssertNotNull(storageKey, nameof(storageKey));
            Argument.AssertNotNull(storageUri, nameof(storageUri));
            Argument.AssertNotNull(administratorLogin, nameof(administratorLogin));
            Argument.AssertNotNull(administratorLoginPassword, nameof(administratorLoginPassword));

            StorageKeyType = storageKeyType;
            StorageKey = storageKey;
            StorageUri = storageUri;
            AdministratorLogin = administratorLogin;
            AdministratorLoginPassword = administratorLoginPassword;
        }

        /// <summary> Initializes a new instance of <see cref="DatabaseExportDefinition"/>. </summary>
        /// <param name="storageKeyType"> Storage key type. </param>
        /// <param name="storageKey"> Storage key. </param>
        /// <param name="storageUri"> Storage Uri. </param>
        /// <param name="administratorLogin"> Administrator login name. </param>
        /// <param name="administratorLoginPassword"> Administrator login password. </param>
        /// <param name="authenticationType"> Authentication type. </param>
        /// <param name="networkIsolation"> Optional resource information to enable network isolation for request. </param>
        internal DatabaseExportDefinition(StorageKeyType storageKeyType, string storageKey, Uri storageUri, string administratorLogin, string administratorLoginPassword, string authenticationType, NetworkIsolationSettings networkIsolation)
        {
            StorageKeyType = storageKeyType;
            StorageKey = storageKey;
            StorageUri = storageUri;
            AdministratorLogin = administratorLogin;
            AdministratorLoginPassword = administratorLoginPassword;
            AuthenticationType = authenticationType;
            NetworkIsolation = networkIsolation;
        }

        /// <summary> Storage key type. </summary>
        public StorageKeyType StorageKeyType { get; }
        /// <summary> Storage key. </summary>
        public string StorageKey { get; }
        /// <summary> Storage Uri. </summary>
        public Uri StorageUri { get; }
        /// <summary> Administrator login name. </summary>
        public string AdministratorLogin { get; }
        /// <summary> Administrator login password. </summary>
        public string AdministratorLoginPassword { get; }
        /// <summary> Authentication type. </summary>
        public string AuthenticationType { get; set; }
        /// <summary> Optional resource information to enable network isolation for request. </summary>
        public NetworkIsolationSettings NetworkIsolation { get; set; }
    }
}
