
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.ComponentModel;
using System.Resources;
using System.Collections;

namespace MBAco.BusinessModel
{
    public  class LocalizedDisplayName : DisplayNameAttribute
    {
        private static Dictionary<string, string> LocalRec = new Dictionary<string, string>();
        
        public LocalizedDisplayName(string resourceId)
            : base(GetMessageFromResource(resourceId)) { }
        public static string GetMessageFromResource(string resourceId)
        {
            //var resource = System.Resources.ResourceReader(resourceId);//ResourceManager.GetObject(resourceId);
            //return resource == null ? "-Not-"+resourceId : resource.ToString();
            // TODO: Return the string from the resource file     } 
            //return //Resources.ResourceReader.ReadStringKey(resourceId);
            //    resourceId;
            return resourceId;
        }
    }

    public class SecurityKey : System.Attribute
    {
        private string m_SecurityKey = "";
        public string Key
        {
            get
            {
                return m_SecurityKey;
            }
            set
            {
                m_SecurityKey = value;
            }
        }
        public  SecurityKey(string mSecurityKey)
        {
            this.Key = mSecurityKey;
        }
    }  
}
