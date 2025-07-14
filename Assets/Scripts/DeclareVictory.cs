using UnityEngine;

public class DeclareVictory : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }
    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == "Player") { Debug.Log("You Won!!!"); }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
