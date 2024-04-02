using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace composition
{
    public class Author
    {
        private string name;
        private char gender;
        private string email;
        
        public Author(string name, char gender, string email){
            this.name = name;
            this.gender = gender;
            this.email = email;
        }
        public Author(){}
        public string GetName(){
            return name;
        }
        public void SetName(string name){
            this.name = name;
        }
        public char GetGender(){
            return gender;
        }
        public void SetGender(char gender){
            this.gender = gender;
        }
        public string GetEmail(){
            return email;
        }
        public void SetEmail(string email){
            this.email = email;
        }
        public override string ToString(){
            return $"Name = {name}, Email = {email}, Gender = {gender}";
        }
    }
}