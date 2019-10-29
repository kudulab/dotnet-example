# Pake and FAKE on dotnet core

This is a spike proving that it is possible to use paket, FAKE and build dotnet
projects using a dotnet SDK without mono.

## Usage without FAKE
Compile all projects of the C# solution:
```
./tasks clean
./tasks build
```

Run tests (without rebuilding the test project):
```
./tasks utest
```

Run the console application project:
```
./tasks run
```

### Usage with FAKE
Compile all projects of the C# solution:
```
./build.sh
```
