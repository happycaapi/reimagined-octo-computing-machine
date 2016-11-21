//Assignment #6

//Copy this block into your Visual Studio.

// Review and Redo this code line by line at home.  

// Place comments on each line and describe what the code is doing

using System;

namespace ConsoleApplication1
{
    public struct Pet //creating the structure pet, making it public
    {
        public string Name; //creating a name for the pet
        public string TypeOfPet;//creating the type of pet
    }

    class Program
    {
        static void Main()
        {
            var numberOfPets = 0;//intialize number of pets
            var pets = new Pet[10];//max list of 10 pets, var pet is now of struct pet, has a name and type

            while (true)//while loop allows the decision making prompt to stay open, can make more than one decision
            {
                Console.Write("A)dd D)elete L)ist pets:");
                var choice = Console.ReadLine();//establishes the option, used in the switch below

                switch (choice)
                {
                    case "A"://makes so either capital or lower-case works for the switch
                    case "a"://
                        {
                            Console.Write("Name :");
                            var name = Console.ReadLine();

                            Console.Write("Type of pet :");
                            var typeOfPet = Console.ReadLine();

                            // Always add the pet at the end of the array
                            pets[numberOfPets].Name = name;// throws pet name added into structure
                            pets[numberOfPets].TypeOfPet = typeOfPet;//throws type of pet into struture

                            numberOfPets++;//makes so the pet you added is included to number of pets
                            break;
                        }

                    case "D"://delete pets, both lower and upper case will work
                    case "d":
                        {
                            if (numberOfPets == 0)
                            {
                                Console.WriteLine("No pets");//ensures no error for if there are zero pets, displays no pets
                                break;
                            }

                            for (var index = 0; index < numberOfPets; index++)//creates array called index with postions equal to number of pets
                            {
                                Console.WriteLine("{0}. {1,-10} {2}", index + 1, pets[index].Name, pets[index].TypeOfPet);//displays pets, []displays pet ot type of pet of the number of the index array
                            }

                            Console.Write("Which pet to remove (1-{0})", numberOfPets);//prompts which pet to remove, {0} is the number of pets

                            var petNumberToDelete = Console.ReadLine();
                            var indexToDelete = int.Parse(petNumberToDelete);//converts chosen pet to delete into an integer variable

                            // Squish the array from index to the end

                            for (var index = indexToDelete - 1; index < numberOfPets; index++)
                            {
                                // Just copy the pet from the next index into the current index
                                pets[index] = pets[index + 1];
                            }

                            // We have one less pet
                            numberOfPets--;

                            break;
                        }

                    case "L": //choice for listing pets
                    case "l":
                        {
                            if (numberOfPets == 0)
                            {
                                Console.WriteLine("No pets");
                            }

                            for (int index = 0; index < numberOfPets; index++)
                            {
                                Console.WriteLine("{0}. {1,-10} {2}", index + 1, pets[index].Name, pets[index].TypeOfPet);// displays the pets in the good form
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
