using UnityEngine;

public class ObjectHit : MonoBehaviour
{
    
    MeshRenderer myMeshRenderer;

    private void Start()
    {
        myMeshRenderer = GetComponent<MeshRenderer>();
    }


    private void OnCollisionEnter(Collision other)
    {
        if (other.gameObject.tag == "Player")
        {
            myMeshRenderer.material.color = new Color(Random.value, Random.value, Random.value);
            gameObject.tag = "Hit";

            Debug.Log("You lost!");
            other.transform.position = new Vector3(-44f, 0f, -26f);
        } 
    }
    
    
}
