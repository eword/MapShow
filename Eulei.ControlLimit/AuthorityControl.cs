using System;
using System.Collections.Generic;
using System.Text;
using System.ComponentModel.Composition;
using Eulei.IControl;
namespace Eulei.ControlLimit
{
      [Export(typeof(IEuleiControl))]
    public class AuthorityControl : IEuleiControl
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
            this.AuthorityDictionary.Add("InfoManege",false);
            this.AuthorityDictionary.Add("AreaInfoManege", false);
            this.AuthorityDictionary.Add("OrganisationInfoManege", false);
            this.AuthorityDictionary.Add("StationInfoManege", false);
        }

        public void Dispose()
        {
            
        }
    }
}
