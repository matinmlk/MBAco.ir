/*------------------------------------------------------------------------
<generated>
     This code was generated by MBAco Template
     Author: Matin Maleki.
     Generated at 04/03/2013 06:45:04 ?.?.

</generated>
------------------------------------------------------------------------*/

using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Data;
using System.Data.Linq.Mapping;
using System.Data.SqlClient;
using System.Diagnostics;
using System.Runtime.Serialization;

namespace MBAco.BusinessModel
{
	/// <summary>
	/// This object represents the properties and methods of tables: dbo.tbl_Contact 
	/// </summary>
	[DebuggerDisplay("ContactModel->ContactID: {ContactID}")]
	public partial class ContactModel: ModelItemBase
	{

        private string m_FullName = String.Empty;
        /// <summary>
        /// Name : String
        /// </summary>   
        [DataMember(Order = 1)]
        [LocalizedDisplayName("FullName")]
        [DatabaseAttribute("FullName", true)]
        [Bindable(true)]
        [Browsable(true)]
        [DataObjectField(false, false, false, 500)]
        public string FullName
        {
            [DebuggerStepThrough()]
            get { return this.Name + " " + this.Family; }

        }
    }
}
