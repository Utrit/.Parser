public class DataHandler : IDataSource
{
    private Dictionary<string,WebData> webServers = new Dictionary<string,WebData>();

    public DataHandler(string[] webs){
        for(int i;i<webs.Length;i++){
            webServers.Add(new WebData(webs[i],4));
        }
    }

    public Antenna GetAntenna(string webServer, int index){
        return webServers.TryGetValue(webServer,out var res) ? res.GetAntenna(index) : null;
    }
}