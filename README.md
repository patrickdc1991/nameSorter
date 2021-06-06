Simple Name Sorter
===============
*by Patrick De Clara*

## Overview
This program is used to sort a list of names in a file alphabetically by last name. The sorted list is outputted to in both the command line and in a file called `sorted-names-list.txt`

## Requirements
This program requires Windows 10 and .NET 5.0

## How to build
In the Windows command prompt, navigate to the project root directory and enter:
>`dotnet build --configuration Release`

The executable can be found in `[PROJECT_ROOT_DIRECTORY]\nameSorter2\bin\Release\net5.0\nameSorter2.exe`

## How to use

The program takes a single argument, which is the text file containing the list of names you wish to sort. The sorted list will appear in the standard output, and a file will be created in the current working directory called `sorted-names-list.txt`. Here is an example of how to use the program:

    C:\[PROJECT_ROOT_DIRECTORY]>nameSorter2\bin\Release\net5.0\nameSorter2.exe unsortedList.txt
    Sorting names in file "unsortedList.txt":

    Marin Alvarez
    Adonis Julius Archer
    Beau Tristan Bentley