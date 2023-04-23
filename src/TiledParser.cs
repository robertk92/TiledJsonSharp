using System.Text.Json;

namespace TiledJsonSharp
{
    public static class TiledParser
    {
        public static TiledMap ParseMap(JsonElement mapElement)
        {
            TiledMap map = new TiledMap();
            if(mapElement.TryGetProperty("backgroundcolor", out JsonElement backgroundColorElement)) {
                map.BackgroundColor = backgroundColorElement.GetString();
            }
            if(mapElement.TryGetProperty("class", out JsonElement classElement)) {
                map.Class = classElement.GetString();
            }
            if(mapElement.TryGetProperty("compressionlevel", out JsonElement compressionLevelElement)) {
                map.CompressionLevel = compressionLevelElement.GetInt32();
            }
            if(mapElement.TryGetProperty("height", out JsonElement heightElement)) {
                map.Height = heightElement.GetInt32();
            }
            if(mapElement.TryGetProperty("hexsidelength", out JsonElement hexSideLengthElement)) {
                map.HexSideLength = hexSideLengthElement.GetInt32();
            }
            if(mapElement.TryGetProperty("infinite", out JsonElement infiniteElement)) {
                map.Infinite = infiniteElement.GetBoolean();
            }
            if(mapElement.TryGetProperty("layers", out JsonElement layersArrayElement)) {
                int numLayers = layersArrayElement.GetArrayLength();
                map.Layers = new TiledLayer[numLayers];

                for(int i = 0; i < numLayers; i++) {
                    map.Layers[i] = ParseLayer(layersArrayElement[i]);
                }
            }
            if(mapElement.TryGetProperty("nextlayerid", out JsonElement nextLayerElement)) {
                map.NextLayerId = nextLayerElement.GetInt32();
            }
            if(mapElement.TryGetProperty("nextobjectid", out JsonElement nextObjectIdElement)) {
                map.NextObjectId = nextObjectIdElement.GetInt32();
            }
            if(mapElement.TryGetProperty("orientation", out JsonElement orientationElement)) {
                map.Orientation = orientationElement.GetString();
            }
            if(mapElement.TryGetProperty("parallaxoriginx", out JsonElement parallaxOriginXElement)) {
                map.ParallaxOriginX = parallaxOriginXElement.GetDouble();
            }
            if(mapElement.TryGetProperty("parallaxoriginy", out JsonElement parallaxOriginYElement)) {
                map.ParallaxOriginY = parallaxOriginYElement.GetDouble();
            }
            if(mapElement.TryGetProperty("properties", out JsonElement propertiesArrayElement)) {
                int numProperties = propertiesArrayElement.GetArrayLength();
                map.Properties = new TiledProperty[numProperties];

                for(int i = 0; i < numProperties; i++) {
                    map.Properties[i] = ParseProperty(propertiesArrayElement[i]);
                }
            }
            if(mapElement.TryGetProperty("renderorder", out JsonElement renderOrderElement)) {
                map.RenderOrder = renderOrderElement.GetString();
            }
            if(mapElement.TryGetProperty("staggeraxis", out JsonElement staggerAxisElement)) {
                map.StaggerAxis = staggerAxisElement.GetString();
            }
            if(mapElement.TryGetProperty("staggerindex", out JsonElement staggerIndexElement)) {
                map.StaggerIndex = staggerIndexElement.GetString();
            }
            if(mapElement.TryGetProperty("tiledversion", out JsonElement tiledVersionElement)) {
                map.TiledVersion = tiledVersionElement.GetString();
            }
            if(mapElement.TryGetProperty("tileheight", out JsonElement tileHeightElement)) {
                map.TileHeight = tileHeightElement.GetInt32();
            }
            if(mapElement.TryGetProperty("tilesets", out JsonElement tileSetsArrayElement)) {
                int numTileSets = tileSetsArrayElement.GetArrayLength();
                map.TileSets = new TiledTileSet[numTileSets];

                for(int i = 0; i < numTileSets; i++) {
                    map.TileSets[i] = ParseTileSet(tileSetsArrayElement[i]);
                }
            }
            if(mapElement.TryGetProperty("tilewidth", out JsonElement tileWidthElement)) {
                map.TileWidth = tileWidthElement.GetInt32();
            }
            if(mapElement.TryGetProperty("type", out JsonElement typeElement)) {
                map.Type = typeElement.GetString();
            }
            if(mapElement.TryGetProperty("version", out JsonElement versionElement)) {
                map.Version = versionElement.GetString();
            }
            if(mapElement.TryGetProperty("width", out JsonElement widthElement)) {
                map.Width = widthElement.GetInt32();
            }

            return map;
        }

