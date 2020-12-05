﻿using System;

using SqlSugar;

namespace SqlSugarDemo.Entity
{
    //Customers
    [SugarTable("customers")]
    public class Customers
    {
        /// <summary>
        /// CustomerId
        /// </summary>
        [SugarColumn(IsPrimaryKey = true, ColumnName = "CustomerID")]
        public virtual string CustomerId
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
        /// ContactName
        /// </summary>
        public virtual string ContactName
        {
            get;
            set;
        }
        /// <summary>
        /// ContactTitle
        /// </summary>
        public virtual string ContactTitle
        {
            get;
            set;
        }
        /// <summary>
        /// Address
        /// </summary>
        public virtual string Address
        {
            get;
            set;
        }
        /// <summary>
        /// City
        /// </summary>
        public virtual string City
        {
            get;
            set;
        }
        /// <summary>
        /// Region
        /// </summary>
        public virtual string Region
        {
            get;
            set;
        }
        /// <summary>
        /// PostalCode
        /// </summary>
        public virtual string PostalCode
        {
            get;
            set;
        }
        /// <summary>
        /// Country
        /// </summary>
        public virtual string Country
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
        /// Fax
        /// </summary>
        public virtual string Fax
        {
            get;
            set;
        }

    }
}