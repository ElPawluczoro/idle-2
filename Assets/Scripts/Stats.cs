using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.IO;
using System.Numerics;
using UnityEngine;

//Author: ElPawluczoro version: 0.02

public class Stats : MonoBehaviour
{
    [SerializeField]
    private GameObject statsWindow;

    [SerializeField]
    private Transform mainCanvas;

    //private static BigInteger bananas;
    private static Bananas bananas = new Bananas(0,BananasPrefixes.UNITY);
    private static int militaryPower;

    //private static int monkeyWorkers;
    //private static int monkeyWarriors;
    //private static int monkeyShamans;


    private static Bananas bananasPerS;
    private static int multiplier = 1;

    private static Bananas bananasPerClick;

    //Hire variables

    private static int unitsPerHire = 1;

    private static int basicBananasPerMonkeyWorker = 1;
    private static int startMonkeyWorkerCost = 100;

    /*private static int startMonkeyWorkerCost = 100;
    private static Bananas monkeyWorkerCost;
    private static int basicBananasPerMonkeyWorker = 1;
    private static Bananas bananasPerMonkeyWorker;*/

    private static int startMonkeyWarriorCost = 500;
    //private static Bananas monkeyWarriorCost;
    private static int basicBananasPerMonkeyWarrior = 5;
    //private static Bananas bananasPerMonkeyWarrior;
    private static int militaryPowerPerMonkeyWarrior = 1;

    private static int startMonkeyShamanCost = 1000;
    //private static Bananas monkeyShamanCost;
    private static int basicBananasPerMonkeyShaman = 20;
    //private static Bananas bananasPerMonkeyShaman;
    private static int militaryPowerPerMonkeyShaman = 5;

    //Upgrades variables

    private static int workerMultiplier;
    private static int warriorMultiplier;
    private static int shamanMultiplier;

    //
    private static int startUpgrade1Cost = 1; //1000
    private static Bananas upgrade1Cost;
    private static int upgrade1Level;
    private static int upgrade1LevelMax = 5;

    private static int startUpgrade2Cost = 5; //5000
    private static Bananas upgrade2Cost;
    private static int upgrade2Level;
    private static int upgrade2LevelMax = 5;

    private static int startUpgrade3Cost = 20; //20000
    private static Bananas upgrade3Cost;
    private static int upgrade3Level;
    private static int upgrade3LevelMax = 5;

    private static int startUpgrade4Cost = 1; //1000000
    private static Bananas upgrade4Cost;
    private static bool isUpgrade4;  //we have 1 level and getlevel returns true
    //


    public static string[] save = new string[9]; //increase if I add new things to save

    public static string[] load;

    public static void Save() {
        save[0] = bananas.ToSave(); //
        save[1] = militaryPower.ToString();

        save[2] = monkeyWorker.GetCount().ToString();
        save[3] = monkeyWarrior.GetCount().ToString();
        save[4] = monkeyShaman.GetCount().ToString();

        save[5] = upgrade1Level.ToString();
        save[6] = upgrade2Level.ToString();
        save[7] = upgrade3Level.ToString();
        save[8] = isUpgrade4.ToString();
    }

    public static void Load()
    {
        //load = System.IO.File.ReadAllLines("Assets/Save/Save.dat");
        load = System.IO.File.ReadAllLines("Save.dat");
        bananas = new Bananas(Int32.Parse(load[0]), Int32.Parse(load[1]), Int32.Parse(load[2]),
             Int32.Parse(load[3]), Int32.Parse(load[4]), Int32.Parse(load[5]), Int32.Parse(load[6]),
            Int32.Parse(load[7]), Int32.Parse(load[8]));
        militaryPower = Int32.Parse(load[9]);
        monkeyWorker.SetCount(Int32.Parse(load[10]));
        monkeyWarrior.SetCount(Int32.Parse(load[11]));
        monkeyShaman.SetCount(Int32.Parse(load[12]));
        upgrade1Level = Int32.Parse(load[13]);
        upgrade2Level = Int32.Parse(load[14]);
        upgrade3Level = Int32.Parse(load[15]);
        if (load[16] == "True")
        {
            isUpgrade4 = true;
        }
        else
        {
            isUpgrade4 = false;
        }
    }
        

