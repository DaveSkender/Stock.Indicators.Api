# Stock Indicators API

A self-hosted REST API that returns stock indicators, based on our [.NET library](https://dotnet.stockindicators.dev).

- pre-compiled, so you don't need to write C# code to use
- runs locally, on Linux, Windows, and other hosts
- interact with the API using standard Open API HTTP client commands (GET, POST, etc.)
- see [Releases](https://github.com/DaveSkender/Stock.Indicators.Api/releases) for the latest distributions
- see our [API documentation](https://api-docs.stockindicators.dev) for more information

## Getting started with self-hosting

Our [Released packages](https://github.com/DaveSkender/Stock.Indicators.Api/releases) can be used directly; however, some initial setup of your hosting environment is required.  If not already setup, [install the .NET Runtime](https://learn.microsoft.com/en-us/dotnet/core/install/) on your host.

### Run local host

1. Extract the `package.zip` or `package.tar.gz` file in a separate folder.
2. Update the `CorsOrigin: Website` value in the `appsettings.json` file (optional).
3. In a `bash` or command window, launch the API with `dotnet Api.dll` and observe the `localhost` URL and port number.
4. To confirm that it's operating, open a browser to the URL root endpoint (e.g. `http://localhost:5000/`) and you should see a `API is functioning nominally.` message.  Your application can now interact with all the HTTP endpoints.

### Run on Linux host

1. Instructions pending ...
2. Run the startup command `dotnet Api.dll`

## Getting started with your own version

If you'd like to start from a customized copy of our source code, [create a repository using the GitHub template](https://docs.github.com/en/repositories/creating-and-managing-repositories/creating-a-repository-from-a-template).

### Fetching updates (optional)

If you are customizing your API, but still also want updates from our core template, setup an `upstream` remote origin to periodically fetch and merge changes from our `main` branch.

1. Setup an alternate remote `upstream` source

   ```bash
   git remote add --no-tags -t main -m main upstream https://github.com/DaveSkender/Stock.Indicators.Api.git
   ```

2. Perform an initial `git merge` to catch up your base branch to our origin.

   ```bash
   # from your repository
   git checkout -b my-update
   git fetch upstream main
   git merge upstream/main
   ```

3. As desired, fetch and merge changes to get updates using the same method in step 3.  Address merge conflicts as usual.

See GitHub documentation to learn more about [managing remote repositories](https://docs.github.com/en/get-started/getting-started-with-git/managing-remote-repositories).  Alternatively, if you are okay with tighter GitHub integration and want a simpler approach, [setup a Fork](https://docs.github.com/en/pull-requests/collaborating-with-pull-requests/working-with-forks/about-forks) of our repository.

## Getting started as a contributor

See our [contributing guidelines](/docs/pages/contributing.md).
