# WinDbg brownbag

## Crash

**Project**: `src\CrashConsole`

1. Compile using the `Release` `Configuration`
1. Browse to the output directory (`src\CrashConsole\bin\Release\net461\`)
1. `C:\path-to-procdump\procdump.exe -e -ma -x C:\dumps .\CrashConsole.exe`
1. Copy `.\CrashConsole.pdb` to your `sympath`
1. Open the dump in `WinDbg Preview`
1. `!analyze -v`

## Hang

### Hang in ASP.NET WebAPI

**Project**: `src\HangApi`

1. `Ctrl+F5`
1. `GET http://localhost:5001/hang` multiple times
1. The requests hang
1. `procdump.exe -ma <pid>`
1. Open the dump in `WinDbg Preview`
1. `.load C:\path-to-mex\mex.dll`
1. `!mex.runaway2`
1. `!mex.mthreads`
1. `.loadby sos clr`
1. `!sos.SyncBlk`
1. `!mex.aspxpagesext`
1. `!mex.us`
1. `~<thread-id>e !CLRStack`

### No hang in ASP.NET Core

**Project**: `src\NoHangApi`

1. `Ctrl+F5`
1. `GET http://localhost:5000/no-hang` multiple times
1. The requests complete as expected
