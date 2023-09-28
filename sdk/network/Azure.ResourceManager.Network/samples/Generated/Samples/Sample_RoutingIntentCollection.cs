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
using Azure.ResourceManager.Network;
using Azure.ResourceManager.Network.Models;

namespace Azure.ResourceManager.Network.Samples
{
    public partial class Sample_RoutingIntentCollection
    {
        // RouteTablePut
        [NUnit.Framework.Test]
        [NUnit.Framework.Ignore("Only verifying that the sample builds")]
        public async Task CreateOrUpdate_RouteTablePut()
        {
            // Generated from example definition: specification/network/resource-manager/Microsoft.Network/stable/2023-05-01/examples/RoutingIntentPut.json
            // this example is just showing the usage of "RoutingIntent_CreateOrUpdate" operation, for the dependent resources, they will have to be created separately.

            // get your azure access token, for more details of how Azure SDK get your access token, please refer to https://learn.microsoft.com/en-us/dotnet/azure/sdk/authentication?tabs=command-line
            TokenCredential cred = new DefaultAzureCredential();
            // authenticate your client
            ArmClient client = new ArmClient(cred);

            // this example assumes you already have this VirtualHubResource created on azure
            // for more information of creating VirtualHubResource, please refer to the document of VirtualHubResource
            string subscriptionId = "subid";
            string resourceGroupName = "rg1";
            string virtualHubName = "virtualHub1";
            ResourceIdentifier virtualHubResourceId = VirtualHubResource.CreateResourceIdentifier(subscriptionId, resourceGroupName, virtualHubName);
            VirtualHubResource virtualHub = client.GetVirtualHubResource(virtualHubResourceId);

            // get the collection of this RoutingIntentResource
            RoutingIntentCollection collection = virtualHub.GetRoutingIntents();

            // invoke the operation
            string routingIntentName = "Intent1";
            RoutingIntentData data = new RoutingIntentData()
            {
                RoutingPolicies =
{
new RoutingPolicy("InternetTraffic",new string[]
{
"Internet"
},"/subscriptions/subid/resourceGroups/rg1/providers/Microsoft.Network/azureFirewalls/azfw1"),new RoutingPolicy("PrivateTrafficPolicy",new string[]
{
"PrivateTraffic"
},"/subscriptions/subid/resourceGroups/rg1/providers/Microsoft.Network/azureFirewalls/azfw1")
},
            };
            ArmOperation<RoutingIntentResource> lro = await collection.CreateOrUpdateAsync(WaitUntil.Completed, routingIntentName, data);
            RoutingIntentResource result = lro.Value;

            // the variable result is a resource, you could call other operations on this instance as well
            // but just for demo, we get its data from this resource instance
            RoutingIntentData resourceData = result.Data;
            // for demo we just print out the id
            Console.WriteLine($"Succeeded on id: {resourceData.Id}");
        }

        // RouteTableGet
        [NUnit.Framework.Test]
        [NUnit.Framework.Ignore("Only verifying that the sample builds")]
        public async Task Get_RouteTableGet()
        {
            // Generated from example definition: specification/network/resource-manager/Microsoft.Network/stable/2023-05-01/examples/RoutingIntentGet.json
            // this example is just showing the usage of "RoutingIntent_Get" operation, for the dependent resources, they will have to be created separately.

            // get your azure access token, for more details of how Azure SDK get your access token, please refer to https://learn.microsoft.com/en-us/dotnet/azure/sdk/authentication?tabs=command-line
            TokenCredential cred = new DefaultAzureCredential();
            // authenticate your client
            ArmClient client = new ArmClient(cred);

            // this example assumes you already have this VirtualHubResource created on azure
            // for more information of creating VirtualHubResource, please refer to the document of VirtualHubResource
            string subscriptionId = "subid";
            string resourceGroupName = "rg1";
            string virtualHubName = "virtualHub1";
            ResourceIdentifier virtualHubResourceId = VirtualHubResource.CreateResourceIdentifier(subscriptionId, resourceGroupName, virtualHubName);
            VirtualHubResource virtualHub = client.GetVirtualHubResource(virtualHubResourceId);

            // get the collection of this RoutingIntentResource
            RoutingIntentCollection collection = virtualHub.GetRoutingIntents();

            // invoke the operation
            string routingIntentName = "Intent1";
            RoutingIntentResource result = await collection.GetAsync(routingIntentName);

            // the variable result is a resource, you could call other operations on this instance as well
            // but just for demo, we get its data from this resource instance
            RoutingIntentData resourceData = result.Data;
            // for demo we just print out the id
            Console.WriteLine($"Succeeded on id: {resourceData.Id}");
        }

