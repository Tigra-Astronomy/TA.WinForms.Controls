New-Item -ErrorAction Ignore -ItemType directory -Path Nuget-Packages
$gitVersion = GitVersion.exe | ConvertFrom-Json
$semver = $gitVersion.SemVer
$packageVersion = $gitVersion.NuGetVersion
$branch = $gitVersion.BranchName
$commit = $gitVersion.Sha
$majorVersion = $gitVersion.Major
$minorVersion = $gitVersion.Minor

nuget pack TA.WinForms.Controls\TA.WinForms.Controls.csproj -Symbols -Properties "Configuration=Release;Branch=$branch;Commit=$commit;packageVersion=$packageVersion" -OutputDirectory .\Nuget-Packages