@echo off
setLocal enableDelayedExpansion

for /l %%n in (1,70,2500) do (
  set /a k=%%n+69
  set "formattedN=000000%%n"
  set "formattedK=000000!k!"
  rem echo !formattedN:~-4!-!formattedK:~-4! >> folders.txt
  mkdir "[!formattedN:~-4!-!formattedK:~-4!]"
)
