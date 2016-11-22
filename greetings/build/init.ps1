$webclient = New-Object System.Net.WebClient
$url = "https://dist.nuget.org/win-x86-commandline/latest/nuget.exe"
$file = join-path $PSScriptRoot "nuget.exe"
$webclient.DownloadFile($url,$file)