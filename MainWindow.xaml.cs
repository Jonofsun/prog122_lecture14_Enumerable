using Microsoft.Win32;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace prog122_lecture14_Enumerable
{
    
    //enum GameType { Arcade, Story, Vs, SomethingTower }
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        List<Account> account = new List<Account>();
        List<InstagramPost> post = new List<InstagramPost>();
        // to declare a enuemreable
        // enum
        // catagory name or types
        // Defference between savings and checking accounts
        // required min balance
        // interest rate
        // withdraw fee
        public MainWindow()
        {
            // Enumerables are a selection list
            InitializeComponent();
            //PopulateAccountTypes();
            //GameSession current = new GameSession();

            //Account Jonathan = new Account(Account.AccountType.Savings, "Jonathan", 02193846129);
            //Account Nami = new Account(Account.AccountType.Savings, "Nami", 999999999999);
            //InstagramPost regular = new InstagramPost(InstagramPost.PhotoFilter.Regular, "", "", GetFilePath());
            //InstagramPost greyScale = new InstagramPost(InstagramPost.PhotoFilter.GreyScale, "", "", GetFilePath());
            PopulateTypes();

        }
        public void PopulateTypes()
        {
            cmbFilter.Items.Add("Regular");
            cmbFilter.Items.Add("GreyScale");

            cmbFilter.SelectedIndex = 0;
        }
        // Inside my button adds a new account to the list or updates the account
        //private void btnAddAccount_Click(object sender, RoutedEventArgs e)
        //{
        //    string filePath = txtFilePath.Text;
        //    string fullName = txtName.Text;
        //    decimal amount = decimal.Parse(txtAmount.Text);
        //    int accountType = cmbAccounttypes.SelectedIndex;

        //    //what is a default constructor
        //    // a new instance of a new Type()
        //    Account account = new Account((Account.AccountType)accountType,fullName,amount); // you have to cast the type ()type

        //    lbAccounts.Items.Add(account.ToString());

        //    imgCustomer.Source = account.CustomerPicture;
        //}
        //public void DisplayAccounts()
        //{
        //    cmbFilter.Items.Clear();
        //    foreach (InstagramPost post in post)
        //    {
        //        cmbFilter.
        //    }
        //}
        private void btnSelectPicture_Click(object sender, RoutedEventArgs e)
        {
            // Open file diagloug
            OpenFileDialog op = new OpenFileDialog();
            string filePath = "";
            op.Title = "Select a picture";
            op.Filter = "All supported graphics|*.jpg;*.jpeg;*.png|" +
              "JPEG (*.jpg;*.jpeg)|*.jpg;*.jpeg|" +
              "Portable Network Graphic (*.png)|*.png";
            if (op.ShowDialog() == true)
            {
                filePath = op.FileName;
                txtFilePath.Text = filePath;
            }

        }
        public string GetFilePath()
        {
            // Opens a file dialogue to find a path to a file
            OpenFileDialog op = new OpenFileDialog();
            op.Title = "Select a picture";
            op.Filter = "All supported graphics|*.jpg;*.jpeg;*.png|" +
              "JPEG (*.jpg;*.jpeg)|*.jpg;*.jpeg|" +
              "Portable Network Graphic (*.png)|*.png";

            if (op.ShowDialog() == true)
            {
                return op.FileName;
            }
            else
            {
                return "";
            }
        }

        private void btnPost_Click(object sender, RoutedEventArgs e)
        {
            //string filePath = GetFilePath();
            //if (filePath != "")
            //{
            //    txtFilePath.Text = filePath;
            //    imgDisplay.Source = ;
            //}
            //else
            //{
            //    MessageBox.Show("Please select a valid picture");
            //}
            string filePath = GetFilePath();
            string fullName = txtName.Text;
            string headder = txtAmount.Text;
            int filterType = cmbFilter.SelectedIndex;

            //what is a default constructor
            // a new instance of a new Type()
            /*Account account = new Account((Account.AccountType)accountType, fullName, amount);*/ // you have to cast the type ()type
            //InstagramPost posting = new InstagramPost((InstagramPost.PhotoFilter)filterType, fullName, headder, filePath);


            //imgDisplay.Source = post[selectedIndex].Photo;
        }
        int selectedIndex = 0;
        private void cmbFilter_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            if (cmbFilter.SelectedIndex == -1)
            {
                selectedIndex = cmbFilter.SelectedIndex;
            }
            //imgDisplay.Source = post[selectedIndex].Photo;
        }

        //private void lbAccounts_SelectionChanged(object sender, SelectionChangedEventArgs e)
        //{
        //    int selectedIndex = 0;
        //    if(lbAccounts.SelectedIndex > -1)
        //    {
        //        selectedIndex = lbAccounts.SelectedIndex;
        //    }


        //    imgCustomer.Source = accounts[selectedIndex].CustomerPicture;
        //}
        //public class GameSession(GameType currentSession){}
    }
}
