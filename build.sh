#!/bin/bash

set -e

rm -rf ./paket-files

paket restore
git checkout .paket/Paket.Restore.targets
fake run myscript.fsx
dotnet src/app/bin/Release/netcoreapp2.1/publish/app.dll
