// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for license information.
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is regenerated.

namespace Microsoft.Azure.PowerShell.Cmdlets.DataProtection.Models
{
    using Microsoft.Azure.PowerShell.Cmdlets.DataProtection.Runtime.PowerShell;

    [System.ComponentModel.TypeConverter(typeof(OperationResultGetAcceptedResponseHeadersTypeConverter))]
    public partial class OperationResultGetAcceptedResponseHeaders
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
        /// Deserializes a <see cref="global::System.Collections.IDictionary" /> into an instance of <see cref="Microsoft.Azure.PowerShell.Cmdlets.DataProtection.Models.OperationResultGetAcceptedResponseHeaders"
        /// />.
        /// </summary>
        /// <param name="content">The global::System.Collections.IDictionary content that should be used.</param>
        /// <returns>
        /// an instance of <see cref="Microsoft.Azure.PowerShell.Cmdlets.DataProtection.Models.IOperationResultGetAcceptedResponseHeaders"
        /// />.
        /// </returns>
        public static Microsoft.Azure.PowerShell.Cmdlets.DataProtection.Models.IOperationResultGetAcceptedResponseHeaders DeserializeFromDictionary(global::System.Collections.IDictionary content)
        {
            return new OperationResultGetAcceptedResponseHeaders(content);
        }

        /// <summary>
        /// Deserializes a <see cref="global::System.Management.Automation.PSObject" /> into an instance of <see cref="Microsoft.Azure.PowerShell.Cmdlets.DataProtection.Models.OperationResultGetAcceptedResponseHeaders"
        /// />.
        /// </summary>
        /// <param name="content">The global::System.Management.Automation.PSObject content that should be used.</param>
        /// <returns>
        /// an instance of <see cref="Microsoft.Azure.PowerShell.Cmdlets.DataProtection.Models.IOperationResultGetAcceptedResponseHeaders"
        /// />.
        /// </returns>
        public static Microsoft.Azure.PowerShell.Cmdlets.DataProtection.Models.IOperationResultGetAcceptedResponseHeaders DeserializeFromPSObject(global::System.Management.Automation.PSObject content)
        {
            return new OperationResultGetAcceptedResponseHeaders(content);
        }

        /// <summary>
        /// Creates a new instance of <see cref="OperationResultGetAcceptedResponseHeaders" />, deserializing the content from a json
        /// string.
        /// </summary>
        /// <param name="jsonText">a string containing a JSON serialized instance of this model.</param>
        /// <returns>an instance of the <see cref="className" /> model class.</returns>
        public static Microsoft.Azure.PowerShell.Cmdlets.DataProtection.Models.IOperationResultGetAcceptedResponseHeaders FromJsonString(string jsonText) => FromJson(Microsoft.Azure.PowerShell.Cmdlets.DataProtection.Runtime.Json.JsonNode.Parse(jsonText));

        /// <summary>
        /// Deserializes a <see cref="global::System.Collections.IDictionary" /> into a new instance of <see cref="Microsoft.Azure.PowerShell.Cmdlets.DataProtection.Models.OperationResultGetAcceptedResponseHeaders"
        /// />.
        /// </summary>
        /// <param name="content">The global::System.Collections.IDictionary content that should be used.</param>
        internal OperationResultGetAcceptedResponseHeaders(global::System.Collections.IDictionary content)
        {
            bool returnNow = false;
            BeforeDeserializeDictionary(content, ref returnNow);
            if (returnNow)
            {
                return;
            }
            // actually deserialize
            if (content.Contains("Location"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.DataProtection.Models.IOperationResultGetAcceptedResponseHeadersInternal)this).Location = (string) content.GetValueForProperty("Location",((Microsoft.Azure.PowerShell.Cmdlets.DataProtection.Models.IOperationResultGetAcceptedResponseHeadersInternal)this).Location, global::System.Convert.ToString);
            }
            if (content.Contains("AzureAsyncOperation"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.DataProtection.Models.IOperationResultGetAcceptedResponseHeadersInternal)this).AzureAsyncOperation = (string) content.GetValueForProperty("AzureAsyncOperation",((Microsoft.Azure.PowerShell.Cmdlets.DataProtection.Models.IOperationResultGetAcceptedResponseHeadersInternal)this).AzureAsyncOperation, global::System.Convert.ToString);
            }
            if (content.Contains("RetryAfter"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.DataProtection.Models.IOperationResultGetAcceptedResponseHeadersInternal)this).RetryAfter = (int?) content.GetValueForProperty("RetryAfter",((Microsoft.Azure.PowerShell.Cmdlets.DataProtection.Models.IOperationResultGetAcceptedResponseHeadersInternal)this).RetryAfter, (__y)=> (int) global::System.Convert.ChangeType(__y, typeof(int)));
            }
            AfterDeserializeDictionary(content);
        }

        /// <summary>
        /// Deserializes a <see cref="global::System.Management.Automation.PSObject" /> into a new instance of <see cref="Microsoft.Azure.PowerShell.Cmdlets.DataProtection.Models.OperationResultGetAcceptedResponseHeaders"
        /// />.
        /// </summary>
        /// <param name="content">The global::System.Management.Automation.PSObject content that should be used.</param>
        internal OperationResultGetAcceptedResponseHeaders(global::System.Management.Automation.PSObject content)
        {
            bool returnNow = false;
            BeforeDeserializePSObject(content, ref returnNow);
            if (returnNow)
            {
                return;
            }
            // actually deserialize
            if (content.Contains("Location"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.DataProtection.Models.IOperationResultGetAcceptedResponseHeadersInternal)this).Location = (string) content.GetValueForProperty("Location",((Microsoft.Azure.PowerShell.Cmdlets.DataProtection.Models.IOperationResultGetAcceptedResponseHeadersInternal)this).Location, global::System.Convert.ToString);
            }
            if (content.Contains("AzureAsyncOperation"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.DataProtection.Models.IOperationResultGetAcceptedResponseHeadersInternal)this).AzureAsyncOperation = (string) content.GetValueForProperty("AzureAsyncOperation",((Microsoft.Azure.PowerShell.Cmdlets.DataProtection.Models.IOperationResultGetAcceptedResponseHeadersInternal)this).AzureAsyncOperation, global::System.Convert.ToString);
            }
            if (content.Contains("RetryAfter"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.DataProtection.Models.IOperationResultGetAcceptedResponseHeadersInternal)this).RetryAfter = (int?) content.GetValueForProperty("RetryAfter",((Microsoft.Azure.PowerShell.Cmdlets.DataProtection.Models.IOperationResultGetAcceptedResponseHeadersInternal)this).RetryAfter, (__y)=> (int) global::System.Convert.ChangeType(__y, typeof(int)));
            }
            AfterDeserializePSObject(content);
        }

        /// <summary>Serializes this instance to a json string.</summary>

        /// <returns>a <see cref="System.String" /> containing this model serialized to JSON text.</returns>
        public string ToJsonString() => ToJson(null, Microsoft.Azure.PowerShell.Cmdlets.DataProtection.Runtime.SerializationMode.IncludeAll)?.ToString();
    }
    [System.ComponentModel.TypeConverter(typeof(OperationResultGetAcceptedResponseHeadersTypeConverter))]
    public partial interface IOperationResultGetAcceptedResponseHeaders

    {

    }
}