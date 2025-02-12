// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Collections.Generic;
using Azure.Core;

namespace Azure.ResourceManager.RecoveryServicesSiteRecovery.Models
{
    /// <summary> VMwareCbt specific update migration item input. </summary>
    public partial class VMwareCbtUpdateMigrationItemInput : UpdateMigrationItemProviderSpecificInput
    {
        /// <summary> Initializes a new instance of VMwareCbtUpdateMigrationItemInput. </summary>
        public VMwareCbtUpdateMigrationItemInput()
        {
            VmNics = new ChangeTrackingList<VMwareCbtNicInput>();
            VmDisks = new ChangeTrackingList<VMwareCbtUpdateDiskInput>();
            TargetVmTags = new ChangeTrackingDictionary<string, string>();
            TargetDiskTags = new ChangeTrackingDictionary<string, string>();
            TargetNicTags = new ChangeTrackingDictionary<string, string>();
            InstanceType = "VMwareCbt";
        }

        /// <summary> The target VM name. </summary>
        public string TargetVmName { get; set; }
        /// <summary> The target VM size. </summary>
        public string TargetVmSize { get; set; }
        /// <summary> The target resource group ARM Id. </summary>
        public string TargetResourceGroupId { get; set; }
        /// <summary> The target availability set ARM Id. </summary>
        public string TargetAvailabilitySetId { get; set; }
        /// <summary> The target availability zone. </summary>
        public string TargetAvailabilityZone { get; set; }
        /// <summary> The target proximity placement group ARM Id. </summary>
        public string TargetProximityPlacementGroupId { get; set; }
        /// <summary> The target boot diagnostics storage account ARM Id. </summary>
        public string TargetBootDiagnosticsStorageAccountId { get; set; }
        /// <summary> The target network ARM Id. </summary>
        public string TargetNetworkId { get; set; }
        /// <summary> The test network ARM Id. </summary>
        public string TestNetworkId { get; set; }
        /// <summary> The list of NIC details. </summary>
        public IList<VMwareCbtNicInput> VmNics { get; }
        /// <summary> The list of disk update properties. </summary>
        public IList<VMwareCbtUpdateDiskInput> VmDisks { get; }
        /// <summary> The license type. </summary>
        public LicenseType? LicenseType { get; set; }
        /// <summary> The SQL Server license type. </summary>
        public SqlServerLicenseType? SqlServerLicenseType { get; set; }
        /// <summary> A value indicating whether auto resync is to be done. </summary>
        public string PerformAutoResync { get; set; }
        /// <summary> The target VM tags. </summary>
        public IDictionary<string, string> TargetVmTags { get; }
        /// <summary> The tags for the target disks. </summary>
        public IDictionary<string, string> TargetDiskTags { get; }
        /// <summary> The tags for the target NICs. </summary>
        public IDictionary<string, string> TargetNicTags { get; }
    }
}
