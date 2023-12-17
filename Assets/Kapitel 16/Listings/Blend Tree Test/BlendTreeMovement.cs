using System;
using UnityEngine;

public class BlendTreeMovement : MonoBehaviour
{
    [SerializeField] private float speed;

    private Animator animator;

    private void Awake()
    {
        animator = GetComponent<Animator>();
    }

    private void Update()
    {
        float input = Input.GetAxisRaw("Horizontal");
        transform.Translate(Vector2.right * input * speed * Time.deltaTime);
        animator.SetFloat("movementX", input);
    }
}