    public static int GetUnitsPerHire()
    {
        return unitsPerHire;
    }

    //Bananas Per Click//

    public static void setBananasPerClick(int value)
    {
        bananasPerClick = new Bananas(value, BananasPrefixes.UNITY);
    }

    public static Bananas getBanasPerClick()
    {
        return bananasPerClick;
    }

    //Monkey Worker//

    static Units monkeyWorker = new Units(basicBananasPerMonkeyWorker, startMonkeyWorkerCost);


    public static Bananas getBananasPerMonkeyWorker()
    {
        return monkeyWorker.GetBananasPerUnit();
    }
    public static void setBananasPerMonkeyWorker()
    {
        monkeyWorker.setBananasPerUnit(upgrade1Level, BananasPrefixes.UNITY);
    }

    public static void setMonkeyWorkerCost()
    {
        monkeyWorker.setUnitCost(BananasPrefixes.UNITY, unitsPerHire);
    }
    
    public static int getMonkeyWorkers()
    {
        return monkeyWorker.GetCount();
    }

    public static void addMonkeyWorkers(int amount)
    {
        monkeyWorker.addUnits(amount);
    }

    public static Bananas getMonkeyWorkerCost()
    {
        return monkeyWorker.GetCost();
    }

    //Monkey Warrior//

    static Units monkeyWarrior = new Units(basicBananasPerMonkeyWarrior, startMonkeyWarriorCost);

    public static void setBananasPerMonkeyWarrior()
    {
        //bananasPerMonkeyWarrior = new Bananas(basicBananasPerMonkeyWarrior + basicBananasPerMonkeyWarrior * upgrade2Level, BananasPrefixes.UNITY);
        monkeyWarrior.setBananasPerUnit(upgrade2Level, BananasPrefixes.UNITY);
    }

    public static Bananas getBananasPerMonkeyWarrior()
    {
       //return bananasPerMonkeyWarrior;
       return monkeyWarrior.GetBananasPerUnit();
    }

    public static void setMonkeyWarriorCost()
    {
        //monkeyWarriorCost = setUnitCost(startMonkeyWarriorCost, monkeyWarriors, BananasPrefixes.UNITY);
        monkeyWarrior.setUnitCost(BananasPrefixes.UNITY, unitsPerHire);
    }
    public static int getMonkeyWarriors()
    {
        return monkeyWarrior.GetCount();
    }
    public static void addMonkeyWarriors(int amount)
    {
        //monkeyWarriors += amount;
        monkeyWarrior.addUnits(amount);
    }
    public static Bananas getMonkeyWarriorCost()
    {
        //return monkeyWarriorCost;
        return monkeyWarrior.GetCost();
    }
    public static int GetMilitaryPowerPerMonkeyWarrior()
    {
        return militaryPowerPerMonkeyWarrior;
    }

    //Monkey Shaman//

    static Units monkeyShaman = new Units(basicBananasPerMonkeyShaman, startMonkeyShamanCost);

    public static void setBananasPerMonkeyShaman()
    {
        //bananasPerMonkeyShaman = new Bananas(basicBananasPerMonkeyShaman + basicBananasPerMonkeyShaman * upgrade3Level, BananasPrefixes.UNITY);
        monkeyShaman.setBananasPerUnit(upgrade3Level, BananasPrefixes.UNITY);
    }
    public static Bananas getBananasPerMonkeyShaman()
    {
        //return bananasPerMonkeyShaman;
        return monkeyShaman.GetBananasPerUnit();
    }

