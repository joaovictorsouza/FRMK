#See https://aka.ms/containerfastmode to understand how Visual Studio uses this Dockerfile to build your images for faster debugging.

FROM mcr.microsoft.com/dotnet/aspnet:6.0 AS base
WORKDIR /app
EXPOSE 80
EXPOSE 443

FROM mcr.microsoft.com/dotnet/sdk:6.0 AS build
WORKDIR /src
COPY ["FRML.API/FRML.API.csproj", "FRML.API/"]
RUN dotnet restore "FRML.API/FRML.API.csproj"
COPY . .
WORKDIR "/src/FRML.API"
RUN dotnet build "FRML.API.csproj" -c Release -o /app/build

FROM build AS publish
RUN dotnet publish "FRML.API.csproj" -c Release -o /app/publish

FROM base AS final
WORKDIR /app
COPY --from=publish /app/publish .
ENTRYPOINT ["dotnet", "FRML.API.dll"]