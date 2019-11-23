using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameEngine
{
    //Settings - Singleton
    class Settings
    {
        int difficulty = 5;
        int volume = 5;
        string language = "";
        string graphicsQuality = "";
        string controls = "";
        string worldSize = "";

        private Settings() { }

        private static Settings instance;

        public static Settings GetInstance()
         
        {
            if (instance == null)
            {
                instance = new Settings();
            }
            return instance;
        }
        public void DifficultySetting(int diff)
        {
            difficulty = diff;
        }
        public void VolumeSetting(int vol)
        {
            volume = vol;
        }

        public void LanguageSettings(string lang)
        {
            language = lang;
        }
        public void ControlSettings(string contr)
        {
            controls = contr;
        }
        public void WorldSize(string size)
        {
            worldSize = size;
        }
    }
}
