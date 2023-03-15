using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Media.Imaging;

namespace prog122_lecture14_Enumerable
{

    
    public class Account
    {
        public enum AccountType { Savings, Checking, Investment }
        string _accountNumber;
        AccountType _typeOfAccount;
        string _name;
        decimal _amount;
        BitmapImage _image;
        decimal _withdrawFee;

        public BitmapImage Image { get => _image; set => _image = value; }

        // Defference between savings and checking accounts
        // required min balance
        // interest rate
        // withdraw fee
        public Account(AccountType typeOfAccount, string name, decimal amount, string filePath)
        {
            Random random = new Random();
            _accountNumber = random.Next(10000000, 100000000).ToString();
            _typeOfAccount = typeOfAccount;
            _name = name;

            Uri uri = new Uri(filePath);
            BitmapImage bitmap = new BitmapImage(uri);
            //if (_typeOfAccount == AccountType.Savings && amount > _minBalance)
            //{
            //    _amount = amount;
            //}
            //else
            //{
            //    MessageBox.Show("Please enter a proper balance");
            //}
            
        } // Account()

        //private BitmapImage ConvertImage(string image)
        //{
        //    return image;
        //}
        public void Withdraw(decimal amount)
        {
            if (amount < _amount)
            {
                _amount -= _withdrawFee;
            }
            else
            {
                if (_typeOfAccount == AccountType.Checking)
                {
                    _amount -= amount;
                }
            }
            
        }
        //public override string ToString()
        //{
        //    return $"{_accountNumber} - {_typeOfAccount} - {_amount}";
        //}
    }
}
