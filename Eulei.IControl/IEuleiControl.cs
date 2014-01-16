using System;
using System.Collections.Generic;
using System.Text;

namespace Eulei.IControl
{
    public interface IEuleiControl:IDisposable
    {
         bool GetAuthority(string authorityName);
         bool GetAuthority(int authorityID);
    }
}
