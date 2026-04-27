# My Amazing App

Welcome to a tiny e-commerce order management demo written in C# and .NET 10. It creates a few sample customers and orders, stores them in an in-memory repository, and prints the results to the console like a very polite shopping clerk with zero coffee breaks.

## Project Overview

This repository contains a simple console application that demonstrates:

- Basic domain models for customers, products, orders, and order status
- A repository abstraction for working with orders
- An in-memory repository implementation for demo and learning purposes
- A straightforward console entry point that seeds sample data and displays results

If you want a production-ready commerce platform, this is not that. If you want a clean demo that does not immediately start a distributed systems incident, this is a better fit.

## Prerequisites

Before running the app, make sure you have:

- .NET 10 SDK installed
- A terminal such as PowerShell, Windows Terminal, or the VS Code integrated terminal
- A reasonable tolerance for sample data that really likes laptops and USB cables

You can verify your SDK with:

```powershell
dotnet --version
```

## Setup Instructions

1. Clone the repository.
2. Open the repository root in VS Code or your preferred editor.
3. Restore dependencies:

```powershell
dotnet restore MyAmazingApp.slnx
```

That is the whole setup. No database, no containers, no mysterious yak-shaving side quest.

## How To Run Locally

Run the console app from the repository root:

```powershell
dotnet run --project MyAmazingConsole/MyAmazingConsole.csproj
```

Or build first, then run:

```powershell
dotnet build MyAmazingApp.slnx
dotnet run --project MyAmazingConsole/MyAmazingConsole.csproj
```

When the app runs, it:

- Creates sample customers and orders
- Stores them in an in-memory repository
- Prints all orders
- Prints completed orders
- Prints the total order count
- Retrieves a specific order and shows its total cost

## How To Test

There is currently no automated test project in this repository.

For now, the practical test process is:

1. Build the solution.
2. Run the console app.
3. Confirm the output includes seeded orders, a completed-order section, and a total order count.

If you want to add automated tests later, a good next step would be a dedicated test project for the models and repository behavior.

## Project Structure

```text
.
|-- LICENSE
|-- MyAmazingApp.slnx
|-- README.md
`-- MyAmazingConsole/
	|-- MyAmazingConsole.csproj
	|-- Program.cs
	|-- Models/
	|   |-- CustomerInfo.cs
	|   |-- Order.cs
	|   |-- OrderStatus.cs
	|   `-- Product.cs
	`-- Repositories/
		|-- IOrderRepository.cs
		`-- InMemoryOrderRepository.cs
```

## Useful Commands

Restore dependencies:

```powershell
dotnet restore MyAmazingApp.slnx
```

Build the solution:

```powershell
dotnet build MyAmazingApp.slnx
```

Run the app:

```powershell
dotnet run --project MyAmazingConsole/MyAmazingConsole.csproj
```

Clean build output:

```powershell
dotnet clean MyAmazingApp.slnx
```

## Contributing Notes

Contributions are welcome.

If you update the project:

- Keep changes small and focused
- Preserve the existing simple structure unless there is a good reason to expand it
- Add or update documentation when behavior changes
- Consider adding automated tests if you introduce non-trivial logic

If you submit a pull request, make sure the app builds and runs locally first. Future you will appreciate present you. So will everyone else.

## License

This project is licensed under the MIT License. See the LICENSE file for details.
