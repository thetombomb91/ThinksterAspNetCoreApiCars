# ASP.Net Core API Exercise

This repository contains a GET exercise sample for ASP.Net Core API Exercise.

## Overview
The goal of this exercise is to implement a GET action that returns a collection of Car objects. The in-memory database a CarRepository.cs service have already been implemented and do not need any modifications. It is up to you to complete the CarsController.cs so the router https://(YourEndpoint)/api/cars returns a collection of cars. 

## Expectations

 - Setup the Route for your controller
 - Using **dependency injection** get access to the CarRepository service interface.
 - Implement an **asynchronous** http GET call that returns the whole collection of Cars from the in memory database.
 - Return the correct **status codes** based on a succes or non-successful call to the GET method
 - Verify inside of Postman that calling https://(YourEndpoint)/api/cars returns full list of Cars. 
