// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for license information.
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is regenerated.

namespace Microsoft.Azure.PowerShell.Cmdlets.Cdn.Support
{

    /// <summary>Describes operator to be matched</summary>
    public partial struct PostArgsOperator :
        System.IEquatable<PostArgsOperator>
    {
        public static Microsoft.Azure.PowerShell.Cmdlets.Cdn.Support.PostArgsOperator Any = @"Any";

        public static Microsoft.Azure.PowerShell.Cmdlets.Cdn.Support.PostArgsOperator BeginsWith = @"BeginsWith";

        public static Microsoft.Azure.PowerShell.Cmdlets.Cdn.Support.PostArgsOperator Contains = @"Contains";

        public static Microsoft.Azure.PowerShell.Cmdlets.Cdn.Support.PostArgsOperator EndsWith = @"EndsWith";

        public static Microsoft.Azure.PowerShell.Cmdlets.Cdn.Support.PostArgsOperator Equal = @"Equal";

        public static Microsoft.Azure.PowerShell.Cmdlets.Cdn.Support.PostArgsOperator GreaterThan = @"GreaterThan";

        public static Microsoft.Azure.PowerShell.Cmdlets.Cdn.Support.PostArgsOperator GreaterThanOrEqual = @"GreaterThanOrEqual";

        public static Microsoft.Azure.PowerShell.Cmdlets.Cdn.Support.PostArgsOperator LessThan = @"LessThan";

        public static Microsoft.Azure.PowerShell.Cmdlets.Cdn.Support.PostArgsOperator LessThanOrEqual = @"LessThanOrEqual";

        public static Microsoft.Azure.PowerShell.Cmdlets.Cdn.Support.PostArgsOperator RegEx = @"RegEx";

        /// <summary>the value for an instance of the <see cref="PostArgsOperator" /> Enum.</summary>
        private string _value { get; set; }

        /// <summary>Conversion from arbitrary object to PostArgsOperator</summary>
        /// <param name="value">the value to convert to an instance of <see cref="PostArgsOperator" />.</param>
        internal static object CreateFrom(object value)
        {
            return new PostArgsOperator(global::System.Convert.ToString(value));
        }

        /// <summary>Compares values of enum type PostArgsOperator</summary>
        /// <param name="e">the value to compare against this instance.</param>
        /// <returns><c>true</c> if the two instances are equal to the same value</returns>
        public bool Equals(Microsoft.Azure.PowerShell.Cmdlets.Cdn.Support.PostArgsOperator e)
        {
            return _value.Equals(e._value);
        }

        /// <summary>Compares values of enum type PostArgsOperator (override for Object)</summary>
        /// <param name="obj">the value to compare against this instance.</param>
        /// <returns><c>true</c> if the two instances are equal to the same value</returns>
        public override bool Equals(object obj)
        {
            return obj is PostArgsOperator && Equals((PostArgsOperator)obj);
        }

        /// <summary>Returns hashCode for enum PostArgsOperator</summary>
        /// <returns>The hashCode of the value</returns>
        public override int GetHashCode()
        {
            return this._value.GetHashCode();
        }

        /// <summary>Creates an instance of the <see cref="PostArgsOperator" Enum class./></summary>
        /// <param name="underlyingValue">the value to create an instance for.</param>
        private PostArgsOperator(string underlyingValue)
        {
            this._value = underlyingValue;
        }

        /// <summary>Returns string representation for PostArgsOperator</summary>
        /// <returns>A string for this value.</returns>
        public override string ToString()
        {
            return this._value;
        }

        /// <summary>Implicit operator to convert string to PostArgsOperator</summary>
        /// <param name="value">the value to convert to an instance of <see cref="PostArgsOperator" />.</param>

        public static implicit operator PostArgsOperator(string value)
        {
            return new PostArgsOperator(value);
        }

        /// <summary>Implicit operator to convert PostArgsOperator to string</summary>
        /// <param name="e">the value to convert to an instance of <see cref="PostArgsOperator" />.</param>

        public static implicit operator string(Microsoft.Azure.PowerShell.Cmdlets.Cdn.Support.PostArgsOperator e)
        {
            return e._value;
        }

        /// <summary>Overriding != operator for enum PostArgsOperator</summary>
        /// <param name="e1">the value to compare against <see cref="e2" /></param>
        /// <param name="e2">the value to compare against <see cref="e1" /></param>
        /// <returns><c>true</c> if the two instances are not equal to the same value</returns>
        public static bool operator !=(Microsoft.Azure.PowerShell.Cmdlets.Cdn.Support.PostArgsOperator e1, Microsoft.Azure.PowerShell.Cmdlets.Cdn.Support.PostArgsOperator e2)
        {
            return !e2.Equals(e1);
        }

        /// <summary>Overriding == operator for enum PostArgsOperator</summary>
        /// <param name="e1">the value to compare against <see cref="e2" /></param>
        /// <param name="e2">the value to compare against <see cref="e1" /></param>
        /// <returns><c>true</c> if the two instances are equal to the same value</returns>
        public static bool operator ==(Microsoft.Azure.PowerShell.Cmdlets.Cdn.Support.PostArgsOperator e1, Microsoft.Azure.PowerShell.Cmdlets.Cdn.Support.PostArgsOperator e2)
        {
            return e2.Equals(e1);
        }
    }
}