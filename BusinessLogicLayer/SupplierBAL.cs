using DAL;
using ExceptionsLibrary;
namespace BusinessLogicLayer
{
    public class SupplierBAL
    {
		private int _SupplierID;

		public int SupplierID
		{
			get { return _SupplierID; }
			set {

				if (value!=0)
				{
                    _SupplierID = value;

                }
				else
				{
					throw new InvalidSupplierIDException("Pls input valid supplier id, it cannot be less than or equal to zero");
				}

			}
		}

		private string _companyName;

		public string CompanyName
		{
			get { return _companyName; }
			set
			{
				if (value != null && value.Length > 40 && value.Length != 0)
				{
					_companyName = value;
				}
				else
				{
					throw new InvalidCompanyNameException("Name must be less than or equal to 40 chars, it cannot be null, it cannot be empty");
				}
			}
		}
        public string ContactTitle { get; set; }

        public string ContactName { get; set; }
        public string Address { get; set; }

        public string City { get; set; }

        SupplierOperations supp_operations=new SupplierOperations();

		public bool NewSupplier()
		{

			Supplier obj = new Supplier();
			//obj.SupplierID = this.SupplierID;
			obj.CompanyName=this.CompanyName;
			obj.ContactName = this.ContactName;
			obj.ContactTitle = this.ContactTitle;
			obj.Address = this.Address;
			obj.City = this.City;
			return supp_operations.AddSupplier(obj);

		}




	}
}
