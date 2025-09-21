using UnityEditor;
using UnityEngine;

public class Scorer : MonoBehaviour
{
    int hits = 0;
    private void OnCollisionEnter(Collision other)
    {
        if (other.gameObject.CompareTag("Ground"))
        // if (collision.gameObject.tag == "Ground")
        //Instead of this we should use the below statement as its fast 
        //and if the thing is untagged will not throw error
        {
            return;
        }

        if (other.gameObject.tag == "Hit")
        {
            hits++;
            Debug.Log("You've bumped into a object this many times: " + hits);
        }     
        }
       
    }



