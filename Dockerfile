#See https://aka.ms/customizecontainer to learn how to customize your debug container and how Visual Studio uses this Dockerfile to build your images for faster debugging.

FROM mcr.microsoft.com/dotnet/aspnet:8.0 AS base
USER app
WORKDIR /app
EXPOSE 8080

FROM mcr.microsoft.com/dotnet/sdk:8.0 AS build
ARG BUILD_CONFIGURATION=Release
WORKDIR /src
COPY ["Galaxi.Movie.API/Galaxi.Query.Movie.API.csproj", "Galaxi.Movie.API/"]
COPY ["Galaxi.Movie.Domain/Galaxi.Query.Movie.Domain.csproj", "Galaxi.Movie.Domain/"]
COPY ["Galaxi.Bus.Message/Galaxi.Query.Bus.Message.csproj", "Galaxi.Bus.Message/"]
COPY ["Galaxi.Movie.Data/Galaxi.Query.Movie.Data.csproj", "Galaxi.Movie.Data/"]
COPY ["Galaxi.Movie.Persistence/Galaxi.Query.Movie.Persistence.csproj", "Galaxi.Movie.Persistence/"]
RUN dotnet restore "./Galaxi.Movie.API/./Galaxi.Query.Movie.API.csproj"
COPY . .
WORKDIR "/src/Galaxi.Movie.API"
RUN dotnet build "./Galaxi.Query.Movie.API.csproj" -c $BUILD_CONFIGURATION -o /app/build

FROM build AS publish
ARG BUILD_CONFIGURATION=Release
RUN dotnet publish "./Galaxi.Query.Movie.API.csproj" -c $BUILD_CONFIGURATION -o /app/publish /p:UseAppHost=false

FROM base AS final
WORKDIR /app
COPY --from=publish /app/publish .
ENTRYPOINT ["dotnet", "Galaxi.Query.Movie.API.dll"]