        // RouteTableGet
        [NUnit.Framework.Test]
        [NUnit.Framework.Ignore("Only verifying that the sample builds")]
        public async Task Exists_RouteTableGet()
        {
            // Generated from example definition: specification/network/resource-manager/Microsoft.Network/stable/2023-05-01/examples/RoutingIntentGet.json
            // this example is just showing the usage of "RoutingIntent_Get" operation, for the dependent resources, they will have to be created separately.

            // get your azure access token, for more details of how Azure SDK get your access token, please refer to https://learn.microsoft.com/en-us/dotnet/azure/sdk/authentication?tabs=command-line
            TokenCredential cred = new DefaultAzureCredential();
            // authenticate your client
            ArmClient client = new ArmClient(cred);

            // this example assumes you already have this VirtualHubResource created on azure
            // for more information of creating VirtualHubResource, please refer to the document of VirtualHubResource
            string subscriptionId = "subid";
            string resourceGroupName = "rg1";
            string virtualHubName = "virtualHub1";
            ResourceIdentifier virtualHubResourceId = VirtualHubResource.CreateResourceIdentifier(subscriptionId, resourceGroupName, virtualHubName);
            VirtualHubResource virtualHub = client.GetVirtualHubResource(virtualHubResourceId);

            // get the collection of this RoutingIntentResource
            RoutingIntentCollection collection = virtualHub.GetRoutingIntents();

            // invoke the operation
            string routingIntentName = "Intent1";
            bool result = await collection.ExistsAsync(routingIntentName);

            Console.WriteLine($"Succeeded: {result}");
        }

        // RouteTableGet
        [NUnit.Framework.Test]
        [NUnit.Framework.Ignore("Only verifying that the sample builds")]
        public async Task GetIfExists_RouteTableGet()
        {
            // Generated from example definition: specification/network/resource-manager/Microsoft.Network/stable/2023-05-01/examples/RoutingIntentGet.json
            // this example is just showing the usage of "RoutingIntent_Get" operation, for the dependent resources, they will have to be created separately.

            // get your azure access token, for more details of how Azure SDK get your access token, please refer to https://learn.microsoft.com/en-us/dotnet/azure/sdk/authentication?tabs=command-line
            TokenCredential cred = new DefaultAzureCredential();
            // authenticate your client
            ArmClient client = new ArmClient(cred);

            // this example assumes you already have this VirtualHubResource created on azure
            // for more information of creating VirtualHubResource, please refer to the document of VirtualHubResource
            string subscriptionId = "subid";
            string resourceGroupName = "rg1";
            string virtualHubName = "virtualHub1";
            ResourceIdentifier virtualHubResourceId = VirtualHubResource.CreateResourceIdentifier(subscriptionId, resourceGroupName, virtualHubName);
            VirtualHubResource virtualHub = client.GetVirtualHubResource(virtualHubResourceId);

            // get the collection of this RoutingIntentResource
            RoutingIntentCollection collection = virtualHub.GetRoutingIntents();

            // invoke the operation
            string routingIntentName = "Intent1";
            NullableResponse<RoutingIntentResource> response = await collection.GetIfExistsAsync(routingIntentName);
            RoutingIntentResource result = response.HasValue ? response.Value : null;

            if (result == null)
            {
                Console.WriteLine($"Succeeded with null as result");
            }
            else
            {
                // the variable result is a resource, you could call other operations on this instance as well
                // but just for demo, we get its data from this resource instance
                RoutingIntentData resourceData = result.Data;
                // for demo we just print out the id
                Console.WriteLine($"Succeeded on id: {resourceData.Id}");
            }
        }

        // RoutingIntentList
        [NUnit.Framework.Test]
        [NUnit.Framework.Ignore("Only verifying that the sample builds")]
        public async Task GetAll_RoutingIntentList()
        {
            // Generated from example definition: specification/network/resource-manager/Microsoft.Network/stable/2023-05-01/examples/RoutingIntentList.json
            // this example is just showing the usage of "RoutingIntent_List" operation, for the dependent resources, they will have to be created separately.

            // get your azure access token, for more details of how Azure SDK get your access token, please refer to https://learn.microsoft.com/en-us/dotnet/azure/sdk/authentication?tabs=command-line
            TokenCredential cred = new DefaultAzureCredential();
            // authenticate your client
            ArmClient client = new ArmClient(cred);

            // this example assumes you already have this VirtualHubResource created on azure
            // for more information of creating VirtualHubResource, please refer to the document of VirtualHubResource
            string subscriptionId = "subid";
            string resourceGroupName = "rg1";
            string virtualHubName = "virtualHub1";
            ResourceIdentifier virtualHubResourceId = VirtualHubResource.CreateResourceIdentifier(subscriptionId, resourceGroupName, virtualHubName);
            VirtualHubResource virtualHub = client.GetVirtualHubResource(virtualHubResourceId);

            // get the collection of this RoutingIntentResource
            RoutingIntentCollection collection = virtualHub.GetRoutingIntents();

            // invoke the operation and iterate over the result
            await foreach (RoutingIntentResource item in collection.GetAllAsync())
            {
                // the variable item is a resource, you could call other operations on this instance as well
                // but just for demo, we get its data from this resource instance
                RoutingIntentData resourceData = item.Data;
                // for demo we just print out the id
                Console.WriteLine($"Succeeded on id: {resourceData.Id}");
            }

            Console.WriteLine($"Succeeded");
        }
    }
}
