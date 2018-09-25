
using System;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace MBAco.BusinessModel
{
    public abstract class ModelItemBase : IPropertyNotification, IDisposable, IBusinessModel//, IValidatable
    {
        #region Fields and Properties

        private string m_ObjectId = System.Guid.NewGuid().ToString();

        private Boolean m_IsNew = false;
        /// <summary>
        /// ??? ?? ???? ????? ??? ??? ?? ????
        /// ReadOnly
        /// </summary>
        /// <remarks>????? ?? ??? ?? ??? ?? ???? ????? ??? ??? ?? ????</remarks>
        /// <value>
        /// ??? ????? ???? ????? ?????? ?? ????
        /// True or False
        /// </value>
        [DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
        [Browsable(false)]
        [Display(AutoGenerateField = false)]
        public virtual Boolean IsNew
        {
            get
            {
                return m_IsNew;
            }
        }

        private Boolean m_IsDirty = true;
        /// <summary>
        /// ??? ??? ????? ??? ??? ????? ???? ????
        /// ReadOnly
        /// </summary>
        /// <remarks>????? ?? ??? ?? ??? ????? ????? ??? ??? ????? ???? ??? ?? ???? ??? ????? ????? ???????? ???? ????? ?????? ?? ???</remarks>
        /// <value>
        /// ????? ??? ????? ???? ????? ?????? ?? ??? 
        /// True or False
        /// </value>
        [DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
        [Browsable(false)]
        [Display(AutoGenerateField = false)]
        public virtual Boolean IsDirty
        {
            get
            {
                return m_IsDirty;
            }
        }

        private Boolean m_IsSelected = false;
        /// <summary>
        /// ??? ??? ??? ??? ??? ????
        /// ReadOnly
        /// </summary>
        /// <remarks>???? ????????? ????? ??? ??? ??? ??? ??? ?? ????</remarks>
        /// <value>
        /// ????? ???????? ? ???? ????? ?????? ?? ???
        /// True or False        
        [DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
        [Browsable(true)]
        [Display(AutoGenerateField = false)]
        public virtual Boolean IsSelected
        {
            set
            {
                m_IsSelected = value;
            }
            get
            {
                return m_IsSelected;
            }
        }

        private Boolean m_IsDeleted = false;
        /// <summary>
        /// ??? ??? ??? ??? ??? ????
        /// ReadOnly
        /// </summary>
        /// <remarks>???? ????????? ????? ??? ??? ??? ??? ??? ?? ????</remarks>
        /// <value>
        /// ????? ???????? ? ???? ????? ?????? ?? ???
        /// True or False
        /// </value>
        [DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
        [Browsable(false)]
        [Display(AutoGenerateField = false)]
        public virtual Boolean IsDeleted
        {
            get
            {
                return m_IsDeleted;
            }
        }

        /// <summary>
        /// ????? ????? ?? ??? ?? ??? ??? 
        /// ReadOnly ; Unique Identifier
        /// </summary>
        /// <remarks>??? ????? ????? ????? ?? ??? ?? ?? ?? ???? ?? ???? ????? ????? ?? ????</remarks>
        /// <value>
        /// ???? ?? ???????? ??? ?? ??????
        /// GUID
        /// </value>
        [DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
        [Browsable(false)]
        [Display(AutoGenerateField = false)]
        public virtual String ObjectId
        {
            get
            {
                return m_ObjectId;
            }
        }

        private String m_CultureId = "en-US";
        [Browsable(false)]
        [Display(AutoGenerateField = true)]
        public String CultureId
        {
            get
            {
                return m_CultureId;
            }
        }
        #endregion

        #region Methods

        /// <summary>
        /// Marks the object as being a new object. This also marks the object
        /// as being dirty and ensures that it is not marked for deletion.
        /// </summary>
        /// <remarks>
        /// <para>
        /// Newly created objects are marked new by default. You should call
        /// this method in the implementation of Data Access Update when the
        /// object is deleted (due to being marked for deletion) to indicate
        /// that the object no longer reflects data in the database.
        /// </para><para>
        /// If you override this method, make sure to call the base
        /// implementation after executing your new code.
        /// </para>
        /// </remarks> 
        public virtual void MarkNew()
        {
            m_IsNew = true;
            m_IsDeleted = false;
            m_IsDirty = false;
        }

        /// <summary>
        /// Marks the object as being an old (not new) object. This also
        /// marks the object as being unchanged (not dirty).
        /// </summary>
        /// <remarks>
        /// <para>
        /// You should call this method in the implementation of
        /// Data Acess Fetch to indicate that an existing object has been
        /// successfully retrieved from the database.
        /// </para><para>
        /// You should call this method in the implementation of
        /// Data Acess to indicate that a new object has been successfully
        /// inserted into the database.
        /// </para><para>
        /// If you override this method, make sure to call the base
        /// implementation after executing your new code.
        /// </para>
        /// </remarks>
        public virtual void MarkOld()
        {
            MarkNew();
            m_IsNew = false;
        }

        /// <summary>
        /// Marks an object for deletion. This also marks the object
        /// as being dirty.
        /// </summary>
        /// <remarks>
        /// You should call this method in your business logic in the
        /// case that you want to have the object deleted when it is
        /// saved to the database.
        /// </remarks>
        public void MarkDeleted()
        {
            m_IsDeleted = true;
            //MarkDirty();
        }

        /// <summary>
        /// Marks an object as being dirty, or changed.
        /// </summary>
        /// <remarks>
        /// <para>
        /// You should call this method in your business logic any time
        /// the object's internal data changes. Any time any instance
        /// variable changes within the object, this method should be called
        /// to tell framework that the object's data has been changed.
        /// </para><para>
        /// Marking an object as dirty does two things. First it ensures
        /// that framework will properly save the object as appropriate. Second,
        /// it causes framework to tell Windows Forms data binding that the
        /// object's data has changed so any bound controls will update to
        /// reflect the new values.
        /// </para>
        /// </remarks>
        public void MarkDirty()
        {
            m_IsDirty = true;
        }

        /// <summary>
        /// Forces the object's IsDirty flag to <see langword="false" />.
        /// </summary>
        /// <remarks>
        /// This method is normally called automatically and is
        /// not intended to be called manually.
        /// </remarks>
        public void MarkClean()
        {
            m_IsDirty = false;
        }

        protected virtual long GetIdValue()
        {
            return -1;
        }

        
        
        #endregion //Methods

        #region Constructor

        public ModelItemBase()
        {
            MarkNew();
            this.PropertyChanged += new PropertyChangedEventHandler(ModelItemBase_PropertyChanged);
            this.PropertyChanging += new PropertyChangingEventHandler(ModelItemBase_PropertyChanging);
        }

        public ModelItemBase(string cultureId)
        {
            MarkNew();
            this.PropertyChanged += new PropertyChangedEventHandler(ModelItemBase_PropertyChanged);
            this.PropertyChanging += new PropertyChangingEventHandler(ModelItemBase_PropertyChanging);
            if (!String.IsNullOrEmpty(cultureId))
                m_CultureId = cultureId;
        }
        #endregion //Constructor

        #region IPropertyNotification Members

        /// <summary>
        /// Occurs when a property value is changing.
        /// </summary>
        [field: NonSerialized]
        public event PropertyChangingEventHandler PropertyChanging;

        /// <summary>
        /// Occurs when a property value changes.
        /// </summary>
        [field: NonSerialized]
        public event PropertyChangedEventHandler PropertyChanged;

        #endregion //IPropertyNotification Members

        #region IPropertyNotification Private Helpers

        protected void NotifyPropertyChanged(string propertyName)
        {
            OnPropertyChanged(propertyName);
        }

        /// <summary>
        /// Raises the <see cref="E:PropertyChanged"/> event.
        /// </summary>
        /// <param name="propertyName">
        /// Name of the property that changed.
        /// </param>
        protected void OnPropertyChanged(String propertyName)
        {
            if (PropertyChanged != null)
            {
                PropertyChangedEventArgs e = new PropertyChangedEventArgs(propertyName);
                OnPropertyChanged(e);
                MarkDirty();
            }
        }

        /// <summary>
        /// Raises the <see cref="E:PropertyChanged"/> event.
        /// </summary>
        /// <param name="propertyName">
        /// Name of the property that changed.
        /// </param>
        /// <param name="oldValue">The old value.</param>
        /// <param name="newValue">The new value.</param>
        protected void OnPropertyChanged(String propertyName,
            Object oldValue, Object newValue)
        {
            PropertyNotificationEventArgs e = new PropertyNotificationEventArgs(propertyName,
                oldValue, newValue);
            OnPropertyChanged(e);
        }

        /// <summary>
        /// Raises the <see cref="E:PropertyChanged"/> event.
        /// </summary>
        /// <param name="e">
        /// The <see cref="PropertyChangedEventArgs"/> instance
        /// containing the event data.
        /// </param>
        protected void OnPropertyChanged(PropertyChangedEventArgs e)
        {
            PropertyChangedEventHandler temp = this.PropertyChanged;
            if (null != temp)
                temp(this, e);
        }

        /// <summary>
        /// Raises the <see cref="E:PropertyChanged"/> event.
        /// </summary>
        /// <param name="e">
        /// The <see cref="PropertyNotificationEventArgs"/> instance
        /// containing the event data.
        /// </param>
        protected void OnPropertyChanged(PropertyNotificationEventArgs e)
        {
            PropertyChangedEventHandler temp = this.PropertyChanged;
            if (null != temp)
                temp(this, e);
        }

        /// <summary>
        /// Raises the <see cref="E:PropertyChanging"/> event.
        /// </summary>
        /// <param name="propertyName">
        /// Name of the property that is changing.
        /// </param>
        /// <param name="oldValue">The old value.</param>
        /// <param name="newValue">The new value.</param>
        /// <returns><c>true</c> if the change can continue; otherwise <c>false</c>.</returns>
        protected Boolean OnPropertyChanging(String propertyName,
            Object oldValue, Object newValue)
        {
            CancelPropertyNotificationEventArgs e = new CancelPropertyNotificationEventArgs(propertyName,
                oldValue, newValue);
            OnPropertyChanging(e);
            return !e.Cancel;
        }

        /// <summary>
        /// Raises the <see cref="E:PropertyChanging"/> event.
        /// </summary>
        /// <param name="e">
        /// The <see cref="CancelPropertyNotificationEventArgs"/> instance
        /// containing the event data.
        /// </param>
        protected void OnPropertyChanging(CancelPropertyNotificationEventArgs e)
        {
            PropertyChangingEventHandler temp = this.PropertyChanging;
            if (null != temp)
                temp(this, e);
        }

        /// <summary>
        /// This method is used to set a property while firing associated
        /// PropertyChanging and PropertyChanged events.
        /// </summary>
        /// <param name="propertyName">Name of the property.</param>
        /// <param name="propertyField">The property field.</param>
        /// <param name="value">The value.</param>
        protected void SetProperty<T>(String propertyName, ref T propertyField,
            T value)
        {
            if (false == Object.Equals(value, propertyField))
            {
                if (true == OnPropertyChanging(propertyName, propertyField, value))
                {
                    T oldValue = propertyField;
                    propertyField = value;
                    OnPropertyChanged(propertyName, oldValue, propertyField);
                }
            }

            //Example
            //public String Name 
            //{
            //    get 
            //        {
            //            return this.m_Name;
            //        }
            //    set 
            //        {
            //            SetProperty<String>("Name", ref this.m_Name, value);
            //        }
            //}
        }

        #endregion //IPropertyNotification Private Helpers

        #region IPropertyNotification Properties/Fields

        /// <summary>
        /// Holds a value indicating whether the
        /// <see cref="T:IPropertyNotification"/> events of child objects
        /// should be propagated through this object's event sinks.
        /// </summary>
        private Boolean propagatePropertyNotifications = true;

        /// <summary>
        /// Gets or sets a value indicating whether the
        /// <see cref="T:IPropertyNotification"/> events of child objects
        /// should be propagated through this object's event sinks.
        /// </summary>
        /// <value>
        /// 	<c>true</c> if property events should be propagated; otherwise, <c>false</c>.
        /// </value>
        [Browsable(false)]
        public Boolean PropagatePropertyNotifications
        {
            get
            {
                return this.propagatePropertyNotifications;
            }
            set
            {
                SetProperty<Boolean>("PropagatePropertyNotifications",
                    ref this.propagatePropertyNotifications, value);
            }
        }

        /// <summary>
        /// Gets a value indicating whether the <see cref="PropertyChanged"/>
        /// and <see cref="PropertyChanging"/> events are suspended.
        /// </summary>
        /// <value>
        /// 	<c>true</c> if the property events are suspended; otherwise, <c>false</c>.
        /// </value>
        [Browsable(false)]
        public Boolean PropertyEventsSuspended
        {
            get
            {
                return (0 != this.propertyEventSuspendCount);
            }
        }

        /// <summary>
        /// Holds the suspension count for the <see cref="PropertyChanged"/>
        /// and <see cref="PropertyChanging"/> events. When 0, then the
        /// events are not suspended.
        /// </summary>
        private Int32 propertyEventSuspendCount = 0;

        #endregion // End IPropertyNotification Properties/Fields

        #region IDisposable Members

        public void Dispose()
        {
            GC.SuppressFinalize(this);
        }

        #endregion

        #region IPropertyNotification Events
        /// <summary>
        /// Handles the PropertyChanged event of the Object
        /// </summary>
        /// <param name="sender">The source of the event.</param>
        /// <param name="e">The <see cref="System.ComponentModel.PropertyChangedEventArgs"/> instance containing the event data.</param>
        private void ModelItemBase_PropertyChanged(Object sender, PropertyChangedEventArgs e)
        {
            //if (0 == String.Compare(e.PropertyName, "PropagatePropertyNotifications", true))
            //    return;

            //String text = String.Empty;
            //if (e is ListPropertyNotificationEventArgs)
            //{
            //    ListPropertyNotificationEventArgs e2 = e as ListPropertyNotificationEventArgs;
            //    switch (e2.Operation)
            //    {
            //        case ListOperation.Add:
            //            text = String.Format("The item '{0}' was added to the collection property '{1}' at index {2}.",
            //                (null == e2.NewValue) ? "<null>" : e2.NewValue.ToString(),
            //                e2.PropertyName,
            //                e2.Index);
            //            break;
            //        case ListOperation.Clear:
            //            text = String.Format("The collection property '{0}' was cleared.",
            //                e.PropertyName);
            //            break;
            //        case ListOperation.Insert:
            //            text = String.Format("The item '{0}' was inserted into the collection property '{1}' at index {2}.",
            //                (null == e2.NewValue) ? "<null>" : e2.NewValue.ToString(),
            //                e2.PropertyName,
            //                e2.Index);
            //            break;
            //        case ListOperation.Remove:
            //            text = String.Format("The item '{0}' in the collection property '{1}' at index {2} was removed.",
            //                (null == e2.OldValue) ? "<null>" : e2.OldValue.ToString(),
            //                e2.PropertyName,
            //                e2.Index);
            //            break;
            //        case ListOperation.Set:
            //            text = String.Format("The entry at index {0} of the collection property '{1}' was changed from '{2}' to '{3}'.",
            //                e2.Index,
            //                e2.PropertyName,
            //                (null == e2.OldValue) ? "<null>" : e2.OldValue.ToString(),
            //                (null == e2.NewValue) ? "<null>" : e2.NewValue.ToString());
            //            break;
            //    }
            //}
            //else if (e is PropertyNotificationEventArgs)
            //{
            //    PropertyNotificationEventArgs e2 = e as PropertyNotificationEventArgs;
            //    text = String.Format("The property '{0}' was changed from '{1}' to '{2}'.",
            //        e2.PropertyName,
            //        (null == e2.OldValue) ? "<null>" : e2.OldValue.ToString(),
            //        (null == e2.NewValue) ? "<null>" : e2.NewValue.ToString());
            //}
            //else
            //{
            //    text = String.Format("The property '{0}' was changed.",
            //        e.PropertyName);
            //}

            //MessageBox.Show(this, text, "Notify Test",
            //    MessageBoxButtons.OK,
            //    MessageBoxIcon.Information);
            this.MarkDirty();
        }

        /// <summary>
        /// Handles the PropertyChanging event of the Object
        /// </summary>
        /// <param name="sender">The source of the event.</param>
        /// <param name="e">The <see cref="NotifyTest.CancelPropertyNotificationEventArgs"/> instance containing the event data.</param>
        private void ModelItemBase_PropertyChanging(Object sender, CancelPropertyNotificationEventArgs e)
        {
            //if (0 == String.Compare(e.PropertyName, "PropagatePropertyNotifications", true))
            //    return;

            //String text = String.Empty;
            //if (e is ListCancelPropertyNotificationEventArgs)
            //{
            //    ListCancelPropertyNotificationEventArgs e2 = e as ListCancelPropertyNotificationEventArgs;
            //    switch (e2.Operation)
            //    {
            //        case ListOperation.Add:
            //            text = String.Format("Would you like to add the item '{0}' to the collection property '{1}' at index {2}?",
            //                (null == e2.NewValue) ? "<null>" : e2.NewValue.ToString(),
            //                e2.PropertyName,
            //                e2.Index);
            //            break;
            //        case ListOperation.Clear:
            //            text = String.Format("Would you like to clear the collection property '{0}'?",
            //                e.PropertyName);
            //            break;
            //        case ListOperation.Insert:
            //            text = String.Format("Would you like to insert the item '{0}' to the collection property '{1}' at index {2}?",
            //                (null == e2.NewValue) ? "<null>" : e2.NewValue.ToString(),
            //                e2.PropertyName,
            //                e2.Index);
            //            break;
            //        case ListOperation.Remove:
            //            text = String.Format("Would you like to remove the item '{0}' from the collection property '{1}' at index {2}?",
            //                (null == e2.OldValue) ? "<null>" : e2.OldValue.ToString(),
            //                e2.PropertyName,
            //                e2.Index);
            //            break;
            //        case ListOperation.Set:
            //            text = String.Format("Would you like to change the entry at index {0} of the collection property '{1}' from '{2}' to '{3}'?",
            //                e2.Index,
            //                e2.PropertyName,
            //                (null == e2.OldValue) ? "<null>" : e2.OldValue.ToString(),
            //                (null == e2.NewValue) ? "<null>" : e2.NewValue.ToString());
            //            break;
            //    }
            //}
            //else
            //{
            //    text = String.Format("Would you like to change the property '{0}' from '{1}' to '{2}'?",
            //        e.PropertyName,
            //        (null == e.OldValue) ? "<null>" : e.OldValue.ToString(),
            //        (null == e.NewValue) ? "<null>" : e.NewValue.ToString());
            //}

            //DialogResult dr = MessageBox.Show(this, text, "Notify Test",
            //    MessageBoxButtons.YesNo,
            //    MessageBoxIcon.Question);
            //if (DialogResult.No == dr)
            //    e.Cancel = true;
        }
        #endregion //End IPropertyNotification Events

        #region IValidatable
        //private Boolean m_IsValid = false;
        //[DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
        //[Browsable(true)]
        //[Display(AutoGenerateField = false)]
        //public virtual Boolean IsValid
        //{
        //    get
        //    {
        //        return m_IsValid;
        //    }
        //}

        //public virtual bool Validate()
        //{
        //    throw new NotImplementedException();
        //}

        //public virtual List<object> ValidationResults
        //{
        //    get { throw new NotImplementedException(); }
        //}
        #endregion //IValidatable
    }   
}
