using System;
/// <summary>
/// Summary description for Configuration
/// </summary>
public class AppConfiguration
{
    private static readonly string configConnectionName = "BeersContext";
    private static readonly string blobStorageUrl = "";

    public static string ConnectionString
    {
        get
        {
            var envConnectionString = Environment.GetEnvironmentVariable("ConnectionString");
            return envConnectionString ?? $"name={configConnectionName}";
        }
    }

    public static string BlobStorageUrl
    {
        get
        {
            var envBlobStorageUrl = Environment.GetEnvironmentVariable("BlobStorageUrl");
            return envBlobStorageUrl ?? $"name={blobStorageUrl}";
        }
    }
}