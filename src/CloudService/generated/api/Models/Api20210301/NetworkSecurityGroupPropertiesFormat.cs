// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for license information.
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is regenerated.

namespace Microsoft.Azure.PowerShell.Cmdlets.CloudService.Models.Api20210301
{
    using static Microsoft.Azure.PowerShell.Cmdlets.CloudService.Runtime.Extensions;

    /// <summary>Network Security Group resource.</summary>
    public partial class NetworkSecurityGroupPropertiesFormat :
        Microsoft.Azure.PowerShell.Cmdlets.CloudService.Models.Api20210301.INetworkSecurityGroupPropertiesFormat,
        Microsoft.Azure.PowerShell.Cmdlets.CloudService.Models.Api20210301.INetworkSecurityGroupPropertiesFormatInternal
    {

        /// <summary>Backing field for <see cref="DefaultSecurityRule" /> property.</summary>
        private Microsoft.Azure.PowerShell.Cmdlets.CloudService.Models.Api20210301.ISecurityRule[] _defaultSecurityRule;

        /// <summary>The default security rules of network security group.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.CloudService.Origin(Microsoft.Azure.PowerShell.Cmdlets.CloudService.PropertyOrigin.Owned)]
        public Microsoft.Azure.PowerShell.Cmdlets.CloudService.Models.Api20210301.ISecurityRule[] DefaultSecurityRule { get => this._defaultSecurityRule; }

        /// <summary>Backing field for <see cref="FlowLog" /> property.</summary>
        private Microsoft.Azure.PowerShell.Cmdlets.CloudService.Models.Api20210301.IFlowLog[] _flowLog;

        /// <summary>A collection of references to flow log resources.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.CloudService.Origin(Microsoft.Azure.PowerShell.Cmdlets.CloudService.PropertyOrigin.Owned)]
        public Microsoft.Azure.PowerShell.Cmdlets.CloudService.Models.Api20210301.IFlowLog[] FlowLog { get => this._flowLog; }

        /// <summary>Internal Acessors for DefaultSecurityRule</summary>
        Microsoft.Azure.PowerShell.Cmdlets.CloudService.Models.Api20210301.ISecurityRule[] Microsoft.Azure.PowerShell.Cmdlets.CloudService.Models.Api20210301.INetworkSecurityGroupPropertiesFormatInternal.DefaultSecurityRule { get => this._defaultSecurityRule; set { {_defaultSecurityRule = value;} } }

        /// <summary>Internal Acessors for FlowLog</summary>
        Microsoft.Azure.PowerShell.Cmdlets.CloudService.Models.Api20210301.IFlowLog[] Microsoft.Azure.PowerShell.Cmdlets.CloudService.Models.Api20210301.INetworkSecurityGroupPropertiesFormatInternal.FlowLog { get => this._flowLog; set { {_flowLog = value;} } }

        /// <summary>Internal Acessors for NetworkInterface</summary>
        Microsoft.Azure.PowerShell.Cmdlets.CloudService.Models.Api20210301.INetworkInterface[] Microsoft.Azure.PowerShell.Cmdlets.CloudService.Models.Api20210301.INetworkSecurityGroupPropertiesFormatInternal.NetworkInterface { get => this._networkInterface; set { {_networkInterface = value;} } }

        /// <summary>Internal Acessors for ProvisioningState</summary>
        Microsoft.Azure.PowerShell.Cmdlets.CloudService.Support.ProvisioningState? Microsoft.Azure.PowerShell.Cmdlets.CloudService.Models.Api20210301.INetworkSecurityGroupPropertiesFormatInternal.ProvisioningState { get => this._provisioningState; set { {_provisioningState = value;} } }

        /// <summary>Internal Acessors for ResourceGuid</summary>
        string Microsoft.Azure.PowerShell.Cmdlets.CloudService.Models.Api20210301.INetworkSecurityGroupPropertiesFormatInternal.ResourceGuid { get => this._resourceGuid; set { {_resourceGuid = value;} } }

        /// <summary>Internal Acessors for Subnet</summary>
        Microsoft.Azure.PowerShell.Cmdlets.CloudService.Models.Api20210301.ISubnet[] Microsoft.Azure.PowerShell.Cmdlets.CloudService.Models.Api20210301.INetworkSecurityGroupPropertiesFormatInternal.Subnet { get => this._subnet; set { {_subnet = value;} } }

        /// <summary>Backing field for <see cref="NetworkInterface" /> property.</summary>
        private Microsoft.Azure.PowerShell.Cmdlets.CloudService.Models.Api20210301.INetworkInterface[] _networkInterface;

        /// <summary>A collection of references to network interfaces.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.CloudService.Origin(Microsoft.Azure.PowerShell.Cmdlets.CloudService.PropertyOrigin.Owned)]
        public Microsoft.Azure.PowerShell.Cmdlets.CloudService.Models.Api20210301.INetworkInterface[] NetworkInterface { get => this._networkInterface; }

        /// <summary>Backing field for <see cref="ProvisioningState" /> property.</summary>
        private Microsoft.Azure.PowerShell.Cmdlets.CloudService.Support.ProvisioningState? _provisioningState;

        /// <summary>The provisioning state of the network security group resource.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.CloudService.Origin(Microsoft.Azure.PowerShell.Cmdlets.CloudService.PropertyOrigin.Owned)]
        public Microsoft.Azure.PowerShell.Cmdlets.CloudService.Support.ProvisioningState? ProvisioningState { get => this._provisioningState; }

        /// <summary>Backing field for <see cref="ResourceGuid" /> property.</summary>
        private string _resourceGuid;

        /// <summary>The resource GUID property of the network security group resource.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.CloudService.Origin(Microsoft.Azure.PowerShell.Cmdlets.CloudService.PropertyOrigin.Owned)]
        public string ResourceGuid { get => this._resourceGuid; }

        /// <summary>Backing field for <see cref="SecurityRule" /> property.</summary>
        private Microsoft.Azure.PowerShell.Cmdlets.CloudService.Models.Api20210301.ISecurityRule[] _securityRule;

        /// <summary>A collection of security rules of the network security group.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.CloudService.Origin(Microsoft.Azure.PowerShell.Cmdlets.CloudService.PropertyOrigin.Owned)]
        public Microsoft.Azure.PowerShell.Cmdlets.CloudService.Models.Api20210301.ISecurityRule[] SecurityRule { get => this._securityRule; set => this._securityRule = value; }

        /// <summary>Backing field for <see cref="Subnet" /> property.</summary>
        private Microsoft.Azure.PowerShell.Cmdlets.CloudService.Models.Api20210301.ISubnet[] _subnet;

        /// <summary>A collection of references to subnets.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.CloudService.Origin(Microsoft.Azure.PowerShell.Cmdlets.CloudService.PropertyOrigin.Owned)]
        public Microsoft.Azure.PowerShell.Cmdlets.CloudService.Models.Api20210301.ISubnet[] Subnet { get => this._subnet; }

        /// <summary>Creates an new <see cref="NetworkSecurityGroupPropertiesFormat" /> instance.</summary>
        public NetworkSecurityGroupPropertiesFormat()
        {

        }
    }
    /// Network Security Group resource.
    public partial interface INetworkSecurityGroupPropertiesFormat :
        Microsoft.Azure.PowerShell.Cmdlets.CloudService.Runtime.IJsonSerializable
    {
        /// <summary>The default security rules of network security group.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.CloudService.Runtime.Info(
        Required = false,
        ReadOnly = true,
        Description = @"The default security rules of network security group.",
        SerializedName = @"defaultSecurityRules",
        PossibleTypes = new [] { typeof(Microsoft.Azure.PowerShell.Cmdlets.CloudService.Models.Api20210301.ISecurityRule) })]
        Microsoft.Azure.PowerShell.Cmdlets.CloudService.Models.Api20210301.ISecurityRule[] DefaultSecurityRule { get;  }
        /// <summary>A collection of references to flow log resources.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.CloudService.Runtime.Info(
        Required = false,
        ReadOnly = true,
        Description = @"A collection of references to flow log resources.",
        SerializedName = @"flowLogs",
        PossibleTypes = new [] { typeof(Microsoft.Azure.PowerShell.Cmdlets.CloudService.Models.Api20210301.IFlowLog) })]
        Microsoft.Azure.PowerShell.Cmdlets.CloudService.Models.Api20210301.IFlowLog[] FlowLog { get;  }
        /// <summary>A collection of references to network interfaces.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.CloudService.Runtime.Info(
        Required = false,
        ReadOnly = true,
        Description = @"A collection of references to network interfaces.",
        SerializedName = @"networkInterfaces",
        PossibleTypes = new [] { typeof(Microsoft.Azure.PowerShell.Cmdlets.CloudService.Models.Api20210301.INetworkInterface) })]
        Microsoft.Azure.PowerShell.Cmdlets.CloudService.Models.Api20210301.INetworkInterface[] NetworkInterface { get;  }
        /// <summary>The provisioning state of the network security group resource.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.CloudService.Runtime.Info(
        Required = false,
        ReadOnly = true,
        Description = @"The provisioning state of the network security group resource.",
        SerializedName = @"provisioningState",
        PossibleTypes = new [] { typeof(Microsoft.Azure.PowerShell.Cmdlets.CloudService.Support.ProvisioningState) })]
        Microsoft.Azure.PowerShell.Cmdlets.CloudService.Support.ProvisioningState? ProvisioningState { get;  }
        /// <summary>The resource GUID property of the network security group resource.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.CloudService.Runtime.Info(
        Required = false,
        ReadOnly = true,
        Description = @"The resource GUID property of the network security group resource.",
        SerializedName = @"resourceGuid",
        PossibleTypes = new [] { typeof(string) })]
        string ResourceGuid { get;  }
        /// <summary>A collection of security rules of the network security group.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.CloudService.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"A collection of security rules of the network security group.",
        SerializedName = @"securityRules",
        PossibleTypes = new [] { typeof(Microsoft.Azure.PowerShell.Cmdlets.CloudService.Models.Api20210301.ISecurityRule) })]
        Microsoft.Azure.PowerShell.Cmdlets.CloudService.Models.Api20210301.ISecurityRule[] SecurityRule { get; set; }
        /// <summary>A collection of references to subnets.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.CloudService.Runtime.Info(
        Required = false,
        ReadOnly = true,
        Description = @"A collection of references to subnets.",
        SerializedName = @"subnets",
        PossibleTypes = new [] { typeof(Microsoft.Azure.PowerShell.Cmdlets.CloudService.Models.Api20210301.ISubnet) })]
        Microsoft.Azure.PowerShell.Cmdlets.CloudService.Models.Api20210301.ISubnet[] Subnet { get;  }

    }
    /// Network Security Group resource.
    internal partial interface INetworkSecurityGroupPropertiesFormatInternal

    {
        /// <summary>The default security rules of network security group.</summary>
        Microsoft.Azure.PowerShell.Cmdlets.CloudService.Models.Api20210301.ISecurityRule[] DefaultSecurityRule { get; set; }
        /// <summary>A collection of references to flow log resources.</summary>
        Microsoft.Azure.PowerShell.Cmdlets.CloudService.Models.Api20210301.IFlowLog[] FlowLog { get; set; }
        /// <summary>A collection of references to network interfaces.</summary>
        Microsoft.Azure.PowerShell.Cmdlets.CloudService.Models.Api20210301.INetworkInterface[] NetworkInterface { get; set; }
        /// <summary>The provisioning state of the network security group resource.</summary>
        Microsoft.Azure.PowerShell.Cmdlets.CloudService.Support.ProvisioningState? ProvisioningState { get; set; }
        /// <summary>The resource GUID property of the network security group resource.</summary>
        string ResourceGuid { get; set; }
        /// <summary>A collection of security rules of the network security group.</summary>
        Microsoft.Azure.PowerShell.Cmdlets.CloudService.Models.Api20210301.ISecurityRule[] SecurityRule { get; set; }
        /// <summary>A collection of references to subnets.</summary>
        Microsoft.Azure.PowerShell.Cmdlets.CloudService.Models.Api20210301.ISubnet[] Subnet { get; set; }

    }
}