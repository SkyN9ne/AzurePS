// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for license information.
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is regenerated.

namespace Microsoft.Azure.PowerShell.Cmdlets.Peering.Models.Api20221001
{
    using static Microsoft.Azure.PowerShell.Cmdlets.Peering.Runtime.Extensions;

    /// <summary>Service specification payload.</summary>
    public partial class ServiceSpecification :
        Microsoft.Azure.PowerShell.Cmdlets.Peering.Models.Api20221001.IServiceSpecification,
        Microsoft.Azure.PowerShell.Cmdlets.Peering.Models.Api20221001.IServiceSpecificationInternal
    {

        /// <summary>Backing field for <see cref="MetricSpecification" /> property.</summary>
        private Microsoft.Azure.PowerShell.Cmdlets.Peering.Models.Api20221001.IMetricSpecification[] _metricSpecification;

        /// <summary>Specifications of the Metrics for Azure Monitoring.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Peering.Origin(Microsoft.Azure.PowerShell.Cmdlets.Peering.PropertyOrigin.Owned)]
        public Microsoft.Azure.PowerShell.Cmdlets.Peering.Models.Api20221001.IMetricSpecification[] MetricSpecification { get => this._metricSpecification; }

        /// <summary>Internal Acessors for MetricSpecification</summary>
        Microsoft.Azure.PowerShell.Cmdlets.Peering.Models.Api20221001.IMetricSpecification[] Microsoft.Azure.PowerShell.Cmdlets.Peering.Models.Api20221001.IServiceSpecificationInternal.MetricSpecification { get => this._metricSpecification; set { {_metricSpecification = value;} } }

        /// <summary>Creates an new <see cref="ServiceSpecification" /> instance.</summary>
        public ServiceSpecification()
        {

        }
    }
    /// Service specification payload.
    public partial interface IServiceSpecification :
        Microsoft.Azure.PowerShell.Cmdlets.Peering.Runtime.IJsonSerializable
    {
        /// <summary>Specifications of the Metrics for Azure Monitoring.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Peering.Runtime.Info(
        Required = false,
        ReadOnly = true,
        Description = @"Specifications of the Metrics for Azure Monitoring.",
        SerializedName = @"metricSpecifications",
        PossibleTypes = new [] { typeof(Microsoft.Azure.PowerShell.Cmdlets.Peering.Models.Api20221001.IMetricSpecification) })]
        Microsoft.Azure.PowerShell.Cmdlets.Peering.Models.Api20221001.IMetricSpecification[] MetricSpecification { get;  }

    }
    /// Service specification payload.
    internal partial interface IServiceSpecificationInternal

    {
        /// <summary>Specifications of the Metrics for Azure Monitoring.</summary>
        Microsoft.Azure.PowerShell.Cmdlets.Peering.Models.Api20221001.IMetricSpecification[] MetricSpecification { get; set; }

    }
}