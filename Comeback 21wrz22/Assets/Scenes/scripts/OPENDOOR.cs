using UnityEngine;

public class OPENDOOR : MonoBehaviour
{
    Animator animator;
    private void Start()
    {
        animator = GetComponent<Animator>();
    }

    private void OnCollisionEnter(Collision collision)
    {
        animator.Play("DoorOpenClose");
    }
}
