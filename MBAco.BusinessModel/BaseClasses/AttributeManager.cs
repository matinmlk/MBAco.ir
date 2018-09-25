
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using MBAco.BusinessModel;

namespace MBAco.BusinessModel
{
    public static class AttributeManager
    {
        public static string GetDatabaseAttributeName(string className, string propertyName)
        {
            try
            {
                Assembly exeAssembly = Assembly.GetExecutingAssembly();
                Type theType = exeAssembly.GetType(className);
                PropertyInfo prop = theType.GetProperty(propertyName);
                Type attrType = typeof(DatabaseAttribute);
                DatabaseAttribute[] custom_attributes = (DatabaseAttribute[])prop.GetCustomAttributes(attrType, true);
                if (custom_attributes.Length > 0)
                    return custom_attributes[0].Name;
                else
                    throw new Exception("Error: There is no Database Attribute for this property");
            }
            catch
            {
                throw new Exception("Error: There is some error for Database Attribute on this property");
            }
        }
    } 
}
