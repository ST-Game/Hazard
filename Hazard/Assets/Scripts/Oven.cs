using UnityEngine;
using System.Collections;

public class Oven : Stateful
{
    [SerializeField] private bool isHazardous;

    public override void displayState()
    {
        foreach (Transform child in transform)
        {
            if (child.name.StartsWith("Stove"))
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

    void Start()
    {
        displayState();
    }
}