        public static TiledObjectTemplate ParseObjectTemplate(JsonElement objectTemplateElement)
        {
            TiledObjectTemplate template = new TiledObjectTemplate();

            if(objectTemplateElement.TryGetProperty("type", out JsonElement typeElement)) {
                template.Type = typeElement.GetString();
            }
            if(objectTemplateElement.TryGetProperty("tileset", out JsonElement tileSetElement)) {
                template.TileSet = ParseTileSet(tileSetElement);
            }
            if(objectTemplateElement.TryGetProperty("object", out JsonElement objectElement)) {
                template.Object = ParseObject(objectElement);
            }

            return template;
        }

        private static TiledLayer ParseLayer(JsonElement layerElement)
        {
            TiledLayer layer = new TiledLayer();
            if(layerElement.TryGetProperty("chunks", out JsonElement chunksArrayElement)) {
                int numChunks = chunksArrayElement.GetArrayLength();
                layer.Chunks = new TiledChunk[numChunks];

                for(int i = 0; i < numChunks; i++) {
                    JsonElement chunkElement = chunksArrayElement[i];
                    TiledChunk chunk = new TiledChunk();
                    if(chunkElement.TryGetProperty("data", out JsonElement chunkDataElement)) {
                        if(chunkDataElement.ValueKind == JsonValueKind.Array) {
                            int numGids = chunkDataElement.GetArrayLength();
                            chunk.Data = new uint[numGids];

                            for(int j = 0; j < numGids; j++) {
                                ((uint[])chunk.Data)[j] = chunkDataElement[j].GetUInt32();
                            }
                        }
                        else {
                            chunk.Data = chunkElement.GetString();
                        }
                    }
                    layer.Chunks[i] = chunk;
                }
            }
            if(layerElement.TryGetProperty("class", out JsonElement classElement)) {
                layer.Class = classElement.GetString();
            }
            if(layerElement.TryGetProperty("compression", out JsonElement compressionElement)) {
                layer.Compression = compressionElement.GetString();
            }
            if(layerElement.TryGetProperty("data", out JsonElement dataElement)) {
                if(dataElement.ValueKind == JsonValueKind.Array) {
                    int numGids = dataElement.GetArrayLength();
                    layer.Data = new uint[numGids];

                    for(int i = 0; i < numGids; i++) {
                        ((uint[])layer.Data)[i] = dataElement[i].GetUInt32();
                    }
                }
                else {
                    layer.Data = dataElement.GetString();
                }
            }
            if(layerElement.TryGetProperty("draworder", out JsonElement drawOrderElement)) {
                layer.DrawOrder = drawOrderElement.GetString();
            }
            if(layerElement.TryGetProperty("encoding", out JsonElement encodingElement)) {
                layer.Encoding = encodingElement.GetString();
            }
            if(layerElement.TryGetProperty("height", out JsonElement heightElement)) {
                layer.Height = heightElement.GetInt32();
            }
            if(layerElement.TryGetProperty("id", out JsonElement idElement)) {
                layer.Id = idElement.GetInt32();
            }
            if(layerElement.TryGetProperty("image", out JsonElement imageElement)) {
                layer.Image = imageElement.GetString();
            }
            if(layerElement.TryGetProperty("layers", out JsonElement subLayersArrayElement)) {
                int numSubLayers = subLayersArrayElement.GetArrayLength();
                layer.Layers = new TiledLayer[numSubLayers];

                for(int i = 0; i < numSubLayers; i++) {
                    layer.Layers[i] = ParseLayer(subLayersArrayElement[i]);
                }
            }
            if(layerElement.TryGetProperty("locked", out JsonElement lockedElement)) {
                layer.Locked = lockedElement.GetBoolean();
            }
            if(layerElement.TryGetProperty("name", out JsonElement nameElement)) {
                layer.Name = nameElement.GetString();
            }
            if(layerElement.TryGetProperty("objects", out JsonElement objectsArrayElement)) {
                int numObjects = objectsArrayElement.GetArrayLength();
                layer.Objects = new TiledObject[numObjects];

                for(int i = 0; i < numObjects; i++) {
                    layer.Objects[i] = ParseObject(objectsArrayElement[i]);
                }
            }
            if(layerElement.TryGetProperty("offsetx", out JsonElement offsetXElement)) {
                layer.OffsetX = offsetXElement.GetDouble();
            }
            if(layerElement.TryGetProperty("offsety", out JsonElement offsetYElement)) {
                layer.OffsetY = offsetYElement.GetDouble();
            }
            if(layerElement.TryGetProperty("opacity", out JsonElement opacityElement)) {
                layer.Opacity = opacityElement.GetDouble();
            }
            if(layerElement.TryGetProperty("parallaxx", out JsonElement parallaxXElement)) {
                layer.ParallaxX = parallaxXElement.GetDouble();
            }
            if(layerElement.TryGetProperty("parallaxy", out JsonElement parallaxYElement)) {
                layer.ParallaxY = parallaxYElement.GetDouble();
            }
            if(layerElement.TryGetProperty("properties", out JsonElement propertiesArrayElement)) {
                int numProperties = propertiesArrayElement.GetArrayLength();
                layer.Properties = new TiledProperty[numProperties];

                for(int i = 0; i < numProperties; i++) {
                    layer.Properties[i] = ParseProperty(propertiesArrayElement[i]);
                }
            }
            if(layerElement.TryGetProperty("repeatx", out JsonElement repeatXElement)) {
                layer.RepeatX = repeatXElement.GetBoolean();
            }
            if(layerElement.TryGetProperty("repeaty", out JsonElement repeatYElement)) {
                layer.RepeatY = repeatYElement.GetBoolean();
            }
            if(layerElement.TryGetProperty("startx", out JsonElement startXElement)) {
                layer.StartX = startXElement.GetInt32();
            }
            if(layerElement.TryGetProperty("starty", out JsonElement startYElement)) {
                layer.StartY = startYElement.GetInt32();
            }
            if(layerElement.TryGetProperty("tintcolor", out JsonElement tintColorElement)) {
                layer.TintColor = tintColorElement.GetString();
            }
            if(layerElement.TryGetProperty("transparentcolor", out JsonElement transparentColorElement)) {
                layer.TransparentColor = transparentColorElement.GetString();
            }
            if(layerElement.TryGetProperty("type", out JsonElement typeElement)) {
                layer.Type = typeElement.GetString();
            }
            if(layerElement.TryGetProperty("visible", out JsonElement visibleElement)) {
                layer.Visible = visibleElement.GetBoolean();
            }
            if(layerElement.TryGetProperty("width", out JsonElement widthElement)) {
                layer.Width = widthElement.GetInt32();
            }
            if(layerElement.TryGetProperty("x", out JsonElement xElement)) {
                layer.X = xElement.GetInt32();
            }
            if(layerElement.TryGetProperty("y", out JsonElement yElement)) {
                layer.Y = yElement.GetInt32();
            }

            return layer;
        }

