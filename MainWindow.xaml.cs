using Godiskalkylatorn;
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
using static Godiskalkylatorn.Filehandler;

namespace Godiskalkylatorn
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        CandyCalculator candyCalcutor = new CandyCalculator();
        List<Person> Persons = new List<Person>();


        public MainWindow()
        {

            InitializeComponent();
        }

        private void btnOK_Click(object sender, RoutedEventArgs e)
        {
            
            int age = int.Parse(txtAge.Text);
          
            string firstName = txtFirstName.Text;
            string lastName = txtLastName.Text;
            candyCalcutor.Addperson(firstName, lastName, age);

            listBoxJoke.ItemsSource = candyCalcutor.Persons;
            candyCalcutor.Addperson(firstName, lastName, age);


        }

        private void btnShare_Click(object sender, RoutedEventArgs e)
        {
            
            CandyCalculator candyCalcutor = new CandyCalculator();
            int totalCandies = int.Parse(txtCandy.Text);
            candyCalcutor.DistributeCandy(totalCandies);
            listBoxJoke.ItemsSource = null;

            if (namelast.IsChecked == true)

            {
                candyCalcutor.LastNameSort();
                candyCalcutor.DistributeCandy(totalCandies);


            }

            else if (namefirst.IsChecked == true)
            {
                candyCalcutor.FirstNameSort();
                candyCalcutor.DistributeCandy(totalCandies);
            }
            else if (age.IsChecked == true)
            {
                candyCalcutor.AgeSort();
                candyCalcutor.DistributeCandy(totalCandies);
            }

            listBoxJoke.ItemsSource = null;
            listBoxJoke.ItemsSource = candyCalcutor.Persons;
        }

        private void namefirst_Checked(object sender, RoutedEventArgs e)
        {
           
            candyCalcutor.FirstNameSort();
            listBoxJoke.ItemsSource = null;
            listBoxJoke.ItemsSource = candyCalcutor.Persons;
        }

        private void namelast_Checked(object sender, RoutedEventArgs e)
        {
            candyCalcutor.LastNameSort();
            listBoxJoke.ItemsSource = null;
            listBoxJoke.ItemsSource = candyCalcutor.Persons;
        }

        private void age_Checked(object sender, RoutedEventArgs e)
        {
            candyCalcutor.AgeSort();
            listBoxJoke.ItemsSource = null;
            listBoxJoke.ItemsSource = candyCalcutor.Persons;

        }
        public void SaveList()
        {
            string filename = "Godiskalkytorn.json";
            FileHandler.Save(candyCalcutor, filename);
            CandyCalculator candyCalculator = FileHandler.Open<CandyCalculator>(filename);


        }
    }

        
    }






