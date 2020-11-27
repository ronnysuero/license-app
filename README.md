# License APP

> License CRUD.

## Frontend built With

- [Vue](https://cli.vuejs.org/) - The web framework used
- [PrimeVue](https://primefaces.org/primevue/showcase/) - UI library

### Installing frontend

Get git source code :

```sh
$ git clone https://github.com/ronnysuero/license-app.git
$ cd LicenseApp/clientapp/
```

Download dependencies

```sh
$ npm install
```

## Backend built With

- [NetCore](https://docs.microsoft.com/en-us/dotnet/) - The webapi framework used

### Server

Connection String is already added, but if you need to change it, you need to go inside backend folder and there is a file called appsettings.json. This file contains all the configurations if you need change any else.

```json
    "ConnectionStrings": {
        "Local": "Data Source=.;Initial Catalog=DbLicenseApp;Integrated Security=true;MultipleActiveResultSets=True"
    }
```

AutoMigrations is already enabled by default, so you just need startup the project and that's it.

## Author

Ronny Zapata – ronnysuero@gmail.com

## License

This software is licensed under the [MIT](https://github.com/nhn/tui.editor/blob/master/LICENSE) ©