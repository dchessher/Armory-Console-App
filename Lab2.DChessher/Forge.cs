using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Lab2.DChessher
{
    public static class Forge
    {
        public static void StartForge(ref Armory badlandArmory, ref Weapon forgeWeapon)
        {
            string createAnotherWeapon;
            string nameDecision;
            bool anotherRound = false;
            bool goodValue;
            int weaponCount = 0;

            do
            {
                Console.WriteLine("Welcome to the Badlands Armory"
                    + "\nWhat kind of weapon would you like to create?");

                Console.WriteLine("Select (1) to forge a Sword" + "\nSelect (2) to fashion a Staff" + "\nSelect (3) to wrought a Mace");

                goodValue = int.TryParse(Console.ReadLine(), out int topSelection);

                if (goodValue) 
                {
                    if (topSelection > 3) 
                    {
                        Console.WriteLine("You must select a valid Value.\nTerminating Program");
                        break;
                    }   

                    switch (topSelection)
                    {
                        case 1:
                            ForgeSword();                            
                            break;

                        case 2:
                            Console.WriteLine("A Staff is a fine choice. Now, let's pick the type of staff."
                                + "\nSelect (1) for Halberd " + "\nor (2) for Guandao");

                            int.TryParse(Console.ReadLine(), out int staffSelection);

                            switch (staffSelection)
                            {
                                case 1:
                                    forgeWeapon = new Halberd();
                                    break;

                                case 2:
                                    forgeWeapon = new Guandao();
                                    break;

                                default:
                                    Console.WriteLine("Please Select a Valid value: 1 or 2");
                                    break;
                            }
                            break;

                        case 3:
                            Console.WriteLine("A Mace is a fine choice. Now, let's pick the type of mace."
                                + "\nSelect (1) for Morning Star");

                            int.TryParse(Console.ReadLine(), out int maceSelection);

                            switch (maceSelection)
                            {
                                case 1:
                                    forgeWeapon = new MorningStar();
                                    break;

                                default:
                                    Console.WriteLine("Please Select a Valid value: 1");
                                    break;
                            }
                            break;

                        default:
                            Console.WriteLine("Please Select a Valid value: 1, 2, or 3");
                            break;
                    }
                    
                    badlandArmory.AddWeapon(forgeWeapon);

                    Console.WriteLine("Would you like to add another Weapon to the Armory?"
                        + "\nSelect (Y) or (N)");

                    createAnotherWeapon = Console.ReadLine();

                    if (createAnotherWeapon.ToUpper() == "Y")
                    {
                        anotherRound = true;
                    }
                    else anotherRound = false;

                    weaponCount++;
                }
                else Console.WriteLine("That's not a selection.\nTerminating Program");
            }
            while (anotherRound);
        }

        public void ForgeSword()
        {
            Console.WriteLine("A Sword is a fine choice. Now, let's pick the type of blade."
                                    + "\nSelect (1) for Katana " + "\n(2) for Claymore " + "\n(3) for Rapier "
                                    + "\n(4) for Flamberge " + "\nor (5) for Bastard ");

            int.TryParse(Console.ReadLine(), out int swordSelection);

            switch (swordSelection)
            {
                case 1:
                    forgeWeapon = new Katana();
                    break;

                case 2:
                    forgeWeapon = new Claymore();
                    break;

                case 3:
                    forgeWeapon = new Rapier();
                    break;

                case 4:
                    forgeWeapon = new Flamberge();
                    break;

                case 5:
                    Console.WriteLine("Would you like to name your Sword? (Enter Name) or (N)");
                    nameDecision = Console.ReadLine();
                    if (nameDecision.ToUpper() != "N") 
                    {
                        forgeWeapon = new Bastard(nameDecision);
                    }
                    else {forgeWeapon = new Bastard();}
                    break;

                 default:
                     Console.WriteLine("Please Select a Valid value: 1, 2, 3, 4, or 5");
                     break;
            }
        }
    }
}