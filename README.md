# Overview
Dotnet Core example of using FileNet GraphQL to fetch domain data and convert it into C# object using graphql-client library.
https://github.com/graphql-dotnet/graphql-client

# Setup
I used .net6 on mac. Setup instructions  here: https://docs.microsoft.com/en-us/dotnet/core/tutorials/with-visual-studio-code?pivots=dotnet-6-0

To start a new project I used the following command to create a solution and project. But this will not be necessary when using this project as it'll already contain a project.
```
dotnet new console --framework net6.0
dotnet add package GraphQL.Client --version 4.0.2
```
I am not even sure what `dotnet build` does but I ran it. Compiles fine.

# Run
To test the application run the command:
`dotnet run`

# Tools
- convert json schema to C# https://app.quicktype.io/?l=csharp
- get schema from graphql or graphiql https://stackoverflow.com/questions/37397886/get-graphql-whole-schema-query 