        private static TiledObject ParseObject(JsonElement objectElement)
        {
            TiledObject obj = new TiledObject();
            if(objectElement.TryGetProperty("ellipse", out JsonElement ellipseElement)) {
                obj.Ellipse = ellipseElement.GetBoolean();
            }
            if(objectElement.TryGetProperty("gid", out JsonElement gidElement)) {
                obj.Gid = gidElement.GetInt32();
            }
            if(objectElement.TryGetProperty("height", out JsonElement heightElement)) {
                obj.Height = heightElement.GetDouble();
            }
            if(objectElement.TryGetProperty("id", out JsonElement idElement)) {
                obj.Id = idElement.GetInt32();
            }
            if(objectElement.TryGetProperty("name", out JsonElement nameElement)) {
                obj.Name = nameElement.GetString();
            }
            if(objectElement.TryGetProperty("point", out JsonElement pointElement)) {
                obj.Point = pointElement.GetBoolean();
            }
            if(objectElement.TryGetProperty("polygon", out JsonElement polygonArrayElement)) {
                int numPoints = polygonArrayElement.GetArrayLength();
                obj.Polygon = new TiledPoint[numPoints];

                for(int i = 0; i < numPoints; i++) {
                    obj.Polygon[i] = ParsePoint(polygonArrayElement[i]);
                }
            }
            if(objectElement.TryGetProperty("polyline", out JsonElement polylineArrayElement)) {
                int numPoints = polylineArrayElement.GetArrayLength();
                obj.Polyline = new TiledPoint[numPoints];

                for(int i = 0; i < numPoints; i++) {
                    obj.Polyline[i] = ParsePoint(polylineArrayElement[i]);
                }
            }
            if(objectElement.TryGetProperty("properties", out JsonElement propertiesArrayElement)) {
                int numProperties = propertiesArrayElement.GetArrayLength();
                obj.Properties = new TiledProperty[numProperties];

                for(int i = 0; i < numProperties; i++) {
                    obj.Properties[i] = ParseProperty(propertiesArrayElement[i]);
                }
            }
            if(objectElement.TryGetProperty("rotation", out JsonElement rotationElement)) {
                obj.Rotation = rotationElement.GetDouble();
            }
            if(objectElement.TryGetProperty("template", out JsonElement templateElement)) {
                obj.Template = templateElement.GetString();
            }
            if(objectElement.TryGetProperty("text", out JsonElement textElement)) {
                obj.Text = ParseText(textElement);
            }
            if(objectElement.TryGetProperty("type", out JsonElement typeElement)) {
                obj.Type = typeElement.GetString();
            }
            if(objectElement.TryGetProperty("visible", out JsonElement visibleElement)) {
                obj.Visible = visibleElement.GetBoolean();
            }
            if(objectElement.TryGetProperty("width", out JsonElement widthElement)) {
                obj.Width = widthElement.GetDouble();
            }
            if(objectElement.TryGetProperty("x", out JsonElement xElement)) {
                obj.X = xElement.GetDouble();
            }
            if(objectElement.TryGetProperty("y", out JsonElement yElement)) {
                obj.Y = yElement.GetDouble();
            }

            return obj;
        }
        
