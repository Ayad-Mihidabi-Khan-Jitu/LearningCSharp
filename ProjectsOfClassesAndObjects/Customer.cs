using System;
using System.Collections.Generic;
using System.Text;

namespace ProjectsOfClassesAndObjects
    {
    class Customer
    {
        private string name;
        private Account account; //a object name account of the class Account
        public Customer(string n, Account a)
        {
            name = n;
            account = a;
        }
        public void display()
        {
            Console.WriteLine("Name : " + name + " | Account Number : " + account.getAccountNumber() + " | Balance : " + account.getBalance());
        } 
        public string getName()
        {
            return name;
        }
        public Account  getAccount()
        {
            return account;
        }

    }
}
