cd C:\Users\Kirsten\source\repos\kgreed\SO60540720\vb6
pause
copy ..\myframeworklib\bin\Debug\*.* .
c:\windows\microsoft.net\framework\v4.0.30319\regasm /verbose /tlb:myframeworklib.tlb .\myframeworklib.dll 
dir
pause
