using Microsoft.Azure.WebJobs;
using Microsoft.Extensions.Logging;

namespace FunctionAppQueues
{
    public static class RabbitMQTrigger
    {
        [FunctionName("RabbitMQTrigger")]
        public static void Run(
            [RabbitMQTrigger("queue-rabbit", ConnectionStringSetting = "RabbitMQConnection")]string inputMessage,
            ILogger log)
        {
            log.LogInformation($"Dados recebidos via Queue do RabbitMQ: {inputMessage}");
        }
    }
}