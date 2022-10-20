#See https://aka.ms/containerfastmode to understand how Visual Studio uses this Dockerfile to build your images for faster debugging.

FROM mcr.microsoft.com/dotnet/aspnet:6.0 AS base
WORKDIR /app
EXPOSE 80
EXPOSE 443

FROM mcr.microsoft.com/dotnet/sdk:6.0 AS build
WORKDIR /src
COPY ["University.WebApi/University.WebApi.csproj", "University.WebApi/"]
RUN dotnet restore "University.WebApi/University.WebApi.csproj"
COPY . .
WORKDIR "/src/University.WebApi"
RUN dotnet build "University.WebApi.csproj" -c Release -o /app/build

FROM build AS publish
RUN dotnet publish "University.WebApi.csproj" -c Release -o /app/publish

FROM base AS final
WORKDIR /app
COPY --from=publish /app/publish .
ENTRYPOINT ["dotnet", "University.WebApi.dll"]