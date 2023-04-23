namespace TiledJsonSharp
{
    public static class StreamUtil
    {
        public static byte[] ReadAllBytes(Stream stream)
        {
            if(stream.CanSeek && stream.Position == stream.Length) {
                stream.Seek(0, SeekOrigin.Begin);
            }

            byte[] data = new byte[stream.Length];
            int bytesRead = 0;
            do {
                bytesRead += stream.Read(data, bytesRead, (int)stream.Length);
            } while(bytesRead > 0 && bytesRead < stream.Length);
            return data;
        }
    }
}