using System;
using System.Windows;
using System.Windows.Controls;

namespace SMO_Project
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        SMOFabric fabric;
        public MainWindow()
        {
            InitializeComponent();
            fabric = new SMOFabric(Convert.ToInt32(totalMemoryTextBox.Text), Convert.ToInt32(minimalMemoryTextBox.Text), Convert.ToInt32(quantityReqTextBox.Text), Convert.ToInt32(depthThreadTextBox.Text), Convert.ToInt32(averageTimeTextBox.Text));
        }

        private void Model1RunButton_Click(object sender, RoutedEventArgs e)
        {
            var SMO = fabric.getModel(1);
            SMO.calculate();
            Model1TextBox.Text = SMO.getResult();
        }

        private void Model2RunButton_Click(object sender, RoutedEventArgs e)
        {
            var SMO = fabric.getModel(2);
            SMO.calculate();
            Model2TextBox.Text = SMO.getResult();
        }

        private void totalMemoryTextBox_TextChanged(object sender, TextChangedEventArgs e)
        {
            if (IsInitialized)
            {
                TextBox textBox = (TextBox)sender;
                int result;
                if (Int32.TryParse(textBox.Text,out result))
                {
                    fabric.totalMemory = Convert.ToInt32(textBox.Text);
                }
            }
        }

        private void minimalMemoryTextBox_TextChanged(object sender, TextChangedEventArgs e)
        {
            if (IsInitialized)
            {
                TextBox textBox = (TextBox)sender;
                int result;
                if (Int32.TryParse(textBox.Text, out result))
                {
                    fabric.minimalMemory = Convert.ToInt32(textBox.Text);
                }
            }
        }

        private void quantityReqTextBox_TextChanged(object sender, TextChangedEventArgs e)
        {
            if (IsInitialized)
            {
                TextBox textBox = (TextBox)sender;
                int result;
                if (Int32.TryParse(textBox.Text, out result))
                {
                    fabric.quantityReq = Convert.ToInt32(textBox.Text);
                }
            }
        }

        private void depthThreadTextBox_TextChanged(object sender, TextChangedEventArgs e)
        {
            if (IsInitialized)
            {
                TextBox textBox = (TextBox)sender;
                int result;
                if (Int32.TryParse(textBox.Text, out result))
                {
                    fabric.depthThread = Convert.ToInt32(textBox.Text);
                }
            }
        }

        private void averageTimeTextBox_TextChanged(object sender, TextChangedEventArgs e)
        {
            if (IsInitialized)
            {
                TextBox textBox = (TextBox)sender;
                int result;
                if (Int32.TryParse(textBox.Text, out result))
                {
                    fabric.averageTime = Convert.ToInt32(textBox.Text);
                }
            }
        }


    }
}
