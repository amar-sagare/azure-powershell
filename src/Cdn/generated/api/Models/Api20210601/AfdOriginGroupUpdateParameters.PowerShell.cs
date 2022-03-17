// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for license information.
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is regenerated.

namespace Microsoft.Azure.PowerShell.Cmdlets.Cdn.Models.Api20210601
{
    using Microsoft.Azure.PowerShell.Cmdlets.Cdn.Runtime.PowerShell;

    /// <summary>AFDOrigin group properties needed for origin group creation or update.</summary>
    [System.ComponentModel.TypeConverter(typeof(AfdOriginGroupUpdateParametersTypeConverter))]
    public partial class AfdOriginGroupUpdateParameters
    {

        /// <summary>
        /// <c>AfterDeserializeDictionary</c> will be called after the deserialization has finished, allowing customization of the
        /// object before it is returned. Implement this method in a partial class to enable this behavior
        /// </summary>
        /// <param name="content">The global::System.Collections.IDictionary content that should be used.</param>

        partial void AfterDeserializeDictionary(global::System.Collections.IDictionary content);

        /// <summary>
        /// <c>AfterDeserializePSObject</c> will be called after the deserialization has finished, allowing customization of the object
        /// before it is returned. Implement this method in a partial class to enable this behavior
        /// </summary>
        /// <param name="content">The global::System.Management.Automation.PSObject content that should be used.</param>

        partial void AfterDeserializePSObject(global::System.Management.Automation.PSObject content);

        /// <summary>
        /// <c>BeforeDeserializeDictionary</c> will be called before the deserialization has commenced, allowing complete customization
        /// of the object before it is deserialized.
        /// If you wish to disable the default deserialization entirely, return <c>true</c> in the <see "returnNow" /> output parameter.
        /// Implement this method in a partial class to enable this behavior.
        /// </summary>
        /// <param name="content">The global::System.Collections.IDictionary content that should be used.</param>
        /// <param name="returnNow">Determines if the rest of the serialization should be processed, or if the method should return
        /// instantly.</param>

        partial void BeforeDeserializeDictionary(global::System.Collections.IDictionary content, ref bool returnNow);

        /// <summary>
        /// <c>BeforeDeserializePSObject</c> will be called before the deserialization has commenced, allowing complete customization
        /// of the object before it is deserialized.
        /// If you wish to disable the default deserialization entirely, return <c>true</c> in the <see "returnNow" /> output parameter.
        /// Implement this method in a partial class to enable this behavior.
        /// </summary>
        /// <param name="content">The global::System.Management.Automation.PSObject content that should be used.</param>
        /// <param name="returnNow">Determines if the rest of the serialization should be processed, or if the method should return
        /// instantly.</param>

        partial void BeforeDeserializePSObject(global::System.Management.Automation.PSObject content, ref bool returnNow);

        /// <summary>
        /// <c>OverrideToString</c> will be called if it is implemented. Implement this method in a partial class to enable this behavior
        /// </summary>
        /// <param name="stringResult">/// instance serialized to a string, normally it is a Json</param>
        /// <param name="returnNow">/// set returnNow to true if you provide a customized OverrideToString function</param>

        partial void OverrideToString(ref string stringResult, ref bool returnNow);

