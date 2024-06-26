// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for license information.
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is regenerated.

namespace Microsoft.Azure.PowerShell.Cmdlets.App.Models
{
    using static Microsoft.Azure.PowerShell.Cmdlets.App.Runtime.Extensions;

    /// <summary>Diagnostics data table</summary>
    public partial class DiagnosticDataTableResponseObject :
        Microsoft.Azure.PowerShell.Cmdlets.App.Models.IDiagnosticDataTableResponseObject,
        Microsoft.Azure.PowerShell.Cmdlets.App.Models.IDiagnosticDataTableResponseObjectInternal
    {

        /// <summary>Backing field for <see cref="Column" /> property.</summary>
        private System.Collections.Generic.List<Microsoft.Azure.PowerShell.Cmdlets.App.Models.IDiagnosticDataTableResponseColumn> _column;

        /// <summary>Columns in the table</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.App.Origin(Microsoft.Azure.PowerShell.Cmdlets.App.PropertyOrigin.Owned)]
        public System.Collections.Generic.List<Microsoft.Azure.PowerShell.Cmdlets.App.Models.IDiagnosticDataTableResponseColumn> Column { get => this._column; set => this._column = value; }

        /// <summary>Backing field for <see cref="Row" /> property.</summary>
        private System.Collections.Generic.List<Microsoft.Azure.PowerShell.Cmdlets.App.Models.IAny> _row;

        /// <summary>Rows in the table</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.App.Origin(Microsoft.Azure.PowerShell.Cmdlets.App.PropertyOrigin.Owned)]
        public System.Collections.Generic.List<Microsoft.Azure.PowerShell.Cmdlets.App.Models.IAny> Row { get => this._row; set => this._row = value; }

        /// <summary>Backing field for <see cref="TableName" /> property.</summary>
        private string _tableName;

        /// <summary>Table name</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.App.Origin(Microsoft.Azure.PowerShell.Cmdlets.App.PropertyOrigin.Owned)]
        public string TableName { get => this._tableName; set => this._tableName = value; }

        /// <summary>Creates an new <see cref="DiagnosticDataTableResponseObject" /> instance.</summary>
        public DiagnosticDataTableResponseObject()
        {

        }
    }
    /// Diagnostics data table
    public partial interface IDiagnosticDataTableResponseObject :
        Microsoft.Azure.PowerShell.Cmdlets.App.Runtime.IJsonSerializable
    {
        /// <summary>Columns in the table</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.App.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Read = true,
        Create = true,
        Update = true,
        Description = @"Columns in the table",
        SerializedName = @"columns",
        PossibleTypes = new [] { typeof(Microsoft.Azure.PowerShell.Cmdlets.App.Models.IDiagnosticDataTableResponseColumn) })]
        System.Collections.Generic.List<Microsoft.Azure.PowerShell.Cmdlets.App.Models.IDiagnosticDataTableResponseColumn> Column { get; set; }
        /// <summary>Rows in the table</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.App.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Read = true,
        Create = true,
        Update = true,
        Description = @"Rows in the table",
        SerializedName = @"rows",
        PossibleTypes = new [] { typeof(Microsoft.Azure.PowerShell.Cmdlets.App.Models.IAny) })]
        System.Collections.Generic.List<Microsoft.Azure.PowerShell.Cmdlets.App.Models.IAny> Row { get; set; }
        /// <summary>Table name</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.App.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Read = true,
        Create = true,
        Update = true,
        Description = @"Table name",
        SerializedName = @"tableName",
        PossibleTypes = new [] { typeof(string) })]
        string TableName { get; set; }

    }
    /// Diagnostics data table
    internal partial interface IDiagnosticDataTableResponseObjectInternal

    {
        /// <summary>Columns in the table</summary>
        System.Collections.Generic.List<Microsoft.Azure.PowerShell.Cmdlets.App.Models.IDiagnosticDataTableResponseColumn> Column { get; set; }
        /// <summary>Rows in the table</summary>
        System.Collections.Generic.List<Microsoft.Azure.PowerShell.Cmdlets.App.Models.IAny> Row { get; set; }
        /// <summary>Table name</summary>
        string TableName { get; set; }

    }
}