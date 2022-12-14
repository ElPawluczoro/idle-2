using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.Numerics;
using UnityEngine.Android;
using UnityEngine.UI;

public class ButtonsControler : MonoBehaviour
{

    [SerializeField]
    private Transform mainCanvas;

    [SerializeField]
    private GameObject hireMonkeyWindow;

    [SerializeField]
    private GameObject upgradesWindow;

    [SerializeField]
    private GameObject exitPanel;

    [SerializeField]
    private GameObject warWindow;

    /*public bool isBananaEnough(BigInteger cost)
    {
        if(BigInteger.Compare(Stats.GetBananasString(), cost) >= 0)
        {
            return true;
        }
        else
        {
            return false;
        }
    }*/

    public bool isBananaEnough(Bananas cost)
    {
        if  (Bananas.Compare(Stats.GetBananas(), cost) >= 0)
        {
            return true;
        }
        else
        {
            return false;
        }
    }


    public void closeGame()
    {
        Application.Quit();
    }

    public void OpenExitPanel()
    {
        Instantiate(exitPanel, mainCanvas);
    }

    public void CloseExitPanel()
    {
        GameObject.Destroy(GameObject.Find("AskExitPannel(Clone)"));
    }

    public void OpenWarWindow()
    {
        Instantiate(warWindow, mainCanvas);
    }

    public void CloseWarWindow()
    {
        GameObject.Destroy(GameObject.Find("ConfirmWar(Clone)"));
    }

    public void bananasButton()
    {
        Stats.addBananas(Stats.getBanasPerClick());
    }


    //HIRE

    public delegate void MonkeyWorkerHiered();
    public static event MonkeyWorkerHiered monkeyWorkerHiered;

    //

    public delegate void UpdateHireInfo();
    public static event UpdateHireInfo updateHireInfo;

    //

    public void hireMonkeyWorkerButton()
    {
        if (isBananaEnough(Stats.getMonkeyWorkerCost()))
        {
            Stats.spendBananas(Stats.getMonkeyWorkerCost());
            Stats.addMonkeyWorkers(Stats.GetUnitsPerHire());
            Stats.setMonkeyWorkerCost();

            chceckAndUpdateHireInfo();


            if (monkeyWorkerHiered != null)
            {
                monkeyWorkerHiered();
            }


        }
    }

    public void hireMonkeyWarriorButton()
    {
        if (isBananaEnough(Stats.getMonkeyWarriorCost()))
        {
            Stats.spendBananas(Stats.getMonkeyWarriorCost());
            Stats.addMonkeyWarriors(Stats.GetUnitsPerHire());
            Stats.setMonkeyWarriorCost();
            Stats.addMilitaryPower(Stats.GetMilitaryPowerPerMonkeyWarrior());

            chceckAndUpdateHireInfo();
        }
    }

    public void hireMonkeyShamanButton()
    {
        if (isBananaEnough(Stats.getMonkeyShamanCost()))
        {
            Stats.spendBananas(Stats.getMonkeyShamanCost());
            Stats.addMonkeyShamans(Stats.GetUnitsPerHire());
            Stats.setMonkeyShamanCost();
            Stats.addMilitaryPower(Stats.GetMilitaryPowerPerMonkeyShaman());

            chceckAndUpdateHireInfo();
        }
    }

    public void chceckAndUpdateHireInfo()
    {
        if (updateHireInfo != null)
        {
            updateHireInfo();
        }
    }

    public void openHirePanel()
    {
        string hireCanvas = "HireMonkeysWindow(Clone)";

        if (GameObject.Find(hireCanvas) == null)
        {
            Instantiate(hireMonkeyWindow,mainCanvas);
            chceckAndUpdateHireInfo();
        }
        else
        {
            GameObject.Destroy(GameObject.Find(hireCanvas));
        }
    }

    public void SetHireCosts()
    {
        Stats.setMonkeyWorkerCost();
        Stats.setMonkeyWarriorCost();
        Stats.setMonkeyShamanCost();
    }

    public void X1Hire()
    {
        Stats.SetUnitsPerHire(1);
        SetHireCosts();
        chceckAndUpdateHireInfo();
    }

    public void X10Hire()
    {
        Stats.SetUnitsPerHire(10);
        SetHireCosts();
        chceckAndUpdateHireInfo();
    }

    public void X100Hire()
    {
        Stats.SetUnitsPerHire(100);
        SetHireCosts();
        chceckAndUpdateHireInfo();
    }


    //HIRE ENDS

    //UPGRADES

    public delegate void UpdateUpgradesInfo();
    public static event UpdateUpgradesInfo updateUpgradesInfo;

    public void checkAndUpdateUpgradesInfo()
    {
        if (updateUpgradesInfo != null)
        {
            updateUpgradesInfo();
        }
    }

    public void upgrade1()
    {
        if (isBananaEnough(Stats.getUpgrade1Cost()))
        {
            Stats.spendBananas(Stats.getUpgrade1Cost());
            Stats.levelUpUpgrade1();
            //Stats.setUpgrade1Cost();
            Stats.setBananasPerMonkeyWorker();

            checkAndUpdateUpgradesInfo();
        }
    }

    public void upgrade2()
    {
        if (isBananaEnough(Stats.getUpgrade2Cost()))
        {
            Stats.spendBananas(Stats.getUpgrade2Cost());
            Stats.levelUpUpgrade2();
            Stats.setUpgrade2Cost();
            Stats.setBananasPerMonkeyWarrior();

            checkAndUpdateUpgradesInfo();
        }
    }

    public void upgrade3()
    {
        if (isBananaEnough(Stats.getUpgrade3Cost()))
        {
            Stats.spendBananas(Stats.getUpgrade3Cost());
            Stats.levelUpUpgrade3();
            Stats.setUpgrade3Cost();
            Stats.setBananasPerMonkeyShaman();

            checkAndUpdateUpgradesInfo();
        }
    }

    public void Upgrade4()
    {
        //GameObject upgrade4Button = GameObject.Find("Upgrade4");

        if (isBananaEnough(Stats.getUpgrade4Cost()))
        {
            Stats.spendBananas(Stats.getUpgrade4Cost());
            Stats.levelUpUpgrade4();
            Stats.setUpgrade4Cost();
            Stats.increaseMultiplier(1);

            //upgrade4Button.SetActive(false);

            checkAndUpdateUpgradesInfo();
        }
    }

    public void OpenUpgradesPanel()
    {
        string upgradesCanvas = "UpgradesWindow(Clone)";
        if(GameObject.Find(upgradesCanvas) == null)
        {
            Instantiate(upgradesWindow, mainCanvas);
            checkAndUpdateUpgradesInfo();
        }else
        {
            GameObject.Destroy(GameObject.Find(upgradesCanvas));
        }
    }
    
    //UPGRADES ENDS

    public void Save()
    {
        Stats.Save();
        SaveAndLoad.Save();
    }

}
