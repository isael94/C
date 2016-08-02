using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace backend.Models
{
    public class Apprentice
    {
        int id;
        public int Id
        {
            set; get;
        }


        private string name;

        public string Name
        {
            get { return name; }
            set { name = value; }
        }

        /*   public void SetId(int i)
{
            id = i;
              }
       public int GetId()
        {
           return id;
          }*/

    }
}