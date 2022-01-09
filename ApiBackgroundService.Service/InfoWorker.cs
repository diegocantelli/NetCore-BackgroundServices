using ApiBackgroundService.Repository;
using Microsoft.Extensions.Hosting;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace ApiBackgroundService.Service
{
    public class InfoWorker : IHostedService
    {
        private Timer _timer;
        public string message = "mensagem inicial";
        private readonly ICommandRepository _commandRepository;

        public InfoWorker(ICommandRepository commandRepository)
        {
            _commandRepository = commandRepository;
        }

        public Task StartAsync(CancellationToken cancellationToken)
        {
            Console.WriteLine("Processo iniciado.");
            _timer = new Timer(DoWork, null, TimeSpan.FromSeconds(5), TimeSpan.FromSeconds(1));

            return Task.CompletedTask;
        }

        private void DoWork(object state)
        {
            Thread.Sleep(3000);
            Console.WriteLine($"{ DateTime.Now } : { _commandRepository.GetMessage()}");
        }

        public Task StopAsync(CancellationToken cancellationToken)
        {
            Console.WriteLine("Processo finalizado.");

            return Task.CompletedTask;
        }
    }
}
