// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for license information.
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is regenerated.

namespace Microsoft.Azure.PowerShell.Cmdlets.Cdn.Support
{

    /// <summary>
    /// Type of response errors for real user requests for which origin will be deemed unhealthy
    /// </summary>
    public partial struct ResponseBasedDetectedErrorTypes :
        System.IEquatable<ResponseBasedDetectedErrorTypes>
    {
        public static Microsoft.Azure.PowerShell.Cmdlets.Cdn.Support.ResponseBasedDetectedErrorTypes None = @"None";

        public static Microsoft.Azure.PowerShell.Cmdlets.Cdn.Support.ResponseBasedDetectedErrorTypes TcpAndHttpErrors = @"TcpAndHttpErrors";

        public static Microsoft.Azure.PowerShell.Cmdlets.Cdn.Support.ResponseBasedDetectedErrorTypes TcpErrorsOnly = @"TcpErrorsOnly";

        /// <summary>
        /// the value for an instance of the <see cref="ResponseBasedDetectedErrorTypes" /> Enum.
        /// </summary>
        private string _value { get; set; }

        /// <summary>Conversion from arbitrary object to ResponseBasedDetectedErrorTypes</summary>
        /// <param name="value">the value to convert to an instance of <see cref="ResponseBasedDetectedErrorTypes" />.</param>
        internal static object CreateFrom(object value)
        {
            return new ResponseBasedDetectedErrorTypes(global::System.Convert.ToString(value));
        }

        /// <summary>Compares values of enum type ResponseBasedDetectedErrorTypes</summary>
        /// <param name="e">the value to compare against this instance.</param>
        /// <returns><c>true</c> if the two instances are equal to the same value</returns>
        public bool Equals(Microsoft.Azure.PowerShell.Cmdlets.Cdn.Support.ResponseBasedDetectedErrorTypes e)
        {
            return _value.Equals(e._value);
        }

        /// <summary>
        /// Compares values of enum type ResponseBasedDetectedErrorTypes (override for Object)
        /// </summary>
        /// <param name="obj">the value to compare against this instance.</param>
        /// <returns><c>true</c> if the two instances are equal to the same value</returns>
        public override bool Equals(object obj)
        {
            return obj is ResponseBasedDetectedErrorTypes && Equals((ResponseBasedDetectedErrorTypes)obj);
        }

        /// <summary>Returns hashCode for enum ResponseBasedDetectedErrorTypes</summary>
        /// <returns>The hashCode of the value</returns>
        public override int GetHashCode()
        {
            return this._value.GetHashCode();
        }

        /// <summary>
        /// Creates an instance of the <see cref="ResponseBasedDetectedErrorTypes"/> Enum class.
        /// </summary>
        /// <param name="underlyingValue">the value to create an instance for.</param>
        private ResponseBasedDetectedErrorTypes(string underlyingValue)
        {
            this._value = underlyingValue;
        }

        /// <summary>Returns string representation for ResponseBasedDetectedErrorTypes</summary>
        /// <returns>A string for this value.</returns>
        public override string ToString()
        {
            return this._value;
        }

        /// <summary>Implicit operator to convert string to ResponseBasedDetectedErrorTypes</summary>
        /// <param name="value">the value to convert to an instance of <see cref="ResponseBasedDetectedErrorTypes" />.</param>

        public static implicit operator ResponseBasedDetectedErrorTypes(string value)
        {
            return new ResponseBasedDetectedErrorTypes(value);
        }

        /// <summary>Implicit operator to convert ResponseBasedDetectedErrorTypes to string</summary>
        /// <param name="e">the value to convert to an instance of <see cref="ResponseBasedDetectedErrorTypes" />.</param>

        public static implicit operator string(Microsoft.Azure.PowerShell.Cmdlets.Cdn.Support.ResponseBasedDetectedErrorTypes e)
        {
            return e._value;
        }

        /// <summary>Overriding != operator for enum ResponseBasedDetectedErrorTypes</summary>
        /// <param name="e1">the value to compare against <paramref name="e2" /></param>
        /// <param name="e2">the value to compare against <paramref name="e1" /></param>
        /// <returns><c>true</c> if the two instances are not equal to the same value</returns>
        public static bool operator !=(Microsoft.Azure.PowerShell.Cmdlets.Cdn.Support.ResponseBasedDetectedErrorTypes e1, Microsoft.Azure.PowerShell.Cmdlets.Cdn.Support.ResponseBasedDetectedErrorTypes e2)
        {
            return !e2.Equals(e1);
        }

        /// <summary>Overriding == operator for enum ResponseBasedDetectedErrorTypes</summary>
        /// <param name="e1">the value to compare against <paramref name="e2" /></param>
        /// <param name="e2">the value to compare against <paramref name="e1" /></param>
        /// <returns><c>true</c> if the two instances are equal to the same value</returns>
        public static bool operator ==(Microsoft.Azure.PowerShell.Cmdlets.Cdn.Support.ResponseBasedDetectedErrorTypes e1, Microsoft.Azure.PowerShell.Cmdlets.Cdn.Support.ResponseBasedDetectedErrorTypes e2)
        {
            return e2.Equals(e1);
        }
    }
}