using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ApiBackgroundService.Repository
{
    public class CommandRepository : ICommandRepository
    {
        private string _message;

        public CommandRepository()
        {
            _message = "...";
        }

        public string GetMessage() => _message;

        public void SetMessage(string message)
        {
            _message = message;
        }
        
    }
}