        private static TiledProperty ParseProperty(JsonElement propertyElement)
        {
            TiledProperty property = new TiledProperty();
            if(propertyElement.TryGetProperty("name", out JsonElement nameElement)) {
                property.Name = nameElement.GetString();
            }
            if(propertyElement.TryGetProperty("type", out JsonElement typeElement)) {
                property.Type = typeElement.GetString();
            }
            if(propertyElement.TryGetProperty("propertytype", out JsonElement propertyTypeElement)) {
                property.PropertyType = propertyTypeElement.GetString();
            }
            if(propertyElement.TryGetProperty("value", out JsonElement valueElement)) {
                switch(property.Type) {
                    case "string":
                        property.Value = valueElement.GetString();
                        break;
                    case "int":
                        property.Value = valueElement.GetInt32();
                        break;
                    case "float":
                        property.Value = valueElement.GetSingle();
                        break;
                    case "bool":
                        property.Value = valueElement.GetBoolean();
                        break;
                    case "color":
                        property.Value = valueElement.GetString();
                        break;
                    case "file":
                        property.Value = valueElement.GetString();
                        break;
                    case "object":
                        property.Value = valueElement.GetInt32();
                        break;
                    case "class":
                        property.Value = valueElement.GetString();
                        break;
                }
            }

            return property;
        }

        private static TiledPoint ParsePoint(JsonElement pointElement)
        {
            TiledPoint point = new TiledPoint();

            if(pointElement.TryGetProperty("x", out JsonElement xElement)) {
                point.X = xElement.GetDouble();
            }
            if(pointElement.TryGetProperty("y", out JsonElement yElement)) {
                point.Y = yElement.GetDouble();
            }

            return point;
        }

