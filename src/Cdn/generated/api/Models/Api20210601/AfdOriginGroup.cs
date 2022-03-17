// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for license information.
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is regenerated.

namespace Microsoft.Azure.PowerShell.Cmdlets.Cdn.Models.Api20210601
{
    using static Microsoft.Azure.PowerShell.Cmdlets.Cdn.Runtime.Extensions;

    /// <summary>
    /// AFDOrigin group comprising of origins is used for load balancing to origins when the content cannot be served from CDN.
    /// </summary>
    public partial class AfdOriginGroup :
        Microsoft.Azure.PowerShell.Cmdlets.Cdn.Models.Api20210601.IAfdOriginGroup,
        Microsoft.Azure.PowerShell.Cmdlets.Cdn.Models.Api20210601.IAfdOriginGroupInternal,
        Microsoft.Azure.PowerShell.Cmdlets.Cdn.Runtime.IValidates
    {
        /// <summary>
        /// Backing field for Inherited model <see cref= "Microsoft.Azure.PowerShell.Cmdlets.Cdn.Models.Api20210601.IResource" />
        /// </summary>
        private Microsoft.Azure.PowerShell.Cmdlets.Cdn.Models.Api20210601.IResource __resource = new Microsoft.Azure.PowerShell.Cmdlets.Cdn.Models.Api20210601.Resource();

        [Microsoft.Azure.PowerShell.Cmdlets.Cdn.Origin(Microsoft.Azure.PowerShell.Cmdlets.Cdn.PropertyOrigin.Inlined)]
        public Microsoft.Azure.PowerShell.Cmdlets.Cdn.Support.DeploymentStatus? DeploymentStatus { get => ((Microsoft.Azure.PowerShell.Cmdlets.Cdn.Models.Api20210601.IAfdStatePropertiesInternal)Property).DeploymentStatus; }

        /// <summary>The number of seconds between health probes.Default is 240sec.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Cdn.Origin(Microsoft.Azure.PowerShell.Cmdlets.Cdn.PropertyOrigin.Inlined)]
        public int? HealthProbeSettingProbeIntervalInSecond { get => ((Microsoft.Azure.PowerShell.Cmdlets.Cdn.Models.Api20210601.IAfdOriginGroupUpdatePropertiesParametersInternal)Property).HealthProbeSettingProbeIntervalInSecond; set => ((Microsoft.Azure.PowerShell.Cmdlets.Cdn.Models.Api20210601.IAfdOriginGroupUpdatePropertiesParametersInternal)Property).HealthProbeSettingProbeIntervalInSecond = value ?? default(int); }

        /// <summary>
        /// The path relative to the origin that is used to determine the health of the origin.
        /// </summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Cdn.Origin(Microsoft.Azure.PowerShell.Cmdlets.Cdn.PropertyOrigin.Inlined)]
        public string HealthProbeSettingProbePath { get => ((Microsoft.Azure.PowerShell.Cmdlets.Cdn.Models.Api20210601.IAfdOriginGroupUpdatePropertiesParametersInternal)Property).HealthProbeSettingProbePath; set => ((Microsoft.Azure.PowerShell.Cmdlets.Cdn.Models.Api20210601.IAfdOriginGroupUpdatePropertiesParametersInternal)Property).HealthProbeSettingProbePath = value ?? null; }

        /// <summary>Protocol to use for health probe.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Cdn.Origin(Microsoft.Azure.PowerShell.Cmdlets.Cdn.PropertyOrigin.Inlined)]
        public Microsoft.Azure.PowerShell.Cmdlets.Cdn.Support.ProbeProtocol? HealthProbeSettingProbeProtocol { get => ((Microsoft.Azure.PowerShell.Cmdlets.Cdn.Models.Api20210601.IAfdOriginGroupUpdatePropertiesParametersInternal)Property).HealthProbeSettingProbeProtocol; set => ((Microsoft.Azure.PowerShell.Cmdlets.Cdn.Models.Api20210601.IAfdOriginGroupUpdatePropertiesParametersInternal)Property).HealthProbeSettingProbeProtocol = value ?? ((Microsoft.Azure.PowerShell.Cmdlets.Cdn.Support.ProbeProtocol)""); }

        /// <summary>The type of health probe request that is made.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Cdn.Origin(Microsoft.Azure.PowerShell.Cmdlets.Cdn.PropertyOrigin.Inlined)]
        public Microsoft.Azure.PowerShell.Cmdlets.Cdn.Support.HealthProbeRequestType? HealthProbeSettingProbeRequestType { get => ((Microsoft.Azure.PowerShell.Cmdlets.Cdn.Models.Api20210601.IAfdOriginGroupUpdatePropertiesParametersInternal)Property).HealthProbeSettingProbeRequestType; set => ((Microsoft.Azure.PowerShell.Cmdlets.Cdn.Models.Api20210601.IAfdOriginGroupUpdatePropertiesParametersInternal)Property).HealthProbeSettingProbeRequestType = value ?? ((Microsoft.Azure.PowerShell.Cmdlets.Cdn.Support.HealthProbeRequestType)""); }

        /// <summary>Resource ID.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Cdn.Origin(Microsoft.Azure.PowerShell.Cmdlets.Cdn.PropertyOrigin.Inherited)]
        public string Id { get => ((Microsoft.Azure.PowerShell.Cmdlets.Cdn.Models.Api20210601.IResourceInternal)__resource).Id; }

        /// <summary>
        /// The additional latency in milliseconds for probes to fall into the lowest latency bucket
        /// </summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Cdn.Origin(Microsoft.Azure.PowerShell.Cmdlets.Cdn.PropertyOrigin.Inlined)]
        public int? LoadBalancingSettingAdditionalLatencyInMillisecond { get => ((Microsoft.Azure.PowerShell.Cmdlets.Cdn.Models.Api20210601.IAfdOriginGroupUpdatePropertiesParametersInternal)Property).LoadBalancingSettingAdditionalLatencyInMillisecond; set => ((Microsoft.Azure.PowerShell.Cmdlets.Cdn.Models.Api20210601.IAfdOriginGroupUpdatePropertiesParametersInternal)Property).LoadBalancingSettingAdditionalLatencyInMillisecond = value ?? default(int); }

        /// <summary>The number of samples to consider for load balancing decisions</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Cdn.Origin(Microsoft.Azure.PowerShell.Cmdlets.Cdn.PropertyOrigin.Inlined)]
        public int? LoadBalancingSettingSampleSize { get => ((Microsoft.Azure.PowerShell.Cmdlets.Cdn.Models.Api20210601.IAfdOriginGroupUpdatePropertiesParametersInternal)Property).LoadBalancingSettingSampleSize; set => ((Microsoft.Azure.PowerShell.Cmdlets.Cdn.Models.Api20210601.IAfdOriginGroupUpdatePropertiesParametersInternal)Property).LoadBalancingSettingSampleSize = value ?? default(int); }

        /// <summary>The number of samples within the sample period that must succeed</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Cdn.Origin(Microsoft.Azure.PowerShell.Cmdlets.Cdn.PropertyOrigin.Inlined)]
        public int? LoadBalancingSettingSuccessfulSamplesRequired { get => ((Microsoft.Azure.PowerShell.Cmdlets.Cdn.Models.Api20210601.IAfdOriginGroupUpdatePropertiesParametersInternal)Property).LoadBalancingSettingSuccessfulSamplesRequired; set => ((Microsoft.Azure.PowerShell.Cmdlets.Cdn.Models.Api20210601.IAfdOriginGroupUpdatePropertiesParametersInternal)Property).LoadBalancingSettingSuccessfulSamplesRequired = value ?? default(int); }

        /// <summary>Internal Acessors for DeploymentStatus</summary>
        Microsoft.Azure.PowerShell.Cmdlets.Cdn.Support.DeploymentStatus? Microsoft.Azure.PowerShell.Cmdlets.Cdn.Models.Api20210601.IAfdOriginGroupInternal.DeploymentStatus { get => ((Microsoft.Azure.PowerShell.Cmdlets.Cdn.Models.Api20210601.IAfdStatePropertiesInternal)Property).DeploymentStatus; set => ((Microsoft.Azure.PowerShell.Cmdlets.Cdn.Models.Api20210601.IAfdStatePropertiesInternal)Property).DeploymentStatus = value; }

        /// <summary>Internal Acessors for HealthProbeSetting</summary>
        Microsoft.Azure.PowerShell.Cmdlets.Cdn.Models.Api20210601.IHealthProbeParameters Microsoft.Azure.PowerShell.Cmdlets.Cdn.Models.Api20210601.IAfdOriginGroupInternal.HealthProbeSetting { get => ((Microsoft.Azure.PowerShell.Cmdlets.Cdn.Models.Api20210601.IAfdOriginGroupUpdatePropertiesParametersInternal)Property).HealthProbeSetting; set => ((Microsoft.Azure.PowerShell.Cmdlets.Cdn.Models.Api20210601.IAfdOriginGroupUpdatePropertiesParametersInternal)Property).HealthProbeSetting = value; }

        /// <summary>Internal Acessors for LoadBalancingSetting</summary>
        Microsoft.Azure.PowerShell.Cmdlets.Cdn.Models.Api20210601.ILoadBalancingSettingsParameters Microsoft.Azure.PowerShell.Cmdlets.Cdn.Models.Api20210601.IAfdOriginGroupInternal.LoadBalancingSetting { get => ((Microsoft.Azure.PowerShell.Cmdlets.Cdn.Models.Api20210601.IAfdOriginGroupUpdatePropertiesParametersInternal)Property).LoadBalancingSetting; set => ((Microsoft.Azure.PowerShell.Cmdlets.Cdn.Models.Api20210601.IAfdOriginGroupUpdatePropertiesParametersInternal)Property).LoadBalancingSetting = value; }

        /// <summary>Internal Acessors for ProfileName</summary>
        string Microsoft.Azure.PowerShell.Cmdlets.Cdn.Models.Api20210601.IAfdOriginGroupInternal.ProfileName { get => ((Microsoft.Azure.PowerShell.Cmdlets.Cdn.Models.Api20210601.IAfdOriginGroupUpdatePropertiesParametersInternal)Property).ProfileName; set => ((Microsoft.Azure.PowerShell.Cmdlets.Cdn.Models.Api20210601.IAfdOriginGroupUpdatePropertiesParametersInternal)Property).ProfileName = value; }

        /// <summary>Internal Acessors for Property</summary>
        Microsoft.Azure.PowerShell.Cmdlets.Cdn.Models.Api20210601.IAfdOriginGroupProperties Microsoft.Azure.PowerShell.Cmdlets.Cdn.Models.Api20210601.IAfdOriginGroupInternal.Property { get => (this._property = this._property ?? new Microsoft.Azure.PowerShell.Cmdlets.Cdn.Models.Api20210601.AfdOriginGroupProperties()); set { {_property = value;} } }

        /// <summary>Internal Acessors for ProvisioningState</summary>
        Microsoft.Azure.PowerShell.Cmdlets.Cdn.Support.AfdProvisioningState? Microsoft.Azure.PowerShell.Cmdlets.Cdn.Models.Api20210601.IAfdOriginGroupInternal.ProvisioningState { get => ((Microsoft.Azure.PowerShell.Cmdlets.Cdn.Models.Api20210601.IAfdStatePropertiesInternal)Property).ProvisioningState; set => ((Microsoft.Azure.PowerShell.Cmdlets.Cdn.Models.Api20210601.IAfdStatePropertiesInternal)Property).ProvisioningState = value; }

        /// <summary>Internal Acessors for Id</summary>
        string Microsoft.Azure.PowerShell.Cmdlets.Cdn.Models.Api20210601.IResourceInternal.Id { get => ((Microsoft.Azure.PowerShell.Cmdlets.Cdn.Models.Api20210601.IResourceInternal)__resource).Id; set => ((Microsoft.Azure.PowerShell.Cmdlets.Cdn.Models.Api20210601.IResourceInternal)__resource).Id = value; }

        /// <summary>Internal Acessors for Name</summary>
        string Microsoft.Azure.PowerShell.Cmdlets.Cdn.Models.Api20210601.IResourceInternal.Name { get => ((Microsoft.Azure.PowerShell.Cmdlets.Cdn.Models.Api20210601.IResourceInternal)__resource).Name; set => ((Microsoft.Azure.PowerShell.Cmdlets.Cdn.Models.Api20210601.IResourceInternal)__resource).Name = value; }

        /// <summary>Internal Acessors for SystemData</summary>
        Microsoft.Azure.PowerShell.Cmdlets.Cdn.Models.Api20210601.ISystemData Microsoft.Azure.PowerShell.Cmdlets.Cdn.Models.Api20210601.IResourceInternal.SystemData { get => ((Microsoft.Azure.PowerShell.Cmdlets.Cdn.Models.Api20210601.IResourceInternal)__resource).SystemData; set => ((Microsoft.Azure.PowerShell.Cmdlets.Cdn.Models.Api20210601.IResourceInternal)__resource).SystemData = value; }

        /// <summary>Internal Acessors for Type</summary>
        string Microsoft.Azure.PowerShell.Cmdlets.Cdn.Models.Api20210601.IResourceInternal.Type { get => ((Microsoft.Azure.PowerShell.Cmdlets.Cdn.Models.Api20210601.IResourceInternal)__resource).Type; set => ((Microsoft.Azure.PowerShell.Cmdlets.Cdn.Models.Api20210601.IResourceInternal)__resource).Type = value; }

        /// <summary>Resource name.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Cdn.Origin(Microsoft.Azure.PowerShell.Cmdlets.Cdn.PropertyOrigin.Inherited)]
        public string Name { get => ((Microsoft.Azure.PowerShell.Cmdlets.Cdn.Models.Api20210601.IResourceInternal)__resource).Name; }

        /// <summary>The name of the profile which holds the origin group.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Cdn.Origin(Microsoft.Azure.PowerShell.Cmdlets.Cdn.PropertyOrigin.Inlined)]
        public string ProfileName { get => ((Microsoft.Azure.PowerShell.Cmdlets.Cdn.Models.Api20210601.IAfdOriginGroupUpdatePropertiesParametersInternal)Property).ProfileName; }

        /// <summary>Backing field for <see cref="Property" /> property.</summary>
        private Microsoft.Azure.PowerShell.Cmdlets.Cdn.Models.Api20210601.IAfdOriginGroupProperties _property;

        /// <summary>The JSON object that contains the properties of the origin group.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Cdn.Origin(Microsoft.Azure.PowerShell.Cmdlets.Cdn.PropertyOrigin.Owned)]
        internal Microsoft.Azure.PowerShell.Cmdlets.Cdn.Models.Api20210601.IAfdOriginGroupProperties Property { get => (this._property = this._property ?? new Microsoft.Azure.PowerShell.Cmdlets.Cdn.Models.Api20210601.AfdOriginGroupProperties()); set => this._property = value; }

        /// <summary>Provisioning status</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Cdn.Origin(Microsoft.Azure.PowerShell.Cmdlets.Cdn.PropertyOrigin.Inlined)]
        public Microsoft.Azure.PowerShell.Cmdlets.Cdn.Support.AfdProvisioningState? ProvisioningState { get => ((Microsoft.Azure.PowerShell.Cmdlets.Cdn.Models.Api20210601.IAfdStatePropertiesInternal)Property).ProvisioningState; }

        /// <summary>Gets the resource group name</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Cdn.Origin(Microsoft.Azure.PowerShell.Cmdlets.Cdn.PropertyOrigin.Owned)]
        public string ResourceGroupName { get => (new global::System.Text.RegularExpressions.Regex("^/subscriptions/(?<subscriptionId>[^/]+)/resourceGroups/(?<resourceGroupName>[^/]+)/providers/", global::System.Text.RegularExpressions.RegexOptions.IgnoreCase).Match(this.Id).Success ? new global::System.Text.RegularExpressions.Regex("^/subscriptions/(?<subscriptionId>[^/]+)/resourceGroups/(?<resourceGroupName>[^/]+)/providers/", global::System.Text.RegularExpressions.RegexOptions.IgnoreCase).Match(this.Id).Groups["resourceGroupName"].Value : null); }

        /// <summary>
        /// Whether to allow session affinity on this host. Valid options are 'Enabled' or 'Disabled'
        /// </summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Cdn.Origin(Microsoft.Azure.PowerShell.Cmdlets.Cdn.PropertyOrigin.Inlined)]
        public Microsoft.Azure.PowerShell.Cmdlets.Cdn.Support.EnabledState? SessionAffinityState { get => ((Microsoft.Azure.PowerShell.Cmdlets.Cdn.Models.Api20210601.IAfdOriginGroupUpdatePropertiesParametersInternal)Property).SessionAffinityState; set => ((Microsoft.Azure.PowerShell.Cmdlets.Cdn.Models.Api20210601.IAfdOriginGroupUpdatePropertiesParametersInternal)Property).SessionAffinityState = value ?? ((Microsoft.Azure.PowerShell.Cmdlets.Cdn.Support.EnabledState)""); }

        /// <summary>Read only system data</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Cdn.Origin(Microsoft.Azure.PowerShell.Cmdlets.Cdn.PropertyOrigin.Inherited)]
        public Microsoft.Azure.PowerShell.Cmdlets.Cdn.Models.Api20210601.ISystemData SystemData { get => ((Microsoft.Azure.PowerShell.Cmdlets.Cdn.Models.Api20210601.IResourceInternal)__resource).SystemData; }

        /// <summary>The timestamp of resource creation (UTC)</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Cdn.Origin(Microsoft.Azure.PowerShell.Cmdlets.Cdn.PropertyOrigin.Inherited)]
        public global::System.DateTime? SystemDataCreatedAt { get => ((Microsoft.Azure.PowerShell.Cmdlets.Cdn.Models.Api20210601.IResourceInternal)__resource).SystemDataCreatedAt; set => ((Microsoft.Azure.PowerShell.Cmdlets.Cdn.Models.Api20210601.IResourceInternal)__resource).SystemDataCreatedAt = value ?? default(global::System.DateTime); }

        /// <summary>An identifier for the identity that created the resource</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Cdn.Origin(Microsoft.Azure.PowerShell.Cmdlets.Cdn.PropertyOrigin.Inherited)]
        public string SystemDataCreatedBy { get => ((Microsoft.Azure.PowerShell.Cmdlets.Cdn.Models.Api20210601.IResourceInternal)__resource).SystemDataCreatedBy; set => ((Microsoft.Azure.PowerShell.Cmdlets.Cdn.Models.Api20210601.IResourceInternal)__resource).SystemDataCreatedBy = value ?? null; }

        /// <summary>The type of identity that created the resource</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Cdn.Origin(Microsoft.Azure.PowerShell.Cmdlets.Cdn.PropertyOrigin.Inherited)]
        public Microsoft.Azure.PowerShell.Cmdlets.Cdn.Support.IdentityType? SystemDataCreatedByType { get => ((Microsoft.Azure.PowerShell.Cmdlets.Cdn.Models.Api20210601.IResourceInternal)__resource).SystemDataCreatedByType; set => ((Microsoft.Azure.PowerShell.Cmdlets.Cdn.Models.Api20210601.IResourceInternal)__resource).SystemDataCreatedByType = value ?? ((Microsoft.Azure.PowerShell.Cmdlets.Cdn.Support.IdentityType)""); }

        /// <summary>The timestamp of resource last modification (UTC)</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Cdn.Origin(Microsoft.Azure.PowerShell.Cmdlets.Cdn.PropertyOrigin.Inherited)]
        public global::System.DateTime? SystemDataLastModifiedAt { get => ((Microsoft.Azure.PowerShell.Cmdlets.Cdn.Models.Api20210601.IResourceInternal)__resource).SystemDataLastModifiedAt; set => ((Microsoft.Azure.PowerShell.Cmdlets.Cdn.Models.Api20210601.IResourceInternal)__resource).SystemDataLastModifiedAt = value ?? default(global::System.DateTime); }

        /// <summary>An identifier for the identity that last modified the resource</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Cdn.Origin(Microsoft.Azure.PowerShell.Cmdlets.Cdn.PropertyOrigin.Inherited)]
        public string SystemDataLastModifiedBy { get => ((Microsoft.Azure.PowerShell.Cmdlets.Cdn.Models.Api20210601.IResourceInternal)__resource).SystemDataLastModifiedBy; set => ((Microsoft.Azure.PowerShell.Cmdlets.Cdn.Models.Api20210601.IResourceInternal)__resource).SystemDataLastModifiedBy = value ?? null; }

        /// <summary>The type of identity that last modified the resource</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Cdn.Origin(Microsoft.Azure.PowerShell.Cmdlets.Cdn.PropertyOrigin.Inherited)]
        public Microsoft.Azure.PowerShell.Cmdlets.Cdn.Support.IdentityType? SystemDataLastModifiedByType { get => ((Microsoft.Azure.PowerShell.Cmdlets.Cdn.Models.Api20210601.IResourceInternal)__resource).SystemDataLastModifiedByType; set => ((Microsoft.Azure.PowerShell.Cmdlets.Cdn.Models.Api20210601.IResourceInternal)__resource).SystemDataLastModifiedByType = value ?? ((Microsoft.Azure.PowerShell.Cmdlets.Cdn.Support.IdentityType)""); }

        /// <summary>
        /// Time in minutes to shift the traffic to the endpoint gradually when an unhealthy endpoint comes healthy or a new endpoint
        /// is added. Default is 10 mins. This property is currently not supported.
        /// </summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Cdn.Origin(Microsoft.Azure.PowerShell.Cmdlets.Cdn.PropertyOrigin.Inlined)]
        public int? TrafficRestorationTimeToHealedOrNewEndpointsInMinute { get => ((Microsoft.Azure.PowerShell.Cmdlets.Cdn.Models.Api20210601.IAfdOriginGroupUpdatePropertiesParametersInternal)Property).TrafficRestorationTimeToHealedOrNewEndpointsInMinute; set => ((Microsoft.Azure.PowerShell.Cmdlets.Cdn.Models.Api20210601.IAfdOriginGroupUpdatePropertiesParametersInternal)Property).TrafficRestorationTimeToHealedOrNewEndpointsInMinute = value ?? default(int); }

        /// <summary>Resource type.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Cdn.Origin(Microsoft.Azure.PowerShell.Cmdlets.Cdn.PropertyOrigin.Inherited)]
        public string Type { get => ((Microsoft.Azure.PowerShell.Cmdlets.Cdn.Models.Api20210601.IResourceInternal)__resource).Type; }

        /// <summary>Creates an new <see cref="AfdOriginGroup" /> instance.</summary>
        public AfdOriginGroup()
        {

        }

        /// <summary>Validates that this object meets the validation criteria.</summary>
        /// <param name="eventListener">an <see cref="Microsoft.Azure.PowerShell.Cmdlets.Cdn.Runtime.IEventListener" /> instance that will receive validation
        /// events.</param>
        /// <returns>
        /// A < see cref = "global::System.Threading.Tasks.Task" /> that will be complete when validation is completed.
        /// </returns>
        public async global::System.Threading.Tasks.Task Validate(Microsoft.Azure.PowerShell.Cmdlets.Cdn.Runtime.IEventListener eventListener)
        {
            await eventListener.AssertNotNull(nameof(__resource), __resource);
            await eventListener.AssertObjectIsValid(nameof(__resource), __resource);
        }
    }
    /// AFDOrigin group comprising of origins is used for load balancing to origins when the content cannot be served from CDN.
    public partial interface IAfdOriginGroup :
        Microsoft.Azure.PowerShell.Cmdlets.Cdn.Runtime.IJsonSerializable,
        Microsoft.Azure.PowerShell.Cmdlets.Cdn.Models.Api20210601.IResource
    {
        [Microsoft.Azure.PowerShell.Cmdlets.Cdn.Runtime.Info(
        Required = false,
        ReadOnly = true,
        Description = @"",
        SerializedName = @"deploymentStatus",
        PossibleTypes = new [] { typeof(Microsoft.Azure.PowerShell.Cmdlets.Cdn.Support.DeploymentStatus) })]
        Microsoft.Azure.PowerShell.Cmdlets.Cdn.Support.DeploymentStatus? DeploymentStatus { get;  }
        /// <summary>The number of seconds between health probes.Default is 240sec.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Cdn.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"The number of seconds between health probes.Default is 240sec.",
        SerializedName = @"probeIntervalInSeconds",
        PossibleTypes = new [] { typeof(int) })]
        int? HealthProbeSettingProbeIntervalInSecond { get; set; }
        /// <summary>
        /// The path relative to the origin that is used to determine the health of the origin.
        /// </summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Cdn.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"The path relative to the origin that is used to determine the health of the origin.",
        SerializedName = @"probePath",
        PossibleTypes = new [] { typeof(string) })]
        string HealthProbeSettingProbePath { get; set; }
        /// <summary>Protocol to use for health probe.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Cdn.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"Protocol to use for health probe.",
        SerializedName = @"probeProtocol",
        PossibleTypes = new [] { typeof(Microsoft.Azure.PowerShell.Cmdlets.Cdn.Support.ProbeProtocol) })]
        Microsoft.Azure.PowerShell.Cmdlets.Cdn.Support.ProbeProtocol? HealthProbeSettingProbeProtocol { get; set; }
        /// <summary>The type of health probe request that is made.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Cdn.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"The type of health probe request that is made.",
        SerializedName = @"probeRequestType",
        PossibleTypes = new [] { typeof(Microsoft.Azure.PowerShell.Cmdlets.Cdn.Support.HealthProbeRequestType) })]
        Microsoft.Azure.PowerShell.Cmdlets.Cdn.Support.HealthProbeRequestType? HealthProbeSettingProbeRequestType { get; set; }
        /// <summary>
        /// The additional latency in milliseconds for probes to fall into the lowest latency bucket
        /// </summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Cdn.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"The additional latency in milliseconds for probes to fall into the lowest latency bucket",
        SerializedName = @"additionalLatencyInMilliseconds",
        PossibleTypes = new [] { typeof(int) })]
        int? LoadBalancingSettingAdditionalLatencyInMillisecond { get; set; }
        /// <summary>The number of samples to consider for load balancing decisions</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Cdn.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"The number of samples to consider for load balancing decisions",
        SerializedName = @"sampleSize",
        PossibleTypes = new [] { typeof(int) })]
        int? LoadBalancingSettingSampleSize { get; set; }
        /// <summary>The number of samples within the sample period that must succeed</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Cdn.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"The number of samples within the sample period that must succeed",
        SerializedName = @"successfulSamplesRequired",
        PossibleTypes = new [] { typeof(int) })]
        int? LoadBalancingSettingSuccessfulSamplesRequired { get; set; }
        /// <summary>The name of the profile which holds the origin group.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Cdn.Runtime.Info(
        Required = false,
        ReadOnly = true,
        Description = @"The name of the profile which holds the origin group.",
        SerializedName = @"profileName",
        PossibleTypes = new [] { typeof(string) })]
        string ProfileName { get;  }
        /// <summary>Provisioning status</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Cdn.Runtime.Info(
        Required = false,
        ReadOnly = true,
        Description = @"Provisioning status",
        SerializedName = @"provisioningState",
        PossibleTypes = new [] { typeof(Microsoft.Azure.PowerShell.Cmdlets.Cdn.Support.AfdProvisioningState) })]
        Microsoft.Azure.PowerShell.Cmdlets.Cdn.Support.AfdProvisioningState? ProvisioningState { get;  }
        /// <summary>
        /// Whether to allow session affinity on this host. Valid options are 'Enabled' or 'Disabled'
        /// </summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Cdn.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"Whether to allow session affinity on this host. Valid options are 'Enabled' or 'Disabled'",
        SerializedName = @"sessionAffinityState",
        PossibleTypes = new [] { typeof(Microsoft.Azure.PowerShell.Cmdlets.Cdn.Support.EnabledState) })]
        Microsoft.Azure.PowerShell.Cmdlets.Cdn.Support.EnabledState? SessionAffinityState { get; set; }
        /// <summary>
        /// Time in minutes to shift the traffic to the endpoint gradually when an unhealthy endpoint comes healthy or a new endpoint
        /// is added. Default is 10 mins. This property is currently not supported.
        /// </summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Cdn.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"Time in minutes to shift the traffic to the endpoint gradually when an unhealthy endpoint comes healthy or a new endpoint is added. Default is 10 mins. This property is currently not supported.",
        SerializedName = @"trafficRestorationTimeToHealedOrNewEndpointsInMinutes",
        PossibleTypes = new [] { typeof(int) })]
        int? TrafficRestorationTimeToHealedOrNewEndpointsInMinute { get; set; }

    }
    /// AFDOrigin group comprising of origins is used for load balancing to origins when the content cannot be served from CDN.
    internal partial interface IAfdOriginGroupInternal :
        Microsoft.Azure.PowerShell.Cmdlets.Cdn.Models.Api20210601.IResourceInternal
    {
        Microsoft.Azure.PowerShell.Cmdlets.Cdn.Support.DeploymentStatus? DeploymentStatus { get; set; }
        /// <summary>
        /// Health probe settings to the origin that is used to determine the health of the origin.
        /// </summary>
        Microsoft.Azure.PowerShell.Cmdlets.Cdn.Models.Api20210601.IHealthProbeParameters HealthProbeSetting { get; set; }
        /// <summary>The number of seconds between health probes.Default is 240sec.</summary>
        int? HealthProbeSettingProbeIntervalInSecond { get; set; }
        /// <summary>
        /// The path relative to the origin that is used to determine the health of the origin.
        /// </summary>
        string HealthProbeSettingProbePath { get; set; }
        /// <summary>Protocol to use for health probe.</summary>
        Microsoft.Azure.PowerShell.Cmdlets.Cdn.Support.ProbeProtocol? HealthProbeSettingProbeProtocol { get; set; }
        /// <summary>The type of health probe request that is made.</summary>
        Microsoft.Azure.PowerShell.Cmdlets.Cdn.Support.HealthProbeRequestType? HealthProbeSettingProbeRequestType { get; set; }
        /// <summary>Load balancing settings for a backend pool</summary>
        Microsoft.Azure.PowerShell.Cmdlets.Cdn.Models.Api20210601.ILoadBalancingSettingsParameters LoadBalancingSetting { get; set; }
        /// <summary>
        /// The additional latency in milliseconds for probes to fall into the lowest latency bucket
        /// </summary>
        int? LoadBalancingSettingAdditionalLatencyInMillisecond { get; set; }
        /// <summary>The number of samples to consider for load balancing decisions</summary>
        int? LoadBalancingSettingSampleSize { get; set; }
        /// <summary>The number of samples within the sample period that must succeed</summary>
        int? LoadBalancingSettingSuccessfulSamplesRequired { get; set; }
        /// <summary>The name of the profile which holds the origin group.</summary>
        string ProfileName { get; set; }
        /// <summary>The JSON object that contains the properties of the origin group.</summary>
        Microsoft.Azure.PowerShell.Cmdlets.Cdn.Models.Api20210601.IAfdOriginGroupProperties Property { get; set; }
        /// <summary>Provisioning status</summary>
        Microsoft.Azure.PowerShell.Cmdlets.Cdn.Support.AfdProvisioningState? ProvisioningState { get; set; }
        /// <summary>
        /// Whether to allow session affinity on this host. Valid options are 'Enabled' or 'Disabled'
        /// </summary>
        Microsoft.Azure.PowerShell.Cmdlets.Cdn.Support.EnabledState? SessionAffinityState { get; set; }
        /// <summary>
        /// Time in minutes to shift the traffic to the endpoint gradually when an unhealthy endpoint comes healthy or a new endpoint
        /// is added. Default is 10 mins. This property is currently not supported.
        /// </summary>
        int? TrafficRestorationTimeToHealedOrNewEndpointsInMinute { get; set; }

    }
}