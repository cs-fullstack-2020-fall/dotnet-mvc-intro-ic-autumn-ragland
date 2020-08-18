# In class assignment for .NET MVC introduction

## Exercise 1: Create a new MVC Web Application

`dotnet new mvc -o mvcpractice`

1. Launch the Web Application
2. Hit the web application from the browser
3. Open Postman
* Create a new Postman project
* Add a test case for `Home Page` as an HTTP GET request
* Verify your web application is running using your Postman test
* Export your Postman test project and add to your repo

## Exercise 2: Create a Controller
1. Create a new Controller called `HelloWorldController` 
2. Add a `Home` method to the controller that returns the Content `Hello World`
3. Open Postman
* Open the Postman project create in Exercise 1
* Add a test case for `Hello World` as an HTTP GET request
* Verify your web application is running using your Postman test

## Exercise 3: Export Postman tests
* Export your Postman test project and add to your repo

## Challenge
- Modify your `HelloWorld` controller to accept a GET parameter called `name`
- Modify the endpoint to return `Hello World! Nice to see you [WHATEVERNAME_PASSED_IN]!`


