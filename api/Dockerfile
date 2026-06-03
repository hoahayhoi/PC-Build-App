# ===== Stage 1: Build =====
FROM mcr.microsoft.com/dotnet/sdk:8.0 AS build
WORKDIR /src

# Copy project file và restore dependencies
COPY api.csproj ./
RUN dotnet restore

# Copy toàn bộ source code
COPY . ./

# Build release
RUN dotnet publish -c Release -o /app/publish

# ===== Stage 2: Runtime =====
FROM mcr.microsoft.com/dotnet/aspnet:8.0 AS runtime
WORKDIR /app

# Cài đặt công cụ wait-for (chờ SQL Server sẵn sàng)
RUN apt-get update && apt-get install -y curl && rm -rf /var/lib/apt/lists/*

# Copy binary đã build
COPY --from=build /app/publish ./

# Copy entrypoint script
COPY entrypoint.sh ./
RUN chmod +x entrypoint.sh

EXPOSE 8080

ENTRYPOINT ["./entrypoint.sh"]
