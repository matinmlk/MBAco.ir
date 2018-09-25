/*------------------------------------------------------------------------
<generated>
     This code was generated by MBAco Template
     Author: Matin Maleki.
     Generated at 04/03/2013 06:45:08 ?.?.

</generated>
------------------------------------------------------------------------*/

using MBAco.BusinessModel;//.CustomerContact;
using MBAco.DAL;//.CustomerContact;
using System.Collections.Generic;
using System;
using System.Linq;

namespace MBAco.BLL
{
	/// <summary>
	/// This object represents the properties and methods of tables:dbo.tbl_CustomerContact and 
	/// </summary>
	public partial class CustomerContactBiz : IBusinessBase< CustomerContactModel >
	{
		#region Constructors
        public CustomerContactBiz()
        {
        }                
		#endregion // end of Constructors
        
        #region Public Methods 
        public virtual void Dispose()
        {
        }        
        
        public static CustomerContactModel FindByCustomerContactId(long Id)
        {
            return Get(Id);
        }
        
        internal static tbl_CustomerContact Totbl_CustomerContact(CustomerContactModel param)
        {
            tbl_CustomerContact m_tbl_CustomerContact = new tbl_CustomerContact();          
            if (param == null)
                throw new System.ArgumentNullException("param");         
            try
            {                
                m_tbl_CustomerContact.CustomerContactID = param.CustomerContactID;
				m_tbl_CustomerContact.Post = param.Post;
				m_tbl_CustomerContact.Comment = param.Comment;
				m_tbl_CustomerContact.ContactID = param.ContactID;
				m_tbl_CustomerContact.CustomerID = param.CustomerID;
            }
            catch(Exception ex)
            {
               throw new Exception("Business Object Convertion Error, " + ex.Message); 
            }            
            return m_tbl_CustomerContact;
        }        
        internal static CustomerContactModel Fromtbl_CustomerContact(tbl_CustomerContact m_tbl_CustomerContact)
        {
            CustomerContactModel m_CustomerContactModel = new CustomerContactModel();
            if (m_tbl_CustomerContact == null)
                throw new System.ArgumentNullException("m_tbl_CustomerContact");                
            try
            {                
                m_CustomerContactModel.CustomerContactID = m_tbl_CustomerContact.CustomerContactID;
				m_CustomerContactModel.Post = m_tbl_CustomerContact.Post;
				m_CustomerContactModel.Comment = m_tbl_CustomerContact.Comment;  
				m_CustomerContactModel.Contact = ContactBiz.Get(m_tbl_CustomerContact.ContactID);
				m_CustomerContactModel.Customer = CustomerBiz.Get(m_tbl_CustomerContact.CustomerID);  
            }
            catch(Exception ex)
            {
               throw new Exception("Business Object Convertion Error, " + ex.Message); 
            }            
            return m_CustomerContactModel;
        }            
		#endregion // end of Public Methods
        
        #region Private Methods        
		#endregion // end of Private Methods
        
        #region CRUD Operations          
        public static CustomerContactModel New()
        {
            CustomerContactModel m_CustomerContactModel = new CustomerContactModel();            
            return m_CustomerContactModel;
        }  
        
        public static CustomerContactModel Get(long id)
        {
            CustomerContactModel item = CustomerContactBiz.Fromtbl_CustomerContact(CustomerContact.GetEntity(id));
            if (item == null)
                return null;
            item.MarkOld();
            return item;
        }        
        
        public static CustomerContactModel Save(CustomerContactModel param)
        {
            tbl_CustomerContact access = CustomerContactBiz.Totbl_CustomerContact(param);
            if (param.CustomerContactID == -1 || param.CustomerContactID == int.MinValue)
            {
                param = CustomerContactBiz.Fromtbl_CustomerContact(CustomerContact.Insert(access));
            }
            else if (param.CustomerContactID != -1)
            {
                CustomerContact.Update(access);
                //ItemLocalized.Save(access.TblItemLocalizeds[0]);
            }
            else if (param.IsDeleted)
            {
                if (param.CustomerContactID != -1)
                {
                    Delete(param.CustomerContactID);
                }
                param.Dispose();
                return null;
            }
            param.MarkOld();
            return param;
        }        
        
        private static CustomerContactModel ObjectSave(CustomerContactModel param)
        {
            return null;
        }
        
        public static void Delete(long id)
        {
           CustomerContact.Delete(CustomerContact.GetEntity(id));
        }                
		#endregion // end of CRUD Operations   
        
        #region IBusinessBase Members
        public CustomerContactModel GetItem(long id)
        {
            return Get(id);
        }

        public CustomerContactModel SaveItem(CustomerContactModel dataItem)
        {
            return Save(dataItem);
        }

        public void DeleteItem(long id)
        {
            Delete(id);
        }

        public void DeleteItem(CustomerContactModel dataItem)
        {
            Delete(dataItem.CustomerContactID);
            dataItem.Dispose();
        }        
		#endregion // end of IBusinessBase Members
	}
}
