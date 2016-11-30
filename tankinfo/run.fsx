#r "System.Net.Http"

open System.Net
open System.Net.Http
open Newtonsoft.Json

let Run(req: HttpRequestMessage, log: TraceWriter) =
    log.Info(sprintf "F# HTTP trigger function processed a request.")

    let info = {
        name = "AWI"
        owner = "TechTalk"
    }

    let json = JsonConvert.SerializeObject(info);
    
    req.CreateResponse(HttpStatusCode.OK, json);