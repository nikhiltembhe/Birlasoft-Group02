using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace cs_con_IComparable
{
    internal class Employee : System.IComparable
    {       
        public int EmployeeID { get; set; }
        public string EmployeeName { get; set; }
        public string Designation { get; set; }


        #region System.IComparable interface members

        /// <summary>
        ///     This method is used during comparision and during sorting activities
        /// </summary>
        /// <param name="obj"></param>
        /// <returns>
        ///     0           if current object is equal to the other object
        ///     -negative   if current object (LHS) is lesser than the other object (RHS)
        ///     +positive   if current object (LHS) is greater than the other object (RHS)
        /// </returns>
        public int CompareTo(object obj)
        {
            Employee otherEmployee = obj as Employee;       // unboxing
            return this.EmployeeID.CompareTo(otherEmployee.EmployeeID);         // ASC on EmployeeID
            // return otherEmployee.EmployeeID.CompareTo(this.EmployeeID);      // DESC on EmployeeID
        }

        #endregion
    }
}
