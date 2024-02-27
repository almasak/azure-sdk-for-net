// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using Azure.Core;
using Azure.ResourceManager.Models;
using Azure.ResourceManager.WorkloadMonitor;

namespace Azure.ResourceManager.WorkloadMonitor.Models
{
    /// <summary> Model factory for models. </summary>
    public static partial class ArmWorkloadMonitorModelFactory
    {
        /// <summary> Initializes a new instance of <see cref="WorkloadMonitor.HealthMonitorData"/>. </summary>
        /// <param name="id"> The id. </param>
        /// <param name="name"> The name. </param>
        /// <param name="resourceType"> The resourceType. </param>
        /// <param name="systemData"> The systemData. </param>
        /// <param name="monitorName"> Human-readable name of the monitor. </param>
        /// <param name="monitorType"> Type of the monitor. </param>
        /// <param name="monitoredObject"> Dynamic monitored object of the monitor. </param>
        /// <param name="parentMonitorName"> Name of the parent monitor. </param>
        /// <param name="previousMonitorState"> Previous health state of the monitor. </param>
        /// <param name="currentMonitorState"> Current health state of the monitor. </param>
        /// <param name="evaluationTimestamp"> Timestamp of the monitor's last health evaluation. </param>
        /// <param name="currentStateFirstObservedTimestamp"> Timestamp of the monitor's last health state change. </param>
        /// <param name="lastReportedTimestamp"> Timestamp of the monitor's last reported health state. </param>
        /// <param name="evidence"> Evidence validating the monitor's current health state. </param>
        /// <param name="monitorConfiguration"> The configuration settings at the time of the monitor's health evaluation. </param>
        /// <returns> A new <see cref="WorkloadMonitor.HealthMonitorData"/> instance for mocking. </returns>
        public static HealthMonitorData HealthMonitorData(ResourceIdentifier id = null, string name = null, ResourceType resourceType = default, SystemData systemData = null, string monitorName = null, string monitorType = null, string monitoredObject = null, string parentMonitorName = null, HealthState? previousMonitorState = null, HealthState? currentMonitorState = null, string evaluationTimestamp = null, string currentStateFirstObservedTimestamp = null, string lastReportedTimestamp = null, BinaryData evidence = null, BinaryData monitorConfiguration = null)
        {
            return new HealthMonitorData(
                id,
                name,
                resourceType,
                systemData,
                monitorName,
                monitorType,
                monitoredObject,
                parentMonitorName,
                previousMonitorState,
                currentMonitorState,
                evaluationTimestamp,
                currentStateFirstObservedTimestamp,
                lastReportedTimestamp,
                evidence,
                monitorConfiguration,
                serializedAdditionalRawData: null);
        }

        /// <summary> Initializes a new instance of <see cref="WorkloadMonitor.HealthMonitorStateChangeData"/>. </summary>
        /// <param name="id"> The id. </param>
        /// <param name="name"> The name. </param>
        /// <param name="resourceType"> The resourceType. </param>
        /// <param name="systemData"> The systemData. </param>
        /// <param name="monitorName"> Human-readable name of the monitor. </param>
        /// <param name="monitorType"> Type of the monitor. </param>
        /// <param name="monitoredObject"> Dynamic monitored object of the monitor. </param>
        /// <param name="evaluationTimestamp"> Timestamp of the monitor's last health evaluation. </param>
        /// <param name="currentStateFirstObservedTimestamp"> Timestamp of the monitor's last health state change. </param>
        /// <param name="previousMonitorState"> Previous health state of the monitor. </param>
        /// <param name="currentMonitorState"> Current health state of the monitor. </param>
        /// <param name="evidence"> Evidence validating the monitor's current health state. </param>
        /// <param name="monitorConfiguration"> The configuration settings at the time of the monitor's health evaluation. </param>
        /// <returns> A new <see cref="WorkloadMonitor.HealthMonitorStateChangeData"/> instance for mocking. </returns>
        public static HealthMonitorStateChangeData HealthMonitorStateChangeData(ResourceIdentifier id = null, string name = null, ResourceType resourceType = default, SystemData systemData = null, string monitorName = null, string monitorType = null, string monitoredObject = null, string evaluationTimestamp = null, string currentStateFirstObservedTimestamp = null, HealthState? previousMonitorState = null, HealthState? currentMonitorState = null, BinaryData evidence = null, BinaryData monitorConfiguration = null)
        {
            return new HealthMonitorStateChangeData(
                id,
                name,
                resourceType,
                systemData,
                monitorName,
                monitorType,
                monitoredObject,
                evaluationTimestamp,
                currentStateFirstObservedTimestamp,
                previousMonitorState,
                currentMonitorState,
                evidence,
                monitorConfiguration,
                serializedAdditionalRawData: null);
        }
    }
}
