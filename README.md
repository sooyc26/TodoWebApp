## About TodoWebApp
This project is a simple ASP.NET Core MVC web application that displays a list of To-Do items. Please read the entire README file before starting any work.

## Your Assignment
- Create an account on GitHub.com, if you do not already have one.
- Clone this repository on your local development environment. `git clone ...`
- Alternatively, you may fork this repository and push your changes to your own repository at the end of the assignment.
- Create a new local branch with your name, e.g. "john-smith". `git branch ...`
- Add functionality to the web app so users can edit and save the todo list item text. Upon saving an item's text, the request should redirect back to the newly-updated list.
- Add one field to the TodoListItem class to indicate if and when the item was edited. Display this field on the view of the item list if it has been edited.
- Bonus task: refactor the TodoController class to use Dependency Injection to get an instance of the TodoListService class. Hint: part of the work necessary is already done for you in Startup.cs.
- After these changes are implemented, your project should look and behave similarly to the website at: http://todo.pilatesanytime.com/
- Commit your changes with a descriptive message. `git commit ...`
- Push your changes to GitHub. `git push`

## Tools You'll Need
- git from https://git-scm.com/downloads
- dotnet core SDK 2.1 (and runtime) from https://dotnet.microsoft.com/download/dotnet-core/2.1. The latest 2.1.X version of the SDK and runtime are compatible, which as of this writing are SDK 2.1.607 and runtime 2.1.14. You can check which version(s) are installed in your environment by running `dotnet --info`
- Visual Studio Community 2019 https://visualstudio.microsoft.com/vs/community/ (if you're not using Windows, Visual Studio Code is an alternative: https://code.visualstudio.com/Download. If you must use Visual Studio Code, much of your work will be in the command line using `git` and `dotnet`.)

## Notes
- If you need any help or clarification during the assignment, do not be shy! Contact Alex via email for assistance.
- You are encouraged to use any online documentation, Stack Overflow, or similar resources to complete the assignment. This is how developers solve problems every day!
- Microsoft documentation for dotnet 2.1: https://docs.microsoft.com/en-us/aspnet/core/getting-started/?view=aspnetcore-2.1.
- Feel free to use Visual Studio's integrated source control features instead of the `git` commands shown in the assignment instructions if you prefer.
- You may require additional permissions on your GitHub.com account to perform some actions; please contact Alex if so.
- The URL for this repository: https://github.com/alex-parsons/TodoWebApp
