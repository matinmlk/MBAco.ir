﻿/*------------------------------------------------------------------------
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
	/// This object represents the properties and methods of tables: dbo.tbl_AnalyseParameterType 
	/// </summary>
	[Serializable()]
	[DebuggerDisplay("AnalyseParameterTypeModel->AnalyseParameterTypeID: {AnalyseParameterTypeID}")]
	public partial class AnalyseParameterTypeModel: ModelItemBase
	{
		#region Public Properties        
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		private int m_AnalyseParameterTypeID = int.MinValue;
		/// <summary>
		/// AnalyseParameterTypeID : Int32
		/// </summary>   
        [DataMember(Order = 0)]
		[Key]
        [LocalizedDisplayName("نوع پارامتر")]
        [DatabaseAttribute("AnalyseParameterTypeID", false)]
        [Bindable(false)]      
        [Browsable(false)]        
		[DataObjectField(true, true, false)] 
		[Required(ErrorMessage="Error: AnalyseParameterTypeID is required!")]                
		public int AnalyseParameterTypeID
		{
			[DebuggerStepThrough()]
			get { return this.m_AnalyseParameterTypeID; }
            set
			{                
				if (!this.m_AnalyseParameterTypeID.Equals(value)) 
				{
					this.m_AnalyseParameterTypeID = value;
					NotifyPropertyChanged("AnalyseParameterTypeID");
				}
			}
		}
		 
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		private string m_Name = String.Empty;
		/// <summary>
		/// Name : String
		/// </summary>   
        [DataMember(Order = 1)]
        [LocalizedDisplayName("نام")]
        [DatabaseAttribute("Name", true)]
        [Bindable(true)]      
        [Browsable(true)]        
		[DataObjectField(false, false, false, 150)] 
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
        [LocalizedDisplayName("توضیحات")]
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
		private List<AnalayseParameterModel> m_analayseParameters = null;
		/// <summary>
		/// A collection of AnalayseParameterModel children objects
		/// </summary>
		public List<AnalayseParameterModel> AnalayseParameters
		{
			get 
			{
				if (m_analayseParameters == null) {
					//m_analayseParameters = MBAco..AnalayseParameter.GetAnalayseParametersByAnalyseParameterType(this);
				}
				return m_analayseParameters;
			}
		}	
		#endregion // end of region Public Properties
		
		#region Non-Public Properties
		#endregion // end of region Non-Public Properties
		
		#region Constructors
		/// <summary>
		/// The default protected constructor
		/// </summary>
		public AnalyseParameterTypeModel() { }
		#endregion // end of region Constructors
	}
}