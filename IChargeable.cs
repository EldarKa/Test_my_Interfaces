using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Test_my_Interfaces
{
    public interface IChargeable
    {
        void Charge() { throw new NotImplementedException(); }
        string GetInfo() { throw new NotImplementedException(); }
    }
}
