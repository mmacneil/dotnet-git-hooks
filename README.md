# Improve Your .NET Git Commits With Husky.Net 🐺

This repo contains a sample project from [this tutorial](https://fullstackmark.com/post/30/improve-your-dotnet-git-commits-with-husky-dotnet) explaining how to set up Git hooks with [Husky.Net](https://github.com/alirezanet/husky.net).

The tutorial shows you how to use Husky to add a couple of hooks in a .NET project to run the `dotnet format` and `dotnet test` commands during the Git workflow.

A `pre-commit` hook that runs `dotnet format` to apply code styling rules to any files staged for commit.

<img src="docs/pre-commit-hook-demo.gif" />


A `pre-push` hook runs `dotnet test` to execute the unit tests before code can be pushed successfully to the remote repository.

<img src="docs/pre-push-hook-demo.gif" />

