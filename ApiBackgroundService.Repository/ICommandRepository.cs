using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ApiBackgroundService.Repository
{
    public interface ICommandRepository
    {
        string GetMessage();

        void SetMessage(string message);
    }
}
