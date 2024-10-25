// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

using Azure.Provisioning.Primitives;
using System;

namespace Azure.Provisioning.PostgreSql;

/// <summary>
/// Storage Profile properties of a server.
/// </summary>
public partial class PostgreSqlStorageProfile : ProvisionableConstruct
{
    /// <summary>
    /// Backup retention days for the server.
    /// </summary>
    public BicepValue<int> BackupRetentionDays { get => _backupRetentionDays; set => _backupRetentionDays.Assign(value); }
    private readonly BicepValue<int> _backupRetentionDays;

    /// <summary>
    /// Enable Geo-redundant or not for server backup.
    /// </summary>
    public BicepValue<PostgreSqlGeoRedundantBackup> GeoRedundantBackup { get => _geoRedundantBackup; set => _geoRedundantBackup.Assign(value); }
    private readonly BicepValue<PostgreSqlGeoRedundantBackup> _geoRedundantBackup;

    /// <summary>
    /// Max storage allowed for a server.
    /// </summary>
    public BicepValue<int> StorageInMB { get => _storageInMB; set => _storageInMB.Assign(value); }
    private readonly BicepValue<int> _storageInMB;

    /// <summary>
    /// Enable Storage Auto Grow.
    /// </summary>
    public BicepValue<PostgreSqlStorageAutogrow> StorageAutogrow { get => _storageAutogrow; set => _storageAutogrow.Assign(value); }
    private readonly BicepValue<PostgreSqlStorageAutogrow> _storageAutogrow;

    /// <summary>
    /// Creates a new PostgreSqlStorageProfile.
    /// </summary>
    public PostgreSqlStorageProfile()
    {
        _backupRetentionDays = BicepValue<int>.DefineProperty(this, "BackupRetentionDays", ["backupRetentionDays"]);
        _geoRedundantBackup = BicepValue<PostgreSqlGeoRedundantBackup>.DefineProperty(this, "GeoRedundantBackup", ["geoRedundantBackup"]);
        _storageInMB = BicepValue<int>.DefineProperty(this, "StorageInMB", ["storageMB"]);
        _storageAutogrow = BicepValue<PostgreSqlStorageAutogrow>.DefineProperty(this, "StorageAutogrow", ["storageAutogrow"]);
    }
}
