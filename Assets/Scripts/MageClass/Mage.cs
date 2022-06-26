using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public abstract class Mage : MonoBehaviour
{

    protected bool isReloading;

    // ENCAPSULATION
    [SerializeField]
    protected float _reloadTime;
    public float ReloadTime
    {
        get
        {
            return _reloadTime;
        }
        protected set
        {
            if (_reloadTime > 0)
                _reloadTime = value;
        }
    }

    public void Attack()
    {
        if (!isReloading)
        {
            AttackHandle();
            isReloading = true;
            StartCoroutine(Reload());
        }

    }

    private IEnumerator Reload()
    {
        yield return new WaitForSeconds(_reloadTime);
        isReloading = false;
    }

    protected abstract void AttackHandle();

}
