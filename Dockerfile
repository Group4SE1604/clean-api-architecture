# Use the official image as a parent image.
FROM mcr.microsoft.com/dotnet/sdk:6.0 AS build-env

# Set the working directory.
WORKDIR /app

# Copy csproj and restore dependencies
COPY *.sln ./
COPY src/BuberDinner.Api/*.csproj ./BuberDinner.Api/
COPY src/BuberDinner.Application/*.csproj ./BuberDinner.Application/
COPY src/BuberDinner.Contracts/*.csproj ./BuberDinner.Contracts/
COPY src/BuberDinner.Domain/*.csproj ./BuberDinner.Domain/
COPY src/BuberDinner.Infrastructure/*.csproj ./BuberDinner.Infrastructure/
RUN dotnet restore

# Copy everything else and build the project
COPY . ./
WORKDIR /app/BuberDinner.Api
RUN dotnet publish -c Release -o out

# Build runtime image
FROM mcr.microsoft.com/dotnet/aspnet:6.0
WORKDIR /app
COPY --from=build-env /app/src/BuberDinner.Api/out .
ENTRYPOINT ["dotnet", "BuberDinner.Api.dll"]