    public static void setMonkeyShamanCost()
    {
        //monkeyShamanCost = setUnitCost(startMonkeyShamanCost, monkeyShamans, BananasPrefixes.UNITY);
        monkeyShaman.setUnitCost(BananasPrefixes.UNITY, unitsPerHire);
    }
    public static int getMonkeyShamans()
    {
        //return monkeyShamans;
        return monkeyShaman.GetCount();
    }
    public static void addMonkeyShamans(int amount)
    {
        //monkeyShamans += amount;
        monkeyShaman.addUnits(amount);
    }
    public static Bananas getMonkeyShamanCost()
    {
        //return monkeyShamanCost;
        return monkeyShaman.GetCost();
    }

    public static int GetMilitaryPowerPerMonkeyShaman()
    {
        return militaryPowerPerMonkeyShaman;
    }

    //Upgrades//

    //Upgrade 1

    static Upgrade upgrade1 = new Upgrade(new Bananas(1, BananasPrefixes.KILO), 10,UpgradesMultiplier.WORKER, 1, 5);
    //

    public static int getUpgrade1Level()
    {
        return upgrade1.GetLevel();
    }

    public static Bananas getUpgrade1Cost()
    {
        return upgrade1.GetCost();
    }
    
    public static int GetUpgrade1MaxLevel()
    {
        return upgrade1.GetMaxLevel();
    }

    public static void levelUpUpgrade1()
    {
        upgrade1.LevelUp();
    }

    /*
    public static void setUpgrade1Cost()
    {

        if(upgrade1Level == 0)
        {
            upgrade1Cost = new Bananas(startUpgrade1Cost, BananasPrefixes.KILO); //basic 1000
        }
        else
        {         
            upgrade1Cost = new Bananas(startUpgrade1Cost * (int)Math.Pow((double)10, (double)upgrade1Level), BananasPrefixes.KILO);  //shoud be 10 000 on lvl 2 100 000 on lvl3 etc.
        }
    }*/

    //Upgrade 2

    public static int getUpgrade2Level()
    {
        return upgrade2Level;
    }

    public static int getUpgrade2LevelMax()
    {
        return upgrade2LevelMax;
    }

    public static void levelUpUpgrade2()
    {
        upgrade2Level++;
    }

    public static Bananas getUpgrade2Cost()
    {
        return upgrade2Cost;
    }

    public static void setUpgrade2Cost()
    {
        if (upgrade2Level == 0)
        {
            upgrade2Cost = new Bananas(startUpgrade2Cost,BananasPrefixes.KILO);   //basic 5000
        }
        else
        {
            upgrade2Cost = new Bananas(startUpgrade2Cost * (int)Math.Pow((double)10, (double)upgrade2Level), BananasPrefixes.KILO);
        }
    }

    //Upgrade 3

    public static int getUpgrade3Level()
    {
        return upgrade3Level;
    }

    public static int getUpgrade3LevelMax()
    {
        return upgrade3LevelMax;
    }

    public static void levelUpUpgrade3()
    {
        upgrade3Level++;
    }

    public static Bananas getUpgrade3Cost()
    {
        return upgrade3Cost;
    }

    public static void setUpgrade3Cost()
    {
        if (upgrade3Level == 0)
        {
            upgrade3Cost = new Bananas(startUpgrade3Cost, BananasPrefixes.KILO);   //basic 20000
        }
        else
        {
            upgrade3Cost = new Bananas(startUpgrade3Cost * (int)Math.Pow((double)10, (double)upgrade3Level), BananasPrefixes.KILO);
        }
    }

    //Upgrade 4

    public static bool getUpgrade4Level()
    {
        return isUpgrade4;
    }

    public static void levelUpUpgrade4()
    {
        isUpgrade4 = true;
    }

    public static Bananas getUpgrade4Cost()
    {
        return upgrade4Cost;
    }

