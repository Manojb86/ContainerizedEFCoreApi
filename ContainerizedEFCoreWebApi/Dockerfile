#See https://aka.ms/containerfastmode to understand how Visual Studio uses this Dockerfile to build your images for faster debugging.

FROM mcr.microsoft.com/dotnet/core/aspnet:3.1-buster-slim AS base
WORKDIR /app
EXPOSE 80
EXPOSE 443

FROM mcr.microsoft.com/dotnet/core/sdk:3.1-buster AS build
WORKDIR /src
COPY ["ContainerizedEFCoreWebApi/ContainerizedEFCoreWebApi.csproj", "ContainerizedEFCoreWebApi/"]
RUN dotnet restore "ContainerizedEFCoreWebApi/ContainerizedEFCoreWebApi.csproj"
COPY . .
WORKDIR "/src/ContainerizedEFCoreWebApi"
RUN dotnet build "ContainerizedEFCoreWebApi.csproj" -c Release -o /app/build

FROM build AS publish
RUN dotnet publish "ContainerizedEFCoreWebApi.csproj" -c Release -o /app/publish

FROM base AS final
WORKDIR /app
COPY --from=publish /app/publish .
ENTRYPOINT ["dotnet", "ContainerizedEFCoreWebApi.dll"]