        private static TiledText ParseText(JsonElement textElement)
        {
            TiledText text = new TiledText();

            if(textElement.TryGetProperty("bold", out JsonElement boldElement)) {
                text.Bold = boldElement.GetBoolean();
            }
            if(textElement.TryGetProperty("color", out JsonElement colorElement)) {
                text.Color = colorElement.GetString();
            }
            if(textElement.TryGetProperty("fontfamily", out JsonElement fontFamilyElement)) {
                text.FontFamily = fontFamilyElement.GetString();
            }
            if(textElement.TryGetProperty("halign", out JsonElement hAlignElement)) {
                text.HAlign = hAlignElement.GetString();
            }
            if(textElement.TryGetProperty("italic", out JsonElement italicElement)) {
                text.Italic = italicElement.GetBoolean();
            }
            if(textElement.TryGetProperty("kerning", out JsonElement kerningElement)) {
                text.Kerning = kerningElement.GetBoolean();
            }
            if(textElement.TryGetProperty("pixelsize", out JsonElement pixelSizeElement)) {
                text.PixelSize = pixelSizeElement.GetInt32();
            }
            if(textElement.TryGetProperty("strikeout", out JsonElement strikeoutElement)) {
                text.Strikeout = strikeoutElement.GetBoolean();
            }
            if(textElement.TryGetProperty("text", out JsonElement textStringElement)) {
                text.Text = textStringElement.GetString();
            }
            if(textElement.TryGetProperty("underline", out JsonElement underlineElement)) {
                text.Underline = underlineElement.GetBoolean();
            }
            if(textElement.TryGetProperty("valign", out JsonElement vAlignElement)) {
                text.VAlign = vAlignElement.GetString();
            }
            if(textElement.TryGetProperty("wrap", out JsonElement wrapElement)) {
                text.Wrap = wrapElement.GetBoolean();
            }

            return text;
        }

