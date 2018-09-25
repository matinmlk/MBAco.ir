/*------------------------------------------------------------------------
<generated>
     This code was generated by MBAco Template
     Author: Matin Maleki.
     Generated at 04/03/2013 02:30:03 ?.?.

</generated>
------------------------------------------------------------------------*/

using MBAco.BusinessModel;//.AnalayseParameter;
using MBAco.DAL;//.AnalayseParameter;
using System.Collections.Generic;
using System;
using System.Linq;

namespace MBAco.BLL
{
	/// <summary>
	/// This object represents the properties and methods of tables:dbo.tbl_AnalayseParameter and 
	/// </summary>
	public partial class AnalayseParameterBiz : IBusinessBase< AnalayseParameterModel >
	{
		#region Constructors
        public AnalayseParameterBiz()
        {
        }                
		#endregion // end of Constructors
        
        #region Public Methods 
        public virtual void Dispose()
        {
        }        
        
        public static AnalayseParameterModel FindByAnalayseParameterId(long Id)
        {
            return Get(Id);
        }
        
        internal static tbl_AnalayseParameter Totbl_AnalayseParameter(AnalayseParameterModel param)
        {
            if (param != null)
            {
                tbl_AnalayseParameter m_tbl_AnalayseParameter = new tbl_AnalayseParameter();

                try
                {
                    m_tbl_AnalayseParameter.AnalayseParameterID = param.AnalayseParameterID;
                    m_tbl_AnalayseParameter.Name = param.Name;
                    m_tbl_AnalayseParameter.Symbol = param.Symbol;
                    m_tbl_AnalayseParameter.Comment = param.Comment;
                    m_tbl_AnalayseParameter.AnalyseParameterType = param.AnalyseParameterTypeId;
                }
                catch (Exception)
                {
                    // throw new Exception("Business Object Convertion Error, " + ex.Message); 
                }
                return m_tbl_AnalayseParameter;
            }
            else return null;
        }        
        internal static AnalayseParameterModel Fromtbl_AnalayseParameter(tbl_AnalayseParameter m_tbl_AnalayseParameter)
        {
            AnalayseParameterModel m_AnalayseParameterModel = new AnalayseParameterModel();
            if (m_tbl_AnalayseParameter == null)
                throw new System.ArgumentNullException("m_tbl_AnalayseParameter");                
            try
            {                
                m_AnalayseParameterModel.AnalayseParameterID = m_tbl_AnalayseParameter.AnalayseParameterID;
				m_AnalayseParameterModel.Name = m_tbl_AnalayseParameter.Name;
				m_AnalayseParameterModel.Symbol = m_tbl_AnalayseParameter.Symbol;
				m_AnalayseParameterModel.Comment = m_tbl_AnalayseParameter.Comment;  
				m_AnalayseParameterModel.AnalyseParameterType = AnalyseParameterTypeBiz.Get(m_tbl_AnalayseParameter.AnalyseParameterType);
            }
            catch(Exception ex)
            {
               throw new Exception("Business Object Convertion Error, " + ex.Message); 
            }            
            return m_AnalayseParameterModel;
        }            
		#endregion // end of Public Methods
        
        #region Private Methods        
		#endregion // end of Private Methods
        
        #region CRUD Operations          
        public static AnalayseParameterModel New()
        {
            AnalayseParameterModel m_AnalayseParameterModel = new AnalayseParameterModel();            
            return m_AnalayseParameterModel;
        }  
        
        public static AnalayseParameterModel Get(long id)
        {
            AnalayseParameterModel item = AnalayseParameterBiz.Fromtbl_AnalayseParameter(AnalayseParameter.GetEntity(id));
            if (item == null)
                return null;
            item.MarkOld();
            return item;
        }        
        
        public static AnalayseParameterModel Save(AnalayseParameterModel param)
        {
            tbl_AnalayseParameter access = AnalayseParameterBiz.Totbl_AnalayseParameter(param);
            if (param.AnalayseParameterID == -1 || param.AnalayseParameterID == int.MinValue)
            {
                param = AnalayseParameterBiz.Fromtbl_AnalayseParameter(AnalayseParameter.Insert(access));
            }
            else if (param.AnalayseParameterID != -1)
            {
                AnalayseParameter.Update(access);
                //ItemLocalized.Save(access.TblItemLocalizeds[0]);
            }
            else if (param.IsDeleted)
            {
                if (param.AnalayseParameterID != -1)
                {
                    Delete(param.AnalayseParameterID);
                }
                param.Dispose();
                return null;
            }
            param.MarkOld();
            return param;
        }        
        
        private static AnalayseParameterModel ObjectSave(AnalayseParameterModel param)
        {
            return null;
        }
        
        public static void Delete(long id)
        {
           AnalayseParameter.Delete(AnalayseParameter.GetEntity(id));
        }                
		#endregion // end of CRUD Operations   
        
        #region IBusinessBase Members
        public AnalayseParameterModel GetItem(long id)
        {
            return Get(id);
        }

        public AnalayseParameterModel SaveItem(AnalayseParameterModel dataItem)
        {
            return Save(dataItem);
        }

        public void DeleteItem(long id)
        {
            Delete(id);
        }

        public void DeleteItem(AnalayseParameterModel dataItem)
        {
            Delete(dataItem.AnalayseParameterID);
            dataItem.Dispose();
        }        
		#endregion // end of IBusinessBase Members
	}
}
