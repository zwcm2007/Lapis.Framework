# Paths
$packFolder = (Get-Item -Path "./" -Verbose).FullName
$rootFolder = Join-Path $packFolder "../"
$distFolder = Join-Path $rootFolder "/dist"

# List of solutions
$solutions = (
    #"Laison.Lapis.Identity",
    "Laison.Lapis.Shared"
)

# List of projects
$projects = (
    # Shared
    "Laison.Lapis.Shared/src/Laison.Lapis.Shared",
    "Laison.Lapis.Shared/src/Laison.Lapis.Shared.Application",
    "Laison.Lapis.Shared/src/Laison.Lapis.Shared.Domain",
    "Laison.Lapis.Shared/src/Laison.Lapis.Shared.EntityFrameworkCore",
    "Laison.Lapis.Shared/src/Laison.Lapis.Shared.Host",
    "Laison.Lapis.Shared/src/Laison.Lapis.Shared.HttpApi",
    # Identity
    "Laison.Lapis.Identity/src/Laison.Lapis.Identity.Application",
    "Laison.Lapis.Identity/src/Laison.Lapis.Identity.Application.Contracts",
    "Laison.Lapis.Identity/src/Laison.Lapis.Identity.Domain",
    "Laison.Lapis.Identity/src/Laison.Lapis.Identity.Domain.Shared",
    "Laison.Lapis.Identity/src/Laison.Lapis.Identity.EntityFrameworkCore",
    "Laison.Lapis.Identity/src/Laison.Lapis.Identity.HttpApi"
)