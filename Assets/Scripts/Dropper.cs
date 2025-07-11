using UnityEngine;

public class Dropper : MonoBehaviour
{
    [SerializeField] float timeToWait = 10.0f;
    Rigidbody myRigidBody;
    MeshRenderer myMeshRenderer;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        myRigidBody = GetComponent<Rigidbody>();
        myRigidBody.useGravity = false;

        myMeshRenderer = GetComponent<MeshRenderer>();
        myMeshRenderer.enabled = false;
        
    }

    // Update is called once per frame
    void Update()
    {
        if (timeToWait < Time.time) 
        {
            myRigidBody.useGravity = true;
            myMeshRenderer.enabled = true;
        
        }
        
    }
}
