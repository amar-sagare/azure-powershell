// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for license information.
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is regenerated.

namespace Microsoft.Azure.PowerShell.Cmdlets.Cdn.Support
{

    /// <summary>
    /// Describes if the managed rule is in enabled or disabled state. Defaults to Disabled if not specified.
    /// </summary>
    public partial struct ManagedRuleEnabledState :
        System.IEquatable<ManagedRuleEnabledState>
    {
        public static Microsoft.Azure.PowerShell.Cmdlets.Cdn.Support.ManagedRuleEnabledState Disabled = @"Disabled";

        public static Microsoft.Azure.PowerShell.Cmdlets.Cdn.Support.ManagedRuleEnabledState Enabled = @"Enabled";

        /// <summary>the value for an instance of the <see cref="ManagedRuleEnabledState" /> Enum.</summary>
        private string _value { get; set; }

        /// <summary>Conversion from arbitrary object to ManagedRuleEnabledState</summary>
        /// <param name="value">the value to convert to an instance of <see cref="ManagedRuleEnabledState" />.</param>
        internal static object CreateFrom(object value)
        {
            return new ManagedRuleEnabledState(global::System.Convert.ToString(value));
        }

        /// <summary>Compares values of enum type ManagedRuleEnabledState</summary>
        /// <param name="e">the value to compare against this instance.</param>
        /// <returns><c>true</c> if the two instances are equal to the same value</returns>
        public bool Equals(Microsoft.Azure.PowerShell.Cmdlets.Cdn.Support.ManagedRuleEnabledState e)
        {
            return _value.Equals(e._value);
        }

        /// <summary>Compares values of enum type ManagedRuleEnabledState (override for Object)</summary>
        /// <param name="obj">the value to compare against this instance.</param>
        /// <returns><c>true</c> if the two instances are equal to the same value</returns>
        public override bool Equals(object obj)
        {
            return obj is ManagedRuleEnabledState && Equals((ManagedRuleEnabledState)obj);
        }

        /// <summary>Returns hashCode for enum ManagedRuleEnabledState</summary>
        /// <returns>The hashCode of the value</returns>
        public override int GetHashCode()
        {
            return this._value.GetHashCode();
        }

        /// <summary>Creates an instance of the <see cref="ManagedRuleEnabledState" Enum class./></summary>
        /// <param name="underlyingValue">the value to create an instance for.</param>
        private ManagedRuleEnabledState(string underlyingValue)
        {
            this._value = underlyingValue;
        }

        /// <summary>Returns string representation for ManagedRuleEnabledState</summary>
        /// <returns>A string for this value.</returns>
        public override string ToString()
        {
            return this._value;
        }

        /// <summary>Implicit operator to convert string to ManagedRuleEnabledState</summary>
        /// <param name="value">the value to convert to an instance of <see cref="ManagedRuleEnabledState" />.</param>

        public static implicit operator ManagedRuleEnabledState(string value)
        {
            return new ManagedRuleEnabledState(value);
        }

        /// <summary>Implicit operator to convert ManagedRuleEnabledState to string</summary>
        /// <param name="e">the value to convert to an instance of <see cref="ManagedRuleEnabledState" />.</param>

        public static implicit operator string(Microsoft.Azure.PowerShell.Cmdlets.Cdn.Support.ManagedRuleEnabledState e)
        {
            return e._value;
        }

        /// <summary>Overriding != operator for enum ManagedRuleEnabledState</summary>
        /// <param name="e1">the value to compare against <see cref="e2" /></param>
        /// <param name="e2">the value to compare against <see cref="e1" /></param>
        /// <returns><c>true</c> if the two instances are not equal to the same value</returns>
        public static bool operator !=(Microsoft.Azure.PowerShell.Cmdlets.Cdn.Support.ManagedRuleEnabledState e1, Microsoft.Azure.PowerShell.Cmdlets.Cdn.Support.ManagedRuleEnabledState e2)
        {
            return !e2.Equals(e1);
        }

        /// <summary>Overriding == operator for enum ManagedRuleEnabledState</summary>
        /// <param name="e1">the value to compare against <see cref="e2" /></param>
        /// <param name="e2">the value to compare against <see cref="e1" /></param>
        /// <returns><c>true</c> if the two instances are equal to the same value</returns>
        public static bool operator ==(Microsoft.Azure.PowerShell.Cmdlets.Cdn.Support.ManagedRuleEnabledState e1, Microsoft.Azure.PowerShell.Cmdlets.Cdn.Support.ManagedRuleEnabledState e2)
        {
            return e2.Equals(e1);
        }
    }
}