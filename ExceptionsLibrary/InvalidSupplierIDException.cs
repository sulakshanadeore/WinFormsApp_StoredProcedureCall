namespace ExceptionsLibrary
{

	[Serializable]
	public class InvalidSupplierIDException : Exception
	{
		public InvalidSupplierIDException() { }
		public InvalidSupplierIDException(string message) : base(message) { }
		public InvalidSupplierIDException(string message, Exception inner) : base(message, inner) { }
		protected InvalidSupplierIDException(
		  System.Runtime.Serialization.SerializationInfo info,
		  System.Runtime.Serialization.StreamingContext context) : base(info, context) { }
	}
}
