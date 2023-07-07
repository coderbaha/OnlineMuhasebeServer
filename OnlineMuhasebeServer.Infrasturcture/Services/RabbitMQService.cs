using Newtonsoft.Json;
using OnlineMuhasebeServer.Application.Services;
using OnlineMuhasebeServer.Domain.Dtos;
using RabbitMQ.Client;
using System;
using System.Text;

namespace OnlineMuhasebeServer.Infrasturcture.Services;

public sealed class RabbitMQService : IRabbitMQService
{
    public void SendQueue(ReportDto reportDto)
    {
        var factory = new ConnectionFactory();
        factory.Uri = new Uri("amqps://mvfisxgh:5gp_b2NP0ITFJbTo1Xcx_e8FhedJQwLH@sparrow.rmq.cloudamqp.com/mvfisxgh");

        using var connection = factory.CreateConnection();

        var channel = connection.CreateModel();
        channel.QueueDeclare("Reports", true, false, false);
        var body = Encoding.UTF8.GetBytes(JsonConvert.SerializeObject(reportDto));
        channel.BasicPublish(String.Empty, "Reports", null, body);
    }
}
