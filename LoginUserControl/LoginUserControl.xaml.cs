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

namespace LoginUserControl
{
    /// <summary>
    /// Interaction logic for UserControl1.xaml
    /// </summary>
    public partial class UserControl1 : UserControl
    {
        public UserControl1()
        {
            InitializeComponent();
        }
        public string Login
        {
            get { return (string)GetValue(LoginProperty); }
        }

        public string Password
        {
            get { return (string)GetValue(PasswordProperty); }
        }

        public static DependencyProperty LoginProperty = DependencyProperty.Register(nameof(Login), typeof(string), typeof(UserControl1), new PropertyMetadata("Login Name"));
        public static DependencyProperty PasswordProperty = DependencyProperty.Register(nameof(Login), typeof(string), typeof(UserControl1), new PropertyMetadata("Password"));
    }
}
