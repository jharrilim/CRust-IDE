using System;
using System.Collections.Generic;
using System.Text;

namespace CRust.Api.Profile
{
    class ProfileManager
    {
        private const string ideDirName = ".crust";
        private string profileDir;
        public ProfileManager()
        {
            profileDir = Environment.GetFolderPath(Environment.SpecialFolder.UserProfile);
        }

    }
}
