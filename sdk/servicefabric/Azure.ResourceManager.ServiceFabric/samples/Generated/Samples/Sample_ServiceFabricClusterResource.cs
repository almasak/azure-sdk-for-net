// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Threading.Tasks;
using Azure;
using Azure.Core;
using Azure.Identity;
using Azure.ResourceManager;
using Azure.ResourceManager.Resources;
using Azure.ResourceManager.ServiceFabric;
using Azure.ResourceManager.ServiceFabric.Models;

namespace Azure.ResourceManager.ServiceFabric.Samples
{
    public partial class Sample_ServiceFabricClusterResource
    {
        // Get a cluster
        [NUnit.Framework.Test]
        [NUnit.Framework.Ignore("Only verifying that the sample builds")]
        public async Task Get_GetACluster()
        {
            // Generated from example definition: specification/servicefabric/resource-manager/Microsoft.ServiceFabric/preview/2023-11-01-preview/examples/ClusterGetOperation_example.json
            // this example is just showing the usage of "Clusters_Get" operation, for the dependent resources, they will have to be created separately.

            // get your azure access token, for more details of how Azure SDK get your access token, please refer to https://learn.microsoft.com/en-us/dotnet/azure/sdk/authentication?tabs=command-line
            TokenCredential cred = new DefaultAzureCredential();
            // authenticate your client
            ArmClient client = new ArmClient(cred);

            // this example assumes you already have this ServiceFabricClusterResource created on azure
            // for more information of creating ServiceFabricClusterResource, please refer to the document of ServiceFabricClusterResource
            string subscriptionId = "00000000-0000-0000-0000-000000000000";
            string resourceGroupName = "resRg";
            string clusterName = "myCluster";
            ResourceIdentifier serviceFabricClusterResourceId = ServiceFabricClusterResource.CreateResourceIdentifier(subscriptionId, resourceGroupName, clusterName);
            ServiceFabricClusterResource serviceFabricCluster = client.GetServiceFabricClusterResource(serviceFabricClusterResourceId);

            // invoke the operation
            ServiceFabricClusterResource result = await serviceFabricCluster.GetAsync();

            // the variable result is a resource, you could call other operations on this instance as well
            // but just for demo, we get its data from this resource instance
            ServiceFabricClusterData resourceData = result.Data;
            // for demo we just print out the id
            Console.WriteLine($"Succeeded on id: {resourceData.Id}");
        }

        // Patch a cluster
        [NUnit.Framework.Test]
        [NUnit.Framework.Ignore("Only verifying that the sample builds")]
        public async Task Update_PatchACluster()
        {
            // Generated from example definition: specification/servicefabric/resource-manager/Microsoft.ServiceFabric/preview/2023-11-01-preview/examples/ClusterPatchOperation_example.json
            // this example is just showing the usage of "Clusters_Update" operation, for the dependent resources, they will have to be created separately.

            // get your azure access token, for more details of how Azure SDK get your access token, please refer to https://learn.microsoft.com/en-us/dotnet/azure/sdk/authentication?tabs=command-line
            TokenCredential cred = new DefaultAzureCredential();
            // authenticate your client
            ArmClient client = new ArmClient(cred);

            // this example assumes you already have this ServiceFabricClusterResource created on azure
            // for more information of creating ServiceFabricClusterResource, please refer to the document of ServiceFabricClusterResource
            string subscriptionId = "00000000-0000-0000-0000-000000000000";
            string resourceGroupName = "resRg";
            string clusterName = "myCluster";
            ResourceIdentifier serviceFabricClusterResourceId = ServiceFabricClusterResource.CreateResourceIdentifier(subscriptionId, resourceGroupName, clusterName);
            ServiceFabricClusterResource serviceFabricCluster = client.GetServiceFabricClusterResource(serviceFabricClusterResourceId);

            // invoke the operation
            ServiceFabricClusterPatch patch = new ServiceFabricClusterPatch()
            {
                Tags =
{
["a"] = "b",
},
                IsEventStoreServiceEnabled = true,
                NodeTypes =
{
new ClusterNodeTypeDescription("nt1vm",19000,19007,true,5)
{
DurabilityLevel = ClusterDurabilityLevel.Bronze,
ApplicationPorts = new ClusterEndpointRangeDescription(20000,30000),
EphemeralPorts = new ClusterEndpointRangeDescription(49000,64000),
HttpGatewayTokenAuthEndpointPort = 19081,
},new ClusterNodeTypeDescription("testnt1",0,0,false,3)
{
DurabilityLevel = ClusterDurabilityLevel.Bronze,
ApplicationPorts = new ClusterEndpointRangeDescription(1000,2000),
EphemeralPorts = new ClusterEndpointRangeDescription(3000,4000),
HttpGatewayTokenAuthEndpointPort = 19081,
}
},
                ReliabilityLevel = ClusterReliabilityLevel.Bronze,
                UpgradeMode = ClusterUpgradeMode.Automatic,
                UpgradeWave = new ClusterUpgradeCadence("Wave"),
                UpgradePauseStartOn = DateTimeOffset.Parse("2021-06-21T22:00:00Z"),
                UpgradePauseEndOn = DateTimeOffset.Parse("2021-06-25T22:00:00Z"),
                IsHttpGatewayExclusiveAuthModeEnabled = true,
            };
            ArmOperation<ServiceFabricClusterResource> lro = await serviceFabricCluster.UpdateAsync(WaitUntil.Completed, patch);
            ServiceFabricClusterResource result = lro.Value;

            // the variable result is a resource, you could call other operations on this instance as well
            // but just for demo, we get its data from this resource instance
            ServiceFabricClusterData resourceData = result.Data;
            // for demo we just print out the id
            Console.WriteLine($"Succeeded on id: {resourceData.Id}");
        }

