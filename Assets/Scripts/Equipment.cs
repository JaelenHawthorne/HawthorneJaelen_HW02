using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;


using Random = UnityEngine.Random;

public enum CurrentlyEquipped { Sword, Helmet, Boots, Chain_Mail }
public enum Rarity { low, average, rare, legendary};
public enum Slot { Hand, Head, Feet, Chest }

// Custom serializable class
[Serializable]
public class equipment
{
    public string name;
    public int value = 1;
    public Rarity rarity;
    public CurrentlyEquipped unit;
    public Slot slot;
}



public class Equipment : MonoBehaviour
{
    public equipment currrentlyEquipped;
    public equipment[] Inventory;


  










}


