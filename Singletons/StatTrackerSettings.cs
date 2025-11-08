using StatsTracker.Utils;

namespace StatsTracker.Singletons
{
    public class StatTrackerSettings
    {
        public static readonly StatTrackerSettings Settings = new StatTrackerSettings();

        #region Variables
        private readonly string _filePath = "Settings.json";

        private bool _isLoaded = false;

        private string _version = "0.1";
        #endregion

        #region Properties
        public string Version 
        { 
            get
            {
                return _version;
            }
            set 
            {
                _version = value;
                if (_isLoaded)
                {
                    SaveSettings();
                }
            } 
        }
        #endregion

        public StatTrackerSettings() 
        {
            
        }

        public void LoadSettings()
        {
            if (string.IsNullOrEmpty(_filePath))
            {
                return;
            }

            StatTrackerSettings? newSettings = JSONHelper.LoadFromJsonFile<StatTrackerSettings>(JSONHelper.GetFilePath(_filePath));
            if (newSettings != null)
            {
                _version = newSettings.Version;
            }

            _isLoaded = true;
        }

        private void SaveSettings()
        {
            if(string.IsNullOrEmpty(_filePath))
            {
                return;
            }

            JSONHelper.SaveToJsonFile(JSONHelper.GetFilePath(_filePath), this);
        }
    }
}