        // Delete a cluster
        [NUnit.Framework.Test]
        [NUnit.Framework.Ignore("Only verifying that the sample builds")]
        public async Task Delete_DeleteACluster()
        {
            // Generated from example definition: specification/servicefabric/resource-manager/Microsoft.ServiceFabric/preview/2023-11-01-preview/examples/ClusterDeleteOperation_example.json
            // this example is just showing the usage of "Clusters_Delete" operation, for the dependent resources, they will have to be created separately.

            // get your azure access token, for more details of how Azure SDK get your access token, please refer to https://learn.microsoft.com/en-us/dotnet/azure/sdk/authentication?tabs=command-line
            TokenCredential cred = new DefaultAzureCredential();
            // authenticate your client
            ArmClient client = new ArmClient(cred);

            // this example assumes you already have this ServiceFabricClusterResource created on azure
            // for more information of creating ServiceFabricClusterResource, please refer to the document of ServiceFabricClusterResource
            string subscriptionId = "00000000-0000-0000-0000-000000000000";
            string resourceGroupName = "resRg";
            string clusterName = "myCluster";
            ResourceIdentifier serviceFabricClusterResourceId = ServiceFabricClusterResource.CreateResourceIdentifier(subscriptionId, resourceGroupName, clusterName);
            ServiceFabricClusterResource serviceFabricCluster = client.GetServiceFabricClusterResource(serviceFabricClusterResourceId);

            // invoke the operation
            await serviceFabricCluster.DeleteAsync(WaitUntil.Completed);

            Console.WriteLine($"Succeeded");
        }

        // List clusters
        [NUnit.Framework.Test]
        [NUnit.Framework.Ignore("Only verifying that the sample builds")]
        public async Task GetServiceFabricClusters_ListClusters()
        {
            // Generated from example definition: specification/servicefabric/resource-manager/Microsoft.ServiceFabric/preview/2023-11-01-preview/examples/ClusterListOperation_example.json
            // this example is just showing the usage of "Clusters_List" operation, for the dependent resources, they will have to be created separately.

            // get your azure access token, for more details of how Azure SDK get your access token, please refer to https://learn.microsoft.com/en-us/dotnet/azure/sdk/authentication?tabs=command-line
            TokenCredential cred = new DefaultAzureCredential();
            // authenticate your client
            ArmClient client = new ArmClient(cred);

            // this example assumes you already have this SubscriptionResource created on azure
            // for more information of creating SubscriptionResource, please refer to the document of SubscriptionResource
            string subscriptionId = "00000000-0000-0000-0000-000000000000";
            ResourceIdentifier subscriptionResourceId = SubscriptionResource.CreateResourceIdentifier(subscriptionId);
            SubscriptionResource subscriptionResource = client.GetSubscriptionResource(subscriptionResourceId);

            // invoke the operation and iterate over the result
            await foreach (ServiceFabricClusterResource item in subscriptionResource.GetServiceFabricClustersAsync())
            {
                // the variable item is a resource, you could call other operations on this instance as well
                // but just for demo, we get its data from this resource instance
                ServiceFabricClusterData resourceData = item.Data;
                // for demo we just print out the id
                Console.WriteLine($"Succeeded on id: {resourceData.Id}");
            }

            Console.WriteLine($"Succeeded");
        }

