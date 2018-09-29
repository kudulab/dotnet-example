#r "paket: groupref Build //"
#load "./.fake/myscript.fsx/intellisense.fsx"

open Fake.IO
open Fake.IO.Globbing.Operators
open Fake.DotNet
open Fake.Core


// Properties
let buildDir = "./build/"
let testDir  = "./test/"

// Targets
Target.create "Clean" (fun _ ->
  Shell.cleanDirs [buildDir; testDir]
)

Target.create "RestoreApp" (fun _ ->
    !! "src/**/*.csproj"
    |> MSBuild.runRelease id buildDir "Restore"
    |> ignore
)

Target.create "BuildApp" (fun _ ->
    let setParams (defaults:MSBuildParams) =
        { defaults with
            Verbosity = Some(Quiet)
            Targets = ["Publish"]
            Properties =
                [
                    "Optimize", "True"
                    "TargetFramework", "netcoreapp2.1"
                    "Configuration", "Release"
                ]
         }
    MSBuild.build setParams "src/app/app.csproj"
)

Target.create "BuildTest" (fun _ ->
  !! "src/test/**/*.csproj"
    |> MSBuild.runDebug id testDir "Build"
    |> Trace.logItems "TestBuild-Output: "
)

Target.create "Default" (fun _ ->
  Trace.trace "Hello World from FAKE"
)

open Fake.Core.TargetOperators
"Clean"
  ==> "RestoreApp"
  ==> "BuildApp"
  ==> "Default"

// start build
Target.runOrDefault "BuildApp"
