echo ""
echo " BUILD Visual Studio Project "
echo ""
MSBuild.exe CCodeParser.sln
echo ""
echo " Start Unit Test "
echo ""
"C:\Program Files (x86)\Microsoft Visual Studio\2017\Community\Common7\IDE\mstest.exe"  /testcontainer:"UnitTest\bin\Debug\UnitTest.dll"
echo ""
echo " End Of Unit Test Running!"
echo ""

