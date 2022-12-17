using System.Linq;
using static System.Net.WebRequestMethods;

namespace HtmlAgilityPack
{
    class Html
    {
        public static void Main(string[] args)
        {
            string[] webs = { 
                              "http://161.8.147.76/basic/antennas.psp",
                              "http://161.8.147.155/basic/antennas.psp",
                              "http://172.30.54.150/basic/antennas.psp",
                              "http://172.30.54.151/basic/antennas.psp",
                              "http://161.8.51.90/basic/antennas.psp",
                              "http://161.8.51.92/basic/antennas.psp",
                              "http://161.8.51.91/basic/antennas.psp",
                              "http://161.8.240.31/basic/antennas.psp",
                              "http://161.8.240.32/basic/antennas.psp",
                              "http://161.8.240.33/basic/antennas.psp",
                              "http://161.8.250.231/basic/antennas.psp",
                              "http://161.8.189.113/basic/antennas.psp",
                              "http://161.8.189.112/basic/antennas.psp",
                              "http://161.8.189.114/basic/antennas.psp",
                              "http://10.8.65.150/basic/antennas.psp"
            };
            for (int e = 0; e < 15; e++)
            {
                HtmlWeb web = new HtmlWeb();
                HtmlDocument document = web.Load(webs[e]);
                Console.WriteLine(webs[e]);
                Console.WriteLine();
                string[] cp = { "//input[@id='conducted_power1']",
                            "//input[@id='conducted_power2']",
                            "//input[@id='conducted_power3']",
                            "//input[@id='conducted_power4']"};

                string[] attenuation = {"//input[@id='attenuation1']",
                                    "//input[@id='attenuation2']",
                                    "//input[@id='attenuation3']",
                                    "//input[@id='attenuation3']"
                                    };

                string[] cableLoss = {"//input[@id='cable_loss1']",
                                    "//input[@id='cable_loss2']",
                                    "//input[@id='cable_loss3']",
                                    "//input[@id='cable_loss4']"
                                    };

                string[] gain = {"//input[@id='gain1']",
                                    "//input[@id='gain2']",
                                    "//input[@id='gain3']",
                                    "//input[@id='gain4']"
                                    };

                Console.WriteLine("Name \t Antenna 1 \t Antenna 2 \t Antenna 3 \t Antenna 4\t");

                Console.Write("Conducted \nPower \t \t");
                for (int i = 0; i < 4; i++)
                {
                    var value = document.DocumentNode.SelectSingleNode(cp[i]);
                    var valueFormId = value.GetAttributeValue("value", "");
                    Console.Write(valueFormId + "\t" + "\t");
                }

                Console.Write("\nAttenuation \t");
                for (int i = 0; i < 4; i++)
                {
                    var value = document.DocumentNode.SelectSingleNode(attenuation[i]);
                    var valueFormId = value.GetAttributeValue("value", "");
                    Console.Write(valueFormId + "\t" + "\t");
                }

                Console.Write("\nCable Loss\t");
                for (int i = 0; i < 4; i++)
                {
                    var value = document.DocumentNode.SelectSingleNode(cableLoss[i]);
                    var valueFormId = value.GetAttributeValue("value", "");
                    Console.Write(valueFormId + "\t" + "\t");
                }

                Console.Write("\nGain\t\t");
                for (int i = 0; i < 4; i++)
                {
                    var value = document.DocumentNode.SelectSingleNode(gain[i]);
                    var valueFormId = value.GetAttributeValue("value", "");
                    Console.Write(valueFormId + "\t" + "\t");
                }
                Console.WriteLine();
            }

        }

    }

}