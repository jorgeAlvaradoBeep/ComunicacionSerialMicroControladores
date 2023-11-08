using System;
using System.Collections.Generic;
using System.IO.Ports;
using System.Linq;
using System.Management;
using System.Text;
using System.Threading.Tasks;

namespace Comunicación_Seríal_Micros.Services
{
    public class SerialComunication
    {
        public string ErrorMessage { get; set; }
        public SerialPort MicroController { get; set; }
        public SerialComunication()
        {
            ErrorMessage = "";
        }
        public static string[] ExistingPorts()
        {
            //string[] ports = SerialPort.GetPortNames();
            string[] portnames = SerialPort.GetPortNames();
            if (portnames.Length > 0)
            {
                using (var searcher = new ManagementObjectSearcher
                    ("SELECT * FROM WIN32_SerialPort"))
                {

                    var ports = searcher.Get().Cast<ManagementBaseObject>().ToList();
                    var tList = (from n in portnames
                                 join p in ports on n equals p["DeviceID"].ToString()
                                 select n + " - " + p["Caption"]).ToList();
                    return tList.ToArray();


                }
            }
            else
            {
                return portnames;
            }
        }
        public static string[] ExistingPortsOnly()
        {
            return SerialPort.GetPortNames();
        }
        public void InitializeSensor(int portNum, string[] ports)
        {
            MicroController = new SerialPort();
            if (ports.Length <= 0)
            {
                ErrorMessage = "Micro Controlador no detectado";
            }
            else
            {
                MicroController.PortName = ports[portNum];
                MicroController.BaudRate = 9600;

                try
                {
                    MicroController.Open();
                }
                catch (Exception e)
                {
                    ErrorMessage = "No se pudo establecer comunicacion con el MicroController";
                    ControllerException ex = new ControllerException(ErrorMessage);
                    throw ex;
                }
            }
        }
        public bool Write(string data)
        {
            try
            {
                MicroController.Write(data);
                return true;
            }
            catch (Exception e)
            {
                ErrorMessage = $"Error al escribir: {e.Message}";
                ControllerException ex = new ControllerException(ErrorMessage);
                throw ex;
            }
        }
    }
}
