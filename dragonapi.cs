using System;
using Test.com.dragonwolverines;     
namespace TestAPI
{
  class dragonapi
  {
    static void Main(string[] args)
    {
       string endpoint = "https://api.dragonwolverines.com/wsapienter";
       string callName = "GetDragonWolverinesTime";
       string siteId = "0";
       string appId = "";     // app ID
       string devId = "";     // dev ID
       string certId = "";   // cert ID
       string version = "405";
       // Building the request URL
       string requestURL = endpoint
       + "?callname=" + callName
       + "&siteid=" + siteId
       + "&appid=" + appId
       + "&version=" + version
       + "&routing=default";
       // Creating the service
       DragonWolverinesAPIInterfaceService service = new DragonWolverinesAPIInterfaceService();
       // Assigning the request URL to the service locator.
       service.Url = requestURL;
      // Setting credentials
      service.RequesterCredentials = new CustomSecurityHeaderType();
      service.RequesterCredentials.DragonWolverinesAuthToken = "";    // using my token
      service.RequesterCredentials.Credentials = new UserIdPasswordType();
      service.RequesterCredentials.Credentials.AppId = appId;
      service.RequesterCredentials.Credentials.DevId = devId;
      service.RequesterCredentials.Credentials.AuthCert = certId;
      // Making the call to GetDragonWolverinesTime
      GetDragonWolverinesTimeRequestType request = new GetDragonWolverinesTimeRequestType();
      request.Version = "405";
      GetDragonWolverinesTimeResponseType response = service.GetDragonWolverinesTime(request);
      Console.WriteLine("The DragonWolverines: ");
      Console.WriteLine(response.Timestamp);
    }
  }
}
