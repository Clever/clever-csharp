.PHONY: all test build run
SHELL := /bin/bash

all: test build

test:
	/bin/sh mono_nunit_test.sh

build:
	rm -r bin || true
	./override/override.sh
	/bin/sh build.sh

run: build
	echo "TODO run app"
