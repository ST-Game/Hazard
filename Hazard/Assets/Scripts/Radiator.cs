using UnityEngine;
using System.Collections;

public class Radiator : Stateful
{
    [SerializeField] private bool isHazardous;

    // if hazardous, each stove top turn red (Hex: D40000)
    public override void displayState()
    {
        foreach (Transform child in transform)
        {
            if (child.name.StartsWith("On"))
            {
                SpriteRenderer childSR = child.gameObject.GetComponent<SpriteRenderer>();
                if (isHazardous)
                {
                    childSR.color = Color.red;
                }
                else
                {
                    childSR.color = Color.black;
                }

            }
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
