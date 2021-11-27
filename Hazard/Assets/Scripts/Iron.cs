using UnityEngine;
using System.Collections;

public class Iron : Stateful
{
    [SerializeField] private bool isHazardous;

    // if hazardous, each stove top turn red (Hex: D40000)
    public override void displayState()
    {
        if (isHazardous)
        {
            transform.rotation = Quaternion.Euler(0, 0, 0);
        }
        else
        {
            transform.rotation = Quaternion.Euler(0, 0, 90);
        }
    }

    public override bool getState()
    {
        return isHazardous;
    }

    public override void switchState()
    {
        isHazardous = !isHazardous;
    }

    // Use this for initialization
    void Start()
    {
        displayState();
    }
}
