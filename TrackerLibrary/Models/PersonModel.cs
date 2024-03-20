using System;
using System.Collections.Generic;
using System.Dynamic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TrackerLibrary
{
    public class PersonModel
    {
        public int Id { get; set; }

        /// <summary>
        /// represents first name of the person
        /// </summary>
        public string FirstName { get; set; }

        /// <summary>
        /// represents last name of the person
        /// </summary>
        public string LastName { get; set; }

        /// <summary>
        /// represents email address of the person
        /// </summary>

        public string EmailAddress { get; set; }

        /// <summary>
        /// represents cellphone number of the person
        /// </summary>
        public string CellphoneNumber { get; set; }

        public string FullName
        {
            get { return $"{FirstName} {LastName}"; }
        }
    }
}