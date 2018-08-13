<h1 align="center">softaware.Holidays</h1>
<div align="center">
  <strong>A simple .netstandard library for automatically generating holidays</strong>
</div>

<div align="center">
  <h3>
    <a href="#usage">
      Usage
    </a>
    <span> | </span>
    <a href="#motivation">
      Motivation
    </a>
    <span> | </span>
    <a href="CONTRIBUTING.md">
      Contributing
    </a>
    <span> | </span>
    <a href="https://github.com/softawaregmbh/library-holidays">
      GitHub
    </a>
    <span> | </span>
    <a href="https://www.nuget.org/packages?q=softaware.holidays">
      NuGet
    </a>
    <span> | </span>
    <a href="TODO: insert link to blog article here">
      Blog Article
    </a>
  </h3>
</div>


## Usage
Install `softaware.Holidays.<Country>` from [NuGet](https://www.nuget.org/packages?q=softaware.holidays) and then simply generate your holidays for a specific year using the following line of code:
```csharp
var holidays = new Holidays.Generator().ForAustria(2018); // // Replace Austria with the country you want to generate the holidays for
```

## Motivation
TODO: add motivation here

## To-Dos
- [ ] add option for different federal states in `softaware.Holidays.Austria`
- [ ] more tests (additional years)

## References
- algorithm based on: https://de.wikipedia.org/wiki/Gaußsche_Osterformel
- Austrian Holidays based on: http://gesetzlichefeiertage.at/uebersicht/feiertage-2018.html
