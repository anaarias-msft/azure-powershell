// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for license information.
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is regenerated.

namespace Microsoft.Azure.PowerShell.Cmdlets.ImageBuilder.Models.Api20220701
{
    using static Microsoft.Azure.PowerShell.Cmdlets.ImageBuilder.Runtime.Extensions;

    /// <summary>The result of List triggers operation</summary>
    public partial class TriggerCollection :
        Microsoft.Azure.PowerShell.Cmdlets.ImageBuilder.Models.Api20220701.ITriggerCollection,
        Microsoft.Azure.PowerShell.Cmdlets.ImageBuilder.Models.Api20220701.ITriggerCollectionInternal
    {

        /// <summary>Backing field for <see cref="NextLink" /> property.</summary>
        private string _nextLink;

        /// <summary>The continuation token.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.ImageBuilder.Origin(Microsoft.Azure.PowerShell.Cmdlets.ImageBuilder.PropertyOrigin.Owned)]
        public string NextLink { get => this._nextLink; set => this._nextLink = value; }

        /// <summary>Backing field for <see cref="Value" /> property.</summary>
        private Microsoft.Azure.PowerShell.Cmdlets.ImageBuilder.Models.Api20220701.ITrigger[] _value;

        /// <summary>An array of triggers</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.ImageBuilder.Origin(Microsoft.Azure.PowerShell.Cmdlets.ImageBuilder.PropertyOrigin.Owned)]
        public Microsoft.Azure.PowerShell.Cmdlets.ImageBuilder.Models.Api20220701.ITrigger[] Value { get => this._value; set => this._value = value; }

        /// <summary>Creates an new <see cref="TriggerCollection" /> instance.</summary>
        public TriggerCollection()
        {

        }
    }
    /// The result of List triggers operation
    public partial interface ITriggerCollection :
        Microsoft.Azure.PowerShell.Cmdlets.ImageBuilder.Runtime.IJsonSerializable
    {
        /// <summary>The continuation token.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.ImageBuilder.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"The continuation token.",
        SerializedName = @"nextLink",
        PossibleTypes = new [] { typeof(string) })]
        string NextLink { get; set; }
        /// <summary>An array of triggers</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.ImageBuilder.Runtime.Info(
        Required = true,
        ReadOnly = false,
        Description = @"An array of triggers",
        SerializedName = @"value",
        PossibleTypes = new [] { typeof(Microsoft.Azure.PowerShell.Cmdlets.ImageBuilder.Models.Api20220701.ITrigger) })]
        Microsoft.Azure.PowerShell.Cmdlets.ImageBuilder.Models.Api20220701.ITrigger[] Value { get; set; }

    }
    /// The result of List triggers operation
    internal partial interface ITriggerCollectionInternal

    {
        /// <summary>The continuation token.</summary>
        string NextLink { get; set; }
        /// <summary>An array of triggers</summary>
        Microsoft.Azure.PowerShell.Cmdlets.ImageBuilder.Models.Api20220701.ITrigger[] Value { get; set; }

    }
}