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

namespace Bejcek_20221212
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        Soldier soldier1;
        Soldier soldier2;
        int pick = 0;
        public MainWindow()
        {
            InitializeComponent();
            soldier1 = new Soldier("soldier 1");
            soldier2 = new Soldier("soldier 2");
            picked(brdr1, brdr2);
            Build(soldier1, txtblock1);
            Build(soldier2, txtblock2);
        }
        public void Build(Soldier sol, TextBlock txt)
        {
            txt.Text = " " + sol.Name;
            txt.Text += "\n HP: " + sol.HP;
            txt.Text += "\n Shield: " + sol.Shield;
            txt.Text += "\n Level: " + sol.Level;

        }

        public void picked(Border brd, Border Enemybrd)
        {
            brd.BorderThickness = new Thickness(1);
            Enemybrd.BorderThickness = new Thickness(0);
        }
        public void Switch()
        {
            if (pick == 0)
            {
                pick = 1;
                picked(brdr2, brdr1);
            }
            else
            {
                pick = 0;
                picked(brdr1, brdr2);
            }
            if (soldier1.lost == true)
            {
                MessageBox.Show("soldier 2 vyhral");
                Application.Current.Shutdown();
            }
            else if (soldier2.lost == true)
            {
                MessageBox.Show("soldier 1 vyhral");
                Application.Current.Shutdown();
            }
        }
        private void btnswitch1(object sender, RoutedEventArgs e)
        {
            Switch();
        }

        private void btnattack1(object sender, RoutedEventArgs e)
        {
            if (pick == 0)
            {
                soldier1.Attack(soldier2);
            }
            else
            {
                soldier2.Attack(soldier1);
            }
            Build(soldier1, txtblock1);
            Build(soldier2, txtblock2);
            soldier1.Check(soldier2);
            soldier2.Check(soldier1);
            Switch();

        }

        private void btnheal1(object sender, RoutedEventArgs e)
        {
            if (pick == 0)
            {
                soldier1.Heal();
            }
            else
            {
                soldier2.Heal();
            }
            Build(soldier1, txtblock1);
            Build(soldier2, txtblock2);
        }

       
    }
}
