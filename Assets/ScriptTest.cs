using System.Collections;
using System.Collections.Generic;
using UnityEngine;

 public class Boss
{
    private int hp = 100; // hit point
    private int mp = 53; // magic point
    private int power = 25; // attack skill

    public void Attack()
    {
        Debug.Log(this.power + "damage!!!");
    }

    public void Defence(int damage)
    {
        Debug.Log(damage + "damage happended!!");
        this.hp -= damage;
    }

    public void Magic(int ConsumedMp)
    {
        if(mp>=5)
        {
            this.mp -= 5;
            Debug.Log("You did a Magical attack! Current MP is {mp}");
        }
        else
        {
            Debug.Log("You cannot use Magic because your MP is not enough!");
        }
    }
}

public class ScriptTest : MonoBehaviour
{

    // Start is called before the first frame update
    void Start()
    {
        Boss lastboss = new Boss();
        lastboss.Attack();
        lastboss.Defence(3);

        int[] array = { 43, 51, 78, 93, 36 };
        for (int i = 0; i < array.Length; i++)
        {
            Debug.Log(array[i]);
        }

        for (int i = 4; i >= 0; i--)
        {
            Debug.Log(array[i]);
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
