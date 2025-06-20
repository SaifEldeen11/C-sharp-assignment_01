using System;
namespace Session01_Saif
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region Variables Declaration & Value Type Data Types
            /*----------------------------------------*/
            /* so to declare a varibale u need this formula : dataType name and ; */
            // examples
            short SideOne = 5, SideTwo = 10, SideThree = 15;
            int Perimeter = (SideOne + SideTwo + SideThree);
            Console.WriteLine(Perimeter);


            long phoneNumber = 1234567890;
            Console.WriteLine(phoneNumber);



            short age = 25;
            Console.WriteLine(age);
            
            string SaifEldeen = "Saif Eldeen";
            Console.WriteLine(SaifEldeen);
            /* for the Value Type Data Types part take a look for this example */
            int x = 5, y = 9;

            Console.WriteLine(x); // 5
            Console.WriteLine(y); // 9

            y = x;
            x++;

            Console.WriteLine(x); //6
            Console.WriteLine(y); //5

            /*----------------------------------------*/
            #endregion

            #region Reference Type Data Types
            /*----------------------------------------*/
            point p1; // new pointer with dataType point now the reference is pointing to null  
            p1 = new point(); // But here the pointer is referring to a place in memory (Heap)
            Console.WriteLine(p1.x);  // here will be 0 as there is no values assigned

            p1.x = 7;
            p1.y = 9;

            Console.WriteLine(p1.x);
            Console.WriteLine(p1.y);


            point p2 = new point();


            points3D p3 = new points3D();
            p3.x = 10;
            p3.y = 20;
            p3.z = 30;
            /*----------------------------------------*/
            #endregion

            #region Objects
            /*----------------------------------------*/
            /* The DataType Object is like any DataType but on steroids :)* /
            /* it can be any DataType it's like the Father of DataTypes */

            object obj;
            obj = new object();
            obj = new point();
            obj = new points3D();
            obj = new temp();
            obj = 1;
            obj = 3.14; ;
            obj = 'h';
            obj = " AnyThing ";

            /*  small exercise on the objects  */

            static void  print (object x, object y){
                Console.WriteLine(x);
                Console.WriteLine(y);
            }

            /* other way to make it */
            static void prints <T> (T x, T y)
            {
                Console.WriteLine(x);
                Console.WriteLine(y);
            }

            print(4, 5);
            print("Hello", "World");
            print(3.1, 5.2);

            prints(4, 5);
            prints("Hello", "World");
            prints(3.1, 5.2);



            #endregion

            #region Some Built In Functions
            /*----------------------------------------*/

            string name = "Saif Eldeen";
            string name2 = "Saif Eldeen";

            /* Returns a string representation of the current object */
            /* Most Data type overrides this function */
            /*i wanted to notice you that i overroad this function */

            Console.WriteLine(x.ToString()); // value of x not int 
            Console.WriteLine(name.ToString()); // Saif Eldeen
            Console.WriteLine(p1.ToString());

            /*Gets the hash code of the place it is stored in the memory based on the reference*/
            Console.WriteLine(x.GetHashCode());
            Console.WriteLine(name.GetHashCode());
            Console.WriteLine(p1.GetHashCode());

            /* Checks if somthing is equal to something */
            /*i wanted to notice you that i overroad this function */

            Console.WriteLine(x.Equals(y)); // not true
            Console.WriteLine(name.Equals(name2)); // true 
            Console.WriteLine(p1.Equals(p2)); // not true 


            /* like its name gets the dataType of somthing */

            Console.WriteLine(x.GetType());
            Console.WriteLine(name.GetType());
            Console.WriteLine(p1.GetType());

            /*----------------------------------------*/
            #endregion

        }
    }
    
}
