#See https://aka.ms/containerfastmode to understand how Visual Studio uses this Dockerfile to build your images for faster debugging.

FROM mcr.microsoft.com/dotnet/aspnet:5.0 AS base
WORKDIR /app
EXPOSE 80
EXPOSE 443

FROM mcr.microsoft.com/dotnet/sdk:5.0 AS build
WORKDIR /src
COPY ["OrdemServicoAspNetMVC/OrdemServicoAspNetMVC.csproj", "OrdemServicoAspNetMVC/"]
RUN dotnet restore "OrdemServicoAspNetMVC/OrdemServicoAspNetMVC.csproj"
COPY . .
WORKDIR "/src/OrdemServicoAspNetMVC"
RUN dotnet build "OrdemServicoAspNetMVC.csproj" -c Release -o /app/build

FROM build AS publish
RUN dotnet publish "OrdemServicoAspNetMVC.csproj" -c Release -o /app/publish

FROM base AS final
WORKDIR /app
COPY --from=publish /app/publish .
ENTRYPOINT ["dotnet", "OrdemServicoAspNetMVC.dll"]