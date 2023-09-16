
namespace PDF_Acc_Toolset.Services
{
    internal class ConfigService
    {
        private readonly IFolderPicker _folderPicker;

        public ConfigService(IFolderPicker folderPicker)
        {
            _folderPicker = folderPicker;
        }

        public string GetEntry(string key, string defaultValue)
        {
            return Preferences.Get(key, defaultValue);
        }

        /// <summary>
        /// Check that a key exists. If it doesn't, create it.
        /// </summary>
        /// <param name="key"></param>
        /// <returns></returns>
        public async Task<bool> EnsureCreation(ConfigEntry key)
        {
            return key switch
            {
                ConfigEntry.EXPORT_DIRECTORY => await SetExportDir(),
                _ => false,
            };
        }

        /// <summary>
        /// Sets an entry
        /// </summary>
        /// <param name="key"></param>
        /// <param name="value"></param>
        public void SetEntry(string key, string value) {
            Preferences.Set(key, value);
        }

        public void SetEntry(string key, int value)
        {
            Preferences.Set(key, value);
        }

        public void SetEntry(string key, double value)
        {
            Preferences.Set(key, value);
        }

        public void SetEntry(string key, bool value)
        {
            Preferences.Set(key, value);
        }

        private async Task<bool> SetExportDir()
        {
            try
            {
                string dir = await _folderPicker.PickFolder();
                if (dir != null)
                {

                    return true;
                } else
                {
                    return false;
                }
            } catch (Exception)
            {
                throw;
                return false;
            }
        }
    }

    internal enum ConfigEntry
    {
        /// <summary>
        /// The directory which will contain exported files.
        /// </summary>
        EXPORT_DIRECTORY
    }


    /// <summary>
    /// To do - move this to own file
    /// </summary>
    internal interface IFolderPicker
    {
        Task<string> PickFolder();
    }
}
