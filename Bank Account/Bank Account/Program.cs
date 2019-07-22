using System;

namespace Bank_Account
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                BankAccount accountTest1 = new BankAccount("Popescu", "1234567890", 123.5m, StatusAccount.Open);
                accountTest1.DepositMoney(200);
                accountTest1.WithdrawMoney(500);
                Console.WriteLine(accountTest1.ToString());
            }
            catch (InvalidStatusForActions st)
            {
                Console.WriteLine(st.Message);
            }

            BankAccount accountTest2 = new BankAccount("Ionescu", "0987654321", 15999.99m, StatusAccount.Closed);
            try
            {
                accountTest2.DepositMoney(200);
                accountTest2.WithdrawMoney(500);
            }
            catch (InvalidStatusForActions st)
            {
                Console.WriteLine(st.Message);
            }
                        
            Console.WriteLine(accountTest2.ToString());
           
            
        }
    }
}
