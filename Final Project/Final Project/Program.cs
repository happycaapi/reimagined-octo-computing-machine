using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Final_Project
{
    //create structure item, making it public
    public struct item
    {
        public int item_no;
        public string item_description;
        public int item_quantity;
        public double item_price;
        public double item_retailprice;
        public double item_value;

    }

    class Program
    {
        static void Main(string[] args)
        {
            //intialize the number of items
            //give max number of different items 100
            var numberofitems = 0;
            var items = new item[100];
            /*create while loop to hold men open to decideto add item,
             * change item, delete an item, list all items in database,
             * or close list (quit)*/

            while (true)
            {

                Console.Write("A)dd C)hange D)elete L)ist items:");
                var choice = Console.ReadLine();//establishes the option, used in the switch below

                switch (choice)
                {
                    case "A"://makes so either capital or lower-case works for the switch
                    case "a"://
                        {

                            Console.Write("Item Number :");
                            var item_no = Console.ReadLine();
                            
                         

                                Console.Write("Item :");
                                var item_description = Console.ReadLine();
                         
                                Console.Write("Price per item:");
                                var item_price = Console.ReadLine();

                                Console.Write("Quantity in stock:");
                                var item_quantity = Console.ReadLine();

                                Console.Write("Retail Price per Item:");
                                var item_retailprice = Console.ReadLine();

                            items[numberofitems].item_no = int.Parse(item_no);

                            for (int x = 1; x < numberofitems; x++)  //havent gotten this working yet
                            {
                                if (items[x].item_no == int.Parse(item_no))
                                {

                                    Console.WriteLine("There is already an item that contains that number!!");
                                    goto case "a";
                                }
                                else
                                {
                                    goto case "a";
                                }


                            }


                            // Always add the pet at the end of the array
                            try
                            {
                            
                                items[numberofitems].item_description = item_description;// throws item description added into structure
                                items[numberofitems].item_price = double.Parse(item_price);// 
                                items[numberofitems].item_quantity = int.Parse(item_quantity);// 
                                items[numberofitems].item_retailprice = double.Parse(item_retailprice);//
                                items[numberofitems].item_value = items[numberofitems].item_quantity * items[numberofitems].item_retailprice;
                            }
                            catch (System.FormatException)
                            {
                                Console.WriteLine("invalid input");
                                break;

                            }
                                numberofitems++;//makes so the item you added is included to number of items
                                break;
                            }
                        

                        
                        

                    case "c": //change
                    case "C":
                        { 
                        Console.Write("Please enter an item ID No:");
                        string strchgid = Console.ReadLine();
                        int chgid = int.Parse(strchgid);
                        bool fFound = false;

                        for (int x = 0; x < numberofitems; x++)
                        {
                                if (items[x].item_no == chgid)
                                {
                                    fFound = true;
                                    // code to show what has to happen if the item in the list is found
                                    // reset the count to show a new count for your list 
                                    // (Note: your list is now increased by one item)
                                    Console.WriteLine("Please select the attribute of the item you would like to change:");
                                    Console.WriteLine("(1)item no");
                                    Console.WriteLine("(2)item description");
                                    Console.WriteLine("(3)item price");
                                    Console.WriteLine("(4)item quantity");
                                    Console.WriteLine("(5)item retail price");
                                    var choice2 = Console.ReadLine();//establishes the option, used in the switch below
                                    switch (choice2)
                                    {
                                        case "1":
                                            {
                                                Console.WriteLine("Please input the item number you would like this item to have:");
                                                string temporary_itemno = Console.ReadLine();
                                                items[x].item_no = int.Parse(temporary_itemno);
                                                Console.WriteLine("The item number has been changed:");
                                                break;
                                            }
                                        case "2":
                                            {
                                                Console.WriteLine("Please input the item description you would like this item to have:");
                                                string temporary_descript = Console.ReadLine();
                                                items[x].item_description = (temporary_descript);
                                                Console.WriteLine("The item description has been changed:");
                                                break;
                                            }
                                        case "3":
                                            {
                                                Console.WriteLine("Please input the cost of this item:");
                                                string temporary_itemcost = Console.ReadLine();
                                                items[x].item_price = int.Parse(temporary_itemcost);
                                                Console.WriteLine("The item price (cost) has been changed:");
                                                break;
                                            }
                                        case "4":
                                            {
                                                Console.WriteLine("Please input the quantity of this item:");
                                                string temporary_quant = Console.ReadLine();
                                                items[x].item_no = int.Parse(temporary_quant);
                                                Console.WriteLine("The item number has been changed:");
                                                break;
                                            }
                                        case "5":
                                            {
                                                Console.WriteLine("Please input the retail price of this item:");
                                                string temporary_retail = Console.ReadLine();
                                                items[x].item_no = int.Parse(temporary_retail);
                                                Console.WriteLine("The retail price of this item has been changed:");
                                                break;
                                            }
                                        default://default for if one of the choices is not selected,
                                            {
                                                Console.WriteLine("Invalid option");
                                                break;
                                            }
                                    }

                                }


                                    if (!fFound) // and if not found
                                    {
                                        Console.WriteLine("Item {0} not found", chgid);
                                    }

                                    break;

                                }

                            break;
                        }
     

                    case "d": //delete 
                    case "D":
                        {
                            if (numberofitems == 0)
                            {
                                Console.WriteLine("No inventory");//ensures no error for if there are zero items
                                break;
                            }
                            Console.Write("Please enter ID Number of the item you wish to delete:");
                            string deleto = Console.ReadLine();
                            int deletoint = int.Parse(deleto);
                            bool fFound = false;

                            for (int x = 0; x < numberofitems; x++)
                            {
                                if (items[x].item_no == deletoint)
                                {
                                    fFound = true;

                                    // Squish the array from index to the end


                                    {
                                        // Just copy the item from the next index into the current index
                                        items[x] = items[x + 1];
                                    }

                                    // We have one less item
                                    numberofitems--;

                                    break;
                                }

                            }
                            break;
                        }


                    case "L": //choice for listing items
                    case "l":
                        {
                            if (numberofitems == 0)
                            {
                                Console.WriteLine("No inventory");
                            }
                            Console.WriteLine("item no  item             price       quantity        retail price        value");
                            for (int index = 0; index < numberofitems; index++)
                            {
                                
                                Console.WriteLine("{0}. {1, -15} {2, -15} {3, -10} {4, -10} {5, -10} {6, -5}", index + 1,items[index].item_no, items[index].item_description, items[index].item_price, items[index].item_quantity, items[index].item_retailprice, items[index].item_value);// displays the items in the good form
                            }

                            break;
                        }
                    default://default for if one of the choices is not selected,delete add or list.
                        {
                            Console.WriteLine("Invalid option [{0}]", choice);
                            break;
                        }
                }

            }
        }
    }
}
