using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using WhatsAppApi;

namespace bus_project.Model
{
    public class WhatsappSender
    {
        public WhatsappSender()
        {
            string from = "hier mobiel nummer van bus-systeem";
            string token = "hier whatsapp token van WART (https://github.com/mgp25/WART)";

            WhatsApp wa = new WhatsApp(from, token, "Bus-systeem", false, false);

            wa.OnConnectSuccess += () =>
            {
                //MessageBox.Show("Connecten naar whatsapp..."); // Alleen voor testen

                wa.OnLoginSuccess += (phoneNumber, data) =>
                {
                    // wa.SendMessage(to, msg);
                    //MessageBox.Show("Bericht verstuurd.."); // Alleen voor testen
                };

                wa.OnLoginFailed += (data) =>
                {
                    //MessageBox.Show("Login mislukt : {0}", data); // Alleen voor testen
                };

                wa.Login();

            };

            wa.OnConnectFailed += (ex) =>
            {
                //MessageBox.Show("Connection mislukt"); // Alleen voor testen
            };

            wa.Connect();
        }
    }
}