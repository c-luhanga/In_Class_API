# JokeAPI Console Client

This is a simple C# console application that fetches a random joke from the [JokeAPI](https://v2.jokeapi.dev/joke/Any) and displays the result in the console.

## What to Expect
- The application makes an HTTP GET request to the JokeAPI endpoint.
- The response is printed in raw JSON format to the console.
- You may see either a single-part or two-part joke, depending on the API response.

## How to Run
1. Make sure you have the .NET SDK installed.
2. Open a terminal in the project directory.
3. Run the following command:
   ```
   dotnet run --project CoindeskApiClient/CoindeskApiClient.csproj
   ```

## Customization
- You can modify the API endpoint in `Program.cs` to fetch jokes from specific categories or with different filters. See the [JokeAPI documentation](https://jokeapi.dev/) for more options.

## Repository
This project is part of the `In_Class_API` repository.
