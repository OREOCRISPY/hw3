using System;

namespace Exercise3
{
    class Program
    {
        static void Main(string[] args)
        {
            HouseholdAccounts system = new HouseholdAccounts();
            Boolean flag = true;
            do
            {
                Console.Clear();
                Console.WriteLine("Welcome to System");
                Console.WriteLine("1:Add a new expense");
                Console.WriteLine("2:Show all expenses of a certain category");
                Console.WriteLine("3:Search costs containing a certain text ");
                Console.WriteLine("4:Modify a tab  ");
                Console.WriteLine("5:Delete some data ");
                Console.WriteLine("6:Sort");
                Console.WriteLine("7:quit");
                int opt = Convert.ToInt32(Console.ReadLine());
                switch (opt) {
                    case 1:
                        system.add();
                        break;
                    case 2:
                        system.ShowExpense();
                        break;
                    case 3:
                        system.SearchCost();
                        break;
                    case 4:
                        system.modify();
                        break;
                    case 5:
                        system.delete();
                        break;
                    case 6:
                        system.sort();
                        break;
                    case 7:
                        flag = false;
                        break;
                    default:
                        Console.WriteLine("illegal input");
                        break;
                }



            } while (flag);
        }
    }
}
