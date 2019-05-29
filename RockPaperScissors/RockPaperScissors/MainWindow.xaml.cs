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

namespace RockPaperScissors
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        private int computerChoice; //0 for Rock, 1 for Scissors, and 2 for Paper
        private Random randomNumber = new Random(); //creating random numbers

        public MainWindow()
        {
            computerChoice = randomNumber.Next(0, 3); //sets computer choice to a random number between 0 and 2
            InitializeComponent();
        }

        private void RockButton_Click(object sender, RoutedEventArgs e)
        {
            if (computerChoice == 1)
            {
                MessageBox.Show("Congratulations, you win!  Rock smashes the computer's choice of 'Scissors'.");
            }
            else if (computerChoice == 2)
            {
                MessageBox.Show("Sorry, you lose!  The computer's choice of 'Paper' covers your Rock.");
            }
            else
            {
                MessageBox.Show("It's a tie between you and the computer!");
            }
            computerChoice = randomNumber.Next(0, 3);
        }

        private void PaperButton_Click(object sender, RoutedEventArgs e)
        {
            if (computerChoice == 0)
            {
                MessageBox.Show("Congratulations, you win!  Paper covers the computer's choice of 'Rock'.");
            }
            else if (computerChoice == 1)
            {
                MessageBox.Show("Sorry, you lose!  The computer's choice of 'Scissors' cuts your paper.");
            }
            else
            {
                MessageBox.Show("It's a tie between you and the computer!");
            }
            computerChoice = randomNumber.Next(0, 3);
        }

        private void ScissorsButton_Click(object sender, RoutedEventArgs e)
        {
            if (computerChoice == 0)
            {
                MessageBox.Show("Sorry, you lose!  The computer's choice of 'Rock' smashes your Scissors.");
            }
            else if (computerChoice == 1)
            {
                MessageBox.Show("It's a tie between you and the computer!");
            }
            else
            {
                MessageBox.Show("Congratulations, you win!  Scissors cuts the computer's choice of 'Paper'.");
            }
            computerChoice = randomNumber.Next(0, 3);
        }


    }
}
