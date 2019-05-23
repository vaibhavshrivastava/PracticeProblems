using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using OpenPop.Pop3;
using System.IO;
using System.Net.NetworkInformation;
using System.Net.Security;
using System.Net.Sockets;
using EAGetMail;

namespace Threading
{
    public class ThreadSync
    {
        static ManualResetEvent objAuto = new ManualResetEvent(false);
        public void Test()
        {
         
            TestInterOp();
            TestPop();
            //new Thread(SomeMethod).Start();
            //Console.ReadLine();
            ////Signaled to start again
            //objAuto.Set();

            //Console.ReadLine();
            ////Signaled to start again
            //objAuto.Set();

        }
        public void SomeMethod()
        {
            Console.WriteLine("Starting 1...");
            //wait 
            objAuto.WaitOne();
            Console.WriteLine("Finishing 1...");

            Console.WriteLine("Starting 2...");
            //wait 
            objAuto.WaitOne();
            Console.WriteLine("Finishing 2...");
        }

        public void TestPop()
        {
            var client = new Pop3Client();
            client.Connect("outlook.office365.com", 995, true);
            var username = "Beam@M1cro5oft@outlook.com";
            var authvalue = "Beam@Pass111";
            var nullchar = '\u0000';
            var auth = nullchar + username + nullchar + authvalue;

            
        }


        public void TestInterOp()
        {
            MailServer oServer = new MailServer("outlook.office365.com",
            "cdesbot@microsoft.com", "Password!", ServerProtocol.Imap4);
            MailClient oClient = new MailClient("TryIt");

            oServer.Port = 993;
            oServer.SSLConnection = true;

            oClient.Connect(oServer);
            MailInfo[] infos = oClient.GetMailInfos();

            for (int i = 0; i < infos.Length; i++)
            {
                MailInfo info = infos[i];
                Console.WriteLine("Index: {0}; Size: {1}; UIDL: {2}",
                    info.Index, info.Size, info.UIDL);

                // Receive email from IMAP4 server
                Mail oMail = oClient.GetMail(info);

                Console.WriteLine("From: {0}", oMail.From.ToString());
                Console.WriteLine("Subject: {0}\r\n", oMail.Subject);

            }
        }


            public void TestPopNew()
        {
            MailServer oServer = new MailServer("outlook.office365.com",
            "beamtestacct@outlook.com", "Beam@Pass111", ServerProtocol.Pop3);
            MailClient oClient = new MailClient("TryIt");

            oServer.Port = 995;
            oServer.SSLConnection = true;

            oClient.Connect(oServer);
            MailInfo[] infos = oClient.GetMailInfos();
        }
    }
}
