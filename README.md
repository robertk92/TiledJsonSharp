# TiledJsonSharp

A simple reflection-free Tiled JSON parser for C# using System.Text.Json.
XML formats are not supported.
Tested against Tiled version 1.10.1

Installation:

Just add all .cs files to your own project.

Example usage:

```
using(Stream stream = new FileStream("Map.tmj", FileMode.Open)) {
    TiledMap map = TiledMap.FromStream(stream);
}
```
