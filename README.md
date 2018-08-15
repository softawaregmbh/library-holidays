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
    <a href="https://github.com/softawaregmbh/library-holidays">
      GitHub
    </a>
    <span> | </span>
    <a href="https://www.nuget.org/packages?q=softaware.holidays" target="_blank">
      NuGet
    </a>
    <span> | </span>
    <a href="https://softaware.at/codeaware/2018/08/16/softaware-holidays.html" target="_blank">
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
Some of our products need to be aware of holidays in order to function properly. In our latest project it was needed to calculate and distribute the correct work times.
Because of this requirement in more than one project we decided to create a little library that we can simply include via NuGet in order to calculate the holidays.
The main focus points of this library are *easiest possible usage*, *good readability* and *extensibility via composition*.
Read more about the motivation and extensibility on our blog: [softaware.Holidays - How Carl Friedrich Gauß helps us in resource planning and image categorization.](https://softaware.at/codeaware/2018/08/16/softaware-holidays.html).

## To-Dos
- [ ] add option for different federal states in `softaware.Holidays.Austria`
- [ ] add option if day is off or not (e.g. as realized in [`DanishHolidays.NET`](https://github.com/VisualBean/DanishHolidays.NET))
- [ ] more tests (additional years)

## References
- algorithm based on: https://de.wikipedia.org/wiki/Gaußsche_Osterformel
- Austrian Holidays based on: http://gesetzlichefeiertage.at/uebersicht/feiertage-2018.html
