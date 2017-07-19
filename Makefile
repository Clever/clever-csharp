.PHONY: all test build run
SHELL := /bin/bash

all: test build

test:
	echo "TODO test app"

build:
	git grep -l 'IO.Swagger' -- './*' ':(exclude)Makefile' | xargs -I sed 's/IO.Swagger/Clever/g'
	mv IO.Swagger.sln Clever.sln || true
	mv src/IO.Swagger src/Clever || true
	mv src/Clever/IO.Swagger.csproj src/Clever/Clever.csproj || true
	mv src/Clever/IO.Swagger.nuspec src/Clever/Clever.nuspec || true
	mv src/IO.Swagger.Test src/Clever.Test || true
	mv src/Clever.Test/IO.Swagger.Test.csproj src/Clever.Test/Clever.Test.csproj || true
	mv src/IO.Swagger.Test src/Clever.Test || true

	/bin/sh build.sh

run: build
	echo "TODO run app"
