using System;
using System.Collections.Generic;
using System.Text;

namespace ProjectFirst.Models
{
   public class Todo
    {
        private readonly int id;//Read only
        private String description;
        private bool done;
        private Person assignee ;

        public Todo()//Added automat
        {
        }

        //Constructer
        public Todo(int id, String description)
        {
            this.id = id;
            this.description = description;
         }
        //properties

        public int IdGet { get; }//Id read only
        public string Description
        {
            get { return description; }
            set { this.description = description; }
        }

        public bool Done { get; set; }

        public Person Assignee
        {
            get { return assignee; }
            set { this.assignee = assignee; }
        }




    }
}
