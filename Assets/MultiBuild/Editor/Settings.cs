using UnityEngine;
using System.IO;
using System.Collections.Generic;

namespace MultiBuild {

    // Our own enumeration of targets so we can serialize with confidence
    // in case Unity changes the values of their internal targets
    public enum Target {
        Windows32 = 0,
        Windows64 = 1,
        Mac32 = 2,
        Mac64 = 3,
        MacUniversal = 4,
        Linux32 = 5,
        Linux64 = 6,
        iOS = 7,
        Android = 8,
        WebGL = 9,
        WindowsStore = 10,
        Tizen = 11,
        PS4 = 12,
        XboxOne = 13,
        SamsungTV = 14,
        Nintendo3DS = 15,
        WiiU = 16,
        tvOS = 17,
#if UNITY_5_6
        Switch = 18
#endif
    }
    public class Settings : ScriptableObject {

        public string outputFolder;
        public bool useProductName;
        public string overrideName;
        public bool developmentBuild;
        public List<Target> targets;

        public void Reset() {
            outputFolder = Directory.GetParent(Application.dataPath).FullName;
            useProductName = true;
            overrideName = string.Empty;
            developmentBuild = false;
            targets = new List<Target>();
        }

    }


}
