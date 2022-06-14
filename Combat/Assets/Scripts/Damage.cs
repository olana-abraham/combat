using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Damage : MonoBehaviour
{
    public int damageValue;
    public UnitType targetType;
    
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void DealDamage(GameObject unit) 
    {
        unit.GetComponent<Health>().ModifyHealth(damageValue);
    }

    private void OnTriggerEnter(Collider target)
    {
        switch(targetType)
         {
            case UnitType.Enemy:
            if(target.CompareTag("Enemy")) // game is identifying if the target is an enemy
            {
                DealDamage(target.gameObject);
            }
            break;
            case UnitType.Player:
            if(target.CompareTag("Player")) 
            {
                DealDamage(target.gameObject);
            }
            break;
            case UnitType.Obstacle:
            if(target.CompareTag("Obstacle")) 
            {
                DealDamage(target.gameObject);
            }
            break;
        
        }


    }
}
