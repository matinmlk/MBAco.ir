/*------------------------------------------------------------------------
<generated>
     This code was generated by MBAco Template
     Author: Matin Maleki.
     Generated at 04/03/2013 02:30:02 ?.?.

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
	/// This object represents the properties and methods of tables: dbo.tbl_Culture 
	/// </summary>
	[Serializable()]
	[DebuggerDisplay("CultureModel->CultureID: {CultureID}")]
	public partial class CultureModel: ModelItemBase
	{
		#region Public Properties        
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		private int m_CultureID = int.MinValue;
		/// <summary>
		/// CultureID : Int32
		/// </summary>   
        [DataMember(Order = 0)]
		[Key]
        [LocalizedDisplayName("CultureID")]
        [DatabaseAttribute("CultureID", false)]
        [Bindable(false)]      
        [Browsable(false)]        
		[DataObjectField(true, true, false)] 
		[Required(ErrorMessage="Error: CultureID is required!")]                
		public int CultureID
		{
			[DebuggerStepThrough()]
			get { return this.m_CultureID; }
            set
			{                
				if (!this.m_CultureID.Equals(value)) 
				{
					this.m_CultureID = value;
					NotifyPropertyChanged("CultureID");
				}
			}
		}
		 
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		private string m_Name = String.Empty;
		/// <summary>
		/// Name : String
		/// </summary>   
        [DataMember(Order = 1)]
        [LocalizedDisplayName("Name")]
        [DatabaseAttribute("Name", true)]
        [Bindable(true)]      
        [Browsable(true)]        
		[DataObjectField(false, false, false, 50)] 
		[Required(ErrorMessage="Error: Name is required!")]                
		public string Name
		{
			[DebuggerStepThrough()]
			get { return this.m_Name; }
            set
			{                
				if (!this.m_Name.Equals(value) && value != null) 
				{
					this.m_Name = value;
					NotifyPropertyChanged("Name");
				}
			}
		}
		 
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		private string m_Comment = String.Empty;
		/// <summary>
		/// Comment : String
		/// </summary>   
        [DataMember(Order = 2)]
        [LocalizedDisplayName("Comment")]
        [DatabaseAttribute("Comment", true)]
        [Bindable(true)]      
        [Browsable(true)]        
		[DataObjectField(false, false, true, 500)]                 
		public string Comment
		{
			[DebuggerStepThrough()]
			get { return this.m_Comment; }
            set
			{                
				if (!this.m_Comment.Equals(value) && value != null) 
				{
					this.m_Comment = value;
					NotifyPropertyChanged("Comment");
				}
			}
		}
		 
                    
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		private List<NotificationMessageModel> m_notificationMessages = null;
		/// <summary>
		/// A collection of NotificationMessageModel children objects
		/// </summary>
		public List<NotificationMessageModel> NotificationMessages
		{
			get 
			{
				if (m_notificationMessages == null) {
					//m_notificationMessages = MBAco..NotificationMessage.GetNotificationMessagesByCulture(this);
				}
				return m_notificationMessages;
			}
		}	
		#endregion // end of region Public Properties
		
		#region Non-Public Properties
		#endregion // end of region Non-Public Properties
		
		#region Constructors
		/// <summary>
		/// The default protected constructor
		/// </summary>
		public CultureModel() { }
		#endregion // end of region Constructors
	}
}
