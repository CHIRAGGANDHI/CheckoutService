#See https://aka.ms/containerfastmode to understand how Visual Studio uses this Dockerfile to build your images for faster debugging.

FROM mcr.microsoft.com/dotnet/aspnet:6.0 AS base
WORKDIR /app
EXPOSE 80

FROM mcr.microsoft.com/dotnet/sdk:6.0 AS build
WORKDIR /src
COPY ["Checkout.API/Checkout.API.csproj", "Checkout.API/"]
COPY ["Checkout.Application/Checkout.Application.csproj", "Checkout.Application/"]
COPY ["Checkout.Domain/Checkout.Domain.csproj", "Checkout.Domain/"]
COPY ["Checkout.Infrastructure/Checkout.Infrastructure.csproj", "Checkout.Infrastructure/"]
RUN dotnet restore "Checkout.API/Checkout.API.csproj"
COPY . .
WORKDIR "/src/Checkout.API"
RUN dotnet build "Checkout.API.csproj" -c Release -o /app/build

FROM build AS publish
RUN dotnet publish "Checkout.API.csproj" -c Release -o /app/publish

FROM base AS final
WORKDIR /app
COPY --from=publish /app/publish .
ENTRYPOINT ["dotnet", "Checkout.API.dll"]