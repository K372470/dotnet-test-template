## .NET CLI tutorial
 This is a simple project, which was set up for solving kata's from [CodeWars](https://www.codewars.com/)

###### How to create this project :
 - mkdir *folder_name*
 - cd *folder_name*
 - dotnet new console
 - dotnet add package NUnit
 - dotnet add package NUnit3TestAdapter
 - dotnet add package Microsoft.NET.Test.Sdk
 - dotnet restore

To run program use **dotnet run**

 #### Example Project
 Example project contains 2 files:
  - **Program.cs** which describes class **Maths**
  - **Tests.cs** which describes some unit testing with **NUnit**

To run tests use **dotnet test**