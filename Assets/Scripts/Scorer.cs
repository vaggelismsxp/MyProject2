using UnityEngine;

public class Scorer : MonoBehaviour
{

    float score = 0f;
    
    private void OnCollisionEnter(Collision other)
    {
        if (other.gameObject.tag != "Hit")
        {
            score++;
            Debug.Log("your score is : " + score);
        }
    }
    
   
}