        /// <summary>
        /// Deserializes a <see cref="global::System.Collections.IDictionary" /> into a new instance of <see cref="Microsoft.Azure.PowerShell.Cmdlets.Cdn.Models.Api20210601.AfdOriginGroupUpdateParameters"
        /// />.
        /// </summary>
        /// <param name="content">The global::System.Collections.IDictionary content that should be used.</param>
        internal AfdOriginGroupUpdateParameters(global::System.Collections.IDictionary content)
        {
            bool returnNow = false;
            BeforeDeserializeDictionary(content, ref returnNow);
            if (returnNow)
            {
                return;
            }
            // actually deserialize
            if (content.Contains("Property"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.Cdn.Models.Api20210601.IAfdOriginGroupUpdateParametersInternal)this).Property = (Microsoft.Azure.PowerShell.Cmdlets.Cdn.Models.Api20210601.IAfdOriginGroupUpdatePropertiesParameters) content.GetValueForProperty("Property",((Microsoft.Azure.PowerShell.Cmdlets.Cdn.Models.Api20210601.IAfdOriginGroupUpdateParametersInternal)this).Property, Microsoft.Azure.PowerShell.Cmdlets.Cdn.Models.Api20210601.AfdOriginGroupUpdatePropertiesParametersTypeConverter.ConvertFrom);
            }
            if (content.Contains("LoadBalancingSetting"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.Cdn.Models.Api20210601.IAfdOriginGroupUpdateParametersInternal)this).LoadBalancingSetting = (Microsoft.Azure.PowerShell.Cmdlets.Cdn.Models.Api20210601.ILoadBalancingSettingsParameters) content.GetValueForProperty("LoadBalancingSetting",((Microsoft.Azure.PowerShell.Cmdlets.Cdn.Models.Api20210601.IAfdOriginGroupUpdateParametersInternal)this).LoadBalancingSetting, Microsoft.Azure.PowerShell.Cmdlets.Cdn.Models.Api20210601.LoadBalancingSettingsParametersTypeConverter.ConvertFrom);
            }
            if (content.Contains("HealthProbeSetting"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.Cdn.Models.Api20210601.IAfdOriginGroupUpdateParametersInternal)this).HealthProbeSetting = (Microsoft.Azure.PowerShell.Cmdlets.Cdn.Models.Api20210601.IHealthProbeParameters) content.GetValueForProperty("HealthProbeSetting",((Microsoft.Azure.PowerShell.Cmdlets.Cdn.Models.Api20210601.IAfdOriginGroupUpdateParametersInternal)this).HealthProbeSetting, Microsoft.Azure.PowerShell.Cmdlets.Cdn.Models.Api20210601.HealthProbeParametersTypeConverter.ConvertFrom);
            }
            if (content.Contains("ProfileName"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.Cdn.Models.Api20210601.IAfdOriginGroupUpdateParametersInternal)this).ProfileName = (string) content.GetValueForProperty("ProfileName",((Microsoft.Azure.PowerShell.Cmdlets.Cdn.Models.Api20210601.IAfdOriginGroupUpdateParametersInternal)this).ProfileName, global::System.Convert.ToString);
            }
            if (content.Contains("TrafficRestorationTimeToHealedOrNewEndpointsInMinute"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.Cdn.Models.Api20210601.IAfdOriginGroupUpdateParametersInternal)this).TrafficRestorationTimeToHealedOrNewEndpointsInMinute = (int?) content.GetValueForProperty("TrafficRestorationTimeToHealedOrNewEndpointsInMinute",((Microsoft.Azure.PowerShell.Cmdlets.Cdn.Models.Api20210601.IAfdOriginGroupUpdateParametersInternal)this).TrafficRestorationTimeToHealedOrNewEndpointsInMinute, (__y)=> (int) global::System.Convert.ChangeType(__y, typeof(int)));
            }
            if (content.Contains("SessionAffinityState"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.Cdn.Models.Api20210601.IAfdOriginGroupUpdateParametersInternal)this).SessionAffinityState = (Microsoft.Azure.PowerShell.Cmdlets.Cdn.Support.EnabledState?) content.GetValueForProperty("SessionAffinityState",((Microsoft.Azure.PowerShell.Cmdlets.Cdn.Models.Api20210601.IAfdOriginGroupUpdateParametersInternal)this).SessionAffinityState, Microsoft.Azure.PowerShell.Cmdlets.Cdn.Support.EnabledState.CreateFrom);
            }
            if (content.Contains("HealthProbeSettingProbeProtocol"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.Cdn.Models.Api20210601.IAfdOriginGroupUpdateParametersInternal)this).HealthProbeSettingProbeProtocol = (Microsoft.Azure.PowerShell.Cmdlets.Cdn.Support.ProbeProtocol?) content.GetValueForProperty("HealthProbeSettingProbeProtocol",((Microsoft.Azure.PowerShell.Cmdlets.Cdn.Models.Api20210601.IAfdOriginGroupUpdateParametersInternal)this).HealthProbeSettingProbeProtocol, Microsoft.Azure.PowerShell.Cmdlets.Cdn.Support.ProbeProtocol.CreateFrom);
            }
            if (content.Contains("LoadBalancingSettingSampleSize"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.Cdn.Models.Api20210601.IAfdOriginGroupUpdateParametersInternal)this).LoadBalancingSettingSampleSize = (int?) content.GetValueForProperty("LoadBalancingSettingSampleSize",((Microsoft.Azure.PowerShell.Cmdlets.Cdn.Models.Api20210601.IAfdOriginGroupUpdateParametersInternal)this).LoadBalancingSettingSampleSize, (__y)=> (int) global::System.Convert.ChangeType(__y, typeof(int)));
            }
            if (content.Contains("LoadBalancingSettingSuccessfulSamplesRequired"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.Cdn.Models.Api20210601.IAfdOriginGroupUpdateParametersInternal)this).LoadBalancingSettingSuccessfulSamplesRequired = (int?) content.GetValueForProperty("LoadBalancingSettingSuccessfulSamplesRequired",((Microsoft.Azure.PowerShell.Cmdlets.Cdn.Models.Api20210601.IAfdOriginGroupUpdateParametersInternal)this).LoadBalancingSettingSuccessfulSamplesRequired, (__y)=> (int) global::System.Convert.ChangeType(__y, typeof(int)));
            }
            if (content.Contains("LoadBalancingSettingAdditionalLatencyInMillisecond"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.Cdn.Models.Api20210601.IAfdOriginGroupUpdateParametersInternal)this).LoadBalancingSettingAdditionalLatencyInMillisecond = (int?) content.GetValueForProperty("LoadBalancingSettingAdditionalLatencyInMillisecond",((Microsoft.Azure.PowerShell.Cmdlets.Cdn.Models.Api20210601.IAfdOriginGroupUpdateParametersInternal)this).LoadBalancingSettingAdditionalLatencyInMillisecond, (__y)=> (int) global::System.Convert.ChangeType(__y, typeof(int)));
            }
            if (content.Contains("HealthProbeSettingProbePath"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.Cdn.Models.Api20210601.IAfdOriginGroupUpdateParametersInternal)this).HealthProbeSettingProbePath = (string) content.GetValueForProperty("HealthProbeSettingProbePath",((Microsoft.Azure.PowerShell.Cmdlets.Cdn.Models.Api20210601.IAfdOriginGroupUpdateParametersInternal)this).HealthProbeSettingProbePath, global::System.Convert.ToString);
            }
            if (content.Contains("HealthProbeSettingProbeRequestType"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.Cdn.Models.Api20210601.IAfdOriginGroupUpdateParametersInternal)this).HealthProbeSettingProbeRequestType = (Microsoft.Azure.PowerShell.Cmdlets.Cdn.Support.HealthProbeRequestType?) content.GetValueForProperty("HealthProbeSettingProbeRequestType",((Microsoft.Azure.PowerShell.Cmdlets.Cdn.Models.Api20210601.IAfdOriginGroupUpdateParametersInternal)this).HealthProbeSettingProbeRequestType, Microsoft.Azure.PowerShell.Cmdlets.Cdn.Support.HealthProbeRequestType.CreateFrom);
            }
            if (content.Contains("HealthProbeSettingProbeIntervalInSecond"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.Cdn.Models.Api20210601.IAfdOriginGroupUpdateParametersInternal)this).HealthProbeSettingProbeIntervalInSecond = (int?) content.GetValueForProperty("HealthProbeSettingProbeIntervalInSecond",((Microsoft.Azure.PowerShell.Cmdlets.Cdn.Models.Api20210601.IAfdOriginGroupUpdateParametersInternal)this).HealthProbeSettingProbeIntervalInSecond, (__y)=> (int) global::System.Convert.ChangeType(__y, typeof(int)));
            }
            AfterDeserializeDictionary(content);
        }

        /// <summary>
        /// Deserializes a <see cref="global::System.Management.Automation.PSObject" /> into a new instance of <see cref="Microsoft.Azure.PowerShell.Cmdlets.Cdn.Models.Api20210601.AfdOriginGroupUpdateParameters"
        /// />.
        /// </summary>
        /// <param name="content">The global::System.Management.Automation.PSObject content that should be used.</param>
        internal AfdOriginGroupUpdateParameters(global::System.Management.Automation.PSObject content)
        {
            bool returnNow = false;
            BeforeDeserializePSObject(content, ref returnNow);
            if (returnNow)
            {
                return;
            }
            // actually deserialize
            if (content.Contains("Property"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.Cdn.Models.Api20210601.IAfdOriginGroupUpdateParametersInternal)this).Property = (Microsoft.Azure.PowerShell.Cmdlets.Cdn.Models.Api20210601.IAfdOriginGroupUpdatePropertiesParameters) content.GetValueForProperty("Property",((Microsoft.Azure.PowerShell.Cmdlets.Cdn.Models.Api20210601.IAfdOriginGroupUpdateParametersInternal)this).Property, Microsoft.Azure.PowerShell.Cmdlets.Cdn.Models.Api20210601.AfdOriginGroupUpdatePropertiesParametersTypeConverter.ConvertFrom);
            }
            if (content.Contains("LoadBalancingSetting"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.Cdn.Models.Api20210601.IAfdOriginGroupUpdateParametersInternal)this).LoadBalancingSetting = (Microsoft.Azure.PowerShell.Cmdlets.Cdn.Models.Api20210601.ILoadBalancingSettingsParameters) content.GetValueForProperty("LoadBalancingSetting",((Microsoft.Azure.PowerShell.Cmdlets.Cdn.Models.Api20210601.IAfdOriginGroupUpdateParametersInternal)this).LoadBalancingSetting, Microsoft.Azure.PowerShell.Cmdlets.Cdn.Models.Api20210601.LoadBalancingSettingsParametersTypeConverter.ConvertFrom);
            }
            if (content.Contains("HealthProbeSetting"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.Cdn.Models.Api20210601.IAfdOriginGroupUpdateParametersInternal)this).HealthProbeSetting = (Microsoft.Azure.PowerShell.Cmdlets.Cdn.Models.Api20210601.IHealthProbeParameters) content.GetValueForProperty("HealthProbeSetting",((Microsoft.Azure.PowerShell.Cmdlets.Cdn.Models.Api20210601.IAfdOriginGroupUpdateParametersInternal)this).HealthProbeSetting, Microsoft.Azure.PowerShell.Cmdlets.Cdn.Models.Api20210601.HealthProbeParametersTypeConverter.ConvertFrom);
            }
            if (content.Contains("ProfileName"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.Cdn.Models.Api20210601.IAfdOriginGroupUpdateParametersInternal)this).ProfileName = (string) content.GetValueForProperty("ProfileName",((Microsoft.Azure.PowerShell.Cmdlets.Cdn.Models.Api20210601.IAfdOriginGroupUpdateParametersInternal)this).ProfileName, global::System.Convert.ToString);
            }
            if (content.Contains("TrafficRestorationTimeToHealedOrNewEndpointsInMinute"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.Cdn.Models.Api20210601.IAfdOriginGroupUpdateParametersInternal)this).TrafficRestorationTimeToHealedOrNewEndpointsInMinute = (int?) content.GetValueForProperty("TrafficRestorationTimeToHealedOrNewEndpointsInMinute",((Microsoft.Azure.PowerShell.Cmdlets.Cdn.Models.Api20210601.IAfdOriginGroupUpdateParametersInternal)this).TrafficRestorationTimeToHealedOrNewEndpointsInMinute, (__y)=> (int) global::System.Convert.ChangeType(__y, typeof(int)));
            }
            if (content.Contains("SessionAffinityState"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.Cdn.Models.Api20210601.IAfdOriginGroupUpdateParametersInternal)this).SessionAffinityState = (Microsoft.Azure.PowerShell.Cmdlets.Cdn.Support.EnabledState?) content.GetValueForProperty("SessionAffinityState",((Microsoft.Azure.PowerShell.Cmdlets.Cdn.Models.Api20210601.IAfdOriginGroupUpdateParametersInternal)this).SessionAffinityState, Microsoft.Azure.PowerShell.Cmdlets.Cdn.Support.EnabledState.CreateFrom);
            }
            if (content.Contains("HealthProbeSettingProbeProtocol"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.Cdn.Models.Api20210601.IAfdOriginGroupUpdateParametersInternal)this).HealthProbeSettingProbeProtocol = (Microsoft.Azure.PowerShell.Cmdlets.Cdn.Support.ProbeProtocol?) content.GetValueForProperty("HealthProbeSettingProbeProtocol",((Microsoft.Azure.PowerShell.Cmdlets.Cdn.Models.Api20210601.IAfdOriginGroupUpdateParametersInternal)this).HealthProbeSettingProbeProtocol, Microsoft.Azure.PowerShell.Cmdlets.Cdn.Support.ProbeProtocol.CreateFrom);
            }
            if (content.Contains("LoadBalancingSettingSampleSize"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.Cdn.Models.Api20210601.IAfdOriginGroupUpdateParametersInternal)this).LoadBalancingSettingSampleSize = (int?) content.GetValueForProperty("LoadBalancingSettingSampleSize",((Microsoft.Azure.PowerShell.Cmdlets.Cdn.Models.Api20210601.IAfdOriginGroupUpdateParametersInternal)this).LoadBalancingSettingSampleSize, (__y)=> (int) global::System.Convert.ChangeType(__y, typeof(int)));
            }
            if (content.Contains("LoadBalancingSettingSuccessfulSamplesRequired"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.Cdn.Models.Api20210601.IAfdOriginGroupUpdateParametersInternal)this).LoadBalancingSettingSuccessfulSamplesRequired = (int?) content.GetValueForProperty("LoadBalancingSettingSuccessfulSamplesRequired",((Microsoft.Azure.PowerShell.Cmdlets.Cdn.Models.Api20210601.IAfdOriginGroupUpdateParametersInternal)this).LoadBalancingSettingSuccessfulSamplesRequired, (__y)=> (int) global::System.Convert.ChangeType(__y, typeof(int)));
            }
            if (content.Contains("LoadBalancingSettingAdditionalLatencyInMillisecond"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.Cdn.Models.Api20210601.IAfdOriginGroupUpdateParametersInternal)this).LoadBalancingSettingAdditionalLatencyInMillisecond = (int?) content.GetValueForProperty("LoadBalancingSettingAdditionalLatencyInMillisecond",((Microsoft.Azure.PowerShell.Cmdlets.Cdn.Models.Api20210601.IAfdOriginGroupUpdateParametersInternal)this).LoadBalancingSettingAdditionalLatencyInMillisecond, (__y)=> (int) global::System.Convert.ChangeType(__y, typeof(int)));
            }
            if (content.Contains("HealthProbeSettingProbePath"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.Cdn.Models.Api20210601.IAfdOriginGroupUpdateParametersInternal)this).HealthProbeSettingProbePath = (string) content.GetValueForProperty("HealthProbeSettingProbePath",((Microsoft.Azure.PowerShell.Cmdlets.Cdn.Models.Api20210601.IAfdOriginGroupUpdateParametersInternal)this).HealthProbeSettingProbePath, global::System.Convert.ToString);
            }
            if (content.Contains("HealthProbeSettingProbeRequestType"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.Cdn.Models.Api20210601.IAfdOriginGroupUpdateParametersInternal)this).HealthProbeSettingProbeRequestType = (Microsoft.Azure.PowerShell.Cmdlets.Cdn.Support.HealthProbeRequestType?) content.GetValueForProperty("HealthProbeSettingProbeRequestType",((Microsoft.Azure.PowerShell.Cmdlets.Cdn.Models.Api20210601.IAfdOriginGroupUpdateParametersInternal)this).HealthProbeSettingProbeRequestType, Microsoft.Azure.PowerShell.Cmdlets.Cdn.Support.HealthProbeRequestType.CreateFrom);
            }
            if (content.Contains("HealthProbeSettingProbeIntervalInSecond"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.Cdn.Models.Api20210601.IAfdOriginGroupUpdateParametersInternal)this).HealthProbeSettingProbeIntervalInSecond = (int?) content.GetValueForProperty("HealthProbeSettingProbeIntervalInSecond",((Microsoft.Azure.PowerShell.Cmdlets.Cdn.Models.Api20210601.IAfdOriginGroupUpdateParametersInternal)this).HealthProbeSettingProbeIntervalInSecond, (__y)=> (int) global::System.Convert.ChangeType(__y, typeof(int)));
            }
            AfterDeserializePSObject(content);
        }

        /// <summary>
        /// Deserializes a <see cref="global::System.Collections.IDictionary" /> into an instance of <see cref="Microsoft.Azure.PowerShell.Cmdlets.Cdn.Models.Api20210601.AfdOriginGroupUpdateParameters"
        /// />.
        /// </summary>
        /// <param name="content">The global::System.Collections.IDictionary content that should be used.</param>
        /// <returns>
        /// an instance of <see cref="Microsoft.Azure.PowerShell.Cmdlets.Cdn.Models.Api20210601.IAfdOriginGroupUpdateParameters" />.
        /// </returns>
        public static Microsoft.Azure.PowerShell.Cmdlets.Cdn.Models.Api20210601.IAfdOriginGroupUpdateParameters DeserializeFromDictionary(global::System.Collections.IDictionary content)
        {
            return new AfdOriginGroupUpdateParameters(content);
        }

        /// <summary>
        /// Deserializes a <see cref="global::System.Management.Automation.PSObject" /> into an instance of <see cref="Microsoft.Azure.PowerShell.Cmdlets.Cdn.Models.Api20210601.AfdOriginGroupUpdateParameters"
        /// />.
        /// </summary>
        /// <param name="content">The global::System.Management.Automation.PSObject content that should be used.</param>
        /// <returns>
        /// an instance of <see cref="Microsoft.Azure.PowerShell.Cmdlets.Cdn.Models.Api20210601.IAfdOriginGroupUpdateParameters" />.
        /// </returns>
        public static Microsoft.Azure.PowerShell.Cmdlets.Cdn.Models.Api20210601.IAfdOriginGroupUpdateParameters DeserializeFromPSObject(global::System.Management.Automation.PSObject content)
        {
            return new AfdOriginGroupUpdateParameters(content);
        }

        /// <summary>
        /// Creates a new instance of <see cref="AfdOriginGroupUpdateParameters" />, deserializing the content from a json string.
        /// </summary>
        /// <param name="jsonText">a string containing a JSON serialized instance of this model.</param>
        /// <returns>an instance of the <see cref="className" /> model class.</returns>
        public static Microsoft.Azure.PowerShell.Cmdlets.Cdn.Models.Api20210601.IAfdOriginGroupUpdateParameters FromJsonString(string jsonText) => FromJson(Microsoft.Azure.PowerShell.Cmdlets.Cdn.Runtime.Json.JsonNode.Parse(jsonText));

        /// <summary>Serializes this instance to a json string.</summary>

        /// <returns>a <see cref="System.String" /> containing this model serialized to JSON text.</returns>
        public string ToJsonString() => ToJson(null, Microsoft.Azure.PowerShell.Cmdlets.Cdn.Runtime.SerializationMode.IncludeAll)?.ToString();

        public override string ToString()
        {
            var returnNow = false;
            var result = global::System.String.Empty;
            OverrideToString(ref result, ref returnNow);
            if (returnNow)
            {
                return result;
            }
            return ToJsonString();
        }
    }
    /// AFDOrigin group properties needed for origin group creation or update.
    [System.ComponentModel.TypeConverter(typeof(AfdOriginGroupUpdateParametersTypeConverter))]
    public partial interface IAfdOriginGroupUpdateParameters

    {

    }
}