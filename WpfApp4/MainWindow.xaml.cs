using System.Windows;
using System.Collections.Generic;

namespace WpfApp4
{
    public partial class MainWindow : Window
    {
        private Dictionary<string, string> users = new Dictionary<string, string>
        {
            { "admin", "admin123" },
            { "user", "user123" }
        };

        public MainWindow()
        {
            InitializeComponent();
        }

        private void LoginButton_Click(object sender, RoutedEventArgs e)
        {
            string login = LoginBox.Text;
            string password = PasswordBox.Password;

            if (users.TryGetValue(login, out string correctPassword) &&
                password == correctPassword)
            {
                // Создаем и показываем Window1
                Window1 mainAppWindow = new Window1();
                mainAppWindow.Show();

                // Закрываем текущее окно авторизации
                this.Close();
            }
            else
            {
                MessageBox.Show("Неверный логин или пароль", "Ошибка",
                              MessageBoxButton.OK, MessageBoxImage.Error);
            }
        }
    }
}