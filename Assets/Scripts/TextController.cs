using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using System.Numerics;

public class TextController : MonoBehaviour
{
    public Text bananasInfo;
    public Text bananasPerClick;

    public Text militaryPowerInfo;

    public Text monkeyWorkersInfo;
    public Text monkeyWorkerCostInfo;

    public Text monkeyWariorsInfo;
    public Text monkeyWariorCostInfo;

    public Text monkeyShamansInfo;
    public Text monkeyShamanCostInfo;

    public Text upgrade1CostInfo;
    public Text Upgrade2CostInfo;
    public Text Upgrade3CostInfo;


    public void updateBananas()
    {
        bananasInfo = GameObject.Find("BananasInfo").GetComponent<Text>();
        bananasInfo.text = "Bananas: " + Stats.GetBananas() + " (" + Stats.getBananasPerS() + "b/s)";
    }

    public void updateBananasPerClick()
    {
        bananasPerClick = GameObject.Find("BananasPerClickInfo").GetComponent<Text>();
        bananasPerClick.text = Stats.getBanasPerClick() + " per click";
    }

    public void updateMilitaryPower()
    {
        militaryPowerInfo = GameObject.Find("MilitaryPowerInfo").GetComponent<Text>();
        militaryPowerInfo.text = "Military Power: " + Stats.GetMilitaryPower();
    }

    public void updateMonkeyWorkers()
    {
        monkeyWorkersInfo = GameObject.Find("MonkeyWorkersInfo").GetComponent<Text>();
        //monkeyWorkersInfo.text = "Monkey Workers: " + Stats.getMonkeyWorkers() + " (" + Stats.getMonkeyWorkers() * Stats.getBananasPerMonkeyWorker() + "b/s)";
        monkeyWorkersInfo.text = "Monkey Workers: " + Stats.getMonkeyWorkers();
    }

    public void updateMonkeyWorkersCostInfo()
    {
        monkeyWorkerCostInfo = GameObject.Find("MonkeyWorkerCostInfo").GetComponent<Text>();
        monkeyWorkerCostInfo.text = "Cost: " + Stats.getMonkeyWorkerCost() + "Bananas";
    }

    public void updateMonkeyWariors()
    {
        monkeyWariorsInfo = GameObject.Find("MonkeyWarriorsInfo").GetComponent<Text>();
        //monkeyWariorsInfo.text = "Monkey Wariors: " + Stats.getMonkeyWarriors() + " (" + Stats.getMonkeyWarriors() * Stats.getBananasPerMonkeyWarrior() + "b/s)";
        monkeyWariorsInfo.text = "Monkey Wariors: " + Stats.getMonkeyWarriors();  
    }

    public void updateMonkeyWariorsCostInfo()
    {
        monkeyWariorCostInfo = GameObject.Find("MonkeyWarriorCostInfo").GetComponent<Text>();
        monkeyWariorCostInfo.text = "Cost: " + Stats.getMonkeyWarriorCost() + "Bananas";
    }

    public void updateMonkeyShamans()
    {
        monkeyShamansInfo = GameObject.Find("MonkeyShamansInfo").GetComponent<Text>();
        //monkeyShamansInfo.text = "Monkey Shamans: " + Stats.getMonkeyShamans() + " (" + Stats.getMonkeyShamans() * Stats.getBananasPerMonkeyShaman() + "b/s)";
        monkeyShamansInfo.text = "Monkey Shamans: " + Stats.getMonkeyShamans();
    }


    public void updateMonkeyShamanCostInfo()
    {
        monkeyShamanCostInfo = GameObject.Find("HireMonkeyShamanInfo").GetComponent<Text>();
        monkeyShamanCostInfo.text = "Cost: " + Stats.getMonkeyShamanCost() + "Bananas";
    }

    public void updateUpgrade1CostInfo()
    {
        upgrade1CostInfo = GameObject.Find("Upgrade1CostInfo").GetComponent<Text>();
        upgrade1CostInfo.text = "Cost: " + Stats.getUpgrade1Cost();
    }

    public void updateUpgrade2CostInfo()
    {
        Upgrade2CostInfo = GameObject.Find("Upgrade2CostInfo").GetComponent<Text>();
        Upgrade2CostInfo.text = "Cost: " + Stats.getUpgrade2Cost();
    }

    public void updateUpgrade3CostInfo()
    {
        Upgrade3CostInfo = GameObject.Find("Upgrade3CostInfo").GetComponent<Text>();
        Upgrade3CostInfo.text = "Cost: " + Stats.getUpgrade3Cost();
    }

    public void updateUpgrade4CostInfo()
    {
        if (Stats.getUpgrade4Level())
        {
            GameObject.Find("Upgrade4CostInfo").SetActive(false);
        }
        else 
        {
            Upgrade3CostInfo = GameObject.Find("Upgrade4CostInfo").GetComponent<Text>();
            Upgrade3CostInfo.text = "Cost: " + Stats.getUpgrade4Cost();
        }
    }

    private Text xHireInfo;

    public void updateXHireInfo()
    {
        xHireInfo = GameObject.Find("HireX").GetComponent<Text>();
        xHireInfo.text = "x" + Stats.GetUnitsPerHire();
    }

    public void UpdateHireTexts()
    {
        updateMonkeyWorkersCostInfo();
        updateMonkeyWariorsCostInfo();
        updateMonkeyShamanCostInfo();
        updateXHireInfo();
    }


    public void updateHireInfoListener()
    {
        UpdateHireTexts();
    }

    public void updateUpgradesInfoListener()
    {

        updateUpgrade1CostInfo();
        updateUpgrade2CostInfo();
        updateUpgrade3CostInfo();

        if (GameObject.Find("Upgrade4CostInfo") != null) { updateUpgrade4CostInfo(); }
    }

    private void OnEnable()
    {
        ButtonsControler.updateHireInfo += updateHireInfoListener;
        ButtonsControler.updateUpgradesInfo += updateUpgradesInfoListener;
    }
    private void OnDisable()
    {
        ButtonsControler.updateHireInfo -= updateHireInfoListener;
        ButtonsControler.updateUpgradesInfo -= updateUpgradesInfoListener;
    }


    void Update()
    {
        /*updateUpgrade1CostInfo();
        updateBananas();
        updateMonkeyWorkers();
        updateMonkeyWorkersCostInfo();
        updateBananasPerClick();
        updateMonkeyWariors();
        updateMonkeyWariorsCostInfo();*/

        updateBananas();
        updateBananasPerClick();

        updateMonkeyWorkers();
        updateMonkeyWariors();
        updateMonkeyShamans();
        updateMilitaryPower();
        
    }
}
