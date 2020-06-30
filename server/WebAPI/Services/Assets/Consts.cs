namespace WebAPI.Services.Assets
{
  public static class Consts
  {
    public const string UsersAvatarsPath = @"Assets\Avatars";
    public const string EntertainmentsPath = @"Assets\Entertainments";
    public const string WaypointsFilesPath = @"Assets\Waypoints";
    public const string AssetsPath = @"Assets";

    public static string[] AllowedImageContentTypes = new[] { "image/png", "image/jpeg", "image/jpg",  "image/bmp" };

    public const int MaxImageFileSize = 1024 * 1024 * 2;
    public const int MaxWaypointFileSize = 1024 * 1024 * 5;
    public const int MaxWaypointFileCount = 5;
  }
}
