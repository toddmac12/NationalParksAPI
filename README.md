### Setup and Use

#### Cloning

  1) Navigate to the [National Parks API](https://github.com/toddmac12/NationalParksAPI.git).
  2) Click 'Clone or download' to reveal the HTTPS url ending with .git and the 'Download ZIP' option.
  3) Open up your system Terminal or GitBash, navigate to your desktop with the command: `cd Desktop`, or whichever location suits you best.
  4) Clone the repository to your desktop: `$ git clone https://github.com/toddmac12/NationalParksAPI.git`
  5) Run the command `cd NationalParksAPI` to enter into the project directory.
  6) View or Edit:
      * Code Editor - Run the command `atom .` or `code .` to open the project in Atom or VisualStudio Code respectively for review and editing.
      * Text Editor - Open by double clicking on any of the files to open in a text editor.

#### Download

  1) Navigate to the [NationalParksAPI repository here](https://github.com/toddmac12/NationalParksAPI.git).
  2) Click 'Clone or download' to reveal the HTTPS url ending with .git and the 'Download ZIP' option.
  3) Click 'Download ZIP' and unextract.
  4) Open by double clicking on any of the files to open in a text editor.

#### AppSettings

  1) Create a new file in the NationalParksAPI.Solution/NationalParksAPI directory named `appsettings.json`
  2) Add in the following code snippet to the new appsettings.json file:
  
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

3)Change the server, port, and user id as necessary. Replace 'YourPassword' with relevant MySQL password (set at installation of MySQL).

#### Database

  1) Navigate to NationalParksAPI.Solution/NationalParksAPI directory using the MacOS Terminal or Windows Powershell (e.g. `cd Desktop/NationalParksAPI.Solution/NationalParksAPI`).
  2) Run the command `dotnet ef database update` to generate the database through Entity Framework Core.
  3) (Optional) To update the database with any changes to the code, run the command `dotnet ef migrations add <MigrationsName>` which will use Entity Framework Core's code-first principle to generate a database update. After, run the previous command `dotnet ef database update` to update the database.

#### Launch the API

  1) Navigate to NationalParksAPI.Solution/NationalParksAPI directory using the MacOS Terminal or Windows Powershell (e.g. `cd Desktop/NationalParksAPI.Solution/NationalParksAPI`).
  2) Run the command `dotnet run` to have access to the API in Postman or browser.

------------------------------

## API Documentation

Explore the API endpoints in Postman or a browser. You will not be able to utilize authentication in a browser.

### Using Swagger Documentation

To explore the CoffeeTracker API with NSwag, launch the project using `dotnet run` with the Terminal or Powershell, and input the following URL into your browser: `http://localhost:5000/swagger`

#### Example Query

```https://localhost:5000/api/Parks/?name=Park Name
```

..........................................................................................

### Endpoints

Base URL: `https://localhost:5000`

#### HTTP Request Structure

```POST /api/Parks
GET /api/Parks
PUT /api/Parks/{id}
DELETE /api/Parks/{id}
```

#### Example Query 1

```https://localhost:5001/api/Parks
```

#### Sample JSON Response

```{
     {
    "parkId": 1,
    "name": "string",
    "location": "string",
    "areaKmSquared": 200,
    "description": "string"
  }
}
```

..........................................................................................

### National PArks

Access information on National Parks in the United States.

#### HTTP Request

```GET /api/Parks
POST /api/Parks
GET /api/Parks/{id}
PUT /api/Parks/{id}
DELETE /api/Parks/{id}
```

#### Path Parameters

| Parameter |  Type  | Default | Required | Description                                                   |
| :-------: | :----: | :-----: | :------: | ------------------------------------------------------------- |
|   name    | string |  none   |  false   | Return matches by name.                                       |
|  origin   | string |  none   |  false   | Return any Parks from a specific country or region of origin. |
|  flavor   | string |  none   |  false   | Return Parks matches with a specific flavor profile.          |

#### Example Query 2

```https://localhost:5000/api/Parks/?origin=brazil&flavor=robust
```

#### Sample JSON Response 1

```{
     {
    "parkId": 1,
    "name": "string",
    "location": "string",
    "areaKmSquared": 200,
    "description": "string"
  }
}
```

..........................................................................................

### Parkss

Access information about popular coffee Parkss.

#### HTTP Request

```GET /api/Parks
POST /api/Parks
GET /api/Parks/{id}
PUT /api/Parks/{id}
DELETE /api/Parks/{id}
```

#### Path Parameters

| Parameter |  Type  | Default | Required | Description                                              |
| :-------: | :----: | :-----: | :------: | -------------------------------------------------------- |
|   parkId    | int |  none   |  true   | Return matches by parkId.                                  |
|   name    | string |  none   |  false   | Return Parks matches the park name. |
|  location  | string |  none   |  false   | Return Parks matches park location.            |
|   areaKmSquared    |  int   |  none   |  false   | Return Parks matches area size.  |
|   description    |  string   |  none   |  false   | Return Parks that matches decription.  |

#### Example Query

```https://localhost:5000/api/Parks/?parkId=1
```

#### Sample JSON Response

```{
     {
    "parkId": 1,
    "name": "string",
    "location": "string",
    "areaKmSquared": 200,
    "description": "string"
  }
}```

..........................................................................................

### National Parks

Access National Parks to get information about parks.

#### HTTP Request

```GET /api/Park
POST /api/Park
GET /api/Park/{id}
PUT /api/Park/{id}
DELETE /api/Park/{id}
```

#### Path Parameters

| Parameter  |  Type  | Default | Required | Description                                   |
| :--------: | :----: | :-----: | :------: | --------------------------------------------- |
|    name    | int |  none   |  false   | Return matches by name.                       |
| location | string |  none   |  false   | Return any Parks with a specific location. |

#### Example Query

``
<https://localhost:5000/api/Parks/?name=ParkName>

```#### Sample JSON Response

```{
     {
    "parkId": 1,
    "name": "string",
    "location": "string",
    "areaKmSquared": 200,
    "description": "string"
  }
}
```

------------------------------

###  Contributors

| Author        | GitHub |                              Email                               |
| ------------- | :----: | :--------------------------------------------------------------: |
| Anthony McRae |        | [anthonytoddmcrae@gmail.copm](mailto:anthonytoddmcrae@gmail.com) |

------------------------------

### ✉️ Contact and Support
