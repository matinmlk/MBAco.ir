
using System;
using System.ComponentModel;

namespace MBAco.BusinessModel
{
	/// <summary>
	/// This class implements the <see cref="T:IPropertyNotification"/>
	/// interface and provides helper methods for derived classes.
	/// </summary>
	public class PropertyNotificationObject : IPropertyNotification {
		#region IPropertyNotification

		/// <summary>
		/// Occurs when a property value changes.
		/// </summary>
		[field: NonSerialized]
		public event PropertyChangedEventHandler PropertyChanged;

		/// <summary>
		/// Occurs when a property value is changing.
		/// </summary>
		[field: NonSerialized]
		public event PropertyChangingEventHandler PropertyChanging;

		#endregion // IPropertyNotification

		#region Methods

		/// <summary>
		/// Adds event handlers for <see cref="T:IPropertyNotification"/>
		/// events, if the object supports that interface.
		/// </summary>
		/// <param name="obj">The obj.</param>
		protected void AddPropertyEventHandlers(Object obj) {
			IPropertyNotification propNotify = obj as IPropertyNotification;
			if (null != propNotify) {
				propNotify.PropertyChanged += new PropertyChangedEventHandler(SubObject_PropertyChanged);
				propNotify.PropertyChanging += new PropertyChangingEventHandler(SubObject_PropertyChanging);
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
			Object oldValue, Object newValue) {
			if (true == this.PropertyEventsSuspended)
				return;

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
		protected void OnPropertyChanged(PropertyChangedEventArgs e) {
			if (true == this.PropertyEventsSuspended)
				return;

			OnPropertyChanged(this, e);
		}

		/// <summary>
		/// Raises the <see cref="E:PropertyChanged"/> event.
		/// </summary>
		/// <param name="sender">The sender.</param>
		/// <param name="e">
		/// The <see cref="PropertyNotificationEventArgs"/> instance
		/// containing the event data.
		/// </param>
		protected void OnPropertyChanged(Object sender,
			PropertyChangedEventArgs e) {
			if (true == this.PropertyEventsSuspended)
				return;

			PropertyChangedEventHandler temp = this.PropertyChanged;
			if (null != temp)
				temp(sender, e);
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
			Object oldValue, Object newValue) {
			if (true == this.PropertyEventsSuspended)
				return true;

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
		protected void OnPropertyChanging(CancelPropertyNotificationEventArgs e) {
			if (true == this.PropertyEventsSuspended)
				return;

			OnPropertyChanging(this, e);
		}

		/// <summary>
		/// Raises the <see cref="E:PropertyChanging"/> event.
		/// </summary>
		/// <param name="sender">The sender.</param>
		/// <param name="e">
		/// The <see cref="CancelPropertyNotificationEventArgs"/> instance
		/// containing the event data.
		/// </param>
		protected void OnPropertyChanging(Object sender,
			CancelPropertyNotificationEventArgs e) {
			if (true == this.PropertyEventsSuspended)
				return;

			PropertyChangingEventHandler temp = this.PropertyChanging;
			if (null != temp)
				temp(sender, e);
		}

		/// <summary>
		/// Removes event handlers for <see cref="T:IPropertyNotification"/>
		/// events, if the object supports that interface.
		/// </summary>
		/// <param name="obj">The obj.</param>
		protected void RemovePropertyEventHandlers(Object obj) {
			IPropertyNotification propNotify = obj as IPropertyNotification;
			if (null != propNotify) {
				propNotify.PropertyChanged -= new PropertyChangedEventHandler(SubObject_PropertyChanged);
				propNotify.PropertyChanging -= new PropertyChangingEventHandler(SubObject_PropertyChanging);
			}
		}

		/// <summary>
		/// Resumes the <see cref="PropertyChanged"/> and
		/// <see cref="PropertyChanging"/> events.
		/// </summary>
		public void ResumePropertyEvents() {
			this.propertyEventSuspendCount--;
		}

		/// <summary>
		/// This method is used to set a property while firing associated
		/// PropertyChanging and PropertyChanged events.
		/// </summary>
		/// <param name="propertyName">Name of the property.</param>
		/// <param name="propertyField">The property field.</param>
		/// <param name="value">The value.</param>
		protected void SetProperty<T>(String propertyName, ref T propertyField,
			T value) {
			if (false == Object.Equals(value, propertyField)) {
				if (true == OnPropertyChanging(propertyName, propertyField, value)) {
					T oldValue = propertyField;
					propertyField = value;
					RemovePropertyEventHandlers(oldValue);
					AddPropertyEventHandlers(propertyField);
					OnPropertyChanged(propertyName, oldValue, propertyField);
				}
			}
		}

		/// <summary>
		/// Handles the PropertyChanged event of any sub-objects.
		/// </summary>
		/// <param name="sender">The source of the event.</param>
		/// <param name="e">The <see cref="System.ComponentModel.PropertyChangedEventArgs"/> instance containing the event data.</param>
		protected void SubObject_PropertyChanged(Object sender, PropertyChangedEventArgs e) {
			if (true == this.PropagatePropertyNotifications)
				OnPropertyChanged(sender, e);
		}

		/// <summary>
		/// Handles the PropertyChanging event of any sub-objects.
		/// </summary>
		/// <param name="sender">The source of the event.</param>
		/// <param name="e">The <see cref="NotifyTest.CancelPropertyNotificationEventArgs"/> instance containing the event data.</param>
		protected void SubObject_PropertyChanging(object sender, CancelPropertyNotificationEventArgs e) {
			if (true == this.PropagatePropertyNotifications)
				OnPropertyChanging(sender, e);
		}

		/// <summary>
		/// Suspends the <see cref="PropertyChanged"/> and
		/// <see cref="PropertyChanging"/> events.
		/// </summary>
		public void SuspendPropertyEvents() {
			this.propertyEventSuspendCount++;
		}

		#endregion // Methods

		#region Properties/Fields

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
		public Boolean PropagatePropertyNotifications {
			get {
				return this.propagatePropertyNotifications;
			}
			set {
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
		public Boolean PropertyEventsSuspended {
			get {
				return (0 != this.propertyEventSuspendCount);
			}
		}

		/// <summary>
		/// Holds the suspension count for the <see cref="PropertyChanged"/>
		/// and <see cref="PropertyChanging"/> events. When 0, then the
		/// events are not suspended.
		/// </summary>
		private Int32 propertyEventSuspendCount = 0;

		#endregion // Properties/Fields
	}  
}
