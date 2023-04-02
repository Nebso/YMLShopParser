# YMLShopParser
.NET console application used for downloading a YML-style (Yandex Market Language) XML file from web, parsing shop and offer data it contains and saving it to a database via Entity Framework. A sample output to console in a CSV format is also provided. 
### Usage
There are two commands available after compiling the program

`dotnet run -- save <url>`

downloads the YML file from provided URL link and saves shop's name, URL and all offers associated with it at the moment of launching the app to a MS SQL Server database. Database can be changed to a different one by implementing the IRepository interface.

`dotnet run -- print <shopname>`

prints out all the provided shop's offers to console in a CSV format. Application output can be changed by implementing the IProvider interface.
