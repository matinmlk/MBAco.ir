/*------------------------------------------------------------------------
<generated>
     This code was generated by MBAco Template
     Author: Matin Maleki.
     Generated at 04/03/2013 02:30:04 ?.?.

</generated>
------------------------------------------------------------------------*/

using MBAco.BusinessModel;//.DailyAnalyseReport;
using MBAco.DAL;//.DailyAnalyseReport;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace MBAco.BLL
{
    /// <summary>
    /// This object represents the properties and methods of tables:dbo.tbl_DailyAnalyseReport and 
    /// </summary>
    public partial class DailyAnalyseReportListBiz : BusinessListBase<DailyAnalyseReportModel>
    {
        #region Properties
        int _MaximumRows = -1;
        int _StartRowIndex = -1;
        #endregion

        #region Constructors
        public DailyAnalyseReportListBiz()
        {
        }

        public override int Count
        {
            get
            {
                return DailyAnalyseReport.Count();
            }
        }

        //public int CountByParent(long parentID)
        //{
        //	return DailyAnalyseReport.SelectAll().Where(t => t.ParentTypeID == parentID).Count();
        //}         
        #endregion // end of Constructors

        #region Public Methods
        public virtual void Dispose()
        {
        }

        public static DailyAnalyseReportModel FindByDailyAnalyseReportId(long Id)
        {
            return DailyAnalyseReportBiz.Get(Id);
        }

        /// <summary>
        /// Deletes a DailyAnalyseReportModel based on the primitive primary keys. This can be used as the 
        /// delete method for an ObjectDataSource.
        /// </summary>
        /// <param name="dailyAnalyseReportID">dailyAnalyseReportID</param>
        public static void DeleteDailyAnalyseReportModel(int dailyAnalyseReportID)
        {
            // You should complete this part according to design model
        }

        /// <summary>
        /// Retrieve information for a DailyAnalyseReportModel by a DailyAnalyseReportModel's unique identifier.
        /// </summary>
        /// <param name="dailyAnalyseReportID">dailyAnalyseReportID</param>
        /// <returns>DailyAnalyseReportModel</returns>
        public static DailyAnalyseReportModel GetDailyAnalyseReportModel(int dailyAnalyseReportID)
        {
            return DailyAnalyseReportBiz.Get(dailyAnalyseReportID);
        }

        /// <summary>
        /// Gets a collection DailyAnalyseReportModel objects.
        /// </summary>
        /// <returns>The retrieved collection of DailyAnalyseReportModel objects.</returns>
        public override List<DailyAnalyseReportModel> GetAll()
        {
            return GetAll(string.Empty, -1, -1);
        }

        /// <summary>
        /// Gets a collection DailyAnalyseReportModel objects.
        /// </summary>
        /// <param name="sortExpression">sortExpression</param>
        /// <returns>The retrieved collection of DailyAnalyseReportModel objects.</returns>
        public override List<DailyAnalyseReportModel> GetAll(string sortExpression)
        {
            return GetAll(sortExpression, _MaximumRows, _StartRowIndex);
        }

        /// <summary>
        /// Gets a collection DailyAnalyseReportModel objects.
        /// </summary>
        /// <param name="maximumRows">maximumRows</param>
        /// <param name="startRowIndex">startRowIndex</param>        
        /// <returns>The retrieved collection of DailyAnalyseReportModel objects.</returns>
        public override List<DailyAnalyseReportModel> GetAll(int maximumRows, int startRowIndex)
        {
            return GetAll(string.Empty, maximumRows, startRowIndex);
        }

        /// <summary>
        /// Gets a collection DailyAnalyseReportModel objects.
        /// </summary>
        /// <param name="sortExpression">sortExpression</param>
        /// <param name="maximumRows">maximumRows</param>
        /// <param name="sortExpression">startRowIndex</param>        
        /// <returns>The retrieved collection of DailyAnalyseReportModel objects.</returns>
        public override List<DailyAnalyseReportModel> GetAll(string sortExpression, int maximumRows, int startRowIndex)
        {
            List<DailyAnalyseReportModel> listValue = new List<DailyAnalyseReportModel>();
            IQueryable<tbl_DailyAnalyseReport> list;
            if (string.IsNullOrEmpty(sortExpression) && (maximumRows == -1) && (startRowIndex == -1))
            {
                list = DailyAnalyseReport.SelectAll();
            }
            else
            {
                list = DailyAnalyseReport.SelectAll(sortExpression, maximumRows, startRowIndex);
            }
            foreach (var item in list)
            {
                DailyAnalyseReportModel param = DailyAnalyseReportBiz.Fromtbl_DailyAnalyseReport(item);
                param.MarkOld();
                listValue.Add(param);
            }
            return listValue;
        }

        public List<DailyAnalyseReportModel> GetAllWithSearch(string searchString, bool searchPartial, int maximumRows, int startRowIndex)
        {
            // && (t.Comment == searchString)
            List<DailyAnalyseReportModel> listValue = new List<DailyAnalyseReportModel>();
            IQueryable<tbl_DailyAnalyseReport> list;
            if (string.IsNullOrEmpty(searchString) && (maximumRows == -1) && (startRowIndex == -1))
            {
                list = DailyAnalyseReport.SelectAll();//.Where(t => (t.DailyAnalyseReportIsAccessible == isAccessible && t.DailyAnalyseReportIsVisible == isAccessible)).OrderByDescending(t => t.DailyAnalyseReportPriority).ThenByDescending(t => t.DailyAnalyseReportInsertionDate);
            }
            else if (!string.IsNullOrEmpty(searchString) && (maximumRows == -1) && (startRowIndex == -1))
            {
                if (searchPartial)
                    list = DailyAnalyseReport.SelectAll().Where(t => ((1 == 1) && (t.Comment.Contains(searchString))));//.Where(t => ((t.DailyAnalyseReportTitle.Contains(searchString) || t.DailyAnalyseReportAbstraction.Contains(searchString) || t.DailyAnalyseReportData.Contains(searchString)) && t.DailyAnalyseReportIsAccessible == isAccessible && t.DailyAnalyseReportIsVisible == isAccessible)).OrderByDescending(t => t.DailyAnalyseReportPriority).ThenByDescending(t => t.DailyAnalyseReportInsertionDate);
                else
                    list = DailyAnalyseReport.SelectAll().Where(t => ((1 == 1) && (t.Comment == searchString)));//.Where(t => ((t.DailyAnalyseReportTitle==searchString || t.DailyAnalyseReportAbstraction==searchString || t.DailyAnalyseReportData==searchString) && t.DailyAnalyseReportIsAccessible == isAccessible && t.DailyAnalyseReportIsVisible == isAccessible)).OrderByDescending(t => t.DailyAnalyseReportPriority).ThenByDescending(t => t.DailyAnalyseReportInsertionDate);
            }
            else
            {
                if (searchPartial)
                {
                    list = maximumRows > 0
                    ? DailyAnalyseReport.SelectAll().Where(t => ((1 == 1) && (t.Comment.Contains(searchString)))).Skip(startRowIndex).Take(maximumRows)//.Where(t => ((t.DailyAnalyseReportTitle.Contains(searchString) || t.DailyAnalyseReportAbstraction.Contains(searchString) || t.DailyAnalyseReportData.Contains(searchString)) && t.DailyAnalyseReportIsAccessible == isAccessible && t.DailyAnalyseReportIsVisible == isAccessible)).OrderByDescending(t => t.DailyAnalyseReportPriority).ThenByDescending(t => t.DailyAnalyseReportInsertionDate).Skip(startRowIndex).Take(maximumRows)
                    : DailyAnalyseReport.SelectAll().Where(t => ((1 == 1) && (t.Comment.Contains(searchString))));//.Where(t => ((t.DailyAnalyseReportTitle.Contains(searchString) || t.DailyAnalyseReportAbstraction.Contains(searchString) || t.DailyAnalyseReportData.Contains(searchString)) && t.DailyAnalyseReportIsAccessible == isAccessible && t.DailyAnalyseReportIsVisible == isAccessible)).OrderByDescending(t => t.DailyAnalyseReportPriority).ThenByDescending(t => t.DailyAnalyseReportInsertionDate);
                }
                else
                {
                    list = maximumRows > 0
                    ? DailyAnalyseReport.SelectAll().Where(t => ((1 == 1) && (t.Comment == searchString))).Skip(startRowIndex).Take(maximumRows)//.Where(t => ((t.DailyAnalyseReportTitle == searchString || t.DailyAnalyseReportAbstraction == searchString || t.DailyAnalyseReportData == searchString) && t.DailyAnalyseReportIsAccessible == isAccessible && t.DailyAnalyseReportIsVisible == isAccessible)).OrderByDescending(t => t.DailyAnalyseReportPriority).ThenByDescending(t => t.DailyAnalyseReportInsertionDate).Skip(startRowIndex).Take(maximumRows)
                    : DailyAnalyseReport.SelectAll().Where(t => ((1 == 1) && (t.Comment == searchString)));//.Where(t => ((t.DailyAnalyseReportTitle == searchString || t.DailyAnalyseReportAbstraction == searchString || t.DailyAnalyseReportData == searchString) && t.DailyAnalyseReportIsAccessible == isAccessible && t.DailyAnalyseReportIsVisible == isAccessible)).OrderByDescending(t => t.DailyAnalyseReportPriority).ThenByDescending(t => t.DailyAnalyseReportInsertionDate);
                }
            }
            foreach (var item in list)
            {
                DailyAnalyseReportModel param = DailyAnalyseReportBiz.Fromtbl_DailyAnalyseReport(item);
                param.MarkOld();
                listValue.Add(param);
            }
            return listValue;
        }

        //public List<DailyAnalyseReportModel> GetAllByParent(long parentID, int maximumRows, int startRowIndex)
        //{
        //	List<DailyAnalyseReportModel> listValue = new List<DailyAnalyseReportModel>();
        //	IQueryable<tbl_DailyAnalyseReport> list;
        //	if ((maximumRows == -1) && (startRowIndex == -1))
        //	{
        //		list = DailyAnalyseReport.SelectAll().Where(t => t.ParentTypeID == parentID);
        //	}
        //	else
        //	{
        //		list = maximumRows > 0
        //			   ? DailyAnalyseReport.SelectAll().Where(t => t.ParentTypeID == parentID).Skip(startRowIndex).Take(maximumRows) //Paging
        //			   : DailyAnalyseReport.SelectAll().Where(t => t.ParentTypeID == parentID); //No paging
        //	}
        //	foreach (var item in list)
        //	{
        //		tbl_DailyAnalyseReporttbl_DailyAnalyseReport param = DailyAnalyseReportBiz.Fromtbl_DailyAnalyseReport(item);
        //		param.MarkOld();
        //		listValue.Add(param);
        //	}
        //	return listValue;
        //}

        //public static void DeleteDailyAnalyseReportsByParentType(long objectID) 
        //{
        //	IQueryable<tbl_DailyAnalyseReport> list = DailyAnalyseReport.SelectAll().Where(t => t.ParentTypeID == objectID);
        //	foreach (var item in list)
        //	{
        //		DailyAnalyseReport.Delete(item);
        //	}
        //}

        /// <summary>
        /// Gets a collection of DailyAnalyseReportModel objects by a Customer object.
        /// </summary>
        /// <param name="customer">customer</param>
        /// <returns>A collection DailyAnalyseReportModel objects.</returns>
        public List<DailyAnalyseReportModel> GetDailyAnalyseReportsByCustomer(CustomerModel customer)
        {
            List<DailyAnalyseReportModel> listValue = new List<DailyAnalyseReportModel>();
            // You should complete this part according of design model
            return listValue;
        }

        /// <summary>
        /// Deletes DailyAnalyseReportModel objects by a Customer unique identifier.
        /// </summary>
        /// <param name="customerID">customerID</param>
        public static void DeleteDailyAnalyseReportsByCustomer(int customerID)
        {
            // You should cpmplete this part according of design model
        }
        /// <summary>
        /// Gets a collection of DailyAnalyseReportModel objects by a ProcedureParameter object.
        /// </summary>
        /// <param name="procedureParameter">procedureParameter</param>
        /// <returns>A collection DailyAnalyseReportModel objects.</returns>
        public List<DailyAnalyseReportModel> GetDailyAnalyseReportsByProcedureParameterID(int procedureParameterId)
        {
            List<DailyAnalyseReportModel> listValue = new List<DailyAnalyseReportModel>();


            IQueryable<tbl_DailyAnalyseReport> list;

            list = DailyAnalyseReport.SelectAll().Where(t => t.ProcedureParameterID == procedureParameterId).Where(p => p.IsApproved == true).OrderBy("Date");//.Where(t => (t.DailyAnalyseReportIsAccessible == isAccessible && t.DailyAnalyseReportIsVisible == isAccessible)).OrderByDescending(t => t.DailyAnalyseReportPriority).ThenByDescending(t => t.DailyAnalyseReportInsertionDate);

            foreach (var item in list)
            {
                DailyAnalyseReportModel param = DailyAnalyseReportBiz.Fromtbl_DailyAnalyseReport(item);
                param.MarkOld();
                listValue.Add(param);
            }

            return listValue;
        }

        public List<DailyAnalyseReportModel> GetDaily2monthAnalyseReportsByProcedureParameterID(int procedureParameterId)
        {
            List<DailyAnalyseReportModel> listValue = new List<DailyAnalyseReportModel>();


            IQueryable<tbl_DailyAnalyseReport> list;

            list = DailyAnalyseReport.SelectAll().Where(t => t.ProcedureParameterID == procedureParameterId).Where(p => p.Date > DateTime.Now.AddMonths(-3));

            foreach (var item in list)
            {
                DailyAnalyseReportModel param = DailyAnalyseReportBiz.Fromtbl_DailyAnalyseReport(item);
                param.MarkOld();
                listValue.Add(param);
            }

            return listValue;
        }

        /// <summary>
        /// Deletes DailyAnalyseReportModel objects by a ProcedureParameter unique identifier.
        /// </summary>
        /// <param name="procedureParameterID">procedureParameterID</param>
        public static void DeleteDailyAnalyseReportsByProcedureParameter(int procedureParameterID)
        {
            // You should cpmplete this part according of design model
        }
        #endregion // end of Public Methods

        #region Private Methods
        #endregion // end of Private Methods

        #region CRUD Operations
        public static DailyAnalyseReportModel New()
        {
            DailyAnalyseReportModel m_DailyAnalyseReportModel = new DailyAnalyseReportModel();
            return m_DailyAnalyseReportModel;
        }

        public static DailyAnalyseReportModel Get(long id)
        {
            DailyAnalyseReportModel item = DailyAnalyseReportBiz.Fromtbl_DailyAnalyseReport(DailyAnalyseReport.GetEntity(id));
            if (item == null)
                return null;
            item.MarkOld();
            return item;
        }

        public static DailyAnalyseReportModel Save(DailyAnalyseReportModel param)
        {
            return DailyAnalyseReportBiz.Save(param);
        }

        public static void Delete(long id)
        {
            DailyAnalyseReportBiz.Delete(id);
        }
        #endregion // end of CRUD Operations

        public List<DailyAnalyseReportModel> GetUnApproved()
        {
            List<DailyAnalyseReportModel> listValue = new List<DailyAnalyseReportModel>();
            IQueryable<tbl_DailyAnalyseReport> list;

                list = DailyAnalyseReport.SelectAll().Where(p => p.IsApproved == false);


            foreach (var item in list)
            {
                DailyAnalyseReportModel param = DailyAnalyseReportBiz.Fromtbl_DailyAnalyseReport(item);
                param.MarkOld();
                listValue.Add(param);
            }
            return listValue;
        }

        public List<DailyAnalyseReportModel> GetDailyApproved()
        {
            List<DailyAnalyseReportModel> listValue = new List<DailyAnalyseReportModel>();
            IQueryable<tbl_DailyAnalyseReport> list;

            list = DailyAnalyseReport.SelectAll()
                .Where(p => p.IsApproved == true && p.Date.DayOfYear == DateTime.Now.DayOfYear && p.Date.Year == DateTime.Now.Year);


            foreach (var item in list)
            {
                DailyAnalyseReportModel param = DailyAnalyseReportBiz.Fromtbl_DailyAnalyseReport(item);
                param.MarkOld();
                listValue.Add(param);
            }
            return listValue;
        }

        public static List<DailyAnalyseReportModel> DeleteDailyAnalyseReportsByCustomerAndType(int CustomerId, int TypeId)
        {
            List<DailyAnalyseReportModel> listValue = new List<DailyAnalyseReportModel>();


            IQueryable<tbl_DailyAnalyseReport> list;

            list = DailyAnalyseReport.SelectAll().Where(t => t.CustomerID == CustomerId && t.tbl_ProcedureParameter.tbl_AnalayseParameter.AnalyseParameterType == TypeId).Where(p => p.IsApproved == true).OrderBy("Date");

            foreach (var item in list)
            {
                DailyAnalyseReportModel param = DailyAnalyseReportBiz.Fromtbl_DailyAnalyseReport(item);
                param.MarkOld();
                listValue.Add(param);
            }

            return listValue;
        }
    }
}