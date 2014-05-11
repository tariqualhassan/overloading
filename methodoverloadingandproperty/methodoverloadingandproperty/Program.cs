using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace methodoverloadingandproperty
{
    class Box
    {
        private int length;
        private int width;
        private int height;
        

        //property
        public int Length
        {
            get
            {
                return length;
            }

            set
            {
                length=value;
            }
        }

            public void DisplayBox()
            {
             Console.WriteLine ("Length: {0}, width: {1}, height: {2}", length, width,height);

            }
        public Box (int length, int width, int height)
        {
            this.length=length;
            this.width=width;
            this.height=height;
        }


    }
        class Tester
        {
            public void Run()
            {
                Box newbox = new Box (5,25,14);
                newbox.DisplayBox();

                //accessing a contructor value whic is private to Box class from another class named Tester
                int len= newbox.Length;
                Console.WriteLine ("the value of length is:{0}", len);
                //incrementing the value
                len++;
                Console.WriteLine ("the value of length is now:{0}",len);

                //asssign the new value to the property via set accessor
                newbox.Length=len;
                newbox.DisplayBox();
            }

            static void Main()
            {
                Tester test = new Tester();
                test.Run();

            }
            
        } 

      

        }
        
    

   

