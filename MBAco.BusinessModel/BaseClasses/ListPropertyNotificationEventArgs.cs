
using System;
using System.ComponentModel;

namespace MBAco.BusinessModel
{
	/// <summary>
	/// This class extends <see cref="T:PropertyNotificationEventArgs"/> to
	/// support objects that implement the <see cref="T:IList{T}"/> interface.
	/// </summary>
	public class ListPropertyNotificationEventArgs : PropertyNotificationEventArgs {
		#region Constructors

		/// <summary>
		/// Initializes a new instance of the
		/// <see cref="ListPropertyNotificationEventArgs"/> class.
		/// </summary>
		/// <param name="propertyName">
		/// The name of the property that is associated with this
		/// notification.
		/// </param>
		public ListPropertyNotificationEventArgs(String propertyName)
			: base(propertyName) {
			this.index = -1;
			this.operation = ListOperation.Unknown;
		}

		/// <summary>
		/// Initializes a new instance of the
		/// <see cref="ListPropertyNotificationEventArgs"/> class.
		/// </summary>
		/// <param name="propertyName">
		/// The name of the property that is associated with this
		/// notification.
		/// </param>
		/// <param name="oldValue">The old value.</param>
		/// <param name="newValue">The new value.</param>
		public ListPropertyNotificationEventArgs(String propertyName,
			Object oldValue, Object newValue)
			: base(propertyName, oldValue, newValue) {
			this.index = -1;
			this.operation = ListOperation.Unknown;
		}

		/// <summary>
		/// Initializes a new instance of the
		/// <see cref="ListPropertyNotificationEventArgs"/> class.
		/// </summary>
		/// <param name="propertyName">The name of the property that is associated with this
		/// notification.</param>
		/// <param name="operation">The operation.</param>
		/// <param name="index">The index.</param>
		/// <param name="oldValue">The old value.</param>
		/// <param name="newValue">The new value.</param>
		public ListPropertyNotificationEventArgs(String propertyName,
			ListOperation operation, Int32 index,
			Object oldValue, Object newValue)
			: base(propertyName, oldValue, newValue) {
			this.index = index;
			this.operation = operation;
		}

		#endregion // Constructors

		#region Properties/Fields

		/// <summary>
		/// Holds the index into the list that was affected by the
		/// operation.
		/// </summary>
		private Int32 index;

		/// <summary>
		/// Gets the index into the list that was affected by the
		/// operation.
		/// </summary>
		/// <value>The index.</value>
		public Int32 Index {
			get {
				return this.index;
			}
		}

		/// <summary>
		/// Holds the operation that was performed on the list.
		/// </summary>
		private ListOperation operation;

		/// <summary>
		/// Gets the operation that was performed on the list.
		/// </summary>
		/// <value>The operation.</value>
		public ListOperation Operation {
			get {
				return this.operation;
			}
		}

		#endregion // Properties/Fields
	} 
}
