using System;
using System.Collections.Generic;
using System.Text;
using Eulei.IControl;
using System.ComponentModel.Composition;
namespace Eulei.Control
{
       [Export(typeof(IEuleiControl))]
    public class AuthorityControl:IEuleiControl
    {
        public bool GetAuthority(string authorityName)
        {
           return this.AuthorityDictionary[authorityName];
        }

        public bool GetAuthority(int authorityID)
        {
            throw new NotImplementedException();
        }
        private Dictionary<string, bool> AuthorityDictionary = new Dictionary<string, bool>();
        public AuthorityControl()
        {
            this.AuthorityDictionary.Add("InfoManege", true);
            this.AuthorityDictionary.Add("AreaInfoAdd", true);
            this.AuthorityDictionary.Add("OrganisationInfoAdd", true);
            this.AuthorityDictionary.Add("StationInfoAdd", true);
        }

        public void Dispose()
        {
         
        }
    }
}
