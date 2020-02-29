﻿using Android.Content;

namespace SoundCloudClone.Droid.Utils
{
    public class ResourceUtil
    {
        public static int GetDrawableIdByFileName(string fileName, Context context)
        {
            return context.Resources.GetIdentifier(fileName, "drawable", context.PackageName);
        }
    }
}
