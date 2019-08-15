module Extension

open Fable.Core.JsInterop
open Fable.Import
open VSCode

let activate (context: VSCode.Vscode.ExtensionContext) = 
    VSCode.Vscode.commands.registerCommand("extension.helloWorld", (fun args -> 
        printfn "Fuck that"
        None
    ))

// let activate _ =
//     printfn "HAHAHAHAAH"
