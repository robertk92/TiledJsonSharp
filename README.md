# TiledJsonSharp

A simple reflection-free Tiled JSON parser for C# using System.Text.Json.
XML formats are not supported.

Example usage:

```
using(Stream stream = new FileStream("Map.tmj", FileMode.Open)) {
    TiledMap map = TiledMap.FromStream(stream);
}
```
