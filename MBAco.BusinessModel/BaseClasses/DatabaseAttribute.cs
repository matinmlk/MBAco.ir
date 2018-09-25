
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace MBAco.BusinessModel
{
    [AttributeUsage(AttributeTargets.All)]
    public class DatabaseAttribute : Attribute
    {
        public DatabaseAttribute(string name, bool hasLocalizedValue)
        {
            attrName = name;

        }

        private string attrName = string.Empty;
        public string Name
        {
            get
            {
                return attrName;
            }
        }

        private bool hasLocalizedValue = false;
        public bool HasLocalizedValue
        {
            get
            {
                return hasLocalizedValue;
            }
        }

    }    
}
