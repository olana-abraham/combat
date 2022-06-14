using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ability : MonoBehaviour
{
    #region Variables
    public GameObject projectile;
    public float attackSpeed;
    public Vector3 spawnOffset;
    #endregion
    
    
    // Start is called before the first frame update
    void Start()
    {
        StartCoroutine(FireProjectileRoutine());
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public IEnumerator FireProjectileRoutine()
    {
        while(true)
        {
            yield return new WaitForSeconds(attackSpeed); // pauses coroutine for the given seconds thats = to attack speed
            FireProjectile();
        }
    }

    private void FireProjectile(){
        Instantiate(projectile, transform.parent.position + spawnOffset, transform.parent.rotation); // creates an instance of the gameobject it's applied to
    }
}
