using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FSMTrafficLights
{
    public interface IStateMachine
    {
        void Entry();
        void Exit();
        void Input();
        void Transfer();
    }
}
