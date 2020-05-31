#!/bin/sh

mono .nuget/nuget.exe restore
xbuild
