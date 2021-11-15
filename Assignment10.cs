//Abigail Sikora
//IS 350 Assignment 10
//This program keeps track of a restaurant's info such as its menu items and if it's open 

using System;

namespace Assignment10
{
    class Restaurant
    {
        static int storeCounter=0;//used to keep track of restaurant items created
        string[] mArray;
        int storeID;
        bool isOpen;
        Restaurant()
        {
            storeID = storeCounter;
            storeCounter++;
            isOpen = true;
            mArray = new string[3];

        }
        Restaurant(int size, bool o)
        {
            storeID = storeCounter;
            storeCounter++;//incrementing the storeCounter variable 
            isOpen = o;
            mArray = new string[size];
        }

        void setMenu()
        {
            Console.WriteLine("Enter menu items in");
            for(int i=0; i<mArray.Length; i++)
            {
                Console.WriteLine("Enter a menu item for index {0}", i);
                string item = Console.ReadLine();
                mArray[i] = item;
            }
        }

        void setMenuEasy()
        {
            mArray[0] = "Hamburger";
            mArray[1] = "Hot dog";
            mArray[2] = "Pizza";
        }

        void restaurantDetails()
        {
            Console.WriteLine("The store ID is {0}", storeID);
            Console.WriteLine("The menu items are:");
            for(int i=0; i<mArray.Length; i++)//loops through the menu items to print each one
            {
                Console.WriteLine(mArray[i]);
            }
            if (isOpen == true)
            {
                Console.WriteLine("The store is open");
            }
            else
            {
                Console.WriteLine("The store is closed");
            }
        }
        static void Main(string[] args)
        {
            Restaurant r1 = new Restaurant();//creating a restaurant object using the default constructor
            Restaurant r2 = new Restaurant(4, true);//creating a restaurant object using the parameterized ctor
            Restaurant r3 = new Restaurant(3, false);

            r1.setMenuEasy();//populating the menu items for r1
            r3.setMenuEasy();
            r2.setMenu();

            //printing each of the restuarant's info
            r1.restaurantDetails();
            r2.restaurantDetails();
            r3.restaurantDetails();

            Console.WriteLine("Press enter to exit");
            Console.ReadLine();

        }
    }
}
