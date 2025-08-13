using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExceptionsLibrary
{

	[Serializable]
	public class InvalidCompanyNameException : Exception
	{
		public InvalidCompanyNameException() { }
		public InvalidCompanyNameException(string message) : base(message) { }
		public InvalidCompanyNameException(string message, Exception inner) : base(message, inner) { }
		protected InvalidCompanyNameException(
		  System.Runtime.Serialization.SerializationInfo info,
		  System.Runtime.Serialization.StreamingContext context) : base(info, context) { }
	}
}
