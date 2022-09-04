# Workshop - Unit Test / Automation Test with xUnit/nUnit/FluentAssertions - C# | .NET

How to create Unit Test or Automation Test with xUnit/nUnit/FluentAssertions and using C# / .NET

# Purpose
The purpose of this workshop is to show you how to create unit test scenarios and integration tests following best testing practices and using test libraries (xUnit, nUnit, FluentAssertions).
Some APIs have been created return values that are Mocking data to be used as test scenarios.

## What is unit test?
Unit testing is a way to test the functionality of only one resource to ensure that it is working the way it was designed to work.
If the functionality changes and the unit test continues to work, then this test has not been implemented correctly.

## How important is unit testing?
The importance of unit testing is to ensure that a feature will continue to work, even if new features are added. Unit tests are a guarantee for the developer/team that new code changes do not affect the functionality of others.

## What is test coverage?
Test coverage is a metric percentage of how much of our solution is covered by unit tests.
When creating a unit test, this test will call the method being tested. Each line of code that the interpreter passes is a line that will be covered. If a test is created to fail an IF and ELSE, if this test only passes the IF condition, the test will not cover the ELSE lines. Therefore, it is necessary to create two test cases to pass both conditions.

## How to create a unit test?
To create a unit test we need to create a test project.
By convention this project should be in a 'tests' folder.
The way to create the unit tests changes according to the library chosen for the test (Example: nUnit, xUnit).

## What is an integration test?
An integration of tests or integrated test is a type of test that validates our solution as a whole. His idea is not to specifically test features of our solution, but to test the entire functioning of the application as a whole.
This test normally tests if the application is correctly uploading with the instances and data needed to work.

## How to create an integration test?
BRD

----

## Architecture

```sh
-- src
  |__ ProjectTester.Domain
  |__ ProjectTester.Services
  |__ ProjectTester.WebApi
-- test
  |__ XUnitTests
     |__  ProjectTester.WebApi.Tests
```

### ProjectTester.Domain project
This project is responsible for containing the Domain (Models, Interfaces, Abstracts, Proprieties).

### ProjectTester.Services project
This project is responsible for containing all business logic or rules.

### ProjectTester.WebApi project
This project is responsible for containing the API controllers.

----

## What still needs to be implemented?

[ ] How to test an API;

[ ] How to test a library and its methods;

[ ] How to create a integration test;
