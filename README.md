# demo-csharp

Skeleton project demonstrating C# and Xunit on the Engi network.

## Run

`dotnet test --logger:trx`

### Docker

`docker-compose up --exit-code-from tests`

Engi-compatible test runner output is in `/tmp/*.trx`