using System;
using Microsoft.Azure.WebJobs;
using Microsoft.Azure.WebJobs.Host;
using Microsoft.Extensions.Logging;

namespace FunctionAppQueues
{
    public static class ServiceBusQueueTrigger
    {
        [FunctionName("ServiceBusQueueTrigger")]
        public static void Run([ServiceBusTrigger("queue-servicebus", Connection = "AzureServiceBusConnection")]string myQueueItem, ILogger log)
        {
            log.LogInformation($"Dados recebidos via Queue do Azure Service Bus: {myQueueItem}");
        }
    }
}
