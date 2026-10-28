# Trainer guide

## Demo sequence (about 20 minutes)

1. Show the repository, README, Issues, and Pull Requests tabs.
2. Trigger a workflow with a small commit to `main` (if branch protection is not enabled yet).
3. Open Actions and inspect the job and individual steps.
4. Create a feature branch and modify the calculator plus tests.
5. Open a pull request and inspect its Checks section.
6. Introduce an incorrect expected value to make the test fail.
7. Read the logs, correct the test, push again, and show the successful run.
8. Discuss branch protection and requiring checks before merge.

## Learner task

Add a `CalculateTax` method or another small business rule:
- write at least two tests, including one boundary case;
- open a pull request;
- explain the CI result to a reviewer.

## Teaching points

- A workflow is YAML stored in `.github/workflows/`.
- `on` defines events that trigger the workflow.
- A job runs on a runner; steps execute actions or shell commands.
- `permissions: contents: read` follows least privilege for this workflow.
- A green build does not prove the application is correct; review and additional quality/security checks may still be needed.
- `actions/checkout@v4` and `actions/setup-dotnet@v4` are pinned to major versions for a simple training example. Production repositories should follow their organization's action pinning, update, and supply-chain security policy.
