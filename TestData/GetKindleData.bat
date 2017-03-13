@echo off
%LOCALAPPDATA%\Android\sdk\platform-tools\adb.exe pull /sdcard/Documents D:\BERT\Kindle
%LOCALAPPDATA%\Android\sdk\platform-tools\adb.exe pull /sdcard/DCIM/Camera D:\BERT\Kindle
del D:\BERT\Kindle\Documents\kindlename.txt>nul 2>nul
pause