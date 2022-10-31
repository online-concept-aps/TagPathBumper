FROM mcr.microsoft.com/dotnet/sdk:6.0 as builder
COPY . .
RUN dotnet publish -c Release

RUN chmod +x entrypoint.sh
