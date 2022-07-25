#!/bin/bash

set -e

paket restore
git checkout .paket/Paket.Restore.targets
fake run myscript.fsx
dotnet src/app/bin/Release/net6.0/publish/app.dll
