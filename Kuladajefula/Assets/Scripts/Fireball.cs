using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Fireball : MonoBehaviour
{
   public Transform target;
    public float speed = 1f;
    public int damage = 10;

    private void Update()
    {
        if(target == null)
        {
            Destroy(gameObject);
            return;
        }

        Vector3 direction = target.position - transform.position;
        direction = direction.normalized;
        transform.Translate(direction * Time.deltaTime * speed);
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.transform == target.transform)
        {
            HitPointsController hitPoints = other.GetComponent<HitPointsController>(); //czy to coœ co uderzamy ma na sobie komponent HitPointsController
            if (hitPoints != null)
            {
                hitPoints.TakeDamage(damage);
                Destroy(gameObject);
            }
        }
    }
    
}
