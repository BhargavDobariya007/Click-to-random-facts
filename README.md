# Click-to-random-facts
.NET API Dashboard: Built with ASP.NET Core Minimal APIs and Razor Pages. It demonstrates safe API integration by using the .NET backend to proxy requests to an external fact API (HttpClient). The app fetches a random fact and displays it on the client side, showcasing modern, server-side data fetching.

##  Project Description

This project is a small, focused **API integration dashboard** built with **ASP.NET Core Minimal APIs** and Razor Pages.

It demonstrates a core concept of modern web development: **using a .NET backend to safely proxy external API requests**. The user interface features a button that calls a custom `.NET` endpoint (`/getfact`), which then fetches a random fact from the public Cat Fact API using the **`HttpClient`** service. The result is then displayed on the client side, showcasing a clean, server-side data fetching architecture.

## Installation Steps

To get this project running locally, follow these steps:

1.  **Prerequisites:** Ensure you have the [.NET SDK (v7 or later is recommended)](https://dotnet.microsoft.com/download) installed on your system.
2.  **Clone the Repository:** Open your terminal and clone this public repository:
    ```bash
    git clone https://github.com/BhargavDobariya007/Click-to-random-facts
    cd Click-to-random-facts\MyProject
    ```
3.  **Dependencies:** As this project uses the standard web app template, all necessary packages will be restored automatically upon running the project.

## How to Run the Project

1.  **Run the Application:** From the project's root directory (`YOUT_DIRECTORY\Click-to-random-facts\MyProject`), execute the following command:
    ```bash
    dotnet run
    ```
2.  **Access the Dashboard:** The terminal will provide a local URL (e.g., `http://localhost:5123` or `https://localhost:7001`). Open this URL in your web browser.
3.  **Test Functionality:** Click the **"Get New Fact"** button to trigger the full process: frontend request -> .NET backend -> External API -> .NET backend response -> frontend update.
