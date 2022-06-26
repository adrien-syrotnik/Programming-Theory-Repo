using System.Collections;
using System.Collections.Generic;
using UnityEngine;

// INHERITANCE
public class FireMage : Mage
{

    [SerializeField]
    private GameObject fireColumn;
    [SerializeField]
    private float spawnFireColumn;
    [SerializeField]
    private float totalTimeColumn = 5;

    // POLYMORPHISM
    protected override void AttackHandle()
    {
        GameObject gameObject = Instantiate(fireColumn, transform.position, transform.rotation);
        gameObject.transform.Translate(new Vector3(0, -5, 3));
        gameObject.GetComponent<MoveFireColumn>().time = totalTimeColumn;
    }
}
