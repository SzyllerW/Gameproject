using System.Collections;
using System.Collections.Generic;
using TMPro.EditorUtilities;
using Unity.VisualScripting;
using UnityEngine;

public class PlayerAttactController : MonoBehaviour
{
    public Camera cam;
    public Fireball fireballPrefab;

    private void Start()
    {
        cam = Camera.main;

    }
    void Update()
    {
        if (Input.GetMouseButtonDown(1))
        {
            Ray ray = cam.ScreenPointToRay(Input.mousePosition);

            if (Physics.Raycast(ray, out var hit, Mathf.Infinity) == true)
            {
                HitPointsController hitPoints = hit.transform.GetComponent<HitPointsController>();
                if (hitPoints != null)
                {
                    Fireball spawnedFireball = Instantiate(fireballPrefab, transform.position, Quaternion.identity);
                    spawnedFireball.target = hit.transform;
                }
            }
        }
    }
}
