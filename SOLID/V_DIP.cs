using System;
using System.Collections.Generic;
using System.Text;

namespace SOLID.D
{
    interface IMessage
    {
        void Send();
    }

    class SMS : IMessage
    {
        public string Number { get; set; }
        public string Content { get; set; }

        public void Send()
        {
            SendSMS();
        }

        public void SendSMS()
        {
            Console.WriteLine("Sending SMS...");
        }
    }

    class MMS : IMessage
    {
        public string Number { get; set; }
        public byte[] Content { get; set; }

        public void Send()
        {
            SendMMS();
        }

        public void SendMMS()
        {
            Console.WriteLine("Sending MMS...");
        }
    }

    class Mail : IMessage
    {
        public string Address { get; set; }
        public string Subject { get; set; }
        public string Content { get; set; }

        public void Send()
        {
            SendMail();
        }

        public void SendMail()
        {
            Console.WriteLine("Sending Mail...");
        }
    }

    class Messenger
    {
        //public SMS SMS { get; set; }
        //public MMS MMS { get; set; }
        //public Mail Mail { get; set; }

            public List<IMessage> Messages { get; set; }


        public void SendMessage()
        {
            foreach (var item in Messages)
            {
                item.Send();
            }
        }
    }
}
