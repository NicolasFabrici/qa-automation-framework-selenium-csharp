QA Automation Framework – Selenium C# (.NET 8)

Automation testing framework developed using modern best practices and scalable architecture.
C#
.NET 8
Selenium WebDriver
NUnit
Page Object Model (POM)
Explicit Waits (WebDriverWait)
JSON Configuration
Multi-Browser Support (Chrome / Edge)
Git / GitHub

Project Structure
QAFramework
│
├── Tests          → Test classes
├── Pages          → Page Object Model classes
├── Utilities      → Configuration & helpers
├── Config         → appsettings.json
└── QAFramework.csproj

Features:
Clean and scalable architecture
Separation of concerns (Tests / Pages / Config)
Explicit wait implementation
External configuration via JSON
Multi-browser execution
BaseTest and BasePage reusable structure

How to Run the Project:
Install Requirements
  .NET 8 SDK
  Google Chrome or Microsoft Edge

Verify installation:
  dotnet --version

Clone Repository:
  git clone https://github.com/YOURUSERNAME/qa-automation-framework-selenium-csharp.git
  cd qa-automation-framework-selenium-csharp/QAFramework

Restore and Run Tests
  dotnet restore
  dotnet test


Configuration: Browser and environment settings are managed in:
Config/appsettings.json

Design Pattern Used - This framework follows:
  Page Object Model (POM)
  Base Test abstraction
  Explicit Wait strategy
  Configuration-driven execution

Author:
Nicolas Fabrici
QA Automation Engineer
LinkedIn: https://www.linkedin.com/in/nicolas-fabrici-a842081b2/
