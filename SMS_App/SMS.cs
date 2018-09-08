using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using GsmComm.GsmCommunication;
using GsmComm.PduConverter;
namespace SMS_App
{
    class SMS
    {
        GsmCommMain comm = null;
        public List<string> GetConnectedPort()
        {
            List<string> ConnectedPorts = new List<string>();
            string[] port = System.IO.Ports.SerialPort.GetPortNames();
            foreach (string st in port)
            {
                comm = new GsmCommMain(st, 19200, 300);
                try
                {
                    comm.Open();
                    if (comm.IsConnected())
                    {
                        //Console.WriteLine("BhattiConsole: Modem Connected Successfully " + st);
                        ConnectedPorts.Add(st);
                        comm.Close();
                        
                    }
                    else
                    {
                       // Console.WriteLine("BhattiConsole: Modem noy Connected " + st);
                        comm.Close();
                    }
                }
                catch (Exception ex)
                {
                   // Console.WriteLine("BhattiConsole: " + ex.Message);
                }
            }
            return ConnectedPorts;
        }
        public bool SendSMS(string Port,string message,string phoneNo)
        {
            try
            {
                comm = new GsmCommMain(Port, 19200, 300);

                comm.Open();
                if (comm.IsConnected())
                {
                    byte dcs = (byte)DataCodingScheme.GeneralCoding.Alpha7BitDefault;
                    SmsSubmitPdu pdu = new SmsSubmitPdu(message, phoneNo, dcs);
                    comm.SendMessage(pdu);
                    //  Console.WriteLine("BhattiConsole: Message sent from Port " + item);
                    comm.Close();
                    return true;
                }
            }
            catch (Exception ex)
            {
                // Console.WriteLine("BhattiConsole: " + ex);
                comm.Close();
            }
            return false;
        }
       
    }
}
