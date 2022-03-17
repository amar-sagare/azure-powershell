// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for license information.
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is regenerated.

namespace Microsoft.Azure.PowerShell.Cmdlets.Cdn.Models.Api20210601
{
    using Microsoft.Azure.PowerShell.Cmdlets.Cdn.Runtime.PowerShell;

    /// <summary>The JSON object that contains the properties of the domain to create.</summary>
    [System.ComponentModel.TypeConverter(typeof(AfdDomainPropertiesTypeConverter))]
    public partial class AfdDomainProperties
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
        /// Deserializes a <see cref="global::System.Collections.IDictionary" /> into a new instance of <see cref="Microsoft.Azure.PowerShell.Cmdlets.Cdn.Models.Api20210601.AfdDomainProperties"
        /// />.
        /// </summary>
        /// <param name="content">The global::System.Collections.IDictionary content that should be used.</param>
        internal AfdDomainProperties(global::System.Collections.IDictionary content)
        {
            bool returnNow = false;
            BeforeDeserializeDictionary(content, ref returnNow);
            if (returnNow)
            {
                return;
            }
            // actually deserialize
            if (content.Contains("ValidationProperty"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.Cdn.Models.Api20210601.IAfdDomainPropertiesInternal)this).ValidationProperty = (Microsoft.Azure.PowerShell.Cmdlets.Cdn.Models.Api20210601.IDomainValidationProperties) content.GetValueForProperty("ValidationProperty",((Microsoft.Azure.PowerShell.Cmdlets.Cdn.Models.Api20210601.IAfdDomainPropertiesInternal)this).ValidationProperty, Microsoft.Azure.PowerShell.Cmdlets.Cdn.Models.Api20210601.DomainValidationPropertiesTypeConverter.ConvertFrom);
            }
            if (content.Contains("DomainValidationState"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.Cdn.Models.Api20210601.IAfdDomainPropertiesInternal)this).DomainValidationState = (Microsoft.Azure.PowerShell.Cmdlets.Cdn.Support.DomainValidationState?) content.GetValueForProperty("DomainValidationState",((Microsoft.Azure.PowerShell.Cmdlets.Cdn.Models.Api20210601.IAfdDomainPropertiesInternal)this).DomainValidationState, Microsoft.Azure.PowerShell.Cmdlets.Cdn.Support.DomainValidationState.CreateFrom);
            }
            if (content.Contains("HostName"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.Cdn.Models.Api20210601.IAfdDomainPropertiesInternal)this).HostName = (string) content.GetValueForProperty("HostName",((Microsoft.Azure.PowerShell.Cmdlets.Cdn.Models.Api20210601.IAfdDomainPropertiesInternal)this).HostName, global::System.Convert.ToString);
            }
            if (content.Contains("TlSettingSecret"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.Cdn.Models.Api20210601.IAfdDomainUpdatePropertiesParametersInternal)this).TlSettingSecret = (Microsoft.Azure.PowerShell.Cmdlets.Cdn.Models.Api20210601.IResourceReference) content.GetValueForProperty("TlSettingSecret",((Microsoft.Azure.PowerShell.Cmdlets.Cdn.Models.Api20210601.IAfdDomainUpdatePropertiesParametersInternal)this).TlSettingSecret, Microsoft.Azure.PowerShell.Cmdlets.Cdn.Models.Api20210601.ResourceReferenceTypeConverter.ConvertFrom);
            }
            if (content.Contains("TlSettingCertificateType"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.Cdn.Models.Api20210601.IAfdDomainUpdatePropertiesParametersInternal)this).TlSettingCertificateType = (Microsoft.Azure.PowerShell.Cmdlets.Cdn.Support.AfdCertificateType) content.GetValueForProperty("TlSettingCertificateType",((Microsoft.Azure.PowerShell.Cmdlets.Cdn.Models.Api20210601.IAfdDomainUpdatePropertiesParametersInternal)this).TlSettingCertificateType, Microsoft.Azure.PowerShell.Cmdlets.Cdn.Support.AfdCertificateType.CreateFrom);
            }
            if (content.Contains("TlSettingMinimumTlsVersion"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.Cdn.Models.Api20210601.IAfdDomainUpdatePropertiesParametersInternal)this).TlSettingMinimumTlsVersion = (Microsoft.Azure.PowerShell.Cmdlets.Cdn.Support.AfdMinimumTlsVersion?) content.GetValueForProperty("TlSettingMinimumTlsVersion",((Microsoft.Azure.PowerShell.Cmdlets.Cdn.Models.Api20210601.IAfdDomainUpdatePropertiesParametersInternal)this).TlSettingMinimumTlsVersion, Microsoft.Azure.PowerShell.Cmdlets.Cdn.Support.AfdMinimumTlsVersion.CreateFrom);
            }
            if (content.Contains("AzureDnsZoneId"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.Cdn.Models.Api20210601.IAfdDomainUpdatePropertiesParametersInternal)this).AzureDnsZoneId = (string) content.GetValueForProperty("AzureDnsZoneId",((Microsoft.Azure.PowerShell.Cmdlets.Cdn.Models.Api20210601.IAfdDomainUpdatePropertiesParametersInternal)this).AzureDnsZoneId, global::System.Convert.ToString);
            }
            if (content.Contains("PreValidatedCustomDomainResourceId"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.Cdn.Models.Api20210601.IAfdDomainUpdatePropertiesParametersInternal)this).PreValidatedCustomDomainResourceId = (string) content.GetValueForProperty("PreValidatedCustomDomainResourceId",((Microsoft.Azure.PowerShell.Cmdlets.Cdn.Models.Api20210601.IAfdDomainUpdatePropertiesParametersInternal)this).PreValidatedCustomDomainResourceId, global::System.Convert.ToString);
            }
            if (content.Contains("SecretId"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.Cdn.Models.Api20210601.IAfdDomainUpdatePropertiesParametersInternal)this).SecretId = (string) content.GetValueForProperty("SecretId",((Microsoft.Azure.PowerShell.Cmdlets.Cdn.Models.Api20210601.IAfdDomainUpdatePropertiesParametersInternal)this).SecretId, global::System.Convert.ToString);
            }
            if (content.Contains("TlsSetting"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.Cdn.Models.Api20210601.IAfdDomainUpdatePropertiesParametersInternal)this).TlsSetting = (Microsoft.Azure.PowerShell.Cmdlets.Cdn.Models.Api20210601.IAfdDomainHttpsParameters) content.GetValueForProperty("TlsSetting",((Microsoft.Azure.PowerShell.Cmdlets.Cdn.Models.Api20210601.IAfdDomainUpdatePropertiesParametersInternal)this).TlsSetting, Microsoft.Azure.PowerShell.Cmdlets.Cdn.Models.Api20210601.AfdDomainHttpsParametersTypeConverter.ConvertFrom);
            }
            if (content.Contains("AzureDnsZone"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.Cdn.Models.Api20210601.IAfdDomainUpdatePropertiesParametersInternal)this).AzureDnsZone = (Microsoft.Azure.PowerShell.Cmdlets.Cdn.Models.Api20210601.IResourceReference) content.GetValueForProperty("AzureDnsZone",((Microsoft.Azure.PowerShell.Cmdlets.Cdn.Models.Api20210601.IAfdDomainUpdatePropertiesParametersInternal)this).AzureDnsZone, Microsoft.Azure.PowerShell.Cmdlets.Cdn.Models.Api20210601.ResourceReferenceTypeConverter.ConvertFrom);
            }
            if (content.Contains("AfdDomainUpdatePropertiesParametersPreValidatedCustomDomainResourceId"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.Cdn.Models.Api20210601.IAfdDomainUpdatePropertiesParametersInternal)this).AfdDomainUpdatePropertiesParametersPreValidatedCustomDomainResourceId = (Microsoft.Azure.PowerShell.Cmdlets.Cdn.Models.Api20210601.IResourceReference) content.GetValueForProperty("AfdDomainUpdatePropertiesParametersPreValidatedCustomDomainResourceId",((Microsoft.Azure.PowerShell.Cmdlets.Cdn.Models.Api20210601.IAfdDomainUpdatePropertiesParametersInternal)this).AfdDomainUpdatePropertiesParametersPreValidatedCustomDomainResourceId, Microsoft.Azure.PowerShell.Cmdlets.Cdn.Models.Api20210601.ResourceReferenceTypeConverter.ConvertFrom);
            }
            if (content.Contains("ProfileName"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.Cdn.Models.Api20210601.IAfdDomainUpdatePropertiesParametersInternal)this).ProfileName = (string) content.GetValueForProperty("ProfileName",((Microsoft.Azure.PowerShell.Cmdlets.Cdn.Models.Api20210601.IAfdDomainUpdatePropertiesParametersInternal)this).ProfileName, global::System.Convert.ToString);
            }
            if (content.Contains("ProvisioningState"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.Cdn.Models.Api20210601.IAfdStatePropertiesInternal)this).ProvisioningState = (Microsoft.Azure.PowerShell.Cmdlets.Cdn.Support.AfdProvisioningState?) content.GetValueForProperty("ProvisioningState",((Microsoft.Azure.PowerShell.Cmdlets.Cdn.Models.Api20210601.IAfdStatePropertiesInternal)this).ProvisioningState, Microsoft.Azure.PowerShell.Cmdlets.Cdn.Support.AfdProvisioningState.CreateFrom);
            }
            if (content.Contains("DeploymentStatus"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.Cdn.Models.Api20210601.IAfdStatePropertiesInternal)this).DeploymentStatus = (Microsoft.Azure.PowerShell.Cmdlets.Cdn.Support.DeploymentStatus?) content.GetValueForProperty("DeploymentStatus",((Microsoft.Azure.PowerShell.Cmdlets.Cdn.Models.Api20210601.IAfdStatePropertiesInternal)this).DeploymentStatus, Microsoft.Azure.PowerShell.Cmdlets.Cdn.Support.DeploymentStatus.CreateFrom);
            }
            if (content.Contains("ValidationPropertyValidationToken"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.Cdn.Models.Api20210601.IAfdDomainPropertiesInternal)this).ValidationPropertyValidationToken = (string) content.GetValueForProperty("ValidationPropertyValidationToken",((Microsoft.Azure.PowerShell.Cmdlets.Cdn.Models.Api20210601.IAfdDomainPropertiesInternal)this).ValidationPropertyValidationToken, global::System.Convert.ToString);
            }
            if (content.Contains("ValidationPropertyExpirationDate"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.Cdn.Models.Api20210601.IAfdDomainPropertiesInternal)this).ValidationPropertyExpirationDate = (string) content.GetValueForProperty("ValidationPropertyExpirationDate",((Microsoft.Azure.PowerShell.Cmdlets.Cdn.Models.Api20210601.IAfdDomainPropertiesInternal)this).ValidationPropertyExpirationDate, global::System.Convert.ToString);
            }
            AfterDeserializeDictionary(content);
        }

        /// <summary>
        /// Deserializes a <see cref="global::System.Management.Automation.PSObject" /> into a new instance of <see cref="Microsoft.Azure.PowerShell.Cmdlets.Cdn.Models.Api20210601.AfdDomainProperties"
        /// />.
        /// </summary>
        /// <param name="content">The global::System.Management.Automation.PSObject content that should be used.</param>
        internal AfdDomainProperties(global::System.Management.Automation.PSObject content)
        {
            bool returnNow = false;
            BeforeDeserializePSObject(content, ref returnNow);
            if (returnNow)
            {
                return;
            }
            // actually deserialize
            if (content.Contains("ValidationProperty"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.Cdn.Models.Api20210601.IAfdDomainPropertiesInternal)this).ValidationProperty = (Microsoft.Azure.PowerShell.Cmdlets.Cdn.Models.Api20210601.IDomainValidationProperties) content.GetValueForProperty("ValidationProperty",((Microsoft.Azure.PowerShell.Cmdlets.Cdn.Models.Api20210601.IAfdDomainPropertiesInternal)this).ValidationProperty, Microsoft.Azure.PowerShell.Cmdlets.Cdn.Models.Api20210601.DomainValidationPropertiesTypeConverter.ConvertFrom);
            }
            if (content.Contains("DomainValidationState"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.Cdn.Models.Api20210601.IAfdDomainPropertiesInternal)this).DomainValidationState = (Microsoft.Azure.PowerShell.Cmdlets.Cdn.Support.DomainValidationState?) content.GetValueForProperty("DomainValidationState",((Microsoft.Azure.PowerShell.Cmdlets.Cdn.Models.Api20210601.IAfdDomainPropertiesInternal)this).DomainValidationState, Microsoft.Azure.PowerShell.Cmdlets.Cdn.Support.DomainValidationState.CreateFrom);
            }
            if (content.Contains("HostName"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.Cdn.Models.Api20210601.IAfdDomainPropertiesInternal)this).HostName = (string) content.GetValueForProperty("HostName",((Microsoft.Azure.PowerShell.Cmdlets.Cdn.Models.Api20210601.IAfdDomainPropertiesInternal)this).HostName, global::System.Convert.ToString);
            }
            if (content.Contains("TlSettingSecret"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.Cdn.Models.Api20210601.IAfdDomainUpdatePropertiesParametersInternal)this).TlSettingSecret = (Microsoft.Azure.PowerShell.Cmdlets.Cdn.Models.Api20210601.IResourceReference) content.GetValueForProperty("TlSettingSecret",((Microsoft.Azure.PowerShell.Cmdlets.Cdn.Models.Api20210601.IAfdDomainUpdatePropertiesParametersInternal)this).TlSettingSecret, Microsoft.Azure.PowerShell.Cmdlets.Cdn.Models.Api20210601.ResourceReferenceTypeConverter.ConvertFrom);
            }
            if (content.Contains("TlSettingCertificateType"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.Cdn.Models.Api20210601.IAfdDomainUpdatePropertiesParametersInternal)this).TlSettingCertificateType = (Microsoft.Azure.PowerShell.Cmdlets.Cdn.Support.AfdCertificateType) content.GetValueForProperty("TlSettingCertificateType",((Microsoft.Azure.PowerShell.Cmdlets.Cdn.Models.Api20210601.IAfdDomainUpdatePropertiesParametersInternal)this).TlSettingCertificateType, Microsoft.Azure.PowerShell.Cmdlets.Cdn.Support.AfdCertificateType.CreateFrom);
            }
            if (content.Contains("TlSettingMinimumTlsVersion"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.Cdn.Models.Api20210601.IAfdDomainUpdatePropertiesParametersInternal)this).TlSettingMinimumTlsVersion = (Microsoft.Azure.PowerShell.Cmdlets.Cdn.Support.AfdMinimumTlsVersion?) content.GetValueForProperty("TlSettingMinimumTlsVersion",((Microsoft.Azure.PowerShell.Cmdlets.Cdn.Models.Api20210601.IAfdDomainUpdatePropertiesParametersInternal)this).TlSettingMinimumTlsVersion, Microsoft.Azure.PowerShell.Cmdlets.Cdn.Support.AfdMinimumTlsVersion.CreateFrom);
            }
            if (content.Contains("AzureDnsZoneId"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.Cdn.Models.Api20210601.IAfdDomainUpdatePropertiesParametersInternal)this).AzureDnsZoneId = (string) content.GetValueForProperty("AzureDnsZoneId",((Microsoft.Azure.PowerShell.Cmdlets.Cdn.Models.Api20210601.IAfdDomainUpdatePropertiesParametersInternal)this).AzureDnsZoneId, global::System.Convert.ToString);
            }
            if (content.Contains("PreValidatedCustomDomainResourceId"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.Cdn.Models.Api20210601.IAfdDomainUpdatePropertiesParametersInternal)this).PreValidatedCustomDomainResourceId = (string) content.GetValueForProperty("PreValidatedCustomDomainResourceId",((Microsoft.Azure.PowerShell.Cmdlets.Cdn.Models.Api20210601.IAfdDomainUpdatePropertiesParametersInternal)this).PreValidatedCustomDomainResourceId, global::System.Convert.ToString);
            }
            if (content.Contains("SecretId"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.Cdn.Models.Api20210601.IAfdDomainUpdatePropertiesParametersInternal)this).SecretId = (string) content.GetValueForProperty("SecretId",((Microsoft.Azure.PowerShell.Cmdlets.Cdn.Models.Api20210601.IAfdDomainUpdatePropertiesParametersInternal)this).SecretId, global::System.Convert.ToString);
            }
            if (content.Contains("TlsSetting"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.Cdn.Models.Api20210601.IAfdDomainUpdatePropertiesParametersInternal)this).TlsSetting = (Microsoft.Azure.PowerShell.Cmdlets.Cdn.Models.Api20210601.IAfdDomainHttpsParameters) content.GetValueForProperty("TlsSetting",((Microsoft.Azure.PowerShell.Cmdlets.Cdn.Models.Api20210601.IAfdDomainUpdatePropertiesParametersInternal)this).TlsSetting, Microsoft.Azure.PowerShell.Cmdlets.Cdn.Models.Api20210601.AfdDomainHttpsParametersTypeConverter.ConvertFrom);
            }
            if (content.Contains("AzureDnsZone"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.Cdn.Models.Api20210601.IAfdDomainUpdatePropertiesParametersInternal)this).AzureDnsZone = (Microsoft.Azure.PowerShell.Cmdlets.Cdn.Models.Api20210601.IResourceReference) content.GetValueForProperty("AzureDnsZone",((Microsoft.Azure.PowerShell.Cmdlets.Cdn.Models.Api20210601.IAfdDomainUpdatePropertiesParametersInternal)this).AzureDnsZone, Microsoft.Azure.PowerShell.Cmdlets.Cdn.Models.Api20210601.ResourceReferenceTypeConverter.ConvertFrom);
            }
            if (content.Contains("AfdDomainUpdatePropertiesParametersPreValidatedCustomDomainResourceId"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.Cdn.Models.Api20210601.IAfdDomainUpdatePropertiesParametersInternal)this).AfdDomainUpdatePropertiesParametersPreValidatedCustomDomainResourceId = (Microsoft.Azure.PowerShell.Cmdlets.Cdn.Models.Api20210601.IResourceReference) content.GetValueForProperty("AfdDomainUpdatePropertiesParametersPreValidatedCustomDomainResourceId",((Microsoft.Azure.PowerShell.Cmdlets.Cdn.Models.Api20210601.IAfdDomainUpdatePropertiesParametersInternal)this).AfdDomainUpdatePropertiesParametersPreValidatedCustomDomainResourceId, Microsoft.Azure.PowerShell.Cmdlets.Cdn.Models.Api20210601.ResourceReferenceTypeConverter.ConvertFrom);
            }
            if (content.Contains("ProfileName"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.Cdn.Models.Api20210601.IAfdDomainUpdatePropertiesParametersInternal)this).ProfileName = (string) content.GetValueForProperty("ProfileName",((Microsoft.Azure.PowerShell.Cmdlets.Cdn.Models.Api20210601.IAfdDomainUpdatePropertiesParametersInternal)this).ProfileName, global::System.Convert.ToString);
            }
            if (content.Contains("ProvisioningState"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.Cdn.Models.Api20210601.IAfdStatePropertiesInternal)this).ProvisioningState = (Microsoft.Azure.PowerShell.Cmdlets.Cdn.Support.AfdProvisioningState?) content.GetValueForProperty("ProvisioningState",((Microsoft.Azure.PowerShell.Cmdlets.Cdn.Models.Api20210601.IAfdStatePropertiesInternal)this).ProvisioningState, Microsoft.Azure.PowerShell.Cmdlets.Cdn.Support.AfdProvisioningState.CreateFrom);
            }
            if (content.Contains("DeploymentStatus"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.Cdn.Models.Api20210601.IAfdStatePropertiesInternal)this).DeploymentStatus = (Microsoft.Azure.PowerShell.Cmdlets.Cdn.Support.DeploymentStatus?) content.GetValueForProperty("DeploymentStatus",((Microsoft.Azure.PowerShell.Cmdlets.Cdn.Models.Api20210601.IAfdStatePropertiesInternal)this).DeploymentStatus, Microsoft.Azure.PowerShell.Cmdlets.Cdn.Support.DeploymentStatus.CreateFrom);
            }
            if (content.Contains("ValidationPropertyValidationToken"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.Cdn.Models.Api20210601.IAfdDomainPropertiesInternal)this).ValidationPropertyValidationToken = (string) content.GetValueForProperty("ValidationPropertyValidationToken",((Microsoft.Azure.PowerShell.Cmdlets.Cdn.Models.Api20210601.IAfdDomainPropertiesInternal)this).ValidationPropertyValidationToken, global::System.Convert.ToString);
            }
            if (content.Contains("ValidationPropertyExpirationDate"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.Cdn.Models.Api20210601.IAfdDomainPropertiesInternal)this).ValidationPropertyExpirationDate = (string) content.GetValueForProperty("ValidationPropertyExpirationDate",((Microsoft.Azure.PowerShell.Cmdlets.Cdn.Models.Api20210601.IAfdDomainPropertiesInternal)this).ValidationPropertyExpirationDate, global::System.Convert.ToString);
            }
            AfterDeserializePSObject(content);
        }

        /// <summary>
        /// Deserializes a <see cref="global::System.Collections.IDictionary" /> into an instance of <see cref="Microsoft.Azure.PowerShell.Cmdlets.Cdn.Models.Api20210601.AfdDomainProperties"
        /// />.
        /// </summary>
        /// <param name="content">The global::System.Collections.IDictionary content that should be used.</param>
        /// <returns>
        /// an instance of <see cref="Microsoft.Azure.PowerShell.Cmdlets.Cdn.Models.Api20210601.IAfdDomainProperties" />.
        /// </returns>
        public static Microsoft.Azure.PowerShell.Cmdlets.Cdn.Models.Api20210601.IAfdDomainProperties DeserializeFromDictionary(global::System.Collections.IDictionary content)
        {
            return new AfdDomainProperties(content);
        }

        /// <summary>
        /// Deserializes a <see cref="global::System.Management.Automation.PSObject" /> into an instance of <see cref="Microsoft.Azure.PowerShell.Cmdlets.Cdn.Models.Api20210601.AfdDomainProperties"
        /// />.
        /// </summary>
        /// <param name="content">The global::System.Management.Automation.PSObject content that should be used.</param>
        /// <returns>
        /// an instance of <see cref="Microsoft.Azure.PowerShell.Cmdlets.Cdn.Models.Api20210601.IAfdDomainProperties" />.
        /// </returns>
        public static Microsoft.Azure.PowerShell.Cmdlets.Cdn.Models.Api20210601.IAfdDomainProperties DeserializeFromPSObject(global::System.Management.Automation.PSObject content)
        {
            return new AfdDomainProperties(content);
        }

        /// <summary>
        /// Creates a new instance of <see cref="AfdDomainProperties" />, deserializing the content from a json string.
        /// </summary>
        /// <param name="jsonText">a string containing a JSON serialized instance of this model.</param>
        /// <returns>an instance of the <see cref="className" /> model class.</returns>
        public static Microsoft.Azure.PowerShell.Cmdlets.Cdn.Models.Api20210601.IAfdDomainProperties FromJsonString(string jsonText) => FromJson(Microsoft.Azure.PowerShell.Cmdlets.Cdn.Runtime.Json.JsonNode.Parse(jsonText));

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
    /// The JSON object that contains the properties of the domain to create.
    [System.ComponentModel.TypeConverter(typeof(AfdDomainPropertiesTypeConverter))]
    public partial interface IAfdDomainProperties

    {

    }
}