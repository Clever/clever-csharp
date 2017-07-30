rm -rf src/Clever || true
rm -rf src/Clever.Test || true

mv IO.Swagger.sln Clever.sln || true
mv src/IO.Swagger src/Clever || true
mv src/Clever/IO.Swagger.csproj src/Clever/Clever.csproj || true
mv src/Clever/IO.Swagger.nuspec src/Clever/Clever.nuspec || true
mv src/IO.Swagger.Test src/Clever.Test || true
mv src/Clever.Test/IO.Swagger.Test.csproj src/Clever.Test/Clever.Test.csproj || true

git grep -l 'IO.Swagger' -- './*' ':(exclude)override/override.sh' | xargs sed -i "" 's/IO.Swagger/Clever/g'

cp override/CleverEventJsonConverter.cs src/Clever/Client/

# Interactively merge these files
git checkout --patch master README.md
git checkout --patch master src/Clever/Client/ApiClient.cs
