
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace MBAco.BusinessModel
{
    [AttributeUsage(AttributeTargets.All)]
    public class Searchable : Attribute
    {
        public Searchable(bool isSearchable)
        {
            attrIsSearchable = isSearchable;

        }

        private bool attrIsSearchable = false;
        public bool IsSearchable
        {
            get
            {
                return attrIsSearchable;
            }
        }

    } 
}
