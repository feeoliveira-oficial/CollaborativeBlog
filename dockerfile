FROM mcr.microsoft.com/dotnet/aspnet:8.0 AS base
WORKDIR /app
EXPOSE 80

FROM mcr.microsoft.com/dotnet/sdk:8.0 AS build
WORKDIR /src
COPY ["CollaborativeBlog.csproj", "./"]
RUN dotnet restore "./CollaborativeBlog.csproj"
COPY . .
WORKDIR "/src"
RUN dotnet build "CollaborativeBlog.csproj" -c Release -o /app/build

FROM build AS publish
RUN dotnet publish "CollaborativeBlog.csproj" -c Release -o /app/publish

FROM base AS final
WORKDIR /app
COPY --from=publish /app/publish .
ENTRYPOINT ["dotnet", "CollaborativeBlog.dll"]
