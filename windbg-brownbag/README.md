# WinDbg brownbag

## Crash

**Project**: `src\CrashConsole`

1. Compile using the `Release` `Configuration`
1. Browse to the output directory (by default `src\CrashConsole\bin\Release\netcoreapp2.0\`)
1. `C:\path-to-procdump\procdump.exe -t -ma -x C:\dumps dotnet.exe .\CrashConsole.dll`
1. Copy `.\CrashConsole.pdb` to your `sympath`
1. Open the dump in `WinDbg Preview`
1. `!analyze -v`

## Hang

### No hang in ASP.NET Core

**Project**: `src\NoHangApi`

1. `Ctrl+F5`
2. `GET http://localhost:5000/no-hang` multiple times
3. The requests complete as expected

### Hang in ASP.NET WebAPI

**Project**: `src\HangApi`

1. `Ctrl+F5`
2. `GET http://localhost:5001/hang` multiple times
3. The requests hang
