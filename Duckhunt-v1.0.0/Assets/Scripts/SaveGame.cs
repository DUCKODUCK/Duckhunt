using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UnityEngine;
using System.IO;

namespace Assets.Scripts
{
    [Serializable]
    class SaveGame
    {
        public int HigeScore;

        public void SavePoints()
        {
            //zet punten in .json
            //opslaan in file

            string json = JsonUtility.ToJson(this);
            var path = Path.Combine(Application.dataPath, "points.json");
            File.WriteAllText(path, json);
        }

        public void LoadPoints()
        {
            var path = Path.Combine(Application.dataPath, "points.json");
            //lees file
            //umzetten van .json naar int
            string json = File.ReadAllText(path);
            Debug.Log(json);
            var pointsFromFile = JsonUtility.FromJson<SaveGame>(json);
            HigeScore = pointsFromFile.HigeScore;
            Debug.Log(HigeScore);
        }
    }
}
