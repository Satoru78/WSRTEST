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
using System.Windows.Threading;
using TelecomNevaSvyazTest.Context;
using TelecomNevaSvyazTest.Views.Windows;

namespace TelecomNevaSvyazTest
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class Authorization : Window
    {
        DispatcherTimer timer = new DispatcherTimer();
        public Authorization()
        {
            InitializeComponent();
            txbPassword.IsEnabled = false;
            txbCode.IsEnabled = false;
            LoginBtn.IsEnabled = false;
        }

        private void DwnBtn_Click(object sender, RoutedEventArgs e)
        {

        }
        WindowCode code = new  WindowCode();
        private void LoginBtn_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                if (txbLogin.Text == "" && txbPassword.Text == "")
                {
                    throw new Exception("Заполните все поля");
                }
                else
                {
                    var currentUser = Data.tns.Employee.FirstOrDefault(item => item.Login == txbLogin.Text && item.Password == txbPassword.Text);
                    switch(currentUser.IDRole)
                    {
                        case 1:
                            MainWindow mainWindow = new MainWindow();
                            mainWindow.ShowDialog();
                            break;
                    }
                }
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message , "Неизвестная ошибка");
            }
        }

        private void CancelBtn_Click(object sender, RoutedEventArgs e)
        {
            Application.Current.Shutdown();
        }

        private void Window_Loaded(object sender, RoutedEventArgs e)
        {

        }

        private void txbLogin_KeyDown(object sender, KeyEventArgs e)
        {
            if(e.Key == Key.Enter)
            {
                if(Data.tns.Employee.Count(item => item.Login == txbLogin.Text) > 0)
                {
                    txbPassword.IsEnabled = true;
                    txbPassword.Focus();
                }
                else
                {
                    MessageBox.Show("Такого пользователя не сувществует", "Ошибка", MessageBoxButton.OK, MessageBoxImage.Warning);
                }
            }
        }
        private void txbPassword_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.Key == Key.Enter)
            {
                if (Data.tns.Employee.Count(item => item.Password == txbPassword.Text) > 0)
                {
                    code.ShowDialog();
                    txbCode.IsEnabled = true;
                    txbCode.Focus();
                }

            }
        }

        private void txbCode_TextChanged(object sender, TextChangedEventArgs e)
        {

        }
    }
}
