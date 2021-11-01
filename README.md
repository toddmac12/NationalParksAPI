# National Parks API

## Description

Web API for National Parks in the United States.

## Technologies Used

|C# |  Swagger|
|---|---|
| .NET 5 | MySQL|
|   MSBuild| git|
|   HTML|   Entity|
|   CSS|   JavaScript|

### Setup and Use

#### Cloning

1. Navigate to the [National Parks API](https://github.com/toddmac12/NationalParksAPI.git).
2. Click 'Clone or download' to reveal the HTTPS url ending with .git and the 'Download ZIP' option.
3. Open up your system Terminal or GitBash, navigate to your desktop with the command: `cd Desktop`.
4. Clone the repository to your desktop: `$ git clone https://github.com/toddmac12/NationalParksAPI.git`
5. Run the command `cd NationalParksAPI` to enter into the project directory.
6. View or Edit:
   - Code Editor - Run the command `code .` to open the project in VisualStudio Code review and editing.
   - Text Editor - Open by double clicking on any of the files to open in a text editor.

#### Download

1. Navigate to the [NationalParksAPI repository here](https://github.com/toddmac12/NationalParksAPI.git).
2. Click 'Clone or download' to reveal the HTTPS url ending with .git and the 'Download ZIP' option.
3. Click 'Download ZIP' and unextract.
4. Open by double clicking on any of the files to open in a text editor.

#### AppSettings

1. Create a new file in the NationalParksAPI.Solution/NationalParksAPI directory named `appsettings.json`
2. Add in the following code snippet to the new appsettings.json file:

```{
  "Logging": {
      "LogLevel": {
      "Default": "Warning"
      }
  },
  "AllowedHosts": "*",
  "ConnectionStrings": {
      "DefaultConnection": "Server=localhost;Port=3306;database=NationalParks;uid=root;pwd=YourPassword;"
  }
}
```

3.Change the server, port, and user id as necessary. Replace 'YourPassword' with relevant MySQL password (set at installation of MySQL).

#### Database

1. Navigate to NationalParksAPI.Solution/NationalParksAPI directory using the MacOS Terminal or Windows Powershell (e.g. `cd Desktop/NationalParksAPI.Solution/NationalParksAPI`).
2. Run the command `dotnet ef database update` to generate the database through Entity Framework Core.
3. (Optional) To update the database with any changes to the code, run the command `dotnet ef migrations add <MigrationsName>` which will use Entity Framework Core's code-first principle to generate a database update. After, run the previous command `dotnet ef database update` to update the database.

#### Launch the API

1. Navigate to NationalParksAPI.Solution/NationalParksAPI directory using the MacOS Terminal or Windows Powershell (e.g. `cd Desktop/NationalParksAPI.Solution/NationalParksAPI`).
2. Run the command `dotnet run` to have access to the API in Postman or browser.

---

## API Documentation

Explore the API endpoints in Postman or a browser. You will not be able to utilize authentication in a browser.

### Using Swagger Documentation

To explore the NationalParks API with Swagger, launch the project using `dotnet run` with the Terminal or Powershell, and input the following URL into your browser: `http://localhost:5000/swagger`

..........................................................................................

### Endpoints

#### GET requests

- `http://localhost:5000/api/nationalparks/parks`
  - GETs all National Parks in the database. The database is seeded with information from Alagnak Wild River national park.

\*`http://localhost:5000/api/nationalparks/parks?name=<YOUR QUERY HERE>`

- GETs any National Parks with a name that matches your query

\*`http://localhost:5000/api/nationalparks/parks?location=<YOUR QUERY HERE>`

- GETs any National Parks with a location that matches your query

\*`http://localhost:5000/api/nationalparks/parks?description=<YOUR QUERY HERE>`

- GETs any National Parks that have a description containing your query

\*`http://localhost:5000/api/nationalparks/parks/{ID}`

- GETs the National Park with the Id as specified in the request

#### POST

- `http://localhost:5000/api/nationalparks/parks`
  - POSTs a new National Park to the API

#### DELETE

- `http://localhost:5000/api/nationalparks/parks/{ID}`
  - DELETEs the National Park with the Id as specified in the request

#### PUT

- `http://localhost:5000/api/nationalparks/parks/{ID}`
  - PUTs new data into the National Park entry with the Id as specified in the request

---

### Contributors

| Author        | GitHub |                              Email                               |
| ------------- | :----: | :--------------------------------------------------------------: |
| Anthony McRae |        | [anthonytoddmcrae@gmail.com](mailto:anthonytoddmcrae@gmail.com) |
