using Nancy;
using System.Collections.Generic;
using System.Diagnostics;

namespace PingPong.Objects
{
  public class HomeModule : NancyModule
  {
    public HomeModule()
    {
      Get["/"] = _ =>
      {
        return View["index.cshtml"];
      };
      Post["/result"] = _ => {
        PingPong newPingPong = new PingPong(Request.Form["userInput"]);
        return View["result.cshtml", newPingPong];
      };
    }
  }

}
