
using System;
using System.Collections.Generic;
using System.Text;

namespace MBAco.BusinessModel
{
	/// <summary>
	/// This enumeration holds all the possible operations that can
	/// be performed on an object that supports the 
	/// <see cref="T:IList{T}"/> interface.
	/// </summary>
	public enum ListOperation {
		/// <summary>
		/// Indicates that operation is unknown.
		/// </summary>
		Unknown,

		/// <summary>
		/// Indicates that operation is <see cref="M:IList{T}.Add"/>.
		/// </summary>
		Add,

		/// <summary>
		/// Indicates that operation is <see cref="M:IList{T}.Remove"/>
		/// or <see cref="M:IList{T}.RemoveAt"/>.
		/// </summary>
		Remove,

		/// <summary>
		/// Indicates that operation is <see cref="M:IList{T}.Insert"/>.
		/// </summary>
		Insert,

		/// <summary>
		/// Indicates that operation is <see cref="M:IList{T}.Clear"/>.
		/// </summary>
		Clear,

		/// <summary>
		/// Indicates that operation is <see cref="M:IList{T}.Item[Int32]"/>.
		/// </summary>
		Set
	}   
}
