Coding Challenge Task assumptions and implementation

Implementation

Choosed aspnet.mvc platform
Json file has been consumed directly from the server(stored in local folder)
Sample unit testing feature added

Key Assumptions

Only owners who have properties have been displayed. There is one entity in json file who has no properties. Its ignored as per the requirement.

Filters work independently. At a time, user can filter on gender or property. AND combination hasn't been implemented

It was expected to use JS. So what I've done is for Gender filter, I used simple Jquery to hide\show required rows based on filter value.
For Property filter, ajax call has been used


Improvements

In the interest of time, I couldn't include below ones.

Rich UI
DI implementation
Unit testing for controller through Mock Framework
Logging and Exception Handling


Deployment Instructions

Set up the solution and publish it locally. Home page has the requied output.
