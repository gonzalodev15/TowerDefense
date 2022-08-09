using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bullet : MonoBehaviour
{
    private Transform _target;
    public GameObject _particles;
    public float speed = 70;

    public void setTarget(Transform target)
    {
        _target = target;
    }

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if(_target == null)
        {
            Destroy(gameObject);
            return;
        }
        Vector3 dir = _target.position - transform.position;
        float distanceThisFrame = speed * Time.deltaTime;

        if(dir.magnitude <= distanceThisFrame)
        {
            hitTarget();
        }
        transform.Translate(dir.normalized*distanceThisFrame, Space.World);
    }

    void hitTarget()
    {
        GameObject particles = Instantiate(_particles, _target.position, _target.rotation);
        
        _target.GetComponent<Enemy>().EnemyHit(1);
        Destroy(gameObject);
        Destroy(particles, 1f);
    }
}
