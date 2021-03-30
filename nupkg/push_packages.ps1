. ".\common.ps1"

# Publish all packages
foreach($solution in $solutions){

    foreach($project in $projects) {

       if($project.Contains($solution)){
              
            Set-Location $rootFolder
            # Get the version
            [xml]$commonPropsXml = Get-Content (Join-Path $project.Substring(0, $project.IndexOf("/")) "common.props")
            $version = $commonPropsXml.Project.PropertyGroup.Version
            # Get the projectName
            $projectName = $project.Substring($project.LastIndexOf("/") + 1)
    
            Set-Location $distFolder
            # Push
            & dotnet nuget push ($projectName + "." + $version + ".nupkg") -s http://localhost:9000/v3/index.json --api-key "123" 
       }
    }
}

# Go back to the pack folder
Set-Location $packFolder
