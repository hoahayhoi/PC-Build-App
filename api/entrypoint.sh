#!/bin/bash
set -e

echo "🚀 SQL Server đã sẵn sàng. Khởi động API..."
echo "📝 Migration sẽ được chạy tự động bởi Program.cs..."

exec dotnet api.dll
