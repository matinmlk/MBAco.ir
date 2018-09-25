
using System.Collections.Generic;
using System.Data;
using System.Reflection;
using System.Linq;

namespace MBAco.DAL
{
    /// <summary>
    /// This class is using for convert a linq object result to DataTable
    /// </summary>
    /// <remarks>
    /// Using Example:
    /// var data = new[] {
    ///                   new {FirstName="Bill", LastName="Clinton", ID=1, WasPresident=true}
    ///                   , new {FirstName="John", LastName="McCain", ID=2, WasPresident=false}
    ///                   , new {FirstName="George", LastName="Bush", ID=2, WasPresident=true}
    ///             };
    ///  
    ///             DataTable table = (from d in data
    ///                                where d.WasPresident==true
    ///                                select d).AsDataTable();
    /// </remarks>
    static class Extensions
    {
        public static DataTable AsDataTable<T>(this IEnumerable<T> enumberable)
        {
            DataTable table = new DataTable("Generated");

            T first = enumberable.FirstOrDefault();
            if (first == null)
                return table;

            PropertyInfo[] properties = first.GetType().GetProperties();
            foreach (PropertyInfo pi in properties)
                table.Columns.Add(pi.Name, pi.PropertyType);

            foreach (T t in enumberable)
            {
                DataRow row = table.NewRow();
                foreach (PropertyInfo pi in properties)
                    row[pi.Name] = t.GetType().InvokeMember(pi.Name, BindingFlags.GetProperty, null, t, null);
                table.Rows.Add(row);
            }

            return table;
        }
    }
}
