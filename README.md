## .NET CLI tutorial

This is a simple project, which was set up for solving kata's from [CodeWars](https://www.codewars.com/)

### How did i create this project:

```
mkdir dotnet-test-template
cd dotnet-test-template
dotnet new console
dotnet add package NUnit
dotnet add package NUnit3TestAdapter
dotnet add package Microsoft.NET.Test.Sdk
dotnet restore
```

To run program use `dotnet run`

### Example Project

Example project contains 3 files:
- **Program.cs** describes program, which displays usage of **Maths** class
- **Maths.cs** contains unit-test covered class
- **Tests.cs** describes unit-test methods with **NUnit**

To run tests use `dotnet test`
