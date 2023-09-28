// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;
using System.Text.Json;
using System.Threading.Tasks;
using Azure;
using Azure.AI.Language.Conversations;
using Azure.Core;
using Azure.Identity;
using NUnit.Framework;

namespace Azure.AI.Language.Conversations.Samples
{
    public partial class Samples_ConversationAnalysisClient
    {
        [Test]
        [Ignore("Only validating compilation of examples")]
        public void Example_AnalyzeConversation_ShortVersion()
        {
            Uri endpoint = new Uri("<endpoint>");
            AzureKeyCredential credential = new AzureKeyCredential("<key>");
            ConversationAnalysisClient client = new ConversationAnalysisClient(endpoint, credential);

            RequestContent content = RequestContent.Create(new
            {
                analysisInput = new
                {
                    conversationItem = new
                    {
                        id = "<id>",
                        participantId = "<participantId>",
                    },
                },
                parameters = new
                {
                    projectName = "<projectName>",
                    deploymentName = "<deploymentName>",
                },
                kind = "Conversation",
            });
            Response response = client.AnalyzeConversation(content);

            JsonElement result = JsonDocument.Parse(response.ContentStream).RootElement;
            Console.WriteLine(result.GetProperty("kind").ToString());
        }

        [Test]
        [Ignore("Only validating compilation of examples")]
        public async Task Example_AnalyzeConversation_ShortVersion_Async()
        {
            Uri endpoint = new Uri("<endpoint>");
            AzureKeyCredential credential = new AzureKeyCredential("<key>");
            ConversationAnalysisClient client = new ConversationAnalysisClient(endpoint, credential);

            RequestContent content = RequestContent.Create(new
            {
                analysisInput = new
                {
                    conversationItem = new
                    {
                        id = "<id>",
                        participantId = "<participantId>",
                    },
                },
                parameters = new
                {
                    projectName = "<projectName>",
                    deploymentName = "<deploymentName>",
                },
                kind = "Conversation",
            });
            Response response = await client.AnalyzeConversationAsync(content);

            JsonElement result = JsonDocument.Parse(response.ContentStream).RootElement;
            Console.WriteLine(result.GetProperty("kind").ToString());
        }

        [Test]
        [Ignore("Only validating compilation of examples")]
        public void Example_AnalyzeConversation_AllParameters()
        {
            Uri endpoint = new Uri("<endpoint>");
            AzureKeyCredential credential = new AzureKeyCredential("<key>");
            ConversationAnalysisClient client = new ConversationAnalysisClient(endpoint, credential);

            RequestContent content = RequestContent.Create(new
            {
                analysisInput = new
                {
                    conversationItem = new
                    {
                        id = "<id>",
                        participantId = "<participantId>",
                        language = "<language>",
                        modality = "transcript",
                        role = "agent",
                    },
                },
                parameters = new
                {
                    projectName = "<projectName>",
                    deploymentName = "<deploymentName>",
                    verbose = true,
                    isLoggingEnabled = true,
                    stringIndexType = "Utf16CodeUnit",
                    directTarget = "<directTarget>",
                    targetProjectParameters = new
                    {
                        key = new
                        {
                            query = "<query>",
                            callingOptions = new Dictionary<string, object>
                            {
                                ["verbose"] = true,
                                ["log"] = true,
                                ["show-all-intents"] = true,
                                ["timezoneOffset"] = 123.45F,
                                ["spellCheck"] = true,
                                ["bing-spell-check-subscription-key"] = "<bing-spell-check-subscription-key>"
                            },
                            targetProjectKind = "Luis",
                            apiVersion = "<apiVersion>",
                        },
                    },
                },
                kind = "Conversation",
            });
            Response response = client.AnalyzeConversation(content);

            JsonElement result = JsonDocument.Parse(response.ContentStream).RootElement;
            Console.WriteLine(result.GetProperty("kind").ToString());
        }

