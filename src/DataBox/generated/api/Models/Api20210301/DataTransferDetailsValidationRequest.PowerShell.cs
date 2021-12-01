// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for license information.
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is regenerated.

namespace Microsoft.Azure.PowerShell.Cmdlets.DataBox.Models.Api20210301
{
    using Microsoft.Azure.PowerShell.Cmdlets.DataBox.Runtime.PowerShell;

    /// <summary>Request to validate export and import data details.</summary>
    [System.ComponentModel.TypeConverter(typeof(DataTransferDetailsValidationRequestTypeConverter))]
    public partial class DataTransferDetailsValidationRequest
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
        /// Deserializes a <see cref="global::System.Collections.IDictionary" /> into a new instance of <see cref="Microsoft.Azure.PowerShell.Cmdlets.DataBox.Models.Api20210301.DataTransferDetailsValidationRequest"
        /// />.
        /// </summary>
        /// <param name="content">The global::System.Collections.IDictionary content that should be used.</param>
        internal DataTransferDetailsValidationRequest(global::System.Collections.IDictionary content)
        {
            bool returnNow = false;
            BeforeDeserializeDictionary(content, ref returnNow);
            if (returnNow)
            {
                return;
            }
            // actually deserialize
            if (content.Contains("DataExportDetail"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.DataBox.Models.Api20210301.IDataTransferDetailsValidationRequestInternal)this).DataExportDetail = (Microsoft.Azure.PowerShell.Cmdlets.DataBox.Models.Api20210301.IDataExportDetails[]) content.GetValueForProperty("DataExportDetail",((Microsoft.Azure.PowerShell.Cmdlets.DataBox.Models.Api20210301.IDataTransferDetailsValidationRequestInternal)this).DataExportDetail, __y => TypeConverterExtensions.SelectToArray<Microsoft.Azure.PowerShell.Cmdlets.DataBox.Models.Api20210301.IDataExportDetails>(__y, Microsoft.Azure.PowerShell.Cmdlets.DataBox.Models.Api20210301.DataExportDetailsTypeConverter.ConvertFrom));
            }
            if (content.Contains("DataImportDetail"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.DataBox.Models.Api20210301.IDataTransferDetailsValidationRequestInternal)this).DataImportDetail = (Microsoft.Azure.PowerShell.Cmdlets.DataBox.Models.Api20210301.IDataImportDetails[]) content.GetValueForProperty("DataImportDetail",((Microsoft.Azure.PowerShell.Cmdlets.DataBox.Models.Api20210301.IDataTransferDetailsValidationRequestInternal)this).DataImportDetail, __y => TypeConverterExtensions.SelectToArray<Microsoft.Azure.PowerShell.Cmdlets.DataBox.Models.Api20210301.IDataImportDetails>(__y, Microsoft.Azure.PowerShell.Cmdlets.DataBox.Models.Api20210301.DataImportDetailsTypeConverter.ConvertFrom));
            }
            if (content.Contains("DeviceType"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.DataBox.Models.Api20210301.IDataTransferDetailsValidationRequestInternal)this).DeviceType = (Microsoft.Azure.PowerShell.Cmdlets.DataBox.Support.SkuName) content.GetValueForProperty("DeviceType",((Microsoft.Azure.PowerShell.Cmdlets.DataBox.Models.Api20210301.IDataTransferDetailsValidationRequestInternal)this).DeviceType, Microsoft.Azure.PowerShell.Cmdlets.DataBox.Support.SkuName.CreateFrom);
            }
            if (content.Contains("TransferType"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.DataBox.Models.Api20210301.IDataTransferDetailsValidationRequestInternal)this).TransferType = (Microsoft.Azure.PowerShell.Cmdlets.DataBox.Support.TransferType) content.GetValueForProperty("TransferType",((Microsoft.Azure.PowerShell.Cmdlets.DataBox.Models.Api20210301.IDataTransferDetailsValidationRequestInternal)this).TransferType, Microsoft.Azure.PowerShell.Cmdlets.DataBox.Support.TransferType.CreateFrom);
            }
            if (content.Contains("ValidationType"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.DataBox.Models.Api20210301.IValidationInputRequestInternal)this).ValidationType = (Microsoft.Azure.PowerShell.Cmdlets.DataBox.Support.ValidationInputDiscriminator) content.GetValueForProperty("ValidationType",((Microsoft.Azure.PowerShell.Cmdlets.DataBox.Models.Api20210301.IValidationInputRequestInternal)this).ValidationType, Microsoft.Azure.PowerShell.Cmdlets.DataBox.Support.ValidationInputDiscriminator.CreateFrom);
            }
            AfterDeserializeDictionary(content);
        }

        /// <summary>
        /// Deserializes a <see cref="global::System.Management.Automation.PSObject" /> into a new instance of <see cref="Microsoft.Azure.PowerShell.Cmdlets.DataBox.Models.Api20210301.DataTransferDetailsValidationRequest"
        /// />.
        /// </summary>
        /// <param name="content">The global::System.Management.Automation.PSObject content that should be used.</param>
        internal DataTransferDetailsValidationRequest(global::System.Management.Automation.PSObject content)
        {
            bool returnNow = false;
            BeforeDeserializePSObject(content, ref returnNow);
            if (returnNow)
            {
                return;
            }
            // actually deserialize
            if (content.Contains("DataExportDetail"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.DataBox.Models.Api20210301.IDataTransferDetailsValidationRequestInternal)this).DataExportDetail = (Microsoft.Azure.PowerShell.Cmdlets.DataBox.Models.Api20210301.IDataExportDetails[]) content.GetValueForProperty("DataExportDetail",((Microsoft.Azure.PowerShell.Cmdlets.DataBox.Models.Api20210301.IDataTransferDetailsValidationRequestInternal)this).DataExportDetail, __y => TypeConverterExtensions.SelectToArray<Microsoft.Azure.PowerShell.Cmdlets.DataBox.Models.Api20210301.IDataExportDetails>(__y, Microsoft.Azure.PowerShell.Cmdlets.DataBox.Models.Api20210301.DataExportDetailsTypeConverter.ConvertFrom));
            }
            if (content.Contains("DataImportDetail"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.DataBox.Models.Api20210301.IDataTransferDetailsValidationRequestInternal)this).DataImportDetail = (Microsoft.Azure.PowerShell.Cmdlets.DataBox.Models.Api20210301.IDataImportDetails[]) content.GetValueForProperty("DataImportDetail",((Microsoft.Azure.PowerShell.Cmdlets.DataBox.Models.Api20210301.IDataTransferDetailsValidationRequestInternal)this).DataImportDetail, __y => TypeConverterExtensions.SelectToArray<Microsoft.Azure.PowerShell.Cmdlets.DataBox.Models.Api20210301.IDataImportDetails>(__y, Microsoft.Azure.PowerShell.Cmdlets.DataBox.Models.Api20210301.DataImportDetailsTypeConverter.ConvertFrom));
            }
            if (content.Contains("DeviceType"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.DataBox.Models.Api20210301.IDataTransferDetailsValidationRequestInternal)this).DeviceType = (Microsoft.Azure.PowerShell.Cmdlets.DataBox.Support.SkuName) content.GetValueForProperty("DeviceType",((Microsoft.Azure.PowerShell.Cmdlets.DataBox.Models.Api20210301.IDataTransferDetailsValidationRequestInternal)this).DeviceType, Microsoft.Azure.PowerShell.Cmdlets.DataBox.Support.SkuName.CreateFrom);
            }
            if (content.Contains("TransferType"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.DataBox.Models.Api20210301.IDataTransferDetailsValidationRequestInternal)this).TransferType = (Microsoft.Azure.PowerShell.Cmdlets.DataBox.Support.TransferType) content.GetValueForProperty("TransferType",((Microsoft.Azure.PowerShell.Cmdlets.DataBox.Models.Api20210301.IDataTransferDetailsValidationRequestInternal)this).TransferType, Microsoft.Azure.PowerShell.Cmdlets.DataBox.Support.TransferType.CreateFrom);
            }
            if (content.Contains("ValidationType"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.DataBox.Models.Api20210301.IValidationInputRequestInternal)this).ValidationType = (Microsoft.Azure.PowerShell.Cmdlets.DataBox.Support.ValidationInputDiscriminator) content.GetValueForProperty("ValidationType",((Microsoft.Azure.PowerShell.Cmdlets.DataBox.Models.Api20210301.IValidationInputRequestInternal)this).ValidationType, Microsoft.Azure.PowerShell.Cmdlets.DataBox.Support.ValidationInputDiscriminator.CreateFrom);
            }
            AfterDeserializePSObject(content);
        }

        /// <summary>
        /// Deserializes a <see cref="global::System.Collections.IDictionary" /> into an instance of <see cref="Microsoft.Azure.PowerShell.Cmdlets.DataBox.Models.Api20210301.DataTransferDetailsValidationRequest"
        /// />.
        /// </summary>
        /// <param name="content">The global::System.Collections.IDictionary content that should be used.</param>
        /// <returns>
        /// an instance of <see cref="Microsoft.Azure.PowerShell.Cmdlets.DataBox.Models.Api20210301.IDataTransferDetailsValidationRequest"
        /// />.
        /// </returns>
        public static Microsoft.Azure.PowerShell.Cmdlets.DataBox.Models.Api20210301.IDataTransferDetailsValidationRequest DeserializeFromDictionary(global::System.Collections.IDictionary content)
        {
            return new DataTransferDetailsValidationRequest(content);
        }

        /// <summary>
        /// Deserializes a <see cref="global::System.Management.Automation.PSObject" /> into an instance of <see cref="Microsoft.Azure.PowerShell.Cmdlets.DataBox.Models.Api20210301.DataTransferDetailsValidationRequest"
        /// />.
        /// </summary>
        /// <param name="content">The global::System.Management.Automation.PSObject content that should be used.</param>
        /// <returns>
        /// an instance of <see cref="Microsoft.Azure.PowerShell.Cmdlets.DataBox.Models.Api20210301.IDataTransferDetailsValidationRequest"
        /// />.
        /// </returns>
        public static Microsoft.Azure.PowerShell.Cmdlets.DataBox.Models.Api20210301.IDataTransferDetailsValidationRequest DeserializeFromPSObject(global::System.Management.Automation.PSObject content)
        {
            return new DataTransferDetailsValidationRequest(content);
        }

        /// <summary>
        /// Creates a new instance of <see cref="DataTransferDetailsValidationRequest" />, deserializing the content from a json string.
        /// </summary>
        /// <param name="jsonText">a string containing a JSON serialized instance of this model.</param>
        /// <returns>an instance of the <see cref="className" /> model class.</returns>
        public static Microsoft.Azure.PowerShell.Cmdlets.DataBox.Models.Api20210301.IDataTransferDetailsValidationRequest FromJsonString(string jsonText) => FromJson(Microsoft.Azure.PowerShell.Cmdlets.DataBox.Runtime.Json.JsonNode.Parse(jsonText));

        /// <summary>Serializes this instance to a json string.</summary>

        /// <returns>a <see cref="System.String" /> containing this model serialized to JSON text.</returns>
        public string ToJsonString() => ToJson(null, Microsoft.Azure.PowerShell.Cmdlets.DataBox.Runtime.SerializationMode.IncludeAll)?.ToString();
    }
    /// Request to validate export and import data details.
    [System.ComponentModel.TypeConverter(typeof(DataTransferDetailsValidationRequestTypeConverter))]
    public partial interface IDataTransferDetailsValidationRequest

    {

    }
}