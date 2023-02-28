FROM mcr.microsoft.com/dotnet/aspnet:6.0 AS base
WORKDIR /app
EXPOSE 80
EXPOSE 443

FROM mcr.microsoft.com/dotnet/sdk:6.0 AS build
WORKDIR /src
COPY ["OcelotApiGWExample/OcelotApiGWExample.csproj", "OcelotApiGWExample/"]
RUN dotnet restore "OcelotApiGWExample/OcelotApiGWExample.csproj"
COPY . .
WORKDIR "/src/OcelotApiGWExample"
RUN dotnet build "OcelotApiGWExample.csproj" -c Release -o /app/build

FROM build AS publish
RUN dotnet publish "OcelotApiGWExample.csproj" -c Release -o /app/publish

FROM base AS final
WORKDIR /app
COPY --from=publish /app/publish .
ENTRYPOINT ["dotnet", "OcelotApiGWExample.dll"]
