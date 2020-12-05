using System;

namespace SqlSugarDemo.Entity
{
	 	//Shippers
		public class Shippers
	{
	
      	/// <summary>
		/// ShipperId
        /// </summary>
        public virtual int ShipperId
        {
            get; 
            set; 
        }        
		/// <summary>
		/// CompanyName
        /// </summary>
        public virtual string CompanyName
        {
            get; 
            set; 
        }        
		/// <summary>
		/// Phone
        /// </summary>
        public virtual string Phone
        {
            get; 
            set; 
        }        
		/// <summary>
		/// Reference
        /// </summary>
        public virtual Guid Reference
        {
            get; 
            set; 
        }        
		   
	}
}