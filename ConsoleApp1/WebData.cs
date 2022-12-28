public class WebData
{
    private Antenna[] antennas;
    string[] endPoints = { "//input[@id='conducted_powerINDEX']","//input[@id='attenuationINDEX']","//input[@id='cable_lossINDEX']","//input[@id='gainINDEX']"}; //хардкод фу, лучше откудота тянуть из файла хотябы
    public WebData(string WebServer, int antennasCount)
    {
        antennas = new Antenna[antennasCount];
        for(int i;i<antennasCount;i++)
        {
            HtmlWeb web = new HtmlWeb();
            HtmlDocument document = web.Load(WebServer);
            var power = GetValueFromEndPoint(GetEndPoint(0,i));
            var att = GetValueFromEndPoint(GetEndPoint(1,i));
            var cable = GetValueFromEndPoint(GetEndPoint(2,i));
            var gain = GetValueFromEndPoint(GetEndPoint(3,i));

            antennas[i] = new Antenna(power,att,cable,gain);
        }
    }

    public Antenna GetAntenna(int index){
        return antennas[i];
    }

    private int GetValueFromEndPoint(string endPoint){
        return document.DocumentNode.SelectSingleNode(endPoint).GetAttributeValue("value", "");
    }

    private string GetEndPoint(int index, int endPoint){
        return endPoints[index].Replace("INDEX",endPoint);
    }
}