        [Test]
        [Ignore("Only validating compilation of examples")]
        public async Task Example_AnalyzeConversation_AllParameters_Async()
        {
            Uri endpoint = new Uri("<endpoint>");
            AzureKeyCredential credential = new AzureKeyCredential("<key>");
            ConversationAnalysisClient client = new ConversationAnalysisClient(endpoint, credential);

            RequestContent content = RequestContent.Create(new
            {
                analysisInput = new
                {
                    conversationItem = new
                    {
                        id = "<id>",
                        participantId = "<participantId>",
                        language = "<language>",
                        modality = "transcript",
                        role = "agent",
                    },
                },
                parameters = new
                {
                    projectName = "<projectName>",
                    deploymentName = "<deploymentName>",
                    verbose = true,
                    isLoggingEnabled = true,
                    stringIndexType = "Utf16CodeUnit",
                    directTarget = "<directTarget>",
                    targetProjectParameters = new
                    {
                        key = new
                        {
                            query = "<query>",
                            callingOptions = new Dictionary<string, object>
                            {
                                ["verbose"] = true,
                                ["log"] = true,
                                ["show-all-intents"] = true,
                                ["timezoneOffset"] = 123.45F,
                                ["spellCheck"] = true,
                                ["bing-spell-check-subscription-key"] = "<bing-spell-check-subscription-key>"
                            },
                            targetProjectKind = "Luis",
                            apiVersion = "<apiVersion>",
                        },
                    },
                },
                kind = "Conversation",
            });
            Response response = await client.AnalyzeConversationAsync(content);

            JsonElement result = JsonDocument.Parse(response.ContentStream).RootElement;
            Console.WriteLine(result.GetProperty("kind").ToString());
        }

        [Test]
        [Ignore("Only validating compilation of examples")]
        public void Example_GetAnalyzeConversationJobStatus_ShortVersion()
        {
            Uri endpoint = new Uri("<endpoint>");
            AzureKeyCredential credential = new AzureKeyCredential("<key>");
            ConversationAnalysisClient client = new ConversationAnalysisClient(endpoint, credential);

            Response response = client.GetAnalyzeConversationJobStatus(Guid.Parse("73f411fe-4f43-4b4b-9cbd-6828d8f4cf9a"));

            JsonElement result = JsonDocument.Parse(response.ContentStream).RootElement;
            Console.WriteLine(result.GetProperty("createdDateTime").ToString());
            Console.WriteLine(result.GetProperty("jobId").ToString());
            Console.WriteLine(result.GetProperty("lastUpdatedDateTime").ToString());
            Console.WriteLine(result.GetProperty("status").ToString());
        }

        [Test]
        [Ignore("Only validating compilation of examples")]
        public async Task Example_GetAnalyzeConversationJobStatus_ShortVersion_Async()
        {
            Uri endpoint = new Uri("<endpoint>");
            AzureKeyCredential credential = new AzureKeyCredential("<key>");
            ConversationAnalysisClient client = new ConversationAnalysisClient(endpoint, credential);

            Response response = await client.GetAnalyzeConversationJobStatusAsync(Guid.Parse("73f411fe-4f43-4b4b-9cbd-6828d8f4cf9a"));

            JsonElement result = JsonDocument.Parse(response.ContentStream).RootElement;
            Console.WriteLine(result.GetProperty("createdDateTime").ToString());
            Console.WriteLine(result.GetProperty("jobId").ToString());
            Console.WriteLine(result.GetProperty("lastUpdatedDateTime").ToString());
            Console.WriteLine(result.GetProperty("status").ToString());
        }

