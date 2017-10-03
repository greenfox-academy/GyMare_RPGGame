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
using GreenFox;

namespace RPGGame
{
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            var foxDraw = new FoxDraw(canvas);

            for (int i = 0; i < 10; i++)
            {
                for (int j = 0; j < 10; j++)
                {
                    foxDraw.AddImage("./Assets/floor.png",i*50,j*50); 
                }
            }

            //foxDraw.AddImage("./Assets/boss.png", 50, 50); // add images with FoxDraw like this
        }

        private void WindowKeyDown(object sender, KeyEventArgs e) // handling pressing keys, for moving your hero around
        {
            if (e.Key == Key.Left)
            {
                Console.WriteLine("To the left!");
            }

            if (e.Key == Key.Right)
            {
                Console.WriteLine("To the right!");
            }
        }

    }
}
