using System;
using System.Collections.Specialized;
using System.Net;
using System.Net.Http;
using System.Threading;
public class DcWebHooker : IDisposable
{
    private readonly WebClient dWebClient;
    private static NameValueCollection discordValues = new NameValueCollection();
    public string WebHook { get; set; }
    public string UserName { get; set; }
    public string ProfilePicture { get; set; }
    private HttpClient _Client;

    private string _URL;



    public DcWebHooker()
    {
        dWebClient = new WebClient();

    }


    public void SendMessage(string msgSend)
    {
        discordValues.Add("username", UserName);
        discordValues.Add("avatar_url", ProfilePicture);
        discordValues.Add("content", msgSend);
        Thread.Sleep(9000);
        dWebClient.UploadValues(WebHook, discordValues);
    }

    public void Dispose()
    {
        dWebClient.Dispose();
    }
}