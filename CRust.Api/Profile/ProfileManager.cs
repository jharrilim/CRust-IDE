using System;
using System.Collections.Generic;
using System.Text;

namespace CRust.Api.Profile
{
    /// <summary>
    /// Manages information related to the user's profile such as IDE settings and plugins.
    /// This information should generally be stored in %USERPROFILE%/.crust.
    /// </summary>
    public class ProfileManager
    {
        private const string ideDirName = ".crust";
        private readonly string profileDir;
        public ProfileManager()
        {
            profileDir = Environment.GetFolderPath(Environment.SpecialFolder.UserProfile);
        }

    }
}
