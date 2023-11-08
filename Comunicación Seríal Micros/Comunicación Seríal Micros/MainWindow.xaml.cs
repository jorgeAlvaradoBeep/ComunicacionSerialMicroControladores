using Comunicación_Seríal_Micros.Services;
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

namespace Comunicación_Seríal_Micros
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        #region Propeties
        public bool Enable { get; set; }
        public bool IsOn { get; set; }
        public SerialComunication Arduino { get; set; }
        #endregion

        #region Variables
        public string[] AvailablePorts { get; } = SerialComunication.ExistingPorts();
        #endregion
        public MainWindow()
        {
            InitializeComponent();
            IsOn = false;
            if (AvailablePorts.Length > 0)
                cmbSerialPorts.ItemsSource = AvailablePorts;
            ledOff.Fill = Brushes.DarkRed;
            ledOn.Fill = Brushes.DarkGreen;
            chkEncender.IsEnabled = false;
            cmbSerialPorts.IsEnabled = true;
            btnConnect.IsEnabled = true;
            Arduino = new SerialComunication();
        }

        private void btnConnect_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                if(cmbSerialPorts.SelectedItem != null)
                {
                    if(cmbSerialPorts.SelectedIndex != -1)
                    {
                        Arduino.InitializeSensor(cmbSerialPorts.SelectedIndex, SerialComunication.ExistingPortsOnly());
                        cmbSerialPorts.IsEnabled = false;
                        btnConnect.IsEnabled=false;
                        chkEncender.IsEnabled=true;
                        MessageBox.Show("Conexión Con Micro Exitosa","Exito",MessageBoxButton.OK, MessageBoxImage.Information);
                    }
                }
                
            }
            catch (ControllerException d)
            {
                MessageBox.Show($"Error: {d.Message}", "Error de comunicacion", MessageBoxButton.OK, MessageBoxImage.Error);
            }
        }

        private void chkEncender_Checked(object sender, RoutedEventArgs e)
        {
            try
            {
                TurnOnLeed();
            }catch(ControllerException d) 
            { 
                MessageBox.Show($"Error: {d.Message}", "Error de escritura", MessageBoxButton.OK, MessageBoxImage.Error); 
            }
        }
        private void chkEncender_Unchecked(object sender, RoutedEventArgs e)
        {
            try
            {
                TurnOffLeed();
            }
            catch (ControllerException d)
            {
                MessageBox.Show($"Error: {d.Message}", "Error de escritura", MessageBoxButton.OK, MessageBoxImage.Error);
            }
        }

        void TurnOnLeed()
        {
            Arduino.Write("0");
            IsOn = true;
            ledOn.Fill = Brushes.Green;
            ledOff.Fill = Brushes.DarkRed;
        }
        void TurnOffLeed()
        {
            Arduino.Write("1");
            IsOn = false;
            ledOn.Fill = Brushes.DarkGreen;
            ledOff.Fill = Brushes.Red;
        }

        
    }
}
