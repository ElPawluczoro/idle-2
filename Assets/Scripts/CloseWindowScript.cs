using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CloseWindowScript : MonoBehaviour
{
    [SerializeField]
    private GameObject objectToClose;

    public void closeWindow()
    {
        GameObject.Destroy(objectToClose);
    }
}