        [Test]
        [Ignore("Only validating compilation of examples")]
        public void Example_GetAnalyzeConversationJobStatus_AllParameters()
        {
            Uri endpoint = new Uri("<endpoint>");
            AzureKeyCredential credential = new AzureKeyCredential("<key>");
            ConversationAnalysisClient client = new ConversationAnalysisClient(endpoint, credential);

            Response response = client.GetAnalyzeConversationJobStatus(Guid.Parse("73f411fe-4f43-4b4b-9cbd-6828d8f4cf9a"), showStats: true);

            JsonElement result = JsonDocument.Parse(response.ContentStream).RootElement;
            Console.WriteLine(result.GetProperty("displayName").ToString());
            Console.WriteLine(result.GetProperty("createdDateTime").ToString());
            Console.WriteLine(result.GetProperty("expirationDateTime").ToString());
            Console.WriteLine(result.GetProperty("jobId").ToString());
            Console.WriteLine(result.GetProperty("lastUpdatedDateTime").ToString());
            Console.WriteLine(result.GetProperty("status").ToString());
            Console.WriteLine(result.GetProperty("errors")[0].GetProperty("code").ToString());
            Console.WriteLine(result.GetProperty("errors")[0].GetProperty("message").ToString());
            Console.WriteLine(result.GetProperty("errors")[0].GetProperty("target").ToString());
            Console.WriteLine(result.GetProperty("errors")[0].GetProperty("details")[0].GetProperty("code").ToString());
            Console.WriteLine(result.GetProperty("errors")[0].GetProperty("details")[0].GetProperty("message").ToString());
            Console.WriteLine(result.GetProperty("errors")[0].GetProperty("details")[0].GetProperty("target").ToString());
            Console.WriteLine(result.GetProperty("errors")[0].GetProperty("details")[0].GetProperty("innererror").GetProperty("code").ToString());
            Console.WriteLine(result.GetProperty("errors")[0].GetProperty("details")[0].GetProperty("innererror").GetProperty("message").ToString());
            Console.WriteLine(result.GetProperty("errors")[0].GetProperty("details")[0].GetProperty("innererror").GetProperty("details").GetProperty("<key>").ToString());
            Console.WriteLine(result.GetProperty("errors")[0].GetProperty("details")[0].GetProperty("innererror").GetProperty("target").ToString());
            Console.WriteLine(result.GetProperty("errors")[0].GetProperty("innererror").GetProperty("code").ToString());
            Console.WriteLine(result.GetProperty("errors")[0].GetProperty("innererror").GetProperty("message").ToString());
            Console.WriteLine(result.GetProperty("errors")[0].GetProperty("innererror").GetProperty("details").GetProperty("<key>").ToString());
            Console.WriteLine(result.GetProperty("errors")[0].GetProperty("innererror").GetProperty("target").ToString());
            Console.WriteLine(result.GetProperty("nextLink").ToString());
        }

        [Test]
        [Ignore("Only validating compilation of examples")]
        public async Task Example_GetAnalyzeConversationJobStatus_AllParameters_Async()
        {
            Uri endpoint = new Uri("<endpoint>");
            AzureKeyCredential credential = new AzureKeyCredential("<key>");
            ConversationAnalysisClient client = new ConversationAnalysisClient(endpoint, credential);

            Response response = await client.GetAnalyzeConversationJobStatusAsync(Guid.Parse("73f411fe-4f43-4b4b-9cbd-6828d8f4cf9a"), showStats: true);

            JsonElement result = JsonDocument.Parse(response.ContentStream).RootElement;
            Console.WriteLine(result.GetProperty("displayName").ToString());
            Console.WriteLine(result.GetProperty("createdDateTime").ToString());
            Console.WriteLine(result.GetProperty("expirationDateTime").ToString());
            Console.WriteLine(result.GetProperty("jobId").ToString());
            Console.WriteLine(result.GetProperty("lastUpdatedDateTime").ToString());
            Console.WriteLine(result.GetProperty("status").ToString());
            Console.WriteLine(result.GetProperty("errors")[0].GetProperty("code").ToString());
            Console.WriteLine(result.GetProperty("errors")[0].GetProperty("message").ToString());
            Console.WriteLine(result.GetProperty("errors")[0].GetProperty("target").ToString());
            Console.WriteLine(result.GetProperty("errors")[0].GetProperty("details")[0].GetProperty("code").ToString());
            Console.WriteLine(result.GetProperty("errors")[0].GetProperty("details")[0].GetProperty("message").ToString());
            Console.WriteLine(result.GetProperty("errors")[0].GetProperty("details")[0].GetProperty("target").ToString());
            Console.WriteLine(result.GetProperty("errors")[0].GetProperty("details")[0].GetProperty("innererror").GetProperty("code").ToString());
            Console.WriteLine(result.GetProperty("errors")[0].GetProperty("details")[0].GetProperty("innererror").GetProperty("message").ToString());
            Console.WriteLine(result.GetProperty("errors")[0].GetProperty("details")[0].GetProperty("innererror").GetProperty("details").GetProperty("<key>").ToString());
            Console.WriteLine(result.GetProperty("errors")[0].GetProperty("details")[0].GetProperty("innererror").GetProperty("target").ToString());
            Console.WriteLine(result.GetProperty("errors")[0].GetProperty("innererror").GetProperty("code").ToString());
            Console.WriteLine(result.GetProperty("errors")[0].GetProperty("innererror").GetProperty("message").ToString());
            Console.WriteLine(result.GetProperty("errors")[0].GetProperty("innererror").GetProperty("details").GetProperty("<key>").ToString());
            Console.WriteLine(result.GetProperty("errors")[0].GetProperty("innererror").GetProperty("target").ToString());
            Console.WriteLine(result.GetProperty("nextLink").ToString());
        }

