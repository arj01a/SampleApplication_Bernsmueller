# Sample Application

The sample application has been built with Angular and .Net using DDD, Clean Architecture and CRQS

## Prerequisites

Windows Machine

Visual Studio 2022

Node JS version 18.xx as a minimum

## Set-up

Publish SampleApplicationDatabase

![396516488-d96c133f-2927-439e-8c17-d59250edefbc](https://github.com/user-attachments/assets/d2af841e-d4f4-432c-bdf3-46edb14237c6)

Configure mutliple start-up projects

![396516531-a36f2e09-32a8-4445-9983-61a4d2608149](https://github.com/user-attachments/assets/5371ad36-99f6-4888-9a45-64b94d999e88)

## Domain

Account - List of Accounts
Person - List of Persons
Relations - Connection between Account and Person

## Tasks

1. An example of retrieving the list of accounts has been implemented. Please implement a page displaying a list of Persons.
2. Create a Person detail page where a persons first name / last name can be updated, use a command handler implementation for back end.

## Leandro Scripts

```Sh
cd "SampleApplication_Bernsmueller\SampleApplicationDatabase"

dotnet build SampleApplicationDatabase.sqlproj

dotnet tool install -g microsoft.sqlpackage

sqlpackage /Action:Publish /SourceFile:"bin/Debug/SampleApplicationDatabase.dacpac" /TargetServerName:"localhost,1433" /TargetDatabaseName:"SampleApp" /TargetUser:"sa" /TargetPassword:"THE_PASSWORD_HERE" /TargetTrustServerCertificate:True
```

```Sh
cd "SampleApplication_Bernsmueller\SampleApplication.WebApi"

dotnet user-secrets init
dotnet user-secrets set "ConnectionStrings:DefaultConnection" "Server=localhost,1433;Database=SampleApp;User Id=sa;Password=THE_PASSWORD_HERE;TrustServerCertificate=True;Encrypt=False;"
```

```Sh
cd "SampleApplication_Bernsmueller\sampleapplication.client"

ng serve
```
