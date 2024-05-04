# Mst.Response NuGet Package

## Description

This package includes the Response<T> class, which represents general purpose HTTP responses, used to standardize response generation and communication in APIs.

## Installation

Install it via the NuGet package manager:
```
Install-Package Mst.Response
```

or via the .NET CLI:
```
dotnet add package Mst.Response
```

or you can use NuGet UI on your IDE.

## Usage
- Return success with generic data and status code.
```Csharp
    SampleDataModel sampleDataModel = new()
    {
       FullName = "Mustafa Samet Turan"
    };

    Response<SampleDataModel>.Success(sampleDataModel, 200);
```

- Return success with only status code
```Csharp
    Response<NoDataModel>.Success(200);
```

- Return success with message and status code.
```Csharp
    Response<NoDataModel>.Success("Entity created!", 204);
```

- Return fail with one error message and status code.
```Csharp
    Response<NoDataModel>.Success("Entity not found!", 404);
```

- Return fail with multiple error messages and status code.
```Csharp
    List<string> errorList = new()
    {
        new("Validation error!"),
        new("Validation error 2!"),
    };
        
    Response<SampleDataModel>.Fail(errorList, 400);
```

## Contributing
Feel free to improve and comment! Thank you.

## License
`Mst.Response` NuGet package is licensed under MIT license.