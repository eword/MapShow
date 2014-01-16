using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Xml;
using System.Xml.Serialization;
using System.IO;
using Eulei.Serialization;
namespace Eulei.Map.Code
{
    public class UserHistory : IDisposable
    {
        private static UserHistory _userHistory;
        private Root _usersRoot;
        public static readonly string filePath = AppDomain.CurrentDomain.BaseDirectory + "UserHistory/User";
        private UserHistory()
        {          
        }

        public static UserHistory Init()
        {
            if (_userHistory == null)
                _userHistory = new UserHistory();
            return _userHistory;
        }

        public void Dispose()
        {
        
            _usersRoot = null;
            _userHistory = null;
        }

        public void Save(Root _root)
        {
            XmlHelper.XmlSerializer.SaveToXml(filePath, _root, typeof(Root), "Root");
        }
        public void Load()
        {
            if (File.Exists(filePath))
            {
                _usersRoot = XmlHelper.XmlSerializer.LoadFromXml(filePath, typeof(Root)) as Root;
                _usersRoot = _usersRoot != null ? _usersRoot : new Root();
            }
            else
            {
                var _userInfo = new UserInfo() { Name=string.Empty };
                _usersRoot = new Root() { RememberMe = false, HistoryUser = string.Empty, LastUser = string.Empty, UserList = new UserInfo[] { _userInfo } };
            }
         
            
        }

        public Root UserRoot
        {
            set
            {
                _usersRoot = value != null ? value : new Root();

            }
            get
            {
                return _usersRoot != null ? _usersRoot : new Root();

            }
        }
    }

    [XmlRootAttribute("Root")]
    public class Root
    {
      
        private UserInfo[] _userList;
   
        public UserInfo[] UserList
        {
            set
            {
                _userList = value != null ? value : new UserInfo[1];
            }
            get
            {
                return _userList != null ? _userList :new UserInfo[1];
            }
        }
        [XmlAttribute("RememberMe")]
        public bool RememberMe { set; get; }
        [XmlAttribute("HistoryUser")]
        public string HistoryUser { set; get; }
        [XmlAttribute("LastUser")]
        public string LastUser { set; get; }
    }

    [XmlRootAttribute("User")]
    public class UserInfo
    {
        string _name;   
        public string Name
        {
            set {
                _name = value != null ? value : "  ";
            }
            get {
                return _name;
            }
        }
    }
}
