﻿/*------------------------------------------------------------------------
<generated>
     This code was generated by MBAco Template
     Author: Matin Maleki.
     Generated at 04/03/2013 02:30:03 ?.?.

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
	/// This object represents the properties and methods of tables: dbo.tbl_DailyAnalyseReport 
	/// </summary>
	[Serializable()]
	[DebuggerDisplay("DailyAnalyseReportModel->DailyAnalyseReportID: {DailyAnalyseReportID}")]
	public partial class DailyAnalyseReportModel: ModelItemBase
	{
		#region Public Properties        
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		private int m_DailyAnalyseReportID = int.MinValue;
		/// <summary>
		/// DailyAnalyseReportID : Int32
		/// </summary>   
        [DataMember(Order = 0)]
		[Key]
        [LocalizedDisplayName("DailyAnalyseReportID")]
        [DatabaseAttribute("DailyAnalyseReportID", false)]
        [Bindable(false)]      
        [Browsable(false)]        
		[DataObjectField(true, true, false)] 
		[Required(ErrorMessage="Error: DailyAnalyseReportID is required!")]                
		public int DailyAnalyseReportID
		{
			[DebuggerStepThrough()]
			get { return this.m_DailyAnalyseReportID; }
            set
			{                
				if (!this.m_DailyAnalyseReportID.Equals(value)) 
				{
					this.m_DailyAnalyseReportID = value;
					NotifyPropertyChanged("DailyAnalyseReportID");
				}
			}
		}
		 
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		private int m_CustomerID = int.MinValue;
		/// <summary>
		/// CustomerID : Int32
		/// </summary>   
        [DataMember(Order = 1)]
        [LocalizedDisplayName("مشتری")]
        [DatabaseAttribute("CustomerID", false)]
        [Bindable(true)]      
        [Browsable(true)]        
		[DataObjectField(false, false, false)] 
		[Required(ErrorMessage="Error: CustomerID is required!")]                
		public int CustomerID
		{
			[DebuggerStepThrough()]
			get { return this.m_CustomerID; }
            set
			{                
				if (!this.m_CustomerID.Equals(value)) 
				{
					this.m_CustomerID = value;
					NotifyPropertyChanged("CustomerID");
				}
			}
		}
		 
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		private int m_ProcedureParameterID = int.MinValue;
		/// <summary>
		/// ProcedureParameterID : Int32
		/// </summary>   
        [DataMember(Order = 2)]
        [LocalizedDisplayName("دستورالعمل")]
        [DatabaseAttribute("ProcedureParameterID", false)]
        [Bindable(true)]      
        [Browsable(true)]        
		[DataObjectField(false, false, false)] 
		[Required(ErrorMessage="Error: ProcedureParameterID is required!")]                
		public int ProcedureParameterID
		{
			[DebuggerStepThrough()]
			get { return this.m_ProcedureParameterID; }
            set
			{                
				if (!this.m_ProcedureParameterID.Equals(value)) 
				{
					this.m_ProcedureParameterID = value;
					NotifyPropertyChanged("ProcedureParameterID");
				}
			}
		}
		 
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		private DateTime m_Date = DateTime.MinValue;
		/// <summary>
		/// Date : DateTime
		/// </summary>   
        [DataMember(Order = 3)]
        [LocalizedDisplayName("تاریخ")]
        [DatabaseAttribute("Date", true)]
        [Bindable(true)]      
        [Browsable(true)]        
		[DataObjectField(false, false, false)] 
		[Required(ErrorMessage="Error: Date is required!")]                
		public DateTime Date
		{
			[DebuggerStepThrough()]
			get { return this.m_Date; }
            set
			{                
				if (!this.m_Date.Equals(value)) 
				{
					this.m_Date = value;
					NotifyPropertyChanged("Date");
				}
			}
		}
		 
        [LocalizedDisplayName("تاریخ")]
        [DatabaseAttribute("Date", true)]
        [Bindable(true)]      
        [Browsable(true)]        
		[DataObjectField(false, false, false)] 
		[Required(ErrorMessage="Error: Date is required!")]                
		public string DatePersian
		{
			[DebuggerStepThrough()]
			get { return CalendarHelper.ConvertJulianDateTimeToPersian(m_Date); }
            set
			{                
				if (!string.IsNullOrEmpty(value) && !this.m_Date.Equals(value)) 
				{
                    this.m_Date = CalendarHelper.ConvertPersianToJulianDateTime(value);
					NotifyPropertyChanged("DatePersian");
					NotifyPropertyChanged("Date");                    
				}
			}
		}        
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		private double m_Value;
		/// <summary>
		/// Value : Double
		/// </summary>   
        [DataMember(Order = 4)]
        [LocalizedDisplayName("مقدار")]
        [DatabaseAttribute("Value", false)]
        [Bindable(true)]      
        [Browsable(true)]        
		[DataObjectField(false, false, false)] 
		[Required(ErrorMessage="Error: Value is required!")]                
		public double Value
		{
			[DebuggerStepThrough()]
			get { return this.m_Value; }
            set
			{                
				if (!this.m_Value.Equals(value)) 
				{
					this.m_Value = value;
					NotifyPropertyChanged("Value");
				}
			}
		}
		 
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		private bool m_IsApproved = false;
		/// <summary>
		/// IsApproved : Boolean
		/// </summary>   
        [DataMember(Order = 5)]
        [LocalizedDisplayName("تایید")]
        [DatabaseAttribute("IsApproved", true)]
        [Bindable(true)]      
        [Browsable(true)]        
		[DataObjectField(false, false, false)] 
		[Required(ErrorMessage="Error: IsApproved is required!")]                
		public bool IsApproved
		{
			[DebuggerStepThrough()]
			get { return this.m_IsApproved; }
            set
			{                
				if (!this.m_IsApproved.Equals(value)) 
				{
					this.m_IsApproved = value;
					NotifyPropertyChanged("IsApproved");
				}
			}
		}
		 
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		private string m_Comment = String.Empty;
		/// <summary>
		/// Comment : String
		/// </summary>   
        [DataMember(Order = 6)]
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
		private CustomerModel m_customer = null;
		/// <summary>
		/// The parent Customer object
		/// </summary>
		public CustomerModel Customer
		{
			get 
			{
				return m_customer;
			}
			set
			{
				if(m_customer != value) 
				{
					m_customer = value;
					
					if (value != null) 
					{
						this.CustomerID = value.CustomerID;
					}
					else 
					{
						this.CustomerID = int.MinValue;
					}
				}
			}
		}
		
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		private ProcedureParameterModel m_procedureParameter = null;
		/// <summary>
		/// The parent ProcedureParameter object
		/// </summary>
		public ProcedureParameterModel ProcedureParameter
		{
			get 
			{
				return m_procedureParameter;
			}
			set
			{
				if(m_procedureParameter != value) 
				{
					m_procedureParameter = value;
					
					if (value != null) 
					{
						this.ProcedureParameterID = value.ProcedureParameterID;
					}
					else 
					{
						this.ProcedureParameterID = int.MinValue;
					}
				}
			}
		}
		
		#endregion // end of region Public Properties
		
		#region Non-Public Properties
		#endregion // end of region Non-Public Properties
		
		#region Constructors
		/// <summary>
		/// The default protected constructor
		/// </summary>
		public DailyAnalyseReportModel() { }
		#endregion // end of region Constructors
	}
}
