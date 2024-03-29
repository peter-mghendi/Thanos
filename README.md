![Banner](https://media.githubusercontent.com/media/sixpeteunder/Thanos/main/Images/Banner.png)

# Thanos

[![GitHub Actions Status](https://github.com/sixpeteunder/Thanos/workflows/Build/badge.svg?branch=main)](https://github.com/sixpeteunder/Thanos/actions) [![Thanos NuGet Package Downloads](https://img.shields.io/nuget/dt/Thanos)](https://www.nuget.org/packages/Thanos)

[![GitHub Actions Build History](https://buildstats.info/github/chart/sixpeteunder/Thanos?branch=main&includeBuildsFromPullRequest=false)](https://github.com/sixpeteunder/Thanos/actions)


This universe is finite, its resources, finite.

Free up disk space by randomly deleting half of the items in a folder.

*Inspired by [Thanos JS](https://thanosjs.org/).*

## Installation

Thanos can be installed from [NuGet](#) via the dotnet CLI.

```bash
    dotnet add package Thanos
```

## Usage

There are also complete, safe, runnable samples [here](https://github.com/sixpeteunder/Thanos.Samples).

### C#

> These examples use C# 10 syntax.

```csharp
    // A new mad titan called Thanos.
    var thanos = new MadTitan();

    // Forge a new Infinity Gauntlet.
    var gauntlet = new InfinityGauntlet();

    // Give Thanos the gauntlet
    // You may choose to add the stones then give Thanos the gauntlet.
    // The most important thing is that everything is in place before calling Snap() 
    thanos.Give(gauntlet: gauntlet);

    // Add the Infinity Stones.
    gauntlet.Add(stone: new SpaceStone());
    gauntlet.Add(stone: new MindStone());
    gauntlet.Add(stone: new RealityStone());
    gauntlet.Add(stone: new PowerStone());
    gauntlet.Add(stone: new TimeStone());
    gauntlet.Add(stone: new SoulStone());

    // The Snappening
    // This won't work if Thanos doesn't have a gauntlet or all the stones.
    _ = thanos.Snap(location: "C:/Windows"); // LOL, don't actually do this.
```

Alternatively, go straight to The Snappening:

```csharp
    MadTitan.Snappen(location: "C:/Windows"); // Use a different folder!!
```


### F#

> These examples use F# 6 syntax.

```fsharp
    // A new mad titan called Thanos.
    let thanos = new MadTitan()

    // Forge a new Infinity Gauntlet.
    let gauntlet = new InfinityGauntlet()

    // Give Thanos the gauntlet
    // You may choose to add the stones then give Thanos the gauntlet.
    // The most important thing is that everything is in place before calling Snap() 
    thanos.Give gauntlet;

    // Add the Infinity Stones.
    gauntlet.Add (new SpaceStone())
    gauntlet.Add (new MindStone())
    gauntlet.Add (new RealityStone())
    gauntlet.Add (new PowerStone())
    gauntlet.Add (new TimeStone())
    gauntlet.Add (new SoulStone())

    // The Snappening
    // This won't work if Thanos doesn't have a gauntlet or all the stones.
    thanos.Snap "C:/Windows" |> ignore // LOL, don't actually do this.
```

Alternatively, go straight to The Snappening:

```fsharp
    MadTitan.Snappen "C:/Windows" // Use a different folder!!
```

### Visual Basic .NET

> These examples use Visual Basic .NET 15 syntax.

```vbnet
    ' A new mad titan called Thanos.
    Dim thanos As New MadTitan

    ' Forge a new Infinity Gauntlet.
    Dim gauntlet As New InfinityGauntlet

    ' Give Thanos the gauntlet
    ' You may choose to add the stones then give Thanos the gauntlet.
    ' The most important thing is that everything is in place before calling Snap() 
    thanos.Give(gauntlet)

    ' Add the Infinity Stones.
    gauntlet.Add(New SpaceStone)
    gauntlet.Add(New MindStone)
    gauntlet.Add(New RealityStone)
    gauntlet.Add(New PowerStone)
    gauntlet.Add(New TimeStone)
    gauntlet.Add(New SoulStone)

    ' The Snappening
    ' This won't work if Thanos doesn't have a gauntlet or all the stones.
    thanos.Snap("C:/Windows") ' LOL, don't actually do this.
```

Alternatively, go straight to The Snappening:

```vbnet
    MadTitan.Snappen("C:/Windows") ' Use a different folder!!
```

## Running Tests

Clone the repository:

```bash
    git clone https://github.com/sixpeteunder/Thanos.git
```

or

```bash
    gh clone sixpeteunder/Thanos
```

Change to the project dir:

```bash
    cd Thanos
```

Run tests:

> This requires the .NET 6 SDK.

```bash
    dotnet test
```

## Contributing

Now why would you want to do that?
