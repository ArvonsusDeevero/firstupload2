using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ChangeSceneAfterSecond : MonoBehaviour
{
    // Start is called before the first frame update
    public LoadScene ls;
    public float second;
    void Start()
    {
        Invoke("ChangeAfterSecond", second);
    }

    public void ChangeAfterSecond()
    {
        Debug.Log("Test!");
        ls.ChangeScene("MainScene");
    }


}
