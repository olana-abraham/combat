using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    #region variables
        public float moveSpeed;
        public float xInput;
        public float zInput;
        public CharacterController characterController;
        public Vector3 moveDirection;
        public GameObject[] abilities;
    #endregion
    // Start is called before the first frame update
    void Start()
    {
        characterController = GetComponent<CharacterController>();
    }

    // Update is called once per frame
    void Update()
    {
        xInput = Input.GetAxis("Horizontal");
        zInput = Input.GetAxis("Vertical");
        moveDirection = new Vector3(xInput, 0, zInput);

        if(moveDirection != Vector3.zero)
        {
            gameObject.transform.forward = moveDirection;
        }
        characterController.Move(moveDirection * moveSpeed * Time.deltaTime);
    }
}
