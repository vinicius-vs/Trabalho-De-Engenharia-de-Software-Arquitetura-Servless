#See https://aka.ms/containerfastmode to understand how Visual Studio uses this Dockerfile to build your images for faster debugging.

FROM mcr.microsoft.com/dotnet/aspnet:6.0 AS base
WORKDIR /app
EXPOSE 80
EXPOSE 443

FROM mcr.microsoft.com/dotnet/sdk:6.0 AS build
WORKDIR /src
COPY ["Servless-GeracaoDeBoleto/Servless-GeracaoDeBoleto.csproj", "Servless-GeracaoDeBoleto/"]
RUN dotnet restore "Servless-GeracaoDeBoleto/Servless-GeracaoDeBoleto.csproj"
COPY . .
WORKDIR "/src/Servless-GeracaoDeBoleto"
RUN dotnet build "Servless-GeracaoDeBoleto.csproj" -c Release -o /app/build

FROM build AS publish
RUN dotnet publish "Servless-GeracaoDeBoleto.csproj" -c Release -o /app/publish

FROM base AS final
WORKDIR /app
COPY --from=publish /app/publish .
ENTRYPOINT ["dotnet", "Servless-GeracaoDeBoleto.dll"]