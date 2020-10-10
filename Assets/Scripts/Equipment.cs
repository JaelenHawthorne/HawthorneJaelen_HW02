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


    public float baseSpeed = 3f;

    public float newSize = 1f;



    public void Spin()
    {
        float animation = baseSpeed + Mathf.Sin(Time.time * 8f) * baseSpeed / 7f;
        transform.Rotate(baseSpeed, animation, 0);
    }

    public void sizeChange()
    {
        newSize = Random.Range(.5f, 10.0f);
        transform.localScale = Vector3.one * newSize;
    }






}


