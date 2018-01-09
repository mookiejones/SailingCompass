using System;
using System.Collections.Generic;
using System.IO;
using System.Net.Sockets;
using System.Text;

namespace Kompass
{
    public class Client
    {
        private NetworkStream stream;

        private StreamWriter streamw;

        private StreamReader streamr;

        public string client_nmea;

        private TcpClient _client;

        public Client()
        {
            this.client_nmea = "";
        }

        public void connect(string hostAdress, int hostPort)
        {
            try
            {
                this._client = new TcpClient();
                this._client.Connect(hostAdress, hostPort);
                bool connected = this._client.Connected;
                if (connected)
                {
                    this.stream = this._client.GetStream();
                    this.streamw = new StreamWriter(this.stream);
                    this.streamr = new StreamReader(this.stream);
                }
                else
                {
//                    Interaction.MsgBox("Verbidnung konnte nicht mit " + hostAdress + " aufgebaut werden!", MsgBoxStyle.OkOnly, null);
//                    MyProject.Forms.Menue.CheckBox2.CheckState = CheckState.Unchecked;
                }
            }
            catch (Exception expr_91)
            {
//                ProjectData.SetProjectError(expr_91);
//                Interaction.MsgBox("Verbidnung konnte nicht mit TCP " + hostAdress + " aufgebaut werden!", MsgBoxStyle.OkOnly, null);
//                MyProject.Forms.Menue.CheckBox2.CheckState = CheckState.Unchecked;
//                ProjectData.ClearProjectError();
            }
        }

        public void disconnect()
        {
            bool connected = this._client.Connected;
            if (connected)
            {
                NetworkStream networkStream = this._client.GetStream();
                networkStream.Close();
                this._client.Close();
                this._client = new TcpClient();
            }
        }

        public void client_nmea_txt()
        {
            try
            {
                this._client.ReceiveTimeout = 5000;
                bool flag = this._client.Available > 0;
                if (flag)
                {
                    this.client_nmea = this.streamr.ReadLine();
                }
            }
            catch (Exception expr_39)
            {
                
//                MyProject.Forms.Menue.CheckBox2.CheckState = CheckState.Unchecked;
              
            }
        }
    }
}
