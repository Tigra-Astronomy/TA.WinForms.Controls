New-Item -ErrorAction Ignore -ItemType directory -Path Nuget-Packages
nuget pack TA.WinFormsControls\TA.WinFormsControls.csproj -Symbols -Properties Configuration=Release -OutputDirectory .\Nuget-Packages