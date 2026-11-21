DOTNET_OPERATORS_PROJECT := tutorials/dotnet/practice/02-operators/OperatorsPractice.csproj
DOTNET_OPERATORS_TEST_PROJECT := tutorials/dotnet/practice/02-operators.Tests/OperatorsPractice.Tests.csproj
DOTNET ?= dotnet

.DEFAULT_GOAL := help

.PHONY: help dotnet-operators dotnet-operators-test
help:
	@echo "make dotnet-operators       Run tests, then run the operators program"
	@echo "make dotnet-operators-test  Run only the operators tests"

dotnet-operators: dotnet-operators-test
	@echo Running the operators practice program
	@$(DOTNET) run --project $(DOTNET_OPERATORS_PROJECT) --no-restore

dotnet-operators-test:
	@echo Testing the operators practice logic
	@$(DOTNET) test --project $(DOTNET_OPERATORS_TEST_PROJECT) --verbosity minimal
