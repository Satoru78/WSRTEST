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
using System.Windows.Shapes;

namespace TelecomNevaSvyazTest.Views.Windows
{
    /// <summary>
    /// Логика взаимодействия для WindowCode.xaml
    /// </summary>
    public partial class WindowCode : Window
    {
        public WindowCode()
        {
            InitializeComponent();
            txbCode.Text = GenerationCaptcha();
        }
        public string GenerationCaptcha()
        {
            // Получаем кеоличесвто букв и цифр за слово
            int numLetters = 8;


            //Создаем массив букв
            char[] letter = "ABCDEFGHIKLMNOPQRSTVXYZabcdefghiklmnopqrstvxyz!@#$%^123456789".ToCharArray();

            //Генератор рандомных чисел
            Random random = new Random();

            //Создаем слово
            string captcha = "";

            for (int i= 1; i <= numLetters; i++)
            {
                //Выбор случайных чисел
                //Для набора буквы из массива букв
                int letterNum = random.Next(0, letter.Length - 1);

                //Добавить письмо
                captcha += letter[letterNum];
            }
            return captcha;
        }
        
        
    }
}
