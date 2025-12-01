# Basic C# Educational repository

## 01.12.2025

### Topics
    * Git & the .gitignore file
    * Basic variables, datatypes, data structures (collections) & basic Object-oriented programming concepts (OOP)

### To create a new .gitignore file specifically for .NET applications, we can run the following command in the terminal

```sh
# using the .NET CLI
dotnet new gitignore
# or, manually creating it using a posix compliant terminal (not PowerShell)
touch .gitignore
```

```ps1
New-Item -Path "C:\path\to\your\file\.gitignore" -ItemType File
```

### To create new C# projects (in our case, we create a new console application)
```sh
# check where we are in our file explorer using the terminal
pwd # prints the current working directory

# we can also list out the files in this directory to verify we are in the correct folder
ls

# or
ls -l # long output

ls -a # show ALL output

# if we are in the correct folder, we want to create the project in
dotnet new console --use-program-main # pass the last argument --use-program-main to get the full class syntax, otherwise, we get the "top-level statements" this is harder to understand when we are first learning the language.
```