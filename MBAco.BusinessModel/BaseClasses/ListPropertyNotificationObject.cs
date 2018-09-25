
using System;
using System.Collections;
using System.ComponentModel;

namespace MBAco.BusinessModel
{
	/// <summary>
	/// This class extends the class <see cref="T:PropertyNotificationObject"/>
	/// by adding helper methods for firing property change events from a 
	/// list.
	/// </summary>
	public class ListPropertyNotificationObject : PropertyNotificationObject {
		#region Methods

		/// <summary>
		/// Raises the <see cref="E:PropertyChanged"/> event.
		/// </summary>
		/// <param name="propertyName">Name of the property that changed.</param>
		/// <param name="operation">The operation.</param>
		protected void OnPropertyChanged(String propertyName,
			ListOperation operation) {
			if (true == this.PropertyEventsSuspended)
				return;

			ListPropertyNotificationEventArgs e = new ListPropertyNotificationEventArgs(propertyName,
				operation, -1, null, null);
			OnPropertyChanged(e);
		}

		/// <summary>
		/// Raises the <see cref="E:PropertyChanged"/> event.
		/// </summary>
		/// <param name="propertyName">Name of the property that changed.</param>
		/// <param name="operation">The operation.</param>
		/// <param name="index">The index.</param>
		/// <param name="oldValue">The old value.</param>
		/// <param name="newValue">The new value.</param>
		protected void OnPropertyChanged(String propertyName,
			ListOperation operation, Int32 index,
			Object oldValue, Object newValue) {
			if (true == this.PropertyEventsSuspended)
				return;

			ListPropertyNotificationEventArgs e = new ListPropertyNotificationEventArgs(propertyName,
				operation, index, oldValue, newValue);
			OnPropertyChanged(e);
		}

		/// <summary>
		/// Raises the <see cref="E:PropertyChanging"/> event.
		/// </summary>
		/// <param name="propertyName">Name of the property that is changing.</param>
		/// <param name="operation">The operation.</param>
		/// <returns>
		/// 	<c>true</c> if the change can continue; otherwise <c>false</c>.
		/// </returns>
		protected Boolean OnPropertyChanging(String propertyName,
			ListOperation operation) {
			if (true == this.PropertyEventsSuspended)
				return true;

			ListCancelPropertyNotificationEventArgs e = new ListCancelPropertyNotificationEventArgs(propertyName,
				operation, -1, null, null);
			OnPropertyChanging(e);
			return !e.Cancel;
		}

		/// <summary>
		/// Raises the <see cref="E:PropertyChanging"/> event.
		/// </summary>
		/// <param name="propertyName">Name of the property that is changing.</param>
		/// <param name="operation">The operation.</param>
		/// <param name="index">The index.</param>
		/// <param name="oldValue">The old value.</param>
		/// <param name="newValue">The new value.</param>
		/// <returns>
		/// 	<c>true</c> if the change can continue; otherwise <c>false</c>.
		/// </returns>
		protected Boolean OnPropertyChanging(String propertyName,
			ListOperation operation, Int32 index,
			Object oldValue, Object newValue) {
			if (true == this.PropertyEventsSuspended)
				return true;

			ListCancelPropertyNotificationEventArgs e = new ListCancelPropertyNotificationEventArgs(propertyName,
				operation, index, oldValue, newValue);
			OnPropertyChanging(e);
			return !e.Cancel;
		}

		#endregion // Methods
	} 
}
