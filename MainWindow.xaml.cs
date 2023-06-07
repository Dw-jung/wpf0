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

namespace Wpf
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        } 
        private void btnAdd_Click(object sender, RoutedEventArgs e)
        {
            string eevent;
            Random randEvent = new Random();
            string[] NewEvent = { "Ваше сообщение съел крот!", "Почтальон продал вашу заметку!", "Офис заметок сгорел! Ваша заметка утеряна уткой.",
                    "Приносим извинения, мы перепутали ваш адрес, заметка улетела в другой бокс.",
                    "С Новым годом!", "Вы заказали часы, оплата на кассе." };
            int Index = randEvent.Next(5);
            eevent = NewEvent[Index];
            int Index2 = randEvent.Next(10);
            
            if (!string.IsNullOrEmpty(txtElem.Text) && !string.IsNullOrWhiteSpace(txtElem.Text))
            {
                if (Index2 > 5)
                {
                    MessageBox.Show($"{eevent}", "Предупреждение", MessageBoxButton.OK, MessageBoxImage.Warning);
                    txtElem.Clear();
                } 
                else
                if (lstElem.Items.Contains(txtElem.Text))
                {
                    if (MessageBox.Show("Вы действительно хотите повторить элемент?", "Добавление в список", MessageBoxButton.YesNo, MessageBoxImage.Question) == MessageBoxResult.Yes)
                    {
                        lstElem.Items.Add(txtElem.Text);
                        txtElem.Clear();
                    }
                }
                else if (MessageBox.Show("Вы действительно хотите добавить новый элемент?", "Добавление в список",
                    MessageBoxButton.YesNo, MessageBoxImage.Question) == MessageBoxResult.Yes)
                {
                    lstElem.Items.Add(txtElem.Text);
                    txtElem.Clear();
                }
            }
            else MessageBox.Show("Надо что-нибудь ввести!", "Предупреждение", MessageBoxButton.OK, MessageBoxImage.Warning);
        }
        private void btnClose_Click(object sender, RoutedEventArgs e)
        {
            Close();
        }
        private void btnClear_Click(object sender, RoutedEventArgs e)
        {
            txtElem.Clear();
            lstElem.Items.Clear();
        }

       
    }
}
