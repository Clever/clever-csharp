# Notice

This repo is no longer maintained by Clever. We provide the Swagger definitions at https://github.com/Clever/swagger-api.

# Clever - the C# library for the Clever API

## Installation and API Documentation
View more detailed documentation [here](docs/README.md)

<a name="getting-started"></a>
## Getting Started

```csharp
using System;
using System.Diagnostics;
using Clever.Api;
using Clever.Client;
using Clever.Model;

namespace Test
{
    public static class Program
    {
        public static void Main()
        {

            // Note: This is hard coded for demo purposes only. Keep your access tokens secret!
            // https://dev.clever.com/docs/security#section-security-best-practices
            Configuration.Default.AccessToken = "TEST_TOKEN";

            var apiInstance = new DataApi();

            try
            {
                StudentsResponse result = apiInstance.GetStudents();
                foreach (var student in result.Data) {
                    Console.WriteLine("ID: {0}, Name: {1} {2}", student.Data.Id, student.Data.Name.First, student.Data.Name.Last);
                }
            }
            catch (Exception e)
            {
                Console.WriteLine("Exception when calling DataApi.GetStudents: " + e.Message );
            }

        }
    }
}
```

<a name="events-usage"></a>
## Events Usage
Since events are polymorphic you'll need to use a dynamic variable. For example:

```csharp
using System;
using System.Diagnostics;
using Clever.Api;
using Clever.Client;
using Clever.Model;

namespace Test
{
    public static class Events
    {
        public static void Main()
        {

            // Note: This is hard coded for demo purposes only. Keep your access tokens secret!
            // https://dev.clever.com/docs/security#section-security-best-practices
            Configuration.Default.AccessToken = "TEST_TOKEN";

            var apiInstance = new EventsApi();

            try
            {
                EventsResponse result = apiInstance.GetEvents();
                foreach (var eventObj in result.Data) {
                    dynamic eventData = eventObj.Data;
                    Console.WriteLine("Event Type:{0}, Data:{1}", eventObj.Data.GetType(), eventData.Data.ToString());
                }
            }
            catch (Exception e)
            {
                Console.WriteLine("Exception when calling EventsApi.GetEvents: " + e.Message );
            }

        }
    }
}
```

<a name="running-examples"></a>
## Running the Examples
This has been tested on MacOS with Mono. To install Mono run `brew install mono`.

Run `make build` on this library.

To build and run one of the examples, save it to a `.cs` file then, for example:
```
mcs /reference:bin/Clever.dll /reference:System.ComponentModel.DataAnnotations.dll Program.cs
cp bin/*.dll .
mono Program.exe
```

<a name="packaging"></a>
## Packaging

A `.nuspec` is included with the project. You can follow the Nuget quickstart to [create](https://docs.microsoft.com/en-us/nuget/quickstart/create-and-publish-a-package#create-the-package) and [publish](https://docs.microsoft.com/en-us/nuget/quickstart/create-and-publish-a-package#publish-the-package) packages.

This `.nuspec` uses placeholders from the `.csproj`, so build the `.csproj` directly:

```
nuget pack -Build -OutputDirectory out src/Clever/Clever.csproj
```

Then, publish to a [local feed](https://docs.microsoft.com/en-us/nuget/hosting-packages/local-feeds) or [other host](https://docs.microsoft.com/en-us/nuget/hosting-packages/overview) and consume the new package via Nuget as usual.

**Note**: Building from the `.csproj` does not work with Mono on Mac, so you will need to edit `.nuspec` file directly, replacing `$version$` with the correct version number, then run:
```
mono nuget.exe pack -Build -OutputDirectory out src/Clever/Clever.nuspec
```
<a name="publishing"></a>
## Publishing
To publish from Mac:
```
mono nuget.exe push out/Clever.X.X.X.nupkg API-KEY-FROM-1PFT -Source https://www.nuget.org/api/v2/package
```
Credentials are in 1PFT. More information about publishing to NuGet can be found [here](https://docs.microsoft.com/en-us/nuget/create-packages/publish-a-package)


<a name="updating-library"></a>
## Updating the Library
1. Git clone swagger-codegen (https://github.com/swagger-api/swagger-codegen) and build

2. Git clone Clever's swagger-api repo (https://github.com/Clever/swagger-api)

3. In the root directory of the swagger repo run:
```
java -jar modules/swagger-codegen-cli/target/swagger-codegen-cli.jar generate -i $PATH_TO_SWAGGER_API_REPO/v$VERSION-client.yml -l csharp -o $PATH_TO_THIS_REPO --additional-properties packageVersion=$VERSION
```
4. [Install Mono](http://www.mono-project.com/docs/getting-started/install/)

5. Run `make override` and follow the instructions.

6. Update the version in `src/Clever/Properties/AssemblyInfo.cs`, and also `src/Clever/Clever.nuspec` if you are building on Mac

7. After merging to master, don't forget to [package](#packaging) your changes and [publish](#publishing)
