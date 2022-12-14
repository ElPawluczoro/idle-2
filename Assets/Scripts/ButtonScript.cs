using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ButtonScript : MonoBehaviour
{

    public void upgrade4Inactive()
    {
        GetComponent<Button>().interactable = false;
    }

    public void upgrade1Inactive()
    {
        if (Stats.getUpgrade1Level() == Stats.GetUpgrade1MaxLevel())
        {
            GetComponent<Button>().interactable = false;
        }
    }

    public void upgrade2Inactive()
    {
        if (Stats.getUpgrade2Level() == Stats.getUpgrade2LevelMax())
        {
            GetComponent<Button>().interactable = false;
        }
    }
    public void upgrade3Inactive()
    {
        if (Stats.getUpgrade3Level() == Stats.getUpgrade3LevelMax())
        {
            GetComponent<Button>().interactable = false;
        }
    }


    private void OnEnable()
    {
        if (GetComponent<Button>().name == "Upgrade4" && Stats.getUpgrade4Level())
        {
            GetComponent<Button>().interactable = false;
        }
        else if(GetComponent<Button>().name == "Upgrade1" && Stats.getUpgrade1Level() == Stats.GetUpgrade1MaxLevel())
        {
            GetComponent<Button>().interactable = false;
        }
        else if (GetComponent<Button>().name == "Upgrade2" && Stats.getUpgrade2Level() == Stats.getUpgrade2LevelMax())
        {
            GetComponent<Button>().interactable = false;
        }
        else if (GetComponent<Button>().name == "Upgrade3" && Stats.getUpgrade3Level() == Stats.getUpgrade3LevelMax())
        {
            GetComponent<Button>().interactable = false;
        }
    }

}
