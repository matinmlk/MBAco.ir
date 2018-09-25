
using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;

namespace MBAco.BusinessModel
{
	/// <summary>
	/// This list supports the <see cref="T:IPropertyNotification"/>
	/// interface, but is otherwise identical to <see cref="T:List{T}"/>.
	/// </summary>
	[Serializable]
	public class PropertyNotificationList<T>
		: ListPropertyNotificationObject, ICollection<T>,
		IEnumerable<T>, IEnumerable, IList<T> {
		#region Constructors

		/// <summary>
		/// Initializes a new instance of the
		/// <see cref="PropertyNotificationList{T}"/> class.
		/// </summary>
		public PropertyNotificationList() {
			this.items = new List<T>();
		}

		/// <summary>
		/// Initializes a new instance of the
		/// <see cref="PropertyNotificationList{T}"/> class.
		/// </summary>
		/// <param name="collection">
		/// The collection whose elements are copied to the new list.
		/// </param>
		public PropertyNotificationList(IEnumerable<T> collection) {
			this.items = new List<T>(collection);
			foreach (T item in this.items)
				AddPropertyEventHandlers(item);
		}

		/// <summary>
		/// Initializes a new instance of the
		/// <see cref="PropertyNotificationList{T}"/> class.
		/// </summary>
		/// <param name="capacity">
		/// The number of elements that the new list can initially store.
		/// </param>
		public PropertyNotificationList(Int32 capacity) {
			this.items = new List<T>(capacity);
		}

		#endregion // Constructors

		#region ICollection<T>

		/// <summary>
		/// Adds an item to the <see cref="T:ICollection`1"/>.
		/// </summary>
		/// <param name="item">
		/// The object to add to the <see cref="T:ICollection`1"/>.
		/// </param>
		/// <exception cref="T:NotSupportedException">
		/// The <see cref="T:ICollection`1"/> is read-only.
		/// </exception>
		public void Add(T item) {
			Int32 index = this.items.Count;
			if (true == OnPropertyChanging("Item",
				ListOperation.Add, index, null, item)) {
				this.items.Add(item);
				AddPropertyEventHandlers(item);
				OnPropertyChanged("Item", ListOperation.Add,
					index, null, item);
			}
		}

		/// <summary>
		/// Removes all items from the <see cref="T:ICollection`1"/>.
		/// </summary>
		/// <exception cref="T:NotSupportedException">
		/// The <see cref="T:ICollection`1"/> is read-only.
		/// </exception>
		public void Clear() {
			if (true == OnPropertyChanging("Item", ListOperation.Clear)) {
				foreach (T item in this.items)
					RemovePropertyEventHandlers(item);
				this.items.Clear();
				OnPropertyChanged("Item", ListOperation.Clear);
			}
		}

		/// <summary>
		/// Determines whether the <see cref="T:ICollection`1"/> contains
		/// a specific value.
		/// </summary>
		/// <param name="item">
		/// The object to locate in the <see cref="T:ICollection`1"/>.
		/// </param>
		/// <returns>
		/// true if item is found in the <see cref="T:ICollection`1"/>;
		/// otherwise, false.
		/// </returns>
		public Boolean Contains(T item) {
			return this.items.Contains(item);
		}

		/// <summary>
		/// Copies the elements of the <see cref="T:ICollection`1"/> to an
		/// <see cref="T:Array"></see>, starting at a particular
		/// <see cref="T:Array"></see> index.
		/// </summary>
		/// <param name="array">
		/// The one-dimensional <see cref="T:Array"></see> that is the destination
		/// of the elements copied from <see cref="T:ICollection`1"/>. The
		/// <see cref="T:Array"></see> must have zero-based indexing.
		/// </param>
		/// <param name="arrayIndex">
		/// The zero-based index in array at which copying begins.
		/// </param>
		/// <exception cref="T:ArgumentOutOfRangeException">
		/// arrayIndex is less than 0.
		/// </exception>
		/// <exception cref="T:ArgumentNullException">
		/// array is null.
		/// </exception>
		/// <exception cref="T:ArgumentException">
		/// array is multidimensional.-or-arrayIndex is equal to or greater than
		/// the length of array.-or-The number of elements in the source
		/// <see cref="T:ICollection`1"/> is greater than the available space from
		/// arrayIndex to the end of the destination array.-or-Type T cannot be
		/// cast automatically to the type of the destination array.
		/// </exception>
		public void CopyTo(T[] array, Int32 arrayIndex) {
			this.items.CopyTo(array, arrayIndex);
		}

		/// <summary>
		/// Gets the number of elements contained in the
		/// <see cref="T:ICollection`1"/>.
		/// </summary>
		/// <value></value>
		/// <returns>
		/// The number of elements contained in the <see cref="T:ICollection`1"/>.
		/// </returns>
		public Int32 Count {
			get {
				return this.items.Count;
			}
		}

		/// <summary>
		/// Gets a value indicating whether the <see cref="T:ICollection`1"/>
		/// is read-only.
		/// </summary>
		/// <value></value>
		/// <returns>
		/// true if the <see cref="T:ICollection`1"/> is read-only; otherwise, false.
		/// </returns>
		public Boolean IsReadOnly {
			get {
				return false;
			}
		}

		/// <summary>
		/// Removes the first occurrence of a specific object from the
		/// <see cref="T:ICollection`1"/>.
		/// </summary>
		/// <param name="item">
		/// The object to remove from the <see cref="T:ICollection`1"/>.
		/// </param>
		/// <returns>
		/// true if item was successfully removed from the
		/// <see cref="T:ICollection`1"/>; otherwise, false. This method
		/// also returns false if item is not found in the original
		/// <see cref="T:ICollection`1"/>.
		/// </returns>
		/// <exception cref="T:NotSupportedException">
		/// The <see cref="T:ICollection`1"/> is read-only.
		/// </exception>
		public Boolean Remove(T item) {
			// Get the index of the item. if the item was not
			//   found then we won't be changing the list so
			//   skip property change events.
			Int32 index = IndexOf(item);
			if (index >= 0) {
				if (true == OnPropertyChanging("Item", ListOperation.Remove,
					index, item, null)) {
					RemovePropertyEventHandlers(item);
					this.items.RemoveAt(index);
					OnPropertyChanged("Item", ListOperation.Remove,
						index, item, null);
					return true;
				}
			}
			return false;
		}

		#endregion // ICollection<T>

		#region IEnumerable<T>

		/// <summary>
		/// Returns an enumerator that iterates through the collection.
		/// </summary>
		/// <returns>
		/// A <see cref="T:IEnumerator`1"></see> that can be used to iterate
		/// through the collection.
		/// </returns>
		public IEnumerator<T> GetEnumerator() {
			return this.items.GetEnumerator();
		}

		#endregion // IEnumerable<T>

		#region IEnumerable

		/// <summary>
		/// Returns an enumerator that iterates through a collection.
		/// </summary>
		/// <returns>
		/// An <see cref="T:IEnumerator"></see> object that can be used to
		/// iterate through the collection.
		/// </returns>
		IEnumerator IEnumerable.GetEnumerator() {
			return this.items.GetEnumerator();
		}

		#endregion // IEnumerable

		#region IList<T>

		/// <summary>
		/// Determines the index of a specific item in the <see cref="T:IList`1" />.
		/// </summary>
		/// <param name="item">
		/// The object to locate in the <see cref="T:IList`1"></see>.
		/// </param>
		/// <returns>
		/// The index of item if found in the list; otherwise, -1.
		/// </returns>
		public Int32 IndexOf(T item) {
			return this.items.IndexOf(item);
		}

		/// <summary>
		/// Inserts an item to the <see cref="T:IList`1"></see> at the specified
		/// index.
		/// </summary>
		/// <param name="index">
		/// The zero-based index at which item should be inserted.
		/// </param>
		/// <param name="item">
		/// The object to insert into the <see cref="T:IList`1"></see>.
		/// </param>
		/// <exception cref="T:NotSupportedException">
		/// The <see cref="T:IList`1"></see> is read-only.
		/// </exception>
		/// <exception cref="T:ArgumentOutOfRangeException">
		/// index is not a valid index in the <see cref="T:IList`1"></see>.
		/// </exception>
		public void Insert(Int32 index, T item) {
			if (index > this.items.Count)
				throw new ArgumentOutOfRangeException("index", index,
					"index is greater than the Count");

			// First get the existing item at the given index, because we want
			//   to use it in our property change events.
			T existingItem = default(T);
			if (index < this.items.Count)
				existingItem = this.items[index];

			if (true == OnPropertyChanging("Item", ListOperation.Insert, index,
					existingItem, item)) {
				this.items.Insert(index, item);
				AddPropertyEventHandlers(item);
				OnPropertyChanged("Item", ListOperation.Insert, index,
					existingItem, item);
			}
		}

		/// <summary>
		/// Removes the <see cref="T:IList`1"></see> item at the specified index.
		/// </summary>
		/// <param name="index">
		/// The zero-based index of the item to remove.
		/// </param>
		/// <exception cref="T:NotSupportedException">
		/// The <see cref="T:IList`1"></see> is read-only.
		/// </exception>
		/// <exception cref="T:ArgumentOutOfRangeException">
		/// index is not a valid index in the <see cref="T:IList`1"></see>.
		/// </exception>
		public void RemoveAt(Int32 index) {
			if (index >= this.items.Count)
				throw new ArgumentOutOfRangeException("index", index,
					"index is greater than or equal to the Count");

			// First get the existing item at the given index, because we want
			//   to use it in our property change events.
			T existingItem = this.items[index];

			if (true == OnPropertyChanging("Item", ListOperation.Remove, index,
					existingItem, null)) {
				RemovePropertyEventHandlers(existingItem);
				this.items.RemoveAt(index);
				OnPropertyChanged("Item", ListOperation.Remove,
					index, existingItem, null);
			}
		}

		/// <summary>
		/// Gets or sets the item at the specified index.
		/// </summary>
		/// <value></value>
		public T this[int index] {
			get {
				return this.items[index];
			}
			set {
				T existingItem = this.items[index];
				if (true == OnPropertyChanging("Item", ListOperation.Set, index,
						existingItem, value)) {
					RemovePropertyEventHandlers(existingItem);
					this.items[index] = value;
					AddPropertyEventHandlers(value);
					OnPropertyChanged("Item", ListOperation.Set, index,
						existingItem, value);
				}
			}
		}

		#endregion // IList<T>

		#region Methods

		/// <summary>
		/// Returns a <see cref="T:String" /> that represents the current
		/// <see cref="T:Object"/>.
		/// </summary>
		/// <returns>
		/// A <see cref="T:String"/> that represents the current
		/// <see cref="T:Object"/>.
		/// </returns>
		public override String ToString() {
			Int32 count = this.Count;
			if (0 == count)
				return "(No items)";
			else if (1 == count)
				return "(1 item)";
			else
				return String.Format("({0} items)", count);
		}

		#endregion // Methods

		#region Properties/Fields

		/// <summary>
		/// Holds the items contained in this list.
		/// </summary>
		private List<T> items;

		#endregion // Properties/Fields
	}
}
