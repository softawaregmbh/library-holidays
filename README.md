<h1 align="center">softaware.Holidays</h1>
<div align="center">
  <strong>A simple .netstandard library for automatically generating holidays</strong>
</div>

<div align="center">
  <h3>
	[Usage](#usage)
    <span> | </span>
	[Motivation](#motivation)
    <span> | </span>
	[Contributing](CONTRIBUTING.md)
    <span> | </span>
    [GitHub](https://github.com/softawaregmbh/library-holidays)
    <span> | </span>
    [NuGet](https://www.nuget.org/packages?q=softaware.holidays")
    <span> | </span>
    [Blog Article](TODO: insert link to blog article here")
  </h3>
</div>


## Usage
Install `softaware.Holidays.<Country>` from [nuget](https://www.nuget.org/packages?q=softaware.holidays) and then simply generate your holidays for a specific year using the following line of code:
```csharp
var holidays = new Holidays.Generator().ForAustria(2018); // Replace Austria with the country you want to generate the holidays for
```

## Motivation
TODO: add motivation here

## To-Dos
- [ ] add option for different federal states in `softaware.Holidays.Austria`
- [ ] more tests (additional years)

## References
- algorithm based on: https://de.wikipedia.org/wiki/Gaußsche_Osterformel
- Austrian Holidays based on: http://gesetzlichefeiertage.at/uebersicht/feiertage-2018.html
