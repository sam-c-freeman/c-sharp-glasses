# Explore REST APIs with .NET and C#

Now that you have a handle on the basic syntax, we're going to look more closely at how to apply those skills to making a REST API server.

## Objectives

- explore server side frameworks for a new language
- create a REST API in a new language

## Research and exploration

Use the research skills you have developed this week to help you with this assignment. Just make sure that any resources you are referencing:

- Use .NET to build the API server
- Use the `dotnet` CLI tool to generate the starter code (also called "scaffolding").
- Do **not** use a database connection or Entity Framework (we will learn how to do this later).

A good starting place is [this tutorial from Microsoft](https://docs.microsoft.com/en-us/learn/modules/build-web-api-aspnet-core/).

> **NOTE:** When creating a new project with `dotnet`, use the `--no-https` flag. eg `dotnet new webapi -f net6.0 --no-https`. 
>
>  If you are getting errors about _certificates_, comment out the `app.UseHtttpsRedirection()` line from `Program.cs`

> **NOTE:** This tutorial asks you to install the `httprepl` tool. If you are having trouble installing this tool **use Postman** instead to make API Requests.

## Base

Our client, See Sharp Eyewear, is migrating their code base to C#. We will be creating a REST API for them.

The new C# See Sharp API must include the following endpoints:

- `GET /api/glasses` Returns an array of all eye glasses types
- `POST /api/glasses` Creates a new type of eye glasses
- `PUT /api/glasses/:id` Updates an existing type of eye glasses
- `DELETE /api/glasses/:id` Deletes a type of eye glasses

For this assignment, **do not use a database**. All data should be stored _in memory_ (ie, in a variable in your code).

Test your API using Postman.

----

By default, the `GET /api/glasses` endpoint should return a JSON array, like:

```js
[
    {
        id: 1,
        name: 'Ray-Ban Clubmaster',
        color: 'Brown / Gold',
        shape: 'browline',
    },
    {
        id: 2,
        name: 'Ottoto Bellona',
        color: 'Pink / Gold',
        shape: 'Oval'
    },
    {
        id: 3,
        name: 'Oakley Socket 5.5',
        color: 'Gunmetal',
        shape: 'Rectangle'
    }
]
```


## Stretch Goals

- Add a `GET /api/glasses/:id` endpoint, to get a single glasses type by id.
  - Return a `404` response if that id does not exist
- Update the `POST` and `PUT` endpoints to validate that the request body contains the correct properties for a glasses type. If not, respond with a `400` status code.
- Use the [HttpRepl](https://docs.microsoft.com/en-us/aspnet/core/web-api/http-repl/?view=aspnetcore-5.0&tabs=macos) CLI tool to test your API.
