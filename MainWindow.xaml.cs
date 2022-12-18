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

namespace TypingGame_DevOps
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        string[] words = { "internet", "programming", "hannah", "coding" };

        Random rnd = new Random();

        int correct = 0;

        public MainWindow()
        {
            InitializeComponent();


            lblword.Text = words[rnd.Next(0, words.Length)];
        }

        private void checkGame(object sender, KeyEventArgs e)
        {
            if (e.Key == Key.Enter)
            {
                if (textBox1.Text == lblword.Text)
                {
                    correct++;
                    lblword.Text = words[rnd.Next(0, words.Length)];
                    textBox1.Text = null;
                }
                else
                {
                    correct--;
                    lblword.Text = words[rnd.Next(0, words.Length)];
                    textBox1.Text = null;
                }

                lblcorrect.Text = "Score: " + correct;

            }
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            Gegevens gegevens = new Gegevens();
            gegevens.Show();
            Visibility= Visibility.Hidden;
        }
    }
}
