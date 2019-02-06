Call Build on required project to restore NuGet packages for project and build it. Do not call build for entire solution.

Due NuGet changes in v3 PowerShell scripts no longer called during package restore (but called during package install).
Please run install.ps1 script (one time only for solution) in packages\VisioForge.DotNet.Core.TRIAL.xx.xx.xx\tools before SDK usage and restart Visual Studio.
That's required to install unmanaged SDK parts.