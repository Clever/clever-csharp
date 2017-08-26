.PHONY: all test build run override
SHELL := /bin/bash

all: test build

test:
	/bin/sh mono_nunit_test.sh

build:
	/bin/sh build.sh

run: build
	echo "TODO run app"

override:
	./override/override.sh
