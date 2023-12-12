# Use the official image as a parent image.
FROM mcr.microsoft.com/dotnet/sdk:6.0 AS build-env

# Set the working directory.
WORKDIR /app

# Copy csproj and restore dependencies
COPY *.sln ./
COPY BuberDinner.Api/*.csproj ./BuberDinner.Api/
COPY BuberDinner.Application/*.csproj ./BuberDinner.Application/
COPY BuberDinner.Contracts/*.csproj ./BuberDinner.Contracts/
COPY BuberDinner.Domain/*.csproj ./BuberDinner.Domain/
COPY BuberDinner.Infrastructure/*.csproj ./BuberDinner.Infrastructure/
RUN dotnet restore

# Copy everything else and build the project
COPY . ./
WORKDIR /app/BuberDinner.Api
RUN dotnet publish -c Release -o out

# Build runtime image
FROM mcr.microsoft.com/dotnet/aspnet:6.0
WORKDIR /app
COPY --from=build-env /app/BuberDinner.Api/out .
ENTRYPOINT ["dotnet", "BuberDinner.Api.dll"]