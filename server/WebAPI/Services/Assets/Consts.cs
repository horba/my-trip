namespace WebAPI.Services.Assets
{
  public static class Consts
  {
    public const string UsersAvatarsPath = @"Assets\Avatars";
    public const string EntertainmentsPath = @"Assets\Entertainments";

    public static string[] AllowedImageContentTypes = new[] { "image/png", "image/jpeg", "image/jpg",  "image/bmp" };

    public const int MaxImageFileSize = 1024 * 1024 * 2;
  }
}
