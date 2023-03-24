# we compile our project in the first image.
# with the second image, we run our compiled project.

# We use base image from mcr.microsoft.com/dotnet/sdk:6.0
# this image defined as build-env.
FROM mcr.microsoft.com/dotnet/sdk:6.0 AS build-env

# we define working directory as /App
WORKDIR /App

# we copy all files in current directory to /App directory in image
COPY . ./

# we restore nuget packages
RUN dotnet restore

# we publish our project to /App/out directory
RUN dotnet publish -c Release -o out


# we use base image from mcr.microsoft.com/dotnet/aspnet:6.0
FROM mcr.microsoft.com/dotnet/aspnet:6.0

# we define working directory as /App
WORKDIR /App

# we copy all files from /App/out directory in build-env image to /App directory in this image
COPY --from=build-env /App/out .

# we define the required script to run our project
# this script equal "dotnet DotNet.Docker.dll" in terminal
ENTRYPOINT ["dotnet", "DotNet.Docker.dll"]