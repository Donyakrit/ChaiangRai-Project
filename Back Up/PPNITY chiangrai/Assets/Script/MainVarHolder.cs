using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MainVarHolder : MonoBehaviour
{
    public static int Energy = 0;
    public static int EnergyConsumtion = 0;
    public static int MaxEnergy = 0;
    public static int Money = 0;
    public static int SolarUnit = 0;
    public static int WindUnit = 0;
    public static int GeoThermalUnit = 0;
    public static int WaterUnit = 0;
    public static int NuclearUnit = 0;

    public static int SolarEnergy = 1;
    public static int WindEnergy = 2;
    public static int GeoThermalEnergy = 5;
    public static int WaterEnergy = 10;
    public static int NuclearEnergy = 20;

    private void Update()
    {
        MaxEnergy = SolarEnergy * SolarUnit + WindEnergy * WindUnit + GeoThermalEnergy * GeoThermalUnit + WaterEnergy * WaterUnit + NuclearEnergy * NuclearUnit;
        Energy = MaxEnergy - EnergyConsumtion;
    }
}