        // Get minimum and maximum code versions
        [NUnit.Framework.Test]
        [NUnit.Framework.Ignore("Only verifying that the sample builds")]
        public async Task GetUpgradableVersions_GetMinimumAndMaximumCodeVersions()
        {
            // Generated from example definition: specification/servicefabric/resource-manager/Microsoft.ServiceFabric/preview/2023-11-01-preview/examples/ListUpgradableVersionsMinMax_example.json
            // this example is just showing the usage of "Clusters_ListUpgradableVersions" operation, for the dependent resources, they will have to be created separately.

            // get your azure access token, for more details of how Azure SDK get your access token, please refer to https://learn.microsoft.com/en-us/dotnet/azure/sdk/authentication?tabs=command-line
            TokenCredential cred = new DefaultAzureCredential();
            // authenticate your client
            ArmClient client = new ArmClient(cred);

            // this example assumes you already have this ServiceFabricClusterResource created on azure
            // for more information of creating ServiceFabricClusterResource, please refer to the document of ServiceFabricClusterResource
            string subscriptionId = "00000000-0000-0000-0000-000000000000";
            string resourceGroupName = "resRg";
            string clusterName = "myCluster";
            ResourceIdentifier serviceFabricClusterResourceId = ServiceFabricClusterResource.CreateResourceIdentifier(subscriptionId, resourceGroupName, clusterName);
            ServiceFabricClusterResource serviceFabricCluster = client.GetServiceFabricClusterResource(serviceFabricClusterResourceId);

            // invoke the operation
            UpgradableVersionPathResult result = await serviceFabricCluster.GetUpgradableVersionsAsync();

            Console.WriteLine($"Succeeded: {result}");
        }

        // Get upgrade path
        [NUnit.Framework.Test]
        [NUnit.Framework.Ignore("Only verifying that the sample builds")]
        public async Task GetUpgradableVersions_GetUpgradePath()
        {
            // Generated from example definition: specification/servicefabric/resource-manager/Microsoft.ServiceFabric/preview/2023-11-01-preview/examples/ListUpgradableVersionsPath_example.json
            // this example is just showing the usage of "Clusters_ListUpgradableVersions" operation, for the dependent resources, they will have to be created separately.

            // get your azure access token, for more details of how Azure SDK get your access token, please refer to https://learn.microsoft.com/en-us/dotnet/azure/sdk/authentication?tabs=command-line
            TokenCredential cred = new DefaultAzureCredential();
            // authenticate your client
            ArmClient client = new ArmClient(cred);

            // this example assumes you already have this ServiceFabricClusterResource created on azure
            // for more information of creating ServiceFabricClusterResource, please refer to the document of ServiceFabricClusterResource
            string subscriptionId = "00000000-0000-0000-0000-000000000000";
            string resourceGroupName = "resRg";
            string clusterName = "myCluster";
            ResourceIdentifier serviceFabricClusterResourceId = ServiceFabricClusterResource.CreateResourceIdentifier(subscriptionId, resourceGroupName, clusterName);
            ServiceFabricClusterResource serviceFabricCluster = client.GetServiceFabricClusterResource(serviceFabricClusterResourceId);

            // invoke the operation
            UpgradableVersionsDescription versionsDescription = new UpgradableVersionsDescription("7.2.432.9590");
            UpgradableVersionPathResult result = await serviceFabricCluster.GetUpgradableVersionsAsync(versionsDescription: versionsDescription);

            Console.WriteLine($"Succeeded: {result}");
        }
    }
}
