﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;



namespace CatSystem
{
   public class Owner
    {
        private string firstName; 
        private string lastName;

        private List<Cat> cats;
       

        public Owner(string firstName, string lastName )
        {
            this.firstName = FirstName;
            this.lastName = LastName;
            this.Age = 0;
            this.cats = new List<Cat>();
        }

        public string FirstName 
        {
            get
            {
                return this.firstName;
            }
            
        }

        public string LastName
        {
            get
            {
                return this.lastName;
            }
        }

        public string FullName
        {
            get
            {
                return string.Format("{0} {1}", this.firstName, this.lastName);
            }

        }


        public int Age { get; private set; }

        public string AllCats
        {
            get
            {
                return string.Join(", ", this.cats.Select(c => c.Name));
            }
        }

        public void IncreaseAge()
        {
            this.Age++;
        }

        public void AddCat(Cat cat, string name)
        {
            if(this.cats.Contains(cat))
            {
                throw new ArgumentException("This owner already has this cat! " + cat.Name);
            }

            this.cats.Add(cat);
            cat.Name = name;
            cat.Owner = this; 
        }

    }
}
