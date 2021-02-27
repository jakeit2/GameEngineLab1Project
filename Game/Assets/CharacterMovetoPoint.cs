using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CharacterMovetoPoint : MonoBehaviour
{
    public Transform objectLocation;
    public float moveSpeed = 5f;
    private Rigidbody rb;
    private Vector3 movement;
    private Animator ant;

    void Start(){
        rb = this.GetComponent<Rigidbody>();
        ant = this.GetComponent<Animator>();
    }

    void Update(){
        Vector3 direction = objectLocation.position - transform.position;
        direction.Normalize();
        movement = direction;
    }
    private void FixedUpdate(){
        moveCharacter(movement);
    }
    void moveCharacter(Vector3 direction){
        rb.MovePosition(transform.position + (direction * moveSpeed * Time.deltaTime));
    }
}
