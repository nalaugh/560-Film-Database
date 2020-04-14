Param(
   [string] $Server = "(localdb)\MSSQLLocalDb",
   [string] $Database = "johnkeller"
)

# This script requires the SQL Server module for PowerShell.
# The below commands may be required.

# To check whether the module is installed.
# Get-Module -ListAvailable -Name SqlServer;

# Install the SQL Server Module
# Install-Module -Name SqlServer -Scope CurrentUser

$CurrentDrive = (Get-Location).Drive.Name + ":"

Write-Host ""
Write-Host "Rebuilding database $Database on $Server..."

Write-Host "Dropping tables..."
Invoke-SqlCmd -ServerInstance $Server -Database $Database -InputFile "PersonData\Sql\Tables\DropTables.sql"

Write-Host "Creating schema..."
Invoke-SqlCmd -ServerInstance $Server -Database $Database -InputFile "PersonData\Sql\Schemas\Person.sql"

Write-Host "Creating tables..."
Invoke-SqlCmd -ServerInstance $Server -Database $Database -InputFile "PersonData\Sql\Tables\Person.Person.sql"
Invoke-SqlCmd -ServerInstance $Server -Database $Database -InputFile "PersonData\Sql\Tables\Person.AddressType.sql"
Invoke-SqlCmd -ServerInstance $Server -Database $Database -InputFile "PersonData\Sql\Tables\Person.PersonAddress.sql"

Write-Host "Stored procedures..."
Invoke-SqlCmd -ServerInstance $Server -Database $Database -InputFile "PersonData\Sql\Procedures\Person.CreatePerson.sql"
Invoke-SqlCmd -ServerInstance $Server -Database $Database -InputFile "PersonData\Sql\Procedures\Person.RetrievePersons.sql"
Invoke-SqlCmd -ServerInstance $Server -Database $Database -InputFile "PersonData\Sql\Procedures\Person.FetchPerson.sql"
Invoke-SqlCmd -ServerInstance $Server -Database $Database -InputFile "PersonData\Sql\Procedures\Person.GetPerson.sql"
Invoke-SqlCmd -ServerInstance $Server -Database $Database -InputFile "PersonData\Sql\Procedures\Person.SavePersonAddress.sql"
Invoke-SqlCmd -ServerInstance $Server -Database $Database -InputFile "PersonData\Sql\Procedures\Person.RetrieveAddressesForPerson.sql"

Write-Host "Inserting data..."
Invoke-SqlCmd -ServerInstance $Server -Database $Database -InputFile "PersonData\Sql\Data\Person.AddressType.sql"

Write-Host "Rebuild completed."
Write-Host ""

Set-Location $CurrentDrive