        private static TiledTileSet ParseTileSet(JsonElement tileSetElement)
        {
            TiledTileSet tileSet = new TiledTileSet();

            if(tileSetElement.TryGetProperty("backgroundcolor", out JsonElement backgroundColorElement)) {
                tileSet.BackgroundColor = backgroundColorElement.GetString();
            }
            if(tileSetElement.TryGetProperty("class", out JsonElement classElement)) {
                tileSet.Class = classElement.GetString();
            }
            if(tileSetElement.TryGetProperty("columns", out JsonElement columnsElement)) {
                tileSet.Columns = columnsElement.GetInt32();
            }
            if(tileSetElement.TryGetProperty("fillmode", out JsonElement fillModeElement)) {
                tileSet.FillMode = fillModeElement.GetString();
            }
            if(tileSetElement.TryGetProperty("firstgid", out JsonElement firstGidElement)) {
                tileSet.FirstGid = firstGidElement.GetInt32();
            }
            if(tileSetElement.TryGetProperty("grid", out JsonElement gridElement)) {
                tileSet.Grid = ParseGrid(gridElement);
            }
            if(tileSetElement.TryGetProperty("image", out JsonElement imageElement)) {
                tileSet.Image = imageElement.GetString();
            }
            if(tileSetElement.TryGetProperty("imageheight", out JsonElement imageHeightElement)) {
                tileSet.ImageHeight = imageHeightElement.GetInt32();
            }
            if(tileSetElement.TryGetProperty("imagewidth", out JsonElement imageWidthElement)) {
                tileSet.ImageWidth = imageWidthElement.GetInt32();
            }
            if(tileSetElement.TryGetProperty("margin", out JsonElement marginElement)) {
                tileSet.Margin = marginElement.GetInt32();
            }
            if(tileSetElement.TryGetProperty("name", out JsonElement nameElement)) {
                tileSet.Name = nameElement.GetString();
            }
            if(tileSetElement.TryGetProperty("objectalignment", out JsonElement objectAlignmentElement)) {
                tileSet.ObjectAlignment = objectAlignmentElement.GetString();
            }
            if(tileSetElement.TryGetProperty("properties", out JsonElement propertiesArrayElement)) {
                int numProperties = propertiesArrayElement.GetArrayLength();
                tileSet.Properties = new TiledProperty[numProperties];

                for(int i = 0; i < numProperties; i++) {
                    tileSet.Properties[i] = ParseProperty(propertiesArrayElement[i]);
                }
            }
            if(tileSetElement.TryGetProperty("source", out JsonElement sourceElement)) {
                tileSet.Source = sourceElement.GetString();
            }
            if(tileSetElement.TryGetProperty("spacing", out JsonElement spacingElement)) {
                tileSet.Spacing = spacingElement.GetInt32();
            }
            if(tileSetElement.TryGetProperty("terrains", out JsonElement terrainsArrayElement)) {
                int numTerrains = terrainsArrayElement.GetArrayLength();
                tileSet.Terrains = new TiledTerrain[numTerrains];

                for(int i = 0; i < numTerrains; i++) {
                    tileSet.Terrains[i] = ParseTerrain(terrainsArrayElement[i]);
                }
            }
            if(tileSetElement.TryGetProperty("tilecount", out JsonElement tileCountElement)) {
                tileSet.TileCount = tileCountElement.GetInt32();
            }
            if(tileSetElement.TryGetProperty("tiledversion", out JsonElement tiledVersionElement)) {
                tileSet.TiledVersion = tiledVersionElement.GetString();
            }
            if(tileSetElement.TryGetProperty("tileheight", out JsonElement tileHeightElement)) {
                tileSet.TileHeight = tileHeightElement.GetInt32();
            }
            if(tileSetElement.TryGetProperty("tileoffset", out JsonElement tileOffsetElement)) {
                tileSet.TileOffset = ParseTileOffset(tileOffsetElement);
            }
            if(tileSetElement.TryGetProperty("tilerendersize", out JsonElement tileRenderSizeElement)) {
                tileSet.TileRenderSize = tileRenderSizeElement.GetString();
            }
            if(tileSetElement.TryGetProperty("tiles", out JsonElement tilesArrayElement)) {
                int numTiles = tilesArrayElement.GetArrayLength();
                tileSet.Tiles = new TiledTile[numTiles];

                for(int i = 0; i < numTiles; i++) {
                    tileSet.Tiles[i] = ParseTile(tilesArrayElement[i]);
                }
            }
            if(tileSetElement.TryGetProperty("tilewidth", out JsonElement tileWidthElement)) {
                tileSet.TileWidth = tileWidthElement.GetInt32();
            }
            if(tileSetElement.TryGetProperty("transformations", out JsonElement transformationsElement)) {
                tileSet.Transformations = ParseTransformations(transformationsElement);
            }
            if(tileSetElement.TryGetProperty("transparentcolor", out JsonElement transparentColorElement)) {
                tileSet.TransparentColor = transparentColorElement.GetString();
            }
            if(tileSetElement.TryGetProperty("type", out JsonElement typeElement)) {
                tileSet.Type = typeElement.GetString();
            }
            if(tileSetElement.TryGetProperty("version", out JsonElement versionElement)) {
                tileSet.Version = versionElement.GetString();
            }
            if(tileSetElement.TryGetProperty("wangsets", out JsonElement wangSetsArrayElement)) {
                int numWangsets = wangSetsArrayElement.GetArrayLength();
                tileSet.WangSets = new TiledWangSet[numWangsets];

                for(int i = 0; i < numWangsets; i++) {
                    tileSet.WangSets[i] = ParseWangSet(wangSetsArrayElement[i]);
                }
            }

            return tileSet;
        }

        private static TiledGrid ParseGrid(JsonElement gridElement)
        {
            TiledGrid grid = new TiledGrid();

            if(gridElement.TryGetProperty("height", out JsonElement heightElement)) {
                grid.Height = heightElement.GetInt32();
            }
            if(gridElement.TryGetProperty("orientation", out JsonElement orientationElement)) {
                grid.Orientation = orientationElement.GetString();
            }
            if(gridElement.TryGetProperty("width", out JsonElement widthElement)) {
                grid.Width = widthElement.GetInt32();
            }

            return grid;
        }

        private static TiledTerrain ParseTerrain(JsonElement terrainElement)
        {
            TiledTerrain terrain = new TiledTerrain();

            if(terrainElement.TryGetProperty("name", out JsonElement nameElement)) {
                terrain.Name = nameElement.GetString();
            }
            if(terrainElement.TryGetProperty("properties", out JsonElement propertiesArrayElement)) {
                int numProperties = propertiesArrayElement.GetArrayLength();
                terrain.Properties = new TiledProperty[numProperties];

                for(int i = 0; i < numProperties; i++) {
                    terrain.Properties[i] = ParseProperty(propertiesArrayElement[i]);
                }
            }
            if(terrainElement.TryGetProperty("tile", out JsonElement tileElement)) {
                terrain.Tile = tileElement.GetInt32();
            }

            return terrain;
        }

