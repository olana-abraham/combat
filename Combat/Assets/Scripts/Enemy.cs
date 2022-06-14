using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemy : MonoBehaviour
{
    #region variables
    public float moveSpeed;
    public float movementBuffer;
    private CharacterController characterController;
    private Vector3 moveDirection;
    private Vector3 actualDirection;
    private Transform playerTransform;
    #endregion

    
    
    // Start is called before the first frame update
    void Start()
    {
        playerTransform = GameObject.FindWithTag("Player").transform;
        characterController = GetComponent<CharacterController>();
        StartCoroutine(EnemyMovementRoutine());
    }

    // Update is called once per frame
    void Update()
    {
        transform.LookAt(playerTransform);
        actualDirection = transform.TransformDirection(moveDirection);
        characterController.Move(moveSpeed * actualDirection * Time.deltaTime);
    }

    private IEnumerator EnemyMovementRoutine() 
    {
        while(true){
            moveDirection = Vector3.forward;
            yield return new WaitForSeconds(movementBuffer);
            moveDirection = Vector3.right;
            yield return new WaitForSeconds(movementBuffer);
        }
    }

}
