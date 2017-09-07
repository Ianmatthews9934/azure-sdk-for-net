// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for
// license information.
//
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.

namespace Microsoft.Azure.Management.RecoveryServices.Backup.Models
{
    using Microsoft.Azure;
    using Microsoft.Azure.Management;
    using Microsoft.Azure.Management.RecoveryServices;
    using Microsoft.Azure.Management.RecoveryServices.Backup;

    /// <summary>
    /// Defines values for ContainerType.
    /// </summary>
    public static class ContainerType
    {
        public const string Invalid = "Invalid";
        public const string Unknown = "Unknown";
        public const string IaasVMContainer = "IaasVMContainer";
        public const string IaasVMServiceContainer = "IaasVMServiceContainer";
        public const string DPMContainer = "DPMContainer";
        public const string AzureBackupServerContainer = "AzureBackupServerContainer";
        public const string MABContainer = "MABContainer";
        public const string Cluster = "Cluster";
        public const string AzureSqlContainer = "AzureSqlContainer";
        public const string Windows = "Windows";
        public const string VCenter = "VCenter";
    }
}