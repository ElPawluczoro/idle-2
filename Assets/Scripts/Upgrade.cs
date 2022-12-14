using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Upgrade : MonoBehaviour
{
    private Bananas startCost;
    private int costMultiplier;
    private int multiplierPerLevel;
    private UpgradesMultiplier upgradesMultiplier;
    private int maxLevel;

    private Bananas cost;
    private int level = 0;

    public Bananas GetCost()
    {
        return this.cost;
    }

    public int GetLevel()
    {
        return level;
    }

    public int GetMaxLevel()
    {
        return maxLevel;
    }

    public Upgrade(Bananas startCost, int costMultiplier, UpgradesMultiplier upgradesMultiplier, int multiplierPerLevel, int maxLevel)
    {
        this.startCost = startCost;
        this.costMultiplier = costMultiplier;
        this.upgradesMultiplier = upgradesMultiplier;
        this.multiplierPerLevel = multiplierPerLevel;
        this.maxLevel = maxLevel;
    }

    public void SetMultiplier()
    {
        switch (upgradesMultiplier)
        {
            case UpgradesMultiplier.GENERAL: Stats.increaseMultiplier(multiplierPerLevel); break;
            case UpgradesMultiplier.WORKER: Stats.IncreaseWorkerMultiplier(multiplierPerLevel); break;
            case UpgradesMultiplier.WARRIOR: Stats.IncreaseWarriorMultiplier(multiplierPerLevel); break;
            case UpgradesMultiplier.SHAMAN: Stats.IncreaseShamanMultiplier(multiplierPerLevel); break;
        }
    }

    public void SetCost()
    {
        if (level == 0)
        {
            cost = startCost;
        }else
        {
            cost = startCost * (int)Math.Pow((double)costMultiplier, (double)level);
        }
    }

    public void LevelUp() {
        level++;
        SetCost();
        SetMultiplier();
    }






}
