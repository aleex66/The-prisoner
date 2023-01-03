using UnityEngine;

public class OPENDOOR : MonoBehaviour
{
    private MeshRenderer kolorek;
    private void Start()
    {
        kolorek = GetComponent<MeshRenderer>();
    }

    private void OnCollisionEnter
        (Collision collision)
    {
        if (collision.gameObject.tag == "DOOR")
        {
           
            Debug.Log("COLOR");
        }
    }
}
