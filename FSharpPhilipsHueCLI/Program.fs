// Learn more about F# at http://fsharp.org
open System
open System.IO
open FSharpCoreLib
open Utf8Json
open FSharp.Data

//type Config = {
//    BaseUrl: string
//    BridgeIP: string
//    Username: string
//}
type Config = JsonProvider<"sample_config.json">

//let content = Config.Parse(File.ReadAllText(""))

let configFile = @"config.json"

//let rec GetConfig () : string = 
//    let c = configFile |> FileOps.ReadAllTextIfExists
//    match c with
//    | Some (c) -> c
//    | None -> 
//        configFile |> FileOps.Create
//        GetConfig()

//let ConvertConfigIntoObject configContents = Config.Parse(configContents)

//let superGetConfig =
//      let config = GetConfig ()
//      printfn "Config file says: %s" config
//      let x = config |> ConvertConfigIntoObject
      
//      {|
//          BaseConfig = x
//          calculatedUrl = x.BaseUrl + x.BridgeIp
//      |}

let wait() = Console.ReadLine() |> ignore
let out (x: obj) = System.Console.WriteLine(x.ToString())
[<EntryPoint>]
let main argv =
    //printfn "IP = %s" superGetConfig.BaseConfig.BridgeIp
    //printfn "%s" superGetConfig.calculatedUrl

    //SharedFSharpVanilla.Pipes.StringPipe.ConcatSpaces [|"hello";"how";"are";"you"|] |> out

    wait()
    0
