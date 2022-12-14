using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.IO;
using System.Threading.Tasks;
using System.Numerics;

public class SaveAndLoad : MonoBehaviour {

    public static async Task Save()
    {
        //await File.WriteAllLinesAsync("Assets/Save/Save.dat", Stats.save);
        await File.WriteAllLinesAsync("Save.dat", Stats.save);
    }
    public void Load()
    {
        Stats.Load(); 
    }
}
