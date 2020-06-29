namespace WebAPI.Services.Assets
{
  public static class Consts
  {
    public const string UsersAvatarsPath = @"Assets\Avatars";

    public const string WaypointsFilesPath = @"Assets\Waypoints";

    public const string AssetsPath = @"Assets";

    public const string FileEatingPath = @"Assets\ScheduledPlaceToEatFiles";


    public static string[] AllowedImageContentTypes = new[] { "image/png", "image/jpeg", "image/jpg",  "image/bmp" };

    public static string[] AllowedTextContentTypes = new[] { ".txt", ".doc", ".docx" };

    public const int MaxImageFileSize = 1024 * 1024 * 2;

    public const int MaxEatingFileSize = 1024 * 1024 * 10;

    public const int MaxEatingFileCount = 10;
    public const int MaxWaypointFileSize = 1024 * 1024 * 5;
    public const int MaxWaypointFileCount = 5;
  }
}
