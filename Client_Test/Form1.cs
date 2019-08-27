﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using CtrNet_v;
using System.Net;
using System.Net.Sockets;
using System.Diagnostics;

namespace Client_Test
{
    public partial class Form1 : Form
    {
        public delegate void ShowDataCallBack(string sTmp);
        readonly CtrNet_v.Devices newDevice = new CtrNet_v.Devices();
        TcpClient client = new TcpClient();
        public string hexMsg;

        public Form1()
        {
            InitializeComponent();
        }

        private void Send_Click(object sender, EventArgs e)
        {
            GetConnected();
            do
            {
                newDevice.FunctionCode("00", "8599", 1000);
            } while (hexMsg != "54063030030d0a");
            newDevice.ReceiveDatabyDU("00", 0, false, 25000);
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            newDevice.ConnectFailed += new CtrNet_v.Devices.ConnectFailedEventHandler(NewDevice_ConnectFailed);
            newDevice.ConnectSucceed += new CtrNet_v.Devices.ConnectSucceedEventHandler(NewDevice_ConnectSucceed);
            newDevice.GetBufferData += new CtrNet_v.Devices.GetBufferDataHandler(NewDevice_GetBufferData);
            newDevice.ShowEvent += new CtrNet_v.Devices.ShowEventEventHandler(NewDevice_ShowEvent);
        }

        void NewDevice_ConnectSucceed()
        {
            logViewer.Items.Add("Connect OK");
        }

        void NewDevice_ConnectFailed()
        {
            logViewer.Items.Add("Connect Not OK");
        }

        private void NewDevice_GetBufferData(string CommandMode, byte[] FeedBack, string EventLog)
        {

            StringBuilder hex = new StringBuilder(FeedBack.Length * 2);

            foreach (byte b in FeedBack)
            {
                hex.AppendFormat("{0:x2}", b);
            }

            hexMsg = hex.ToString();

            string strMsg = Encoding.ASCII.GetString(FeedBack);

            string[] strSMsg = strMsg.Split(Convert.ToChar(0x0a));

            string timeLog = DateTime.Now.ToString("MM/dd/yyyy HH:mm:ss");

            Debug.WriteLine(hexMsg);

            if (CommandMode == "DU")
            {
                ShowMsg(EventLog + "....");
                for (int i = 0; i < strSMsg.Length; i++)
                {
                    ShowMsg(strSMsg[i] + " -- " + timeLog);
                }
                ShowMsg("OK");
            }
            else
            {
                ShowMsg(EventLog + " " + strMsg + " OK -- " + timeLog);
            }


        }

        private void NewDevice_ShowEvent(string Events, string tResult)
        {
            ShowMsg(Events + " " + tResult + " FAILED");
        }

        private void GetConnected()
        {
            newDevice.DisConnect();
            newDevice.Cnt_IP = "140.118.122.121";
            newDevice.Cnt_PortNo = 4001;
            newDevice.ConnectMode = 0;
            newDevice.Connect();
        }

        private void Connect_Click(object sender, EventArgs e)
        {
            GetConnected();
        }

        public void ShowMsg(string tMsg)
        {
            logViewer.Items.Add(tMsg);

            /**if (this.txtCardNum.InvokeRequired)
            {
                ShowDataCallBack d = new ShowDataCallBack(ShowMsg);
                this.Invoke(d, new object[] { tMsg });
            }
            else
            {
                logViewer.Items.Add(tMsg);

            }*/
        }

        private void AddUser_Click(object sender, EventArgs e)
        {
            //string expDate = "00" + DateTime.Now.ToString("yymmdd");
            string nameUser = userName.Text.Trim();
            string cardNumber = userCardNumber.Text.Trim();

            newDevice.PAM("00", "01", cardNumber, true, true, "0000", "00000000", "00000000", 1000);

        }

        private void ReceiveData_Click(object sender, EventArgs e)
        {
            /*string cardNumber = userCardNumber.Text.Trim();
            newDevice.DelPAM("00", "01", cardNumber, 1000);*/
            //newDevice.CheckCI("00", 1000);
            //newDevice.ReceiveData("00", 25000);
            //string choice = userCardNumber.Text.Trim();
            //newDevice.Setting_Counter("00", 0, "AAAAA", 2000);
            newDevice.FunctionCode("00", "8400", 2000);
            newDevice.CheckCI("00", 1000);
            /*newDevice.FunctionCode("00", "0072", 2000);
            newDevice.FunctionCode("00", "0016", 2000);
            newDevice.FunctionCode("00", "0000", 2000);
            newDevice.FunctionCode("00", "1501", 2000);
            newDevice.FunctionCode("00", "1601", 2000);*/
            //newDevice.EraseFunction("00", 1, 2000);
            //newDevice.EraseFunction("00", 4, 2000);

            /*newDevice.Setting_Date("00", DateTime.Now, 2000);
            newDevice.Setting_Time("00", DateTime.Now, 2000);*/

        }

        private void CheckCi_Click(object sender, EventArgs e)
        {
            string cardNumber = userCardNumber.Text.Trim();
            newDevice.Inquiry_PAM("00",cardNumber, 1000);
        }

        private void TimeZone_Click(object sender, EventArgs e)
        {
            newDevice.TimeZone("00", "01", "1633", "1634", "1111111", 1000);
        }

        private void AcsGroup_Click(object sender, EventArgs e)
        {
            newDevice.AcsGroup("00", "01", "00000001", true, false, "0", 1000);
        }

        private void InquiryTZ_Click(object sender, EventArgs e)
        {
            string cardNumber = userCardNumber.Text.Trim();
            newDevice.Inquiry_TZ("00",cardNumber, 1000);
        }

        private void InquiryAG_Click(object sender, EventArgs e)
        {
            string cardNumber = userCardNumber.Text.Trim();
            newDevice.Inquiry_AG("00", cardNumber, 1000);
        }
    }
}
