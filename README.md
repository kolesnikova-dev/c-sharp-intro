# Overview
This repository contains my first steps at learning C# and application testing with MSTest.

---

### Terminal commands

Create a new console app:
```bash
dotnet new console -n ProjectName
```

<br/>

Create a new test:
```bash
dotnet new mstest -n ProjectName.Tests
```
<br/>

Create solution
```bash
dotnet new sln -n MySolution
```
<br/>

Add projects to solution
```bash
dotnet sln add ProjectName/ProjectName.csproj
dotnet sln add ProjectName.Tests/ProjectName.Tests.csproj
```
<br/>

Add reference (from test to main project)
```bash
cd ProjectName.Tests
dotnet add reference ../ProjectName/ProjectName.csproj
```
<br/>

Run tests:
```bash
dotnet test
```