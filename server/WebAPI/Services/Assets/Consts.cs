﻿namespace WebAPI.Services.Assets
{
  public static class Consts
  {
    public const string UsersAvatarsPath = @"Assets\Avatars";

    public const string FileEatingPath = @"Assets\ScheduledPlaceToEatFiles";

    public const string AssetsPath = @"Assets";

    public static string[] AllowedImageContentTypes = new[] { "image/png", "image/jpeg", "image/jpg",  "image/bmp" };

    public static string[] AllowedTextContentTypes = new[] { ".txt", ".doc", ".docx" };

    public const int MaxImageFileSize = 1024 * 1024 * 2;

    public const int MaxEatingFileSize = 1024 * 1024 * 10;

    public const int MaxEatingFileCount = 10;
  }
}
