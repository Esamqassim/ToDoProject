using System;
using System.Collections.Generic;
//using System.ComponentModel.DataAnnotations;
using System.Text;


namespace ProjectFirst.Models
{
   public class Person
    {
        private readonly int id;//Read only
        private String firstName;
        private String lastName;

        //constructor

        public Person(int id, String firstName, String lastName)
        {
            this.id = id;
            if (!(string.IsNullOrEmpty(firstName))) {
               
                this.firstName = firstName;                
            }
            if ( !(string.IsNullOrEmpty(lastName)))
            {
               
                this.lastName = lastName;
            }
        }
       
       

        public String FirstName
         {
             get => firstName;
             set
             {
                 if (!(string.IsNullOrEmpty(firstName)))
                 {
                     this.firstName = firstName;
                 }
             }
         }

       /* private bool IsNullOrEmpty(string firstName)//Will cause exception problem
         {
             throw new NotImplementedException();
         }*/

       


        public String LastName
        {
            get => lastName;
            set
            {
                if (!(string.IsNullOrEmpty(lastName)))
                {
                    this.lastName = lastName;
                }
            }
        }
        public int IdGet { get; }//Id read only
        public String FullName { get { return $"{FirstName} {LastName}"; } }

       

    }

   
}
