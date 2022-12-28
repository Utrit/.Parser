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

            IDataSource DataSource = new WebHandler(webs);
            DataSource.GetAntenna("http://161.8.51.92/basic/antennas.psp",3) //Тут уже сформировать как удобно вывод в консоль
            /*for (int e = 0; e < webs.Length; e++)
            {
                HtmlWeb web = new HtmlWeb();
                HtmlDocument document = web.Load(webs[e]);
                Console.WriteLine(webs[e]);
                Console.WriteLine();

                Console.WriteLine("Name \t Antenna 1 \t Antenna 2 \t Antenna 3 \t Antenna 4\t");
               
                foreach (var key in loops.Keys)
                {
                    Console.Write(key + "\t" + "\t");
                    for (int j = 0; j < 4; j++)
                    {
                        var value = document.DocumentNode.SelectSingleNode(loops[key][j]);
                        var valueFormId = value.GetAttributeValue("value", "");
                        Console.Write(valueFormId + "\t" + "\t");
                    }
                    Console.WriteLine();о
                }
                
            }*/

        }

    }

}