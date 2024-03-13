﻿using System;
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
using UPDesctop.Core.Persistence;

namespace UPDesckop.Pages
{
    /// <summary>
    /// Логика взаимодействия для Authorization.xaml
    /// </summary>
    public partial class Authorization : Page
    {
        MainWindow mainWindow;
        MainContext mainContext;
        public Authorization(MainWindow mainWindow)
        {
            InitializeComponent();
            this.mainWindow = mainWindow;

            mainContext = new MainContext();
        }

        private void Auth(object sender, RoutedEventArgs e)
        {
            if(login.Text != "")
            {
                if(password.Text != "")
                {
                    var user = mainContext.Users.FirstOrDefault(c => c.Password == password.Text && c.Login == login.Text);

                    if (user != null)
                    {
                        mainWindow.OpenPage(MainWindow.pages.auth);
                    }
                    else MessageBox.Show("Такого юзера не существует");
                }
                MessageBox.Show("Введите пасс");
            }
            MessageBox.Show("Введите логин");
        }
    }
}