        [Test]
        [Ignore("Only validating compilation of examples")]
        public void Example_AnalyzeConversations_ShortVersion()
        {
            Uri endpoint = new Uri("<endpoint>");
            AzureKeyCredential credential = new AzureKeyCredential("<key>");
            ConversationAnalysisClient client = new ConversationAnalysisClient(endpoint, credential);

            RequestContent content = RequestContent.Create(new
            {
                analysisInput = new
                {
                    conversations = new object[]
            {
new
{
conversationItems = new object[]
{
new
{
text = "<text>",
id = "<id>",
participantId = "<participantId>",
}
},
id = "<id>",
language = "<language>",
modality = "text",
}
            },
                },
                tasks = new object[]
            {
new
{
kind = "ConversationalSummarizationTask",
}
            },
            });
            Operation<BinaryData> operation = client.AnalyzeConversations(WaitUntil.Completed, content);
            BinaryData responseData = operation.Value;

            JsonElement result = JsonDocument.Parse(responseData.ToStream()).RootElement;
            Console.WriteLine(result.GetProperty("createdDateTime").ToString());
            Console.WriteLine(result.GetProperty("jobId").ToString());
            Console.WriteLine(result.GetProperty("lastUpdatedDateTime").ToString());
            Console.WriteLine(result.GetProperty("status").ToString());
        }

        [Test]
        [Ignore("Only validating compilation of examples")]
        public async Task Example_AnalyzeConversations_ShortVersion_Async()
        {
            Uri endpoint = new Uri("<endpoint>");
            AzureKeyCredential credential = new AzureKeyCredential("<key>");
            ConversationAnalysisClient client = new ConversationAnalysisClient(endpoint, credential);

            RequestContent content = RequestContent.Create(new
            {
                analysisInput = new
                {
                    conversations = new object[]
            {
new
{
conversationItems = new object[]
{
new
{
text = "<text>",
id = "<id>",
participantId = "<participantId>",
}
},
id = "<id>",
language = "<language>",
modality = "text",
}
            },
                },
                tasks = new object[]
            {
new
{
kind = "ConversationalSummarizationTask",
}
            },
            });
            Operation<BinaryData> operation = await client.AnalyzeConversationsAsync(WaitUntil.Completed, content);
            BinaryData responseData = operation.Value;

            JsonElement result = JsonDocument.Parse(responseData.ToStream()).RootElement;
            Console.WriteLine(result.GetProperty("createdDateTime").ToString());
            Console.WriteLine(result.GetProperty("jobId").ToString());
            Console.WriteLine(result.GetProperty("lastUpdatedDateTime").ToString());
            Console.WriteLine(result.GetProperty("status").ToString());
        }

