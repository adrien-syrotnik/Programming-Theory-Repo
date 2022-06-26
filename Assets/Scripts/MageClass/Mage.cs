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
            if (value > 0)
                _reloadTime = value;
        }
    }


    [SerializeField]
    protected float _speed = 5;
    public float Speed
    {
        get
        {
            return _speed;
        }
        protected set
        {
            if (value > 0)
                _speed = value;
        }
    }

    virtual protected void Update()
    {
        Move();

        if(Input.GetMouseButtonDown(0))
        {
            Attack();
        }
    }

    virtual protected void Start()
    {
        mageAnimator = GetComponent<Animator>();
    }

    protected Animator mageAnimator;

    // ABSTRACTION
    private void Move()
    {
        float horizontalInput = Input.GetAxis("Horizontal");
        float verticalInput = Input.GetAxis("Vertical");

        bool isMoving = Mathf.Abs(verticalInput) > 0.2f || Mathf.Abs(horizontalInput) > 0.2f;

        if (isMoving)
        {
            transform.rotation = Quaternion.LookRotation(new Vector3(horizontalInput, 0, verticalInput), Vector3.up);
            transform.Translate(Speed * Vector3.forward * Time.deltaTime);
        }

        mageAnimator.SetFloat("speed", isMoving ? 1 : 0);

        //transform.Translate(Vector3.right * Input.GetAxis("Horizontal") * Speed * Time.deltaTime);
        //transform.Translate(Vector3.forward * Input.GetAxis("Vertical") * Speed * Time.deltaTime);


    }

    // ABSTRACTION
    public void Attack()
    {
        if (!isReloading)
        {
            mageAnimator.SetTrigger("attack");
            AttackHandle();
            isReloading = true;
            StartCoroutine(Reload());
        }

    }

    // ABSTRACTION
    private IEnumerator Reload()
    {
        yield return new WaitForSeconds(_reloadTime);
        isReloading = false;
    }

    protected abstract void AttackHandle();

}
