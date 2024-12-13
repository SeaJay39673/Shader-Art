# Description: 
This is a basic shader program I wrote following a youtube [tutorial](https://www.youtube.com/watch?v=f4s1h2YETNY) to create fractals.

![](Fractals.gif)

## Requirements:

### VCPKG:
vcpkg (a microsoft package manager) will need to be installed in order for this repo to work on development.

In order to install, run the following commands in the local project directory:
```
git clone https://github.com/microsoft/vcpkg.git
```

For Windows:
```
cd vcpkg; .\bootstrap-vcpkg.bat
```
For Mac/Linux:
```
cd vcpkg; .\bootstrap-vcpkg.sh
```

#### VCPKG Submodule Source Control:
To get rid of problems with source controll tracking the vcpkg submodule, go to settings (UI), search for Git: Auto Repository Detection and set it to "Open Editors". Then reload vscode.

Now you're done!

#### Adding Packages with vcpkg:
***Note: if there is no vcpkg.json or vcpkg-configuration.json files already in your repo directory, run the following command first:***
```
./vcpkg/vcpkg new --application
```

To add a 3rd party library, use the following command in the terminal at the base of the repo:
```
./vcpkg/vcpkg add port <package-name>
```

## VsCode
### Extensions:
A series of VsCode extensions must be installed in order to develop this repo smoothly.

#### CMake
This adds language support for CMake related files

#### CMake Tools
This adds many tools needed to compile and run the application 

### How to compile and run:
Here is the list of steps to get ready to compile and run the application:

#### Setup Environment:

Enter the command "CMake: Select a Kit" and select a compiler that supports x64 (NOT STRAWBERRY - Windows).

Now, you can either use the keyboard shortcuts or select the run to run the program.