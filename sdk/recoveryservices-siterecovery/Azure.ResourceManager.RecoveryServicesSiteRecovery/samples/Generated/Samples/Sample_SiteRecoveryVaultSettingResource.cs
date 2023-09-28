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
using Azure.ResourceManager.RecoveryServicesSiteRecovery;
using Azure.ResourceManager.RecoveryServicesSiteRecovery.Models;

namespace Azure.ResourceManager.RecoveryServicesSiteRecovery.Samples
{
    public partial class Sample_SiteRecoveryVaultSettingResource
    {
        // Gets the vault setting.
        [NUnit.Framework.Test]
        [NUnit.Framework.Ignore("Only verifying that the sample builds")]
        public async Task Get_GetsTheVaultSetting()
        {
            // Generated from example definition: specification/recoveryservicessiterecovery/resource-manager/Microsoft.RecoveryServices/stable/2023-06-01/examples/ReplicationVaultSetting_Get.json
            // this example is just showing the usage of "ReplicationVaultSetting_Get" operation, for the dependent resources, they will have to be created separately.

            // get your azure access token, for more details of how Azure SDK get your access token, please refer to https://learn.microsoft.com/en-us/dotnet/azure/sdk/authentication?tabs=command-line
            TokenCredential cred = new DefaultAzureCredential();
            // authenticate your client
            ArmClient client = new ArmClient(cred);

            // this example assumes you already have this SiteRecoveryVaultSettingResource created on azure
            // for more information of creating SiteRecoveryVaultSettingResource, please refer to the document of SiteRecoveryVaultSettingResource
            string subscriptionId = "c183865e-6077-46f2-a3b1-deb0f4f4650a";
            string resourceGroupName = "resourceGroupPS1";
            string resourceName = "vault1";
            string vaultSettingName = "default";
            ResourceIdentifier siteRecoveryVaultSettingResourceId = SiteRecoveryVaultSettingResource.CreateResourceIdentifier(subscriptionId, resourceGroupName, resourceName, vaultSettingName);
            SiteRecoveryVaultSettingResource siteRecoveryVaultSetting = client.GetSiteRecoveryVaultSettingResource(siteRecoveryVaultSettingResourceId);

            // invoke the operation
            SiteRecoveryVaultSettingResource result = await siteRecoveryVaultSetting.GetAsync();

            // the variable result is a resource, you could call other operations on this instance as well
            // but just for demo, we get its data from this resource instance
            SiteRecoveryVaultSettingData resourceData = result.Data;
            // for demo we just print out the id
            Console.WriteLine($"Succeeded on id: {resourceData.Id}");
        }

        // Updates vault setting. A vault setting object is a singleton per vault and it is always present by default.
        [NUnit.Framework.Test]
        [NUnit.Framework.Ignore("Only verifying that the sample builds")]
        public async Task Update_UpdatesVaultSettingAVaultSettingObjectIsASingletonPerVaultAndItIsAlwaysPresentByDefault()
        {
            // Generated from example definition: specification/recoveryservicessiterecovery/resource-manager/Microsoft.RecoveryServices/stable/2023-06-01/examples/ReplicationVaultSetting_Create.json
            // this example is just showing the usage of "ReplicationVaultSetting_Create" operation, for the dependent resources, they will have to be created separately.

            // get your azure access token, for more details of how Azure SDK get your access token, please refer to https://learn.microsoft.com/en-us/dotnet/azure/sdk/authentication?tabs=command-line
            TokenCredential cred = new DefaultAzureCredential();
            // authenticate your client
            ArmClient client = new ArmClient(cred);

            // this example assumes you already have this SiteRecoveryVaultSettingResource created on azure
            // for more information of creating SiteRecoveryVaultSettingResource, please refer to the document of SiteRecoveryVaultSettingResource
            string subscriptionId = "c183865e-6077-46f2-a3b1-deb0f4f4650a";
            string resourceGroupName = "resourceGroupPS1";
            string resourceName = "vault1";
            string vaultSettingName = "default";
            ResourceIdentifier siteRecoveryVaultSettingResourceId = SiteRecoveryVaultSettingResource.CreateResourceIdentifier(subscriptionId, resourceGroupName, resourceName, vaultSettingName);
            SiteRecoveryVaultSettingResource siteRecoveryVaultSetting = client.GetSiteRecoveryVaultSettingResource(siteRecoveryVaultSettingResourceId);

            // invoke the operation
            SiteRecoveryVaultSettingCreateOrUpdateContent content = new SiteRecoveryVaultSettingCreateOrUpdateContent(new VaultSettingCreationProperties()
            {
                MigrationSolutionId = new ResourceIdentifier("/subscriptions/c183865e-6077-46f2-a3b1-deb0f4f4650a/resourceGroups/resourceGroupPS1/providers/Microsoft.Migrate/MigrateProjects/resourceGroupPS1-MigrateProject/Solutions/Servers-Migration-ServerMigration"),
            });
            ArmOperation<SiteRecoveryVaultSettingResource> lro = await siteRecoveryVaultSetting.UpdateAsync(WaitUntil.Completed, content);
            SiteRecoveryVaultSettingResource result = lro.Value;

            // the variable result is a resource, you could call other operations on this instance as well
            // but just for demo, we get its data from this resource instance
            SiteRecoveryVaultSettingData resourceData = result.Data;
            // for demo we just print out the id
            Console.WriteLine($"Succeeded on id: {resourceData.Id}");
        }
    }
}
