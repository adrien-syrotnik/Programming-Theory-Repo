using System.Collections;
using System.Collections.Generic;
using UnityEngine;

// INHERITANCE
public class WaterMage : Mage
{
    [SerializeField]
    private GameObject bubblePrefab;
    [SerializeField]
    private int numberOfBubble = 10;

    private int currentBubble = 0;

    // POLYMORPHISM
    protected override void AttackHandle()
    {
        StartCoroutine(spawnBubble());
    }

    private IEnumerator spawnBubble()
    {
        while(currentBubble < numberOfBubble)
        {
            Debug.Log("spawxn");
            GameObject bubble = Instantiate(bubblePrefab, transform.position, transform.rotation);

            Vector3 randomForce = new Vector3(Random.Range(-0.2f,0.2f), Random.Range(1, 2), Random.Range(-0.2f, 0.2f));
            bubble.GetComponent<Rigidbody>().AddForce(randomForce * 10, ForceMode.Impulse);
            Destroy(bubble,5f);
            currentBubble++;
            yield return new WaitForSeconds(0.2f);
        }
        currentBubble = 0;
    }
}
