using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SkillMineDotNetFrameWork.CollectionsStudy.MiniP
{
    public enum AccountType
    {
        SavingAccount,CurrentAccount
    }
    public class Loan
    {
        public int LoanId { get; set; }
        public string LoanName { get; set; }
        
    }
    public class Customer
    {
        public int AccNumber { get; set; }
        public string Name { get; set; }
        public AccountType accountType;
        public List<Loan> loan = new List<Loan>();
       
    }
    class AccountMamagement
    {
        /*static void Main(string[] args)
        {
            List<Customer> lc = new List<Customer>();
            lc.Add(new Customer
            {
                AccNumber = 100,
                Name = "Arun Tarle",
                accountType = AccountType.SavingAccount,
                loan = {
                        new Loan{ LoanId=235,LoanName="CarLoan"},
                        new Loan{ LoanId=236,LoanName="HomeLoan"}
                       }
            });
            lc.Add(new Customer
            {
                AccNumber = 101,
                Name = "pranit Chaughule",
                accountType = AccountType.CurrentAccount,
                loan = {
                        new Loan { LoanId = 237, LoanName = "BussinessLoan" },
                        new Loan { LoanId = 239, LoanName = "ShopLoan" }
                       }
            });
           lc.Add(new Customer
           {
               AccNumber = 102,
               Name = "Avinash kadam",
               accountType = AccountType.CurrentAccount,
               loan = {
                        new Loan { LoanId = 245, LoanName = "BussinessLoan" },
                        new Loan { LoanId = 267, LoanName = "CarLoan" }
                       }
           }
            );
            foreach (Customer c in lc)
            {
                Console.WriteLine($"Account Number is: {c.AccNumber}   Name : {c.Name} Account Type Is:{c.accountType}");
                foreach (Loan l in c.loan)
                {
                    Console.WriteLine($"Id: {l.LoanId} ,Type: {l.LoanName} ");
                }
                Console.WriteLine("------------------------------------------");
            }

        }*/
        
       
    }
}
