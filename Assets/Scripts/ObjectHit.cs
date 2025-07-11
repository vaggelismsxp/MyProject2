using UnityEngine;

public class ObjectHit : MonoBehaviour
{
    
    MeshRenderer myMeshRenderer;

    private void Start()
    {
        myMeshRenderer = GetComponent<MeshRenderer>();
    }


    private void OnCollisionEnter(Collision collision)
    {
        myMeshRenderer.material.color = new Color(Random.value, Random.value, Random.value);   
    }
    
    
}
