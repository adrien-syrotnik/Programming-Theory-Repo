using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        Instantiate(MainManager.Instance.mageSelected, transform.position, MainManager.Instance.mageSelected.transform.rotation);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
