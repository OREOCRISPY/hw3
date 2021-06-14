using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise3
{
    class HouseholdAccounts
    {
        List<Record> data = new List<Record>();
        public void add(){
            if (data.Count == 10000) {
                Console.WriteLine("system full please delete some data");
                return;
            }
            Console.WriteLine("please enter record date eg: 2021/12/24");
            Console.WriteLine("2000<=Year<=3000");
            String recordDate = Console.ReadLine();
            String[] recordDateString = recordDate.Split('/');

            if (recordDateString.Length != 3) {
                Console.WriteLine("Date format incorrect");
                return;
            }

            if (Convert.ToInt32(recordDateString[0]) > 3000 || Convert.ToInt32(recordDateString[0]) < 2000) {
                Console.WriteLine("Year is incorrect");
                return;
            }
            if (Convert.ToInt32(recordDateString[1]) > 12 || Convert.ToInt32(recordDateString[0]) < 1)
            {
                Console.WriteLine("month is incorrect");
                return;
            }
            if (Convert.ToInt32(recordDateString[2]) > 31 || Convert.ToInt32(recordDateString[2]) < 1)
            {
                Console.WriteLine("day is incorrect");
                return;
            }

            Console.WriteLine("please enter amount");
            double recordAmount = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("please enter Description");
            String recordDescription = Console.ReadLine();
            if (recordDescription.Trim()== "") {
                Console.WriteLine("Description cannot be empty");
                return;
            }
            Console.WriteLine("please enter Category");
            String recordCategory = Console.ReadLine();
            Record newRecord = new Record();
            newRecord.rAmount = recordAmount;
            newRecord.rCategory = recordCategory.ToLower();
            newRecord.rDes = recordDescription.ToLower();
            newRecord.rDate = recordDate;
            data.Add(newRecord);
        }
        public void ShowExpense() {
            Console.WriteLine("please enter start day");
            int start = convert(Console.ReadLine());
            Console.WriteLine("please enter end day");
            int end= convert(Console.ReadLine());
            int count = 0;
            for(int i=0;i<data.Count;i++) {
                int recordDate = convert(data[i].rDate);
                if (start <= recordDate && recordDate <= end&&data[i].rAmount<0) {
                    Console.Write("{0}({1})({2})({3}){4}-", i, data[i].rDate, data[i].rDes, data[i].rCategory, data[i].rAmount);
                    count++;
                }
            }
            Console.WriteLine("Displayed {0} records", count);
            Console.ReadKey();
        }
        public void SearchCost() {
            Console.WriteLine("please enter text");
            String text = Console.ReadLine();
            for (int i = 0; i < data.Count; i++) {
                if (data[i].rCategory.Contains(text) || data[i].rDes.Contains(text)) {
                    Console.WriteLine("{0}      {1}", i, data[i].rDes);
                }
            }
            Console.ReadKey();
        }

        public void modify() {
            Console.WriteLine("please enter card number");
            int card = Convert.ToInt32(Console.ReadLine());
            if (card < 0 || card > data.Count) {
                Console.WriteLine("illegal input");
                return;
            }
            Record target = data[card];
            Console.WriteLine("{0} {1} {2} {3}", target.rDate, target.rAmount, target.rCategory, target.rDes);
            Console.WriteLine("press enter to quite");
            Console.ReadKey();
        }

        public void delete() {
            Console.WriteLine("please enter card number");
            int card = Convert.ToInt32(Console.ReadLine());
            if (card < 0 || card > data.Count)
            {
                Console.WriteLine("illegal input");
                return;
            }
            Record target = data[card];
            Console.WriteLine("We will delete:");
            Console.WriteLine("{0} {1} {2} {3}", target.rDate, target.rAmount, target.rCategory, target.rDes);
            Console.WriteLine("enter yes to confirm");
            String input = Console.ReadLine();
            if (input.ToLower() == "yes")
            {
                data.Remove(data[card]);
                Console.WriteLine("Successed");
            }
            Console.ReadKey();
        }

        private int convert(String s) {
            String[]temp=s.Split('/');
            return Convert.ToInt32(temp[0]+temp[1]+temp[2]);
        }

        public void sort() {
            data.Sort((x, y) => x.rDate.CompareTo(y.rDate) == 0 ? x.rDes.CompareTo(y.rDes) : x.rDate.CompareTo(y.rDate));
            Console.WriteLine("successed");
            Console.ReadKey();
        }

    }
}
