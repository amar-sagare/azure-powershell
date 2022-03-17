// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for license information.
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is regenerated.

namespace Microsoft.Azure.PowerShell.Cmdlets.Cdn.Models.Api20210601
{
    using static Microsoft.Azure.PowerShell.Cmdlets.Cdn.Runtime.Extensions;

    /// <summary>Defines the url signing action for the delivery rule.</summary>
    public partial class UrlSigningAction :
        Microsoft.Azure.PowerShell.Cmdlets.Cdn.Models.Api20210601.IUrlSigningAction,
        Microsoft.Azure.PowerShell.Cmdlets.Cdn.Models.Api20210601.IUrlSigningActionInternal,
        Microsoft.Azure.PowerShell.Cmdlets.Cdn.Runtime.IValidates
    {
        /// <summary>
        /// Backing field for Inherited model <see cref= "Microsoft.Azure.PowerShell.Cmdlets.Cdn.Models.Api20210601.IDeliveryRuleAction1"
        /// />
        /// </summary>
        private Microsoft.Azure.PowerShell.Cmdlets.Cdn.Models.Api20210601.IDeliveryRuleAction1 __deliveryRuleAction1 = new Microsoft.Azure.PowerShell.Cmdlets.Cdn.Models.Api20210601.DeliveryRuleAction1();

        /// <summary>Internal Acessors for Parameter</summary>
        Microsoft.Azure.PowerShell.Cmdlets.Cdn.Models.Api20210601.IUrlSigningActionParameters Microsoft.Azure.PowerShell.Cmdlets.Cdn.Models.Api20210601.IUrlSigningActionInternal.Parameter { get => (this._parameter = this._parameter ?? new Microsoft.Azure.PowerShell.Cmdlets.Cdn.Models.Api20210601.UrlSigningActionParameters()); set { {_parameter = value;} } }

        /// <summary>Internal Acessors for ParameterTypeName</summary>
        string Microsoft.Azure.PowerShell.Cmdlets.Cdn.Models.Api20210601.IUrlSigningActionInternal.ParameterTypeName { get => ((Microsoft.Azure.PowerShell.Cmdlets.Cdn.Models.Api20210601.IUrlSigningActionParametersInternal)Parameter).TypeName; set => ((Microsoft.Azure.PowerShell.Cmdlets.Cdn.Models.Api20210601.IUrlSigningActionParametersInternal)Parameter).TypeName = value; }

        /// <summary>The name of the action for the delivery rule.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Cdn.Origin(Microsoft.Azure.PowerShell.Cmdlets.Cdn.PropertyOrigin.Inherited)]
        public Microsoft.Azure.PowerShell.Cmdlets.Cdn.Support.DeliveryRuleAction Name { get => ((Microsoft.Azure.PowerShell.Cmdlets.Cdn.Models.Api20210601.IDeliveryRuleAction1Internal)__deliveryRuleAction1).Name; set => ((Microsoft.Azure.PowerShell.Cmdlets.Cdn.Models.Api20210601.IDeliveryRuleAction1Internal)__deliveryRuleAction1).Name = value ; }

        /// <summary>Backing field for <see cref="Parameter" /> property.</summary>
        private Microsoft.Azure.PowerShell.Cmdlets.Cdn.Models.Api20210601.IUrlSigningActionParameters _parameter;

        /// <summary>Defines the parameters for the action.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Cdn.Origin(Microsoft.Azure.PowerShell.Cmdlets.Cdn.PropertyOrigin.Owned)]
        internal Microsoft.Azure.PowerShell.Cmdlets.Cdn.Models.Api20210601.IUrlSigningActionParameters Parameter { get => (this._parameter = this._parameter ?? new Microsoft.Azure.PowerShell.Cmdlets.Cdn.Models.Api20210601.UrlSigningActionParameters()); set => this._parameter = value; }

        /// <summary>Algorithm to use for URL signing</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Cdn.Origin(Microsoft.Azure.PowerShell.Cmdlets.Cdn.PropertyOrigin.Inlined)]
        public Microsoft.Azure.PowerShell.Cmdlets.Cdn.Support.Algorithm? ParameterAlgorithm { get => ((Microsoft.Azure.PowerShell.Cmdlets.Cdn.Models.Api20210601.IUrlSigningActionParametersInternal)Parameter).Algorithm; set => ((Microsoft.Azure.PowerShell.Cmdlets.Cdn.Models.Api20210601.IUrlSigningActionParametersInternal)Parameter).Algorithm = value ?? ((Microsoft.Azure.PowerShell.Cmdlets.Cdn.Support.Algorithm)""); }

        /// <summary>
        /// Defines which query string parameters in the url to be considered for expires, key id etc.
        /// </summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Cdn.Origin(Microsoft.Azure.PowerShell.Cmdlets.Cdn.PropertyOrigin.Inlined)]
        public Microsoft.Azure.PowerShell.Cmdlets.Cdn.Models.Api20210601.IUrlSigningParamIdentifier[] ParameterNameOverride { get => ((Microsoft.Azure.PowerShell.Cmdlets.Cdn.Models.Api20210601.IUrlSigningActionParametersInternal)Parameter).ParameterNameOverride; set => ((Microsoft.Azure.PowerShell.Cmdlets.Cdn.Models.Api20210601.IUrlSigningActionParametersInternal)Parameter).ParameterNameOverride = value ?? null /* arrayOf */; }

        [Microsoft.Azure.PowerShell.Cmdlets.Cdn.Origin(Microsoft.Azure.PowerShell.Cmdlets.Cdn.PropertyOrigin.Inlined)]
        public string ParameterTypeName { get => ((Microsoft.Azure.PowerShell.Cmdlets.Cdn.Models.Api20210601.IUrlSigningActionParametersInternal)Parameter).TypeName; }

        /// <summary>Creates an new <see cref="UrlSigningAction" /> instance.</summary>
        public UrlSigningAction()
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
            await eventListener.AssertNotNull(nameof(__deliveryRuleAction1), __deliveryRuleAction1);
            await eventListener.AssertObjectIsValid(nameof(__deliveryRuleAction1), __deliveryRuleAction1);
        }
    }
    /// Defines the url signing action for the delivery rule.
    public partial interface IUrlSigningAction :
        Microsoft.Azure.PowerShell.Cmdlets.Cdn.Runtime.IJsonSerializable,
        Microsoft.Azure.PowerShell.Cmdlets.Cdn.Models.Api20210601.IDeliveryRuleAction1
    {
        /// <summary>Algorithm to use for URL signing</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Cdn.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"Algorithm to use for URL signing",
        SerializedName = @"algorithm",
        PossibleTypes = new [] { typeof(Microsoft.Azure.PowerShell.Cmdlets.Cdn.Support.Algorithm) })]
        Microsoft.Azure.PowerShell.Cmdlets.Cdn.Support.Algorithm? ParameterAlgorithm { get; set; }
        /// <summary>
        /// Defines which query string parameters in the url to be considered for expires, key id etc.
        /// </summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Cdn.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"Defines which query string parameters in the url to be considered for expires, key id etc. ",
        SerializedName = @"parameterNameOverride",
        PossibleTypes = new [] { typeof(Microsoft.Azure.PowerShell.Cmdlets.Cdn.Models.Api20210601.IUrlSigningParamIdentifier) })]
        Microsoft.Azure.PowerShell.Cmdlets.Cdn.Models.Api20210601.IUrlSigningParamIdentifier[] ParameterNameOverride { get; set; }

        [Microsoft.Azure.PowerShell.Cmdlets.Cdn.Runtime.Info(
        Required = true,
        ReadOnly = true,
        Description = @"",
        SerializedName = @"typeName",
        PossibleTypes = new [] { typeof(string) })]
        string ParameterTypeName { get;  }

    }
    /// Defines the url signing action for the delivery rule.
    internal partial interface IUrlSigningActionInternal :
        Microsoft.Azure.PowerShell.Cmdlets.Cdn.Models.Api20210601.IDeliveryRuleAction1Internal
    {
        /// <summary>Defines the parameters for the action.</summary>
        Microsoft.Azure.PowerShell.Cmdlets.Cdn.Models.Api20210601.IUrlSigningActionParameters Parameter { get; set; }
        /// <summary>Algorithm to use for URL signing</summary>
        Microsoft.Azure.PowerShell.Cmdlets.Cdn.Support.Algorithm? ParameterAlgorithm { get; set; }
        /// <summary>
        /// Defines which query string parameters in the url to be considered for expires, key id etc.
        /// </summary>
        Microsoft.Azure.PowerShell.Cmdlets.Cdn.Models.Api20210601.IUrlSigningParamIdentifier[] ParameterNameOverride { get; set; }

        string ParameterTypeName { get; set; }

    }
}