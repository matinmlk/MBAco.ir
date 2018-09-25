﻿/*------------------------------------------------------------------------
<generated>
     This code was generated by MBAco Template
     Author: Matin Maleki.
     Generated at 04/03/2013 02:30:01 ?.?.

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
	/// This object represents the properties and methods of tables: dbo.tbl_AnalayseParameter 
	/// </summary>
	[Serializable()]
	[DebuggerDisplay("AnalayseParameterModel->AnalayseParameterID: {AnalayseParameterID}")]
	public partial class AnalayseParameterModel: ModelItemBase
	{
		#region Public Properties        
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		private int m_AnalayseParameterID = int.MinValue;
		/// <summary>
		/// AnalayseParameterID : Int32
		/// </summary>   
        [DataMember(Order = 0)]
		[Key]
        [LocalizedDisplayName("پارامتر آنالیز")]
        [DatabaseAttribute("AnalayseParameterID", false)]
        [Bindable(false)]      
        [Browsable(false)]        
		[DataObjectField(true, true, false)] 
		[Required(ErrorMessage="Error: AnalayseParameterID is required!")]                
		public int AnalayseParameterID
		{
			[DebuggerStepThrough()]
			get { return this.m_AnalayseParameterID; }
            set
			{                
				if (!this.m_AnalayseParameterID.Equals(value)) 
				{
					this.m_AnalayseParameterID = value;
					NotifyPropertyChanged("AnalayseParameterID");
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
		private string m_Symbol = String.Empty;
		/// <summary>
		/// Symbol : String
		/// </summary>   
        [DataMember(Order = 2)]
        [LocalizedDisplayName("نماد")]
        [DatabaseAttribute("Symbol", true)]
        [Bindable(true)]      
        [Browsable(true)]        
		[DataObjectField(false, false, false, 50)] 
		[Required(ErrorMessage="Error: Symbol is required!")]                
		public string Symbol
		{
			[DebuggerStepThrough()]
			get { return this.m_Symbol; }
            set
			{                
				if (!this.m_Symbol.Equals(value) && value != null) 
				{
					this.m_Symbol = value;
					NotifyPropertyChanged("Symbol");
				}
			}
		}
		 
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		private int m_AnalyseParameterTypeId = int.MinValue;
		/// <summary>
		/// AnalyseParameterTypeId : Int32
		/// </summary>   
        [DataMember(Order = 3)]
        [LocalizedDisplayName("نوع")]
        [DatabaseAttribute("AnalyseParameterTypeId", false)]
        [Bindable(true)]      
        [Browsable(true)]        
		[DataObjectField(false, false, false)] 
		[Required(ErrorMessage="Error: AnalyseParameterTypeId is required!")]                
		public int AnalyseParameterTypeId
		{
			[DebuggerStepThrough()]
			get { return this.m_AnalyseParameterTypeId; }
            set
			{                
				if (!this.m_AnalyseParameterTypeId.Equals(value)) 
				{
					this.m_AnalyseParameterTypeId = value;
					NotifyPropertyChanged("AnalyseParameterTypeId");
				}
			}
		}
		 
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		private string m_Comment = String.Empty;
		/// <summary>
		/// Comment : String
		/// </summary>   
        [DataMember(Order = 4)]
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
		private AnalyseParameterTypeModel m_analyseParameterType = null;
		/// <summary>
		/// The parent AnalyseParameterType object
		/// </summary>
		public AnalyseParameterTypeModel AnalyseParameterType
		{
			get 
			{
				return m_analyseParameterType;
			}
			set
			{
				if(m_analyseParameterType != value) 
				{
					m_analyseParameterType = value;
					
					if (value != null) 
					{
						this.AnalyseParameterTypeId = value.AnalyseParameterTypeID;
					}
					else 
					{
						this.AnalyseParameterTypeId = int.MinValue;
					}
				}
			}
		}
		
                    
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		private List<ProcedureParameterModel> m_procedureParameters = null;
		/// <summary>
		/// A collection of ProcedureParameterModel children objects
		/// </summary>
		public List<ProcedureParameterModel> ProcedureParameters
		{
			get 
			{
				if (m_procedureParameters == null) {
					//m_procedureParameters = MBAco..ProcedureParameter.GetProcedureParametersByAnalayseParameter(this);
				}
				return m_procedureParameters;
			}
		}	
		#endregion // end of region Public Properties
		
		#region Non-Public Properties
		#endregion // end of region Non-Public Properties
		
		#region Constructors
		/// <summary>
		/// The default protected constructor
		/// </summary>
		public AnalayseParameterModel() { }
		#endregion // end of region Constructors
	}
}