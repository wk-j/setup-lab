# MyWeb Project

This is a .NET Core web application with a PostgreSQL database.

## Build Instructions

1. Ensure you have the following prerequisites installed:
   - .NET SDK 8.0 or later
   - Docker and Docker Compose

2. Clone the repository:
   ```
   git clone https://github.com/yourusername/MyWeb.git
   cd MyWeb
   ```

3. Build and run the project using Docker Compose:
   ```
   docker-compose up --build
   ```

   This command will build the Docker images and start the containers for both the web application and the PostgreSQL database.

4. Once the containers are running, you can access the application at:
   http://localhost:8080

5. To stop the application, use:
   ```
   docker-compose down
   ```

## Development

For local development without Docker:

1. Ensure you have PostgreSQL installed and running locally.

2. Update the connection string in `src/MyWeb/appsettings.Development.json` to point to your local PostgreSQL instance.

3. Navigate to the project directory:
   ```
   cd src/MyWeb
   ```

4. Run the application:
   ```
   dotnet run
   ```

The application will be available at http://localhost:5000 (or https://localhost:5001 for HTTPS).

## Running Tests

To run the API tests:

1. Ensure the application is running.

2. Install [Hurl](https://hurl.dev/) if you haven't already.

3. Run the tests:
   ```
   hurl --test resources/student_api_tests/*.hurl
   ```

This will execute all the API tests located in the `resources/student_api_tests/` directory.
