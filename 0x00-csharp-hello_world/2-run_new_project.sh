#!/usr/bin/env bash
# Builds a dotnet template in 0-new_project folder
dotnet new console -n 2-new_project
dotnet build 2-new_project
dotnet run --project ./2-new_project