    public static void setUpgrade4Cost()
    {
        if (isUpgrade4 == false)
        {
            upgrade4Cost = new Bananas(startUpgrade4Cost, BananasPrefixes.MEGA);   //basic 1000 000
        }
    }

    // //

    //multiplier

    public int GetMultiplier()
    {
        return multiplier;
    }

    public static void increaseMultiplier(int value)
    {
        multiplier+=value;
    }

    public static void IncreaseWorkerMultiplier(int value)
    {
        workerMultiplier += value;
    }

    public static void IncreaseWarriorMultiplier(int value)
    {
        warriorMultiplier += value;
    }

    public static void IncreaseShamanMultiplier(int value)
    {
        shamanMultiplier += value;
    }


    // //

    public static Bananas setUnitCost(int basicCost, int monkeys, BananasPrefixes prefix)
    {
        Bananas cost;
        cost = new Bananas(basicCost + basicCost * monkeys, prefix);
        for (int i = 1; i < unitsPerHire; i++)
        {
            cost += new Bananas(basicCost + basicCost * (monkeys + i), prefix);
        }

        return cost;
    }

    /*public static string GetBananasString()
    {
        return bananas.ToString();
    }*/

    public static Bananas GetBananas()
    {
        return bananas;
    }


    public static void addBananas(Bananas value)
    {
        //bananas = bananas + new Bananas(value,BananasPrefixes.UNITY);
        bananas.AddBananas(value);
    }

    public static void spendBananas(Bananas value)
    {
        //bananas = bananas - new Bananas(value, BananasPrefixes.UNITY);
        bananas.SpendBananas(value);
    }

    public static void setBananasPerS()
    {
        Bananas fromWorkers;
        Bananas fromWarriors;
        Bananas fromShamans;

        fromWorkers = monkeyWorker.GetBananasPerUnit() * monkeyWorker.GetCount() * workerMultiplier;
        fromWarriors = monkeyWarrior.GetBananasPerUnit() * monkeyWarrior.GetCount() * warriorMultiplier;
        fromShamans = monkeyShaman.GetBananasPerUnit() * monkeyShaman.GetCount() * shamanMultiplier;

        //Console.Write(fromWorkers + "\n");//TODO delete

       //bananasPerS = (fromWorkers + fromWarriors + fromShamans) * multiplier;
       bananasPerS = (fromWorkers + fromWarriors + fromShamans) * multiplier;
    }

    public static Bananas getBananasPerS()
    {
        return bananasPerS;
    }

    IEnumerator bananasIncomePerS()
    {
        while (true)
        {
            //yield return new WaitForSeconds(1);
            yield return new WaitForSeconds(1f);
            setBananasPerS();
            //addBananas(bananasPerS);

            //Console.Write("Bananas per/s:" + getBananasPerS() + //TODO delete
              //"\nBanasperMonkeyWorker: " + bananasPerMonkeyWorker);

            bananas.AddBananas(bananasPerS);
        }

    }

    public static int GetMilitaryPower()
    {
        return militaryPower;
    }

    public static void addMilitaryPower(int value)
    {
        militaryPower += value;
    }

    public void AddStatsPanel()
    {
        Instantiate(statsWindow, mainCanvas);
    }

    public static void SetUnitsPerHire(int value)
    {
        unitsPerHire = value;
    }


    void Start()
    {

        bananas = new Bananas(5,BananasPrefixes.JOTTA); //TODO remove after tests

        setBananasPerClick(1);

        //setUpgrade1Cost();
        setUpgrade2Cost();
        setUpgrade3Cost();
        setUpgrade4Cost();

        setMonkeyWorkerCost();
        setBananasPerMonkeyWorker();

        setMonkeyWarriorCost();
        setBananasPerMonkeyWarrior();

        setMonkeyShamanCost();
        setBananasPerMonkeyShaman();


        AddStatsPanel();


        StartCoroutine(bananasIncomePerS());
    }

    
   
    void Update()
    {
        
    }
}
