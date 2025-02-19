# API Common Response Models Package

## Table of Contents
1. [Introduction](#introduction)
2. [Usage Guide](#usage-guide)
3. [Links](#links)

### Introduction
***
This package provides an essay way to work with responses when building APIs.

## Usage Guide
***
Download the package ```API.Common.Response.Models```.'
There is no need to register anything in the service collection. We have a couple of classes
* ```ApiBaseResponse``` is the base class from which all other response classes inherits. This class is intended to be the only you return from all your methods. You can then return the sub-classes within your methods based on the scenario.
* ```OkResponse``` is the response type returned when everything is OK.
* ```BadRequestResponse``` is the response when a request is invalid.
* ```NotFoundResponse``` is the response returned when the resource is not found.
* ```ForbiddenResponse``` is the response sent when a client is not have access to a resource.
* ```UnauthorizedResponse``` is the class returned when a request is unauthorized
* ```InternalServerErrorResponse``` included in verion `1.0.2` for unhandled exceptions.


Check out the [Github Repository](https://github.com/ojotobar/APICommonResponseModels) to see the implementations.

```
public async Task<ApiBaseResponse> GetAsync(Guid id)
{
	if(id == Guid.Empty)
	{
		return new BadRequestResponse("Invalid id")
	}

	var data = await _repository.GetDataAsync(id);
	if(data == null)
	{
		return new NotFoundResponse("Record not found");
	}

	return new OkResponse<DataModel>(data);
}
```

## Links
***
To view the source code or get in touch:
* [Github Repository Link](https://github.com/ojotobar/APICommonResponseModels)
* [Send Me A Mail](mailto:ojotobar@gmail.com)