        [Test]
        [Ignore("Only validating compilation of examples")]
        public void Example_AnalyzeConversations_AllParameters()
        {
            Uri endpoint = new Uri("<endpoint>");
            AzureKeyCredential credential = new AzureKeyCredential("<key>");
            ConversationAnalysisClient client = new ConversationAnalysisClient(endpoint, credential);

            RequestContent content = RequestContent.Create(new
            {
                displayName = "<displayName>",
                analysisInput = new
                {
                    conversations = new object[]
            {
new
{
conversationItems = new object[]
{
new
{
text = "<text>",
id = "<id>",
participantId = "<participantId>",
language = "<language>",
modality = "transcript",
role = "agent",
}
},
id = "<id>",
language = "<language>",
modality = "text",
domain = "finance",
}
            },
                },
                tasks = new object[]
            {
new
{
parameters = new
{
summaryAspects = new object[]
{
"issue"
},
modelVersion = "<modelVersion>",
loggingOptOut = true,
},
kind = "ConversationalSummarizationTask",
taskName = "<taskName>",
}
            },
            });
            Operation<BinaryData> operation = client.AnalyzeConversations(WaitUntil.Completed, content);
            BinaryData responseData = operation.Value;

            JsonElement result = JsonDocument.Parse(responseData.ToStream()).RootElement;
            Console.WriteLine(result.GetProperty("displayName").ToString());
            Console.WriteLine(result.GetProperty("createdDateTime").ToString());
            Console.WriteLine(result.GetProperty("expirationDateTime").ToString());
            Console.WriteLine(result.GetProperty("jobId").ToString());
            Console.WriteLine(result.GetProperty("lastUpdatedDateTime").ToString());
            Console.WriteLine(result.GetProperty("status").ToString());
            Console.WriteLine(result.GetProperty("errors")[0].GetProperty("code").ToString());
            Console.WriteLine(result.GetProperty("errors")[0].GetProperty("message").ToString());
            Console.WriteLine(result.GetProperty("errors")[0].GetProperty("target").ToString());
            Console.WriteLine(result.GetProperty("errors")[0].GetProperty("details")[0].GetProperty("code").ToString());
            Console.WriteLine(result.GetProperty("errors")[0].GetProperty("details")[0].GetProperty("message").ToString());
            Console.WriteLine(result.GetProperty("errors")[0].GetProperty("details")[0].GetProperty("target").ToString());
            Console.WriteLine(result.GetProperty("errors")[0].GetProperty("details")[0].GetProperty("innererror").GetProperty("code").ToString());
            Console.WriteLine(result.GetProperty("errors")[0].GetProperty("details")[0].GetProperty("innererror").GetProperty("message").ToString());
            Console.WriteLine(result.GetProperty("errors")[0].GetProperty("details")[0].GetProperty("innererror").GetProperty("details").GetProperty("<key>").ToString());
            Console.WriteLine(result.GetProperty("errors")[0].GetProperty("details")[0].GetProperty("innererror").GetProperty("target").ToString());
            Console.WriteLine(result.GetProperty("errors")[0].GetProperty("innererror").GetProperty("code").ToString());
            Console.WriteLine(result.GetProperty("errors")[0].GetProperty("innererror").GetProperty("message").ToString());
            Console.WriteLine(result.GetProperty("errors")[0].GetProperty("innererror").GetProperty("details").GetProperty("<key>").ToString());
            Console.WriteLine(result.GetProperty("errors")[0].GetProperty("innererror").GetProperty("target").ToString());
            Console.WriteLine(result.GetProperty("nextLink").ToString());
        }

