#See https://aka.ms/containerfastmode to understand how Visual Studio uses this Dockerfile to build your images for faster debugging.

FROM registry.cn-shanghai.aliyuncs.com/yangww/dotnetruntime:v1.0 AS base
WORKDIR /app
EXPOSE 80
EXPOSE 443

FROM registry.cn-shanghai.aliyuncs.com/yangww/dotnetsdk:v1.0 AS build
WORKDIR /src
COPY ["src/NginxDemo.Api/NginxDemo.Api.csproj", "src/NginxDemo.Api/"]
RUN dotnet restore "src/NginxDemo.Api/NginxDemo.Api.csproj"
COPY . .
WORKDIR "/src/src/NginxDemo.Api"
RUN dotnet build "NginxDemo.Api.csproj" -c Release -o /app/build

FROM build AS publish
RUN dotnet publish "NginxDemo.Api.csproj" -c Release -o /app/publish

FROM base AS final
WORKDIR /app
COPY --from=publish /app/publish .
ENTRYPOINT ["dotnet", "NginxDemo.Api.dll"]