using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MainVarHolder : MonoBehaviour
{
    public static int Energy = 0;
    public static int EnergyConsumtion = 0;
    public static int MaxEnergy = 0;
    public static int Money = 60;
    public static int SolarUnit = 0;
    public static int WindUnit = 0;
    public static int GeoThermalUnit = 0;
    public static int WaterUnit = 0;
    public static int NuclearUnit = 0;

    public static int SolarEnergy = 1;
    public static int WindEnergy = 2;
    public static int GeoThermalEnergy = 4;
    public static int WaterEnergy = 5;
    public static int NuclearEnergy = 25;

    public static int SolarCost = 10;
    public static int WindCost = 18;
    public static int GeoThermalCost = 30;
    public static int WaterCost = 60;
    public static int NuclearCost = 200;

    public static bool MainPower = true;
    public static bool City1Power = false;
    public static bool City2Power = false;
    public static bool City3Power = false;
    public static bool City4Power = false;
    public static bool City5Power = false;

    public static int City1Consumtion = 5;
    public static int City2Consumtion = 9;
    public static int City3Consumtion = 5;
    public static int City4Consumtion = 5;
    public static int City5Consumtion = 5;

    public static int City1Rent = 6;
    public static int City2Rent = 8;
    public static int City3Rent = 5;
    public static int City4Rent = 5;
    public static int City5Rent = 5;

    private void Update()
    {
        MaxEnergy = SolarEnergy * SolarUnit + WindEnergy * WindUnit + GeoThermalEnergy * GeoThermalUnit + WaterEnergy * WaterUnit + NuclearEnergy * NuclearUnit;
        Energy = MaxEnergy - EnergyConsumtion;
    }
}