        [Test]
        [Ignore("Only validating compilation of examples")]
        public async Task Example_AnalyzeConversations_AllParameters_Async()
        {
            Uri endpoint = new Uri("<endpoint>");
            AzureKeyCredential credential = new AzureKeyCredential("<key>");
            ConversationAnalysisClient client = new ConversationAnalysisClient(endpoint, credential);

            RequestContent content = RequestContent.Create(new
            {
                displayName = "<displayName>",
                analysisInput = new
                {
                    conversations = new object[]
            {
new
{
conversationItems = new object[]
{
new
{
text = "<text>",
id = "<id>",
participantId = "<participantId>",
language = "<language>",
modality = "transcript",
role = "agent",
}
},
id = "<id>",
language = "<language>",
modality = "text",
domain = "finance",
}
            },
                },
                tasks = new object[]
            {
new
{
parameters = new
{
summaryAspects = new object[]
{
"issue"
},
modelVersion = "<modelVersion>",
loggingOptOut = true,
},
kind = "ConversationalSummarizationTask",
taskName = "<taskName>",
}
            },
            });
            Operation<BinaryData> operation = await client.AnalyzeConversationsAsync(WaitUntil.Completed, content);
            BinaryData responseData = operation.Value;

            JsonElement result = JsonDocument.Parse(responseData.ToStream()).RootElement;
            Console.WriteLine(result.GetProperty("displayName").ToString());
            Console.WriteLine(result.GetProperty("createdDateTime").ToString());
            Console.WriteLine(result.GetProperty("expirationDateTime").ToString());
            Console.WriteLine(result.GetProperty("jobId").ToString());
            Console.WriteLine(result.GetProperty("lastUpdatedDateTime").ToString());
            Console.WriteLine(result.GetProperty("status").ToString());
            Console.WriteLine(result.GetProperty("errors")[0].GetProperty("code").ToString());
            Console.WriteLine(result.GetProperty("errors")[0].GetProperty("message").ToString());
            Console.WriteLine(result.GetProperty("errors")[0].GetProperty("target").ToString());
            Console.WriteLine(result.GetProperty("errors")[0].GetProperty("details")[0].GetProperty("code").ToString());
            Console.WriteLine(result.GetProperty("errors")[0].GetProperty("details")[0].GetProperty("message").ToString());
            Console.WriteLine(result.GetProperty("errors")[0].GetProperty("details")[0].GetProperty("target").ToString());
            Console.WriteLine(result.GetProperty("errors")[0].GetProperty("details")[0].GetProperty("innererror").GetProperty("code").ToString());
            Console.WriteLine(result.GetProperty("errors")[0].GetProperty("details")[0].GetProperty("innererror").GetProperty("message").ToString());
            Console.WriteLine(result.GetProperty("errors")[0].GetProperty("details")[0].GetProperty("innererror").GetProperty("details").GetProperty("<key>").ToString());
            Console.WriteLine(result.GetProperty("errors")[0].GetProperty("details")[0].GetProperty("innererror").GetProperty("target").ToString());
            Console.WriteLine(result.GetProperty("errors")[0].GetProperty("innererror").GetProperty("code").ToString());
            Console.WriteLine(result.GetProperty("errors")[0].GetProperty("innererror").GetProperty("message").ToString());
            Console.WriteLine(result.GetProperty("errors")[0].GetProperty("innererror").GetProperty("details").GetProperty("<key>").ToString());
            Console.WriteLine(result.GetProperty("errors")[0].GetProperty("innererror").GetProperty("target").ToString());
            Console.WriteLine(result.GetProperty("nextLink").ToString());
        }

        [Test]
        [Ignore("Only validating compilation of examples")]
        public void Example_CancelAnalyzeConversations_ShortVersion()
        {
            Uri endpoint = new Uri("<endpoint>");
            AzureKeyCredential credential = new AzureKeyCredential("<key>");
            ConversationAnalysisClient client = new ConversationAnalysisClient(endpoint, credential);

            Operation operation = client.CancelAnalyzeConversations(WaitUntil.Completed, Guid.Parse("73f411fe-4f43-4b4b-9cbd-6828d8f4cf9a"));
        }

        [Test]
        [Ignore("Only validating compilation of examples")]
        public async Task Example_CancelAnalyzeConversations_ShortVersion_Async()
        {
            Uri endpoint = new Uri("<endpoint>");
            AzureKeyCredential credential = new AzureKeyCredential("<key>");
            ConversationAnalysisClient client = new ConversationAnalysisClient(endpoint, credential);

            Operation operation = await client.CancelAnalyzeConversationsAsync(WaitUntil.Completed, Guid.Parse("73f411fe-4f43-4b4b-9cbd-6828d8f4cf9a"));
        }

        [Test]
        [Ignore("Only validating compilation of examples")]
        public void Example_CancelAnalyzeConversations_AllParameters()
        {
            Uri endpoint = new Uri("<endpoint>");
            AzureKeyCredential credential = new AzureKeyCredential("<key>");
            ConversationAnalysisClient client = new ConversationAnalysisClient(endpoint, credential);

            Operation operation = client.CancelAnalyzeConversations(WaitUntil.Completed, Guid.Parse("73f411fe-4f43-4b4b-9cbd-6828d8f4cf9a"));
        }

        [Test]
        [Ignore("Only validating compilation of examples")]
        public async Task Example_CancelAnalyzeConversations_AllParameters_Async()
        {
            Uri endpoint = new Uri("<endpoint>");
            AzureKeyCredential credential = new AzureKeyCredential("<key>");
            ConversationAnalysisClient client = new ConversationAnalysisClient(endpoint, credential);

            Operation operation = await client.CancelAnalyzeConversationsAsync(WaitUntil.Completed, Guid.Parse("73f411fe-4f43-4b4b-9cbd-6828d8f4cf9a"));
        }
    }
}
