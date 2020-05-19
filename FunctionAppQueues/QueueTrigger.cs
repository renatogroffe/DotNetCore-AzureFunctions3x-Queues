using Microsoft.Azure.WebJobs;
using Microsoft.Extensions.Logging;

namespace FunctionAppQueues
{
    public static class QueueTrigger
    {
        [FunctionName("QueueTrigger")]
        public static void Run([QueueTrigger("queue-storage", Connection = "AzureWebJobsStorage")]string myQueueItem, ILogger log)
        {
            log.LogInformation($"Dados recebidos via Azure Queue Storage: {myQueueItem}");
        }
    }
}
