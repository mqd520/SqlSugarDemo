﻿using System;

using SqlSugar;

namespace SqlSugarDemo.Entity
{
    //Employees
    [SugarTable("Employees")]
    public class Employees
    {
        /// <summary>
        /// EmployeeId
        /// </summary>
        [SugarColumn(IsPrimaryKey = true, IsIdentity = true, ColumnName = "EmployeeID")]
        public virtual int EmployeeId
        {
            get;
            set;
        }
        /// <summary>
        /// LastName
        /// </summary>
        public virtual string LastName
        {
            get;
            set;
        }
        /// <summary>
        /// FirstName
        /// </summary>
        public virtual string FirstName
        {
            get;
            set;
        }
        /// <summary>
        /// Title
        /// </summary>
        public virtual string Title
        {
            get;
            set;
        }
        /// <summary>
        /// TitleOfCourtesy
        /// </summary>
        public virtual string TitleOfCourtesy
        {
            get;
            set;
        }
        /// <summary>
        /// BirthDate
        /// </summary>
        public virtual DateTime? BirthDate
        {
            get;
            set;
        }
        /// <summary>
        /// HireDate
        /// </summary>
        public virtual DateTime? HireDate
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
        /// HomePhone
        /// </summary>
        public virtual string HomePhone
        {
            get;
            set;
        }
        /// <summary>
        /// Extension
        /// </summary>
        public virtual string Extension
        {
            get;
            set;
        }
        /// <summary>
        /// Notes
        /// </summary>
        public virtual string Notes
        {
            get;
            set;
        }
        /// <summary>
        /// ReportsTo
        /// </summary>
        public virtual int? ReportsTo
        {
            get;
            set;
        }
    }
}