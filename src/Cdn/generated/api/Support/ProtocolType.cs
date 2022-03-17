// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for license information.
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is regenerated.

namespace Microsoft.Azure.PowerShell.Cmdlets.Cdn.Support
{

    /// <summary>Defines the TLS extension protocol that is used for secure delivery.</summary>
    public partial struct ProtocolType :
        System.IEquatable<ProtocolType>
    {
        public static Microsoft.Azure.PowerShell.Cmdlets.Cdn.Support.ProtocolType IPBased = @"IPBased";

        public static Microsoft.Azure.PowerShell.Cmdlets.Cdn.Support.ProtocolType ServerNameIndication = @"ServerNameIndication";

        /// <summary>the value for an instance of the <see cref="ProtocolType" /> Enum.</summary>
        private string _value { get; set; }

        /// <summary>Conversion from arbitrary object to ProtocolType</summary>
        /// <param name="value">the value to convert to an instance of <see cref="ProtocolType" />.</param>
        internal static object CreateFrom(object value)
        {
            return new ProtocolType(global::System.Convert.ToString(value));
        }

        /// <summary>Compares values of enum type ProtocolType</summary>
        /// <param name="e">the value to compare against this instance.</param>
        /// <returns><c>true</c> if the two instances are equal to the same value</returns>
        public bool Equals(Microsoft.Azure.PowerShell.Cmdlets.Cdn.Support.ProtocolType e)
        {
            return _value.Equals(e._value);
        }

        /// <summary>Compares values of enum type ProtocolType (override for Object)</summary>
        /// <param name="obj">the value to compare against this instance.</param>
        /// <returns><c>true</c> if the two instances are equal to the same value</returns>
        public override bool Equals(object obj)
        {
            return obj is ProtocolType && Equals((ProtocolType)obj);
        }

        /// <summary>Returns hashCode for enum ProtocolType</summary>
        /// <returns>The hashCode of the value</returns>
        public override int GetHashCode()
        {
            return this._value.GetHashCode();
        }

        /// <summary>Creates an instance of the <see cref="ProtocolType" Enum class./></summary>
        /// <param name="underlyingValue">the value to create an instance for.</param>
        private ProtocolType(string underlyingValue)
        {
            this._value = underlyingValue;
        }

        /// <summary>Returns string representation for ProtocolType</summary>
        /// <returns>A string for this value.</returns>
        public override string ToString()
        {
            return this._value;
        }

        /// <summary>Implicit operator to convert string to ProtocolType</summary>
        /// <param name="value">the value to convert to an instance of <see cref="ProtocolType" />.</param>

        public static implicit operator ProtocolType(string value)
        {
            return new ProtocolType(value);
        }

        /// <summary>Implicit operator to convert ProtocolType to string</summary>
        /// <param name="e">the value to convert to an instance of <see cref="ProtocolType" />.</param>

        public static implicit operator string(Microsoft.Azure.PowerShell.Cmdlets.Cdn.Support.ProtocolType e)
        {
            return e._value;
        }

        /// <summary>Overriding != operator for enum ProtocolType</summary>
        /// <param name="e1">the value to compare against <see cref="e2" /></param>
        /// <param name="e2">the value to compare against <see cref="e1" /></param>
        /// <returns><c>true</c> if the two instances are not equal to the same value</returns>
        public static bool operator !=(Microsoft.Azure.PowerShell.Cmdlets.Cdn.Support.ProtocolType e1, Microsoft.Azure.PowerShell.Cmdlets.Cdn.Support.ProtocolType e2)
        {
            return !e2.Equals(e1);
        }

        /// <summary>Overriding == operator for enum ProtocolType</summary>
        /// <param name="e1">the value to compare against <see cref="e2" /></param>
        /// <param name="e2">the value to compare against <see cref="e1" /></param>
        /// <returns><c>true</c> if the two instances are equal to the same value</returns>
        public static bool operator ==(Microsoft.Azure.PowerShell.Cmdlets.Cdn.Support.ProtocolType e1, Microsoft.Azure.PowerShell.Cmdlets.Cdn.Support.ProtocolType e2)
        {
            return e2.Equals(e1);
        }
    }
}