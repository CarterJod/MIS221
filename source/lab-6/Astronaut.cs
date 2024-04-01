using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace lab_6
{
    public class Astronaut
    {
        private string name;
        private int age;
        private int hours;
        public Astronaut(string name, int age){
            this.name = name;
            this.age = age;
            this.hours = 0;
        }
        public void AddHours(int hoursToAdd){
            this.hours += hoursToAdd;
        }
        public int GetHours(){
            return this.hours;
        }
    }
}