using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace class_3_27
{
    public class AudioBook : Book
    {
        private int listeningTime;

        public int GetListeningTime(){
            return listeningTime;
        }
        public void SetListeningTime(int listeningTime){
            this.listeningTime = listeningTime;
        }
        public override void Read(){
            System.Console.WriteLine("I am listening to the book");
        }
    }
}