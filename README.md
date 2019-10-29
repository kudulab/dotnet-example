# Paket and FAKE on dotnet core

This is a spike proving that it is possible to use Paket, FAKE and build dotnet
projects using a dotnet SDK without mono.

## Usage without FAKE, in Dojo Docker containers
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

Thanks to mounting the docker volume `-v $(pwd)/nuget-packages:/home/dojo/.nuget/packages`, we can run each command in a different container.

## Usage without FAKE, locally
Compile all projects of the C# solution:
```
./tasks _clean
./tasks _build
```

Run tests (without rebuilding the test project):
```
./tasks _utest
```

Run the console application project:
```
./tasks _run
```

### Usage with FAKE, locally
Compile all projects of the C# solution:
```
./build.sh
```
