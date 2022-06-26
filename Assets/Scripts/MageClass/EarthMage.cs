using System.Collections;
using System.Collections.Generic;
using UnityEngine;

// INHERITANCE
public class EarthMage : Mage
{
    private float range = 3;
    [SerializeField]
    private ParticleSystem earthQuake;

    // POLYMORPHISM
    protected override void AttackHandle()
    {
        GameObject particle = Instantiate(earthQuake.gameObject, transform.position, transform.rotation);
        Destroy(particle, particle.GetComponent<ParticleSystem>().main.duration);
    }
}