        private static TiledTileOffset ParseTileOffset(JsonElement tileOffsetElement)
        {
            TiledTileOffset tileOffset = new TiledTileOffset();

            if(tileOffsetElement.TryGetProperty("x", out JsonElement xElement)) {
                tileOffset.X = xElement.GetInt32();
            }
            if(tileOffsetElement.TryGetProperty("y", out JsonElement yElement)) {
                tileOffset.Y = yElement.GetInt32();
            }

            return tileOffset;
        }

        private static TiledTransformations ParseTransformations(JsonElement transformationsElement)
        {
            TiledTransformations transformations = new TiledTransformations();

            if(transformationsElement.TryGetProperty("hflip", out JsonElement hFlipElement)) {
                transformations.HFlip = hFlipElement.GetBoolean();
            }
            if(transformationsElement.TryGetProperty("vflip", out JsonElement vFlipElement)) {
                transformations.VFlip = vFlipElement.GetBoolean();
            }
            if(transformationsElement.TryGetProperty("rotate", out JsonElement rotateElement)) {
                transformations.Rotate = rotateElement.GetBoolean();
            }
            if(transformationsElement.TryGetProperty("preferuntransformed", out JsonElement preferUntransformedElement)) {
                transformations.PreferUntransformed = preferUntransformedElement.GetBoolean();
            }

            return transformations;
        }

        private static TiledTile ParseTile(JsonElement tileElement)
        {
            TiledTile tile = new TiledTile();

            if(tileElement.TryGetProperty("animation", out JsonElement animationArrayElement)) {
                int numFrames = animationArrayElement.GetArrayLength();
                tile.Animation = new TiledFrame[numFrames];

                for(int i = 0; i < numFrames; i++) {
                    tile.Animation[i] = ParseFrame(animationArrayElement[i]);
                }
            }
            if(tileElement.TryGetProperty("id", out JsonElement idElement)) {
                tile.Id = idElement.GetInt32();
            }
            if(tileElement.TryGetProperty("image", out JsonElement imageElement)) {
                tile.Image = imageElement.GetString();
            }
            if(tileElement.TryGetProperty("imageheight", out JsonElement imageHeightElement)) {
                tile.ImageHeight = imageHeightElement.GetInt32();
            }
            if(tileElement.TryGetProperty("imagewidth", out JsonElement imageWidthElement)) {
                tile.ImageWidth = imageWidthElement.GetInt32();
            }
            if(tileElement.TryGetProperty("x", out JsonElement xElement)) {
                tile.X = xElement.GetInt32();
            }
            if(tileElement.TryGetProperty("y", out JsonElement yElement)) {
                tile.Y = yElement.GetInt32();
            }
            if(tileElement.TryGetProperty("width", out JsonElement widthElement)) {
                tile.Width = widthElement.GetInt32();
            }
            if(tileElement.TryGetProperty("height", out JsonElement heightElement)) {
                tile.Height = heightElement.GetInt32();
            }
            if(tileElement.TryGetProperty("objectgroup", out JsonElement objectGroupElement)) {
                tile.ObjectGroup = ParseLayer(objectGroupElement);
            }
            if(tileElement.TryGetProperty("probability", out JsonElement probabilityElement)) {
                tile.Probability = probabilityElement.GetDouble();
            }
            if(tileElement.TryGetProperty("properties", out JsonElement propertiesArrayElement)) {
                int numProperties = propertiesArrayElement.GetArrayLength();
                tile.Properties = new TiledProperty[numProperties];

                for(int i = 0; i < numProperties; i++) {
                    tile.Properties[i] = ParseProperty(propertiesArrayElement[i]);
                }
            }
            if(tileElement.TryGetProperty("terrain", out JsonElement terrainArrayElement)) {
                int numIndices = terrainArrayElement.GetArrayLength();
                tile.Terrain = new int[numIndices];

                for(int i = 0; i < numIndices; i++) {
                    tile.Terrain[i] = terrainArrayElement[i].GetInt32();
                }
            }
            if(tileElement.TryGetProperty("type", out JsonElement typeElement)) {
                tile.Type = typeElement.GetString();
            }

            return tile;
        }

