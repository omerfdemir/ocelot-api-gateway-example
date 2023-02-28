FROM mcr.microsoft.com/dotnet/aspnet:6.0 AS base
WORKDIR /app
EXPOSE 80
EXPOSE 443

FROM mcr.microsoft.com/dotnet/sdk:6.0 AS build
WORKDIR /src
COPY ["Product.Web.Api/Product.Web.Api.csproj", "Product.Web.Api/"]
RUN dotnet restore "Product.Web.Api/Product.Web.Api.csproj"
COPY . .
WORKDIR "/src/Product.Web.Api"
RUN dotnet build "Product.Web.Api.csproj" -c Release -o /app/build

FROM build AS publish
RUN dotnet publish "Product.Web.Api.csproj" -c Release -o /app/publish

FROM base AS final
WORKDIR /app
COPY --from=publish /app/publish .
ENTRYPOINT ["dotnet", "Product.Web.Api.dll"]
