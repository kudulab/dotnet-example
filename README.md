# Paket and FAKE on dotnet core

This is a spike proving that it is possible to use paket, FAKE and build dotnet
projects using a dotnet SDK without mono.

## Caveats

Paket is a super early release. It generates invalid/inconvenient `.paket/Paket.Restore.targets`
 and I had to patch it so that bootstrapper is not executed ever and globally installed `paket` cli is used.

## Usage
Compile and run:
```
dojo ./build.sh
``
