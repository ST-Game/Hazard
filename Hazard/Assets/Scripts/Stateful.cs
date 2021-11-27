/// <summary>
///  AUTHOR: Tal Zichlinsky
/// 
///  This interface can be implemented by any object who wishes to manage
///  its binary state and to indicate it to other game objects or, visually, to the player
///  
/// </summary>

using UnityEngine;
using System;
public interface IStateful
{
    // Return the state of the object
    public abstract bool getState();

    // Switch the state of the object
    public abstract void switchState();

    // indicate in a visual way the state of the object
    public abstract void displayState();

}

[Serializable]
public abstract class Stateful : MonoBehaviour, IStateful
{
    public abstract void displayState();
    public abstract bool getState();
    public abstract void switchState();
}
