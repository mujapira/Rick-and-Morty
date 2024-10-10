FROM mcr.microsoft.com/dotnet/aspnet:8.0 AS base
WORKDIR /app
EXPOSE 5000

FROM mcr.microsoft.com/dotnet/sdk:8.0 AS build
ARG BUILD_CONFIGURATION=Release
WORKDIR /src

# Copiar os arquivos .csproj das classlibs e do projeto principal
COPY ["../WebApi/WebApi.csproj", "./WebApi/"]
COPY ["../Repository/Repository.csproj", "./Repository/"]
COPY ["../Service/Service.csproj", "./Service/"]

# Restaurar as dependências de todos os projetos
RUN dotnet restore "./WebApi/WebApi.csproj"

# Copiar o código do projeto para o container
COPY ../ .

# Compilar o projeto
RUN dotnet build "WebApi/WebApi.csproj" -c $BUILD_CONFIGURATION -o /app/build

FROM build AS publish
ARG BUILD_CONFIGURATION=Release
RUN dotnet publish "WebApi/WebApi.csproj" -c $BUILD_CONFIGURATION -o /app/publish /p:UseAppHost=false

FROM base AS final
WORKDIR /app
COPY --from=publish /app/publish .
ENTRYPOINT ["dotnet", "WebApi.dll"]