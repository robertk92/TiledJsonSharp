# TiledJsonSharp

A simple reflection-free Tiled JSON parser for C# using System.Text.Json.
XML formats are not supported.

Installation:

Just add all .cs files to your own project.

Example usage:

```
using(Stream stream = new FileStream("Map.tmj", FileMode.Open)) {
    TiledMap map = TiledMap.FromStream(stream);
}
```
