using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Health : MonoBehaviour
{
    public int maxHealth;
    public int currentHealth;

    // public bool is_Player;
    // private PlayerStats player_stats;
    
    
    // Start is called before the first frame update
    void Start()
    {
        // if(is_Player) {
        //     player_stats = GetComponent<PlayerStats>();
        // }
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void ModifyHealth(int damageValue) 
    {
        currentHealth = currentHealth + damageValue;
        print("Health = " + currentHealth);
        // if(is_Player) 
        // {
        //     player_stats.Display_HealthStats(currentHealth);
        // }
        if(currentHealth <= 0)
        {
            Destroy(gameObject);
        }
    }
} 
