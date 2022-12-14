using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Units
{
    private int count;
    private int basicBananasPerUnit;
    private Bananas bananasPerUnit;
    private int basicCost;
    private Bananas cost;

    public Units()
    {

    }

    public Units(int basicBananasPerUnit, int basicCost)
    {
        this.basicBananasPerUnit = basicBananasPerUnit;
        this.basicCost = basicCost;
    }

    public int GetCount()
    {
        return count;
    }

    public void SetCount(int value)
    {
        count = value;
    }

    public Bananas GetBananasPerUnit()
    {
        return bananasPerUnit;
    }

    public int GetBasicCost()
    {
        return basicCost;
    }

    public void SetBasicCost(int value)
    {
        basicCost = value;
    }

    public Bananas GetCost()
    {
        return cost;
    }


    public void setBananasPerUnit(int upgradeLv, BananasPrefixes prefix)
    {
        bananasPerUnit = new Bananas(basicCost + upgradeLv, prefix);
    }

    public void setUnitCost(BananasPrefixes prefix, int unitsPerHire)
    {
        cost = new Bananas(basicCost + basicCost * count, prefix);
        for (int i = 1; i < unitsPerHire; i++)
        {
            cost += new Bananas(basicCost + basicCost * (count + i), prefix);
        }
    }

    public void addUnits(int amount)
    {
        count += amount;
    }





}
