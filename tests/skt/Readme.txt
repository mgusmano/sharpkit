
This application compiles the test project in a specifiy history folder and compares it with another history folder.

The current working folder needs to be the folder, where the test project is located.

Command line reference:
/wait --> "Please press any key to continue" at the end of the application.
/version:original --> compiles project and saves output in versions\original folder.
/version:current --> compiles project and saves output in versions\original folder.
/compile:0 --> skip compilation
/compare:0 --> skip comparing

Example:
>cd c:\path\to\test-project\...
>C:\path\to\this\appliacation\SharpKitTester.exe /version:current