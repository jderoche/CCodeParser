MSBuild.exe CCodeParser.sln
pause
"C:\Program Files (x86)\Microsoft Visual Studio\2017\Community\Common7\IDE\mstest.exe"  /testcontainer:"UnitTest\bin\Debug\UnitTest.dll"
pause
cd TestResults
type *.trx