        private static TiledFrame ParseFrame(JsonElement frameElement)
        {
            TiledFrame frame = new TiledFrame();

            if(frameElement.TryGetProperty("duration", out JsonElement durationElement)) {
                frame.Duration = durationElement.GetInt32();
            }
            if(frameElement.TryGetProperty("tileid", out JsonElement tileIdElement)) {
                frame.TileId = tileIdElement.GetInt32();
            }

            return frame;
        }

        private static TiledWangSet ParseWangSet(JsonElement wangSetElement)
        {
            TiledWangSet wangSet = new TiledWangSet();

            if(wangSetElement.TryGetProperty("class", out JsonElement classElement)) {
                wangSet.Class = classElement.GetString();
            }
            if(wangSetElement.TryGetProperty("colors", out JsonElement colorsArrayElement)) {
                int numColors = colorsArrayElement.GetArrayLength();
                wangSet.Colors = new TiledWangColor[numColors];

                for(int i = 0; i < numColors; i++) {
                    wangSet.Colors[i] = ParseWangColor(colorsArrayElement[i]);
                }
            }
            if(wangSetElement.TryGetProperty("name", out JsonElement nameElement)) {
                wangSet.Name = nameElement.GetString();
            }
            if(wangSetElement.TryGetProperty("properties", out JsonElement propertiesArrayElement)) {
                int numProperties = propertiesArrayElement.GetArrayLength();
                wangSet.Properties = new TiledProperty[numProperties];

                for(int i = 0; i < numProperties; i++) {
                    wangSet.Properties[i] = ParseProperty(propertiesArrayElement[i]);
                }
            }
            if(wangSetElement.TryGetProperty("tile", out JsonElement tileElement)) {
                wangSet.Tile = tileElement.GetInt32();
            }
            if(wangSetElement.TryGetProperty("type", out JsonElement typeElement)) {
                wangSet.Type = typeElement.GetString();
            }
            if(wangSetElement.TryGetProperty("wangtiles", out JsonElement wangTilesArrayElement)) {
                int numWangTiles = wangTilesArrayElement.GetArrayLength();
                wangSet.WangTiles = new TiledWangTile[numWangTiles];

                for(int i = 0; i < numWangTiles; i++) {
                    wangSet.WangTiles[i] = ParseWangTile(wangTilesArrayElement[i]);
                }
            }

            return wangSet;
        }

        private static TiledWangColor ParseWangColor(JsonElement wangColorElement)
        {
            TiledWangColor wangColor = new TiledWangColor();

            if(wangColorElement.TryGetProperty("class", out JsonElement classElement)) {
                wangColor.Class = classElement.GetString();
            }
            if(wangColorElement.TryGetProperty("color", out JsonElement colorElement)) {
                wangColor.Color = colorElement.GetString();
            }
            if(wangColorElement.TryGetProperty("name", out JsonElement nameElement)) {
                wangColor.Name = nameElement.GetString();
            }
            if(wangColorElement.TryGetProperty("probability", out JsonElement probabilityElement)) {
                wangColor.Probability = probabilityElement.GetDouble();
            }
            if(wangColorElement.TryGetProperty("properties", out JsonElement propertiesArrayElement)) {
                int numProperties = propertiesArrayElement.GetArrayLength();
                wangColor.Properties = new TiledProperty[numProperties];

                for(int i = 0; i < numProperties; i++) {
                    wangColor.Properties[i] = ParseProperty(propertiesArrayElement[i]);
                }
            }
            if(wangColorElement.TryGetProperty("tile", out JsonElement tileElement)) {
                wangColor.Tile = tileElement.GetInt32();
            }

            return wangColor;
        }

        private static TiledWangTile ParseWangTile(JsonElement wangTileElement)
        {
            TiledWangTile wangTile = new TiledWangTile();

            if(wangTileElement.TryGetProperty("tileid", out JsonElement tileIdElement)) {
                wangTile.TileId = tileIdElement.GetInt32();
            }
            if(wangTileElement.TryGetProperty("wangid", out JsonElement wangIdArrayElement)) {
                int numIndices = wangIdArrayElement.GetArrayLength();
                wangTile.WangId = new byte[numIndices];

                for(int i = 0; i < numIndices; i++) {
                    wangTile.WangId[i] = wangIdArrayElement[i].GetByte();
                }
            }

            return wangTile;
        }
    }
}
