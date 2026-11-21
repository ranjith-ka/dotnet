DOTNET_OPERATORS_PROJECT := tutorials/dotnet/practice/02-operators/OperatorsPractice.csproj
DOTNET_OPERATORS_TEST_PROJECT := tutorials/dotnet/practice/02-operators.Tests/OperatorsPractice.Tests.csproj
MCP_API_PROJECT := projects/kubernetes-mcp/src/KubernetesMcp.Api/KubernetesMcp.Api.csproj
MCP_CLIENT_PROJECT := projects/kubernetes-mcp/src/KubernetesMcp.Client/KubernetesMcp.Client.csproj
MCP_TEST_PROJECT := projects/kubernetes-mcp/tests/KubernetesMcp.Tests/KubernetesMcp.Tests.csproj
DOTNET ?= dotnet

.DEFAULT_GOAL := help

.PHONY: help run basics test test-basics mcp pods pods-http inspect test-mcp test-mcp-unit dotnet-operators dotnet-operators-test
help:
	@echo "make basics / make run     Run foundations tests, then the beginner console app"
	@echo "make test-basics           Run foundations tests (also: make test)"
	@echo "make mcp                   Start the MCP API at http://localhost:5080/mcp"
	@echo "make pods-http             Print pods via the running MCP API (start make mcp first)"
	@echo "make test-mcp              Test MCP get_pods against kind-k8s: default, then kube-system"
	@echo "make test-mcp-unit         Run MCP tests without requiring a cluster"
	@echo "make pods                  Print pods via the C# MCP client: default, then kube-system"
	@echo "make inspect               Optional MCP Inspector (requires npm)"

run basics: dotnet-operators

mcp:
	@$(DOTNET) run --project $(MCP_API_PROJECT) --no-launch-profile -- --urls http://localhost:5080

pods:
	@$(DOTNET) run --project $(MCP_CLIENT_PROJECT) --verbosity quiet

pods-http:
	@$(DOTNET) run --project $(MCP_CLIENT_PROJECT) --verbosity quiet -- --http

inspect:
	@$(DOTNET) build $(MCP_API_PROJECT) --verbosity minimal
	@npx @modelcontextprotocol/inspector $(DOTNET) run --project $(MCP_API_PROJECT) --no-build -- --stdio

test test-basics: dotnet-operators-test

test-mcp:
	@RUN_K8S_TESTS=1 $(DOTNET) test --project $(MCP_TEST_PROJECT) --verbosity minimal

test-mcp-unit:
	@$(DOTNET) test --project $(MCP_TEST_PROJECT) --verbosity minimal

dotnet-operators: dotnet-operators-test
	@echo Running the C# foundations program
	@$(DOTNET) run --project $(DOTNET_OPERATORS_PROJECT) --no-restore

dotnet-operators-test:
	@echo Testing the operators practice logic
	@$(DOTNET) test --project $(DOTNET_OPERATORS_TEST_PROJECT) --verbosity minimal
