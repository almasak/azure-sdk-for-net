// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Threading.Tasks;
using Azure.Core;
using Azure.Identity;
using Azure.ResourceManager.MachineLearning.Models;

namespace Azure.ResourceManager.MachineLearning.Samples
{
    public partial class Sample_MachineLearningDataContainerResource
    {
        // Delete Workspace Data Container.
        [NUnit.Framework.Test]
        [NUnit.Framework.Ignore("Only verifying that the sample builds")]
        public async Task Delete_DeleteWorkspaceDataContainer()
        {
            // Generated from example definition: specification/machinelearningservices/resource-manager/Microsoft.MachineLearningServices/preview/2024-07-01-preview/examples/Workspace/DataContainer/delete.json
            // this example is just showing the usage of "DataContainers_Delete" operation, for the dependent resources, they will have to be created separately.

            // get your azure access token, for more details of how Azure SDK get your access token, please refer to https://learn.microsoft.com/en-us/dotnet/azure/sdk/authentication?tabs=command-line
            TokenCredential cred = new DefaultAzureCredential();
            // authenticate your client
            ArmClient client = new ArmClient(cred);

            // this example assumes you already have this MachineLearningDataContainerResource created on azure
            // for more information of creating MachineLearningDataContainerResource, please refer to the document of MachineLearningDataContainerResource
            string subscriptionId = "00000000-1111-2222-3333-444444444444";
            string resourceGroupName = "testrg123";
            string workspaceName = "workspace123";
            string name = "datacontainer123";
            ResourceIdentifier machineLearningDataContainerResourceId = MachineLearningDataContainerResource.CreateResourceIdentifier(subscriptionId, resourceGroupName, workspaceName, name);
            MachineLearningDataContainerResource machineLearningDataContainer = client.GetMachineLearningDataContainerResource(machineLearningDataContainerResourceId);

            // invoke the operation
            await machineLearningDataContainer.DeleteAsync(WaitUntil.Completed);

            Console.WriteLine($"Succeeded");
        }

        // Get Workspace Data Container.
        [NUnit.Framework.Test]
        [NUnit.Framework.Ignore("Only verifying that the sample builds")]
        public async Task Get_GetWorkspaceDataContainer()
        {
            // Generated from example definition: specification/machinelearningservices/resource-manager/Microsoft.MachineLearningServices/preview/2024-07-01-preview/examples/Workspace/DataContainer/get.json
            // this example is just showing the usage of "DataContainers_Get" operation, for the dependent resources, they will have to be created separately.

            // get your azure access token, for more details of how Azure SDK get your access token, please refer to https://learn.microsoft.com/en-us/dotnet/azure/sdk/authentication?tabs=command-line
            TokenCredential cred = new DefaultAzureCredential();
            // authenticate your client
            ArmClient client = new ArmClient(cred);

            // this example assumes you already have this MachineLearningDataContainerResource created on azure
            // for more information of creating MachineLearningDataContainerResource, please refer to the document of MachineLearningDataContainerResource
            string subscriptionId = "00000000-1111-2222-3333-444444444444";
            string resourceGroupName = "testrg123";
            string workspaceName = "workspace123";
            string name = "datacontainer123";
            ResourceIdentifier machineLearningDataContainerResourceId = MachineLearningDataContainerResource.CreateResourceIdentifier(subscriptionId, resourceGroupName, workspaceName, name);
            MachineLearningDataContainerResource machineLearningDataContainer = client.GetMachineLearningDataContainerResource(machineLearningDataContainerResourceId);

            // invoke the operation
            MachineLearningDataContainerResource result = await machineLearningDataContainer.GetAsync();

            // the variable result is a resource, you could call other operations on this instance as well
            // but just for demo, we get its data from this resource instance
            MachineLearningDataContainerData resourceData = result.Data;
            // for demo we just print out the id
            Console.WriteLine($"Succeeded on id: {resourceData.Id}");
        }

        // CreateOrUpdate Workspace Data Container.
        [NUnit.Framework.Test]
        [NUnit.Framework.Ignore("Only verifying that the sample builds")]
        public async Task Update_CreateOrUpdateWorkspaceDataContainer()
        {
            // Generated from example definition: specification/machinelearningservices/resource-manager/Microsoft.MachineLearningServices/preview/2024-07-01-preview/examples/Workspace/DataContainer/createOrUpdate.json
            // this example is just showing the usage of "DataContainers_CreateOrUpdate" operation, for the dependent resources, they will have to be created separately.

            // get your azure access token, for more details of how Azure SDK get your access token, please refer to https://learn.microsoft.com/en-us/dotnet/azure/sdk/authentication?tabs=command-line
            TokenCredential cred = new DefaultAzureCredential();
            // authenticate your client
            ArmClient client = new ArmClient(cred);

            // this example assumes you already have this MachineLearningDataContainerResource created on azure
            // for more information of creating MachineLearningDataContainerResource, please refer to the document of MachineLearningDataContainerResource
            string subscriptionId = "00000000-1111-2222-3333-444444444444";
            string resourceGroupName = "testrg123";
            string workspaceName = "workspace123";
            string name = "datacontainer123";
            ResourceIdentifier machineLearningDataContainerResourceId = MachineLearningDataContainerResource.CreateResourceIdentifier(subscriptionId, resourceGroupName, workspaceName, name);
            MachineLearningDataContainerResource machineLearningDataContainer = client.GetMachineLearningDataContainerResource(machineLearningDataContainerResourceId);

            // invoke the operation
            MachineLearningDataContainerData data = new MachineLearningDataContainerData(new MachineLearningDataContainerProperties(new MachineLearningDataType("UriFile"))
            {
                Description = "string",
                Properties =
{
["properties1"] = "value1",
["properties2"] = "value2",
},
                Tags =
{
["tag1"] = "value1",
["tag2"] = "value2",
},
            });
            ArmOperation<MachineLearningDataContainerResource> lro = await machineLearningDataContainer.UpdateAsync(WaitUntil.Completed, data);
            MachineLearningDataContainerResource result = lro.Value;

            // the variable result is a resource, you could call other operations on this instance as well
            // but just for demo, we get its data from this resource instance
            MachineLearningDataContainerData resourceData = result.Data;
            // for demo we just print out the id
            Console.WriteLine($"Succeeded on id: {resourceData.Id}");
        }
    }
}
