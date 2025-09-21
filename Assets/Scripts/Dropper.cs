
using UnityEngine;

public class Dropper : MonoBehaviour
{
    [SerializeField] float timeToWait = 2f;

    MeshRenderer myMeshRenderer;

    Rigidbody myRigidBody;

    bool hasLanded = false;
    void Start()
    {
        myMeshRenderer = GetComponent<MeshRenderer>();
        myRigidBody = GetComponent<Rigidbody>();
        myMeshRenderer.enabled = false;
        myRigidBody.useGravity = false;
    }

    void Update()
    {
        if (Time.time > timeToWait && hasLanded == false)
        {
            myMeshRenderer.enabled = true;
            myRigidBody.useGravity = true;
        }
    }

    void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.tag == "Ground")
        {
            hasLanded = true;
            myRigidBody.constraints = RigidbodyConstraints.FreezePositionY;
            myRigidBody.constraints = RigidbodyConstraints.FreezeRotation;
            // myRigidBody.isKinematic = true;
            Destroy(GetComponent<Rigidbody>());
        }
    }


}