// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;

namespace Azure.Data.Tables.Models
{
    /// <summary> Model factory for models. </summary>
    public static partial class TableModelFactory
    {
        /// <summary> Initializes a new instance of TableServiceStatistics. </summary>
        /// <param name="geoReplication"> Geo-Replication information for the Secondary Storage Service. </param>
        /// <returns> A new <see cref="Models.TableServiceStatistics"/> instance for mocking. </returns>
        public static TableServiceStatistics TableServiceStatistics(TableGeoReplicationInfo geoReplication = null)
        {
            return new TableServiceStatistics(geoReplication);
        }

        /// <summary> Initializes a new instance of TableGeoReplicationInfo. </summary>
        /// <param name="status"> The status of the secondary location. </param>
        /// <param name="lastSyncedOn"> A GMT date/time value, to the second. All primary writes preceding this value are guaranteed to be available for read operations at the secondary. Primary writes after this point in time may or may not be available for reads. </param>
        /// <returns> A new <see cref="Models.TableGeoReplicationInfo"/> instance for mocking. </returns>
        public static TableGeoReplicationInfo TableGeoReplicationInfo(TableGeoReplicationStatus status = default, DateTimeOffset lastSyncedOn = default)
        {
            return new TableGeoReplicationInfo(status, lastSyncedOn);
        }
    }
}
