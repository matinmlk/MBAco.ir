/*------------------------------------------------------------------------
<generated>
     This code was generated by MBAco Template
     Author: Matin Maleki.
     Generated at 04/03/2013 02:30:05 ?.?.

</generated>
------------------------------------------------------------------------*/

using MBAco.BusinessModel;//.NotificationMessage;
using MBAco.DAL;//.NotificationMessage;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace MBAco.BLL
{
	/// <summary>
	/// This object represents the properties and methods of tables:dbo.tbl_NotificationMessage and 
	/// </summary>
	public partial class NotificationMessageListBiz : BusinessListBase< NotificationMessageModel >
	{
		#region Properties
		int _MaximumRows = -1;
		int _StartRowIndex = -1; 
		#endregion        
        
		#region Constructors
        public NotificationMessageListBiz()
        {
        } 
        
        public override int Count
		{
			get
			{ 
				return NotificationMessage.Count(); 
			}
		}
        
        //public int CountByParent(long parentID)
		//{
		//	return NotificationMessage.SelectAll().Where(t => t.ParentTypeID == parentID).Count();
		//}         
		#endregion // end of Constructors
        
        #region Public Methods 
        public virtual void Dispose()
        {
        }        
        
        public static NotificationMessageModel FindByNotificationMessageId(long Id)
        {
            return NotificationMessageBiz.Get(Id);
        }               
        
		/// <summary>
		/// Deletes a NotificationMessageModel based on the primitive primary keys. This can be used as the 
		/// delete method for an ObjectDataSource.
		/// </summary>
		/// <param name="notificationMessageID">notificationMessageID</param>
		public static void DeleteNotificationMessageModel(int notificationMessageID)
		{
			// You should complete this part according to design model
		}
				
		/// <summary>
		/// Retrieve information for a NotificationMessageModel by a NotificationMessageModel's unique identifier.
		/// </summary>
		/// <param name="notificationMessageID">notificationMessageID</param>
		/// <returns>NotificationMessageModel</returns>
		public static NotificationMessageModel GetNotificationMessageModel(int notificationMessageID)
		{
            return NotificationMessageBiz.Get(notificationMessageID);
		}
		
		/// <summary>
		/// Gets a collection NotificationMessageModel objects.
		/// </summary>
		/// <returns>The retrieved collection of NotificationMessageModel objects.</returns>
		public override List<NotificationMessageModel> GetAll()
		{		
			return GetAll(string.Empty, -1, -1);
		}
		
		/// <summary>
        /// Gets a collection NotificationMessageModel objects.
        /// </summary>
		/// <param name="sortExpression">sortExpression</param>
        /// <returns>The retrieved collection of NotificationMessageModel objects.</returns>
        public override List<NotificationMessageModel> GetAll(string sortExpression)
        {
			return GetAll(sortExpression, _MaximumRows, _StartRowIndex);
        }
		
		/// <summary>
        /// Gets a collection NotificationMessageModel objects.
        /// </summary>
		/// <param name="maximumRows">maximumRows</param>
		/// <param name="startRowIndex">startRowIndex</param>        
        /// <returns>The retrieved collection of NotificationMessageModel objects.</returns>
        public override List<NotificationMessageModel> GetAll(int maximumRows, int startRowIndex)
        {
			return GetAll(string.Empty, maximumRows, startRowIndex);
        }
        
		/// <summary>
        /// Gets a collection NotificationMessageModel objects.
        /// </summary>
		/// <param name="sortExpression">sortExpression</param>
		/// <param name="maximumRows">maximumRows</param>
		/// <param name="sortExpression">startRowIndex</param>        
        /// <returns>The retrieved collection of NotificationMessageModel objects.</returns>
        public override List<NotificationMessageModel> GetAll(string sortExpression, int maximumRows, int startRowIndex)
        {
			List<NotificationMessageModel> listValue = new List<NotificationMessageModel>();
			IQueryable<tbl_NotificationMessage> list;
			if (string.IsNullOrEmpty(sortExpression) && (maximumRows == -1) && (startRowIndex == -1))
			{
				list =NotificationMessage.SelectAll();
			}
			else
			{
				list = NotificationMessage.SelectAll(sortExpression, maximumRows, startRowIndex);
			}
			foreach (var item in list)
			{
				NotificationMessageModel param = NotificationMessageBiz.Fromtbl_NotificationMessage(item);
				param.MarkOld();
				listValue.Add(param);
			}
			return listValue;
        }        
        
        public List<NotificationMessageModel> GetAllWithSearch(string searchString, bool searchPartial, int maximumRows, int startRowIndex)
        {
            // && (t.Text == searchString || t.ShortText == searchString || t.FullText == searchString || t.Comment == searchString)
            List<NotificationMessageModel> listValue = new List<NotificationMessageModel>();
            IQueryable<tbl_NotificationMessage> list;
            if (string.IsNullOrEmpty(searchString) && (maximumRows == -1) && (startRowIndex == -1))
            {
                list = NotificationMessage.SelectAll();//.Where(t => (t.NotificationMessageIsAccessible == isAccessible && t.NotificationMessageIsVisible == isAccessible)).OrderByDescending(t => t.NotificationMessagePriority).ThenByDescending(t => t.NotificationMessageInsertionDate);
            }
            else if (!string.IsNullOrEmpty(searchString) && (maximumRows == -1) && (startRowIndex == -1))
            {
                if (searchPartial)
                    list = NotificationMessage.SelectAll().Where(t => ((1==1) && (t.Text.Contains(searchString) || t.ShortText.Contains(searchString) || t.FullText.Contains(searchString) || t.Comment.Contains(searchString))));//.Where(t => ((t.NotificationMessageTitle.Contains(searchString) || t.NotificationMessageAbstraction.Contains(searchString) || t.NotificationMessageData.Contains(searchString)) && t.NotificationMessageIsAccessible == isAccessible && t.NotificationMessageIsVisible == isAccessible)).OrderByDescending(t => t.NotificationMessagePriority).ThenByDescending(t => t.NotificationMessageInsertionDate);
                else
                    list = NotificationMessage.SelectAll().Where(t => ((1==1) && (t.Text == searchString || t.ShortText == searchString || t.FullText == searchString || t.Comment == searchString)));//.Where(t => ((t.NotificationMessageTitle==searchString || t.NotificationMessageAbstraction==searchString || t.NotificationMessageData==searchString) && t.NotificationMessageIsAccessible == isAccessible && t.NotificationMessageIsVisible == isAccessible)).OrderByDescending(t => t.NotificationMessagePriority).ThenByDescending(t => t.NotificationMessageInsertionDate);
            }
            else
            {
                if (searchPartial)
                {
                    list = maximumRows > 0
                    ? NotificationMessage.SelectAll().Where(t => ((1==1) && (t.Text.Contains(searchString) || t.ShortText.Contains(searchString) || t.FullText.Contains(searchString) || t.Comment.Contains(searchString)))).Skip(startRowIndex).Take(maximumRows)//.Where(t => ((t.NotificationMessageTitle.Contains(searchString) || t.NotificationMessageAbstraction.Contains(searchString) || t.NotificationMessageData.Contains(searchString)) && t.NotificationMessageIsAccessible == isAccessible && t.NotificationMessageIsVisible == isAccessible)).OrderByDescending(t => t.NotificationMessagePriority).ThenByDescending(t => t.NotificationMessageInsertionDate).Skip(startRowIndex).Take(maximumRows)
                    : NotificationMessage.SelectAll().Where(t => ((1==1) && (t.Text.Contains(searchString) || t.ShortText.Contains(searchString) || t.FullText.Contains(searchString) || t.Comment.Contains(searchString))));//.Where(t => ((t.NotificationMessageTitle.Contains(searchString) || t.NotificationMessageAbstraction.Contains(searchString) || t.NotificationMessageData.Contains(searchString)) && t.NotificationMessageIsAccessible == isAccessible && t.NotificationMessageIsVisible == isAccessible)).OrderByDescending(t => t.NotificationMessagePriority).ThenByDescending(t => t.NotificationMessageInsertionDate);
                }
                else
                {
                    list = maximumRows > 0
                    ? NotificationMessage.SelectAll().Where(t => ((1==1) && (t.Text == searchString || t.ShortText == searchString || t.FullText == searchString || t.Comment == searchString))).Skip(startRowIndex).Take(maximumRows)//.Where(t => ((t.NotificationMessageTitle == searchString || t.NotificationMessageAbstraction == searchString || t.NotificationMessageData == searchString) && t.NotificationMessageIsAccessible == isAccessible && t.NotificationMessageIsVisible == isAccessible)).OrderByDescending(t => t.NotificationMessagePriority).ThenByDescending(t => t.NotificationMessageInsertionDate).Skip(startRowIndex).Take(maximumRows)
                    : NotificationMessage.SelectAll().Where(t => ((1==1) && (t.Text == searchString || t.ShortText == searchString || t.FullText == searchString || t.Comment == searchString)));//.Where(t => ((t.NotificationMessageTitle == searchString || t.NotificationMessageAbstraction == searchString || t.NotificationMessageData == searchString) && t.NotificationMessageIsAccessible == isAccessible && t.NotificationMessageIsVisible == isAccessible)).OrderByDescending(t => t.NotificationMessagePriority).ThenByDescending(t => t.NotificationMessageInsertionDate);
                }
            }
            foreach (var item in list)
            {
                NotificationMessageModel param = NotificationMessageBiz.Fromtbl_NotificationMessage(item);
                param.MarkOld();
                listValue.Add(param);
            }
            return listValue;                        
        }        
        
        //public List<NotificationMessageModel> GetAllByParent(long parentID, int maximumRows, int startRowIndex)
		//{
		//	List<NotificationMessageModel> listValue = new List<NotificationMessageModel>();
		//	IQueryable<tbl_NotificationMessage> list;
		//	if ((maximumRows == -1) && (startRowIndex == -1))
		//	{
		//		list = NotificationMessage.SelectAll().Where(t => t.ParentTypeID == parentID);
		//	}
		//	else
		//	{
		//		list = maximumRows > 0
		//			   ? NotificationMessage.SelectAll().Where(t => t.ParentTypeID == parentID).Skip(startRowIndex).Take(maximumRows) //Paging
		//			   : NotificationMessage.SelectAll().Where(t => t.ParentTypeID == parentID); //No paging
		//	}
		//	foreach (var item in list)
		//	{
		//		tbl_NotificationMessagetbl_NotificationMessage param = NotificationMessageBiz.Fromtbl_NotificationMessage(item);
		//		param.MarkOld();
		//		listValue.Add(param);
		//	}
		//	return listValue;
		//}
		
		//public static void DeleteNotificationMessagesByParentType(long objectID) 
		//{
		//	IQueryable<tbl_NotificationMessage> list = NotificationMessage.SelectAll().Where(t => t.ParentTypeID == objectID);
		//	foreach (var item in list)
		//	{
		//		NotificationMessage.Delete(item);
		//	}
		//}
        
		/// <summary>
		/// Gets a collection of NotificationMessageModel objects by a Culture object.
		/// </summary>
		/// <param name="culture">culture</param>
		/// <returns>A collection NotificationMessageModel objects.</returns>
		public List<NotificationMessageModel> GetNotificationMessagesByCulture(CultureModel culture) 
		{
            List<NotificationMessageModel> listValue = new List<NotificationMessageModel>();
			// You should complete this part according of design model
			return listValue;            
		}
		
		/// <summary>
		/// Deletes NotificationMessageModel objects by a Culture unique identifier.
		/// </summary>
		/// <param name="cultureID">cultureID</param>
		public static void DeleteNotificationMessagesByCulture(int cultureID) 
		{
            // You should cpmplete this part according of design model
		}
		/// <summary>
		/// Gets a collection of NotificationMessageModel objects by a NotificationMessageType object.
		/// </summary>
		/// <param name="type">type</param>
		/// <returns>A collection NotificationMessageModel objects.</returns>
		public List<NotificationMessageModel> GetNotificationMessagesByType(NotificationMessageTypeModel type) 
		{
            List<NotificationMessageModel> listValue = new List<NotificationMessageModel>();
			// You should complete this part according of design model
			return listValue;            
		}
		
		/// <summary>
		/// Deletes NotificationMessageModel objects by a NotificationMessageType unique identifier.
		/// </summary>
		/// <param name="notificationMessageTypeID">notificationMessageTypeID</param>
		public static void DeleteNotificationMessagesByType(int notificationMessageTypeID) 
		{
            // You should cpmplete this part according of design model
		}
		#endregion // end of Public Methods
        
        #region Private Methods        
		#endregion // end of Private Methods
        
        #region CRUD Operations          
        public static NotificationMessageModel New()
        {
            NotificationMessageModel m_NotificationMessageModel = new NotificationMessageModel();            
            return m_NotificationMessageModel;
        }  
        
        public static NotificationMessageModel Get(long id)
        {
            NotificationMessageModel item = NotificationMessageBiz.Fromtbl_NotificationMessage(NotificationMessage.GetEntity(id));
            if (item == null)
                return null;
            item.MarkOld();
            return item;
        }        
        
        public static NotificationMessageModel Save(NotificationMessageModel param)
        {
			return NotificationMessageBiz.Save(param);
        }               
        
        public static void Delete(long id)
        {
           NotificationMessageBiz.Delete(id);
        }                
		#endregion // end of CRUD Operations           
	}
}
