using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Main : MonoBehaviour
{
    // Update is called once per frame
    void Update()
    {
        if (Input.GetMouseButtonDown(0))
        {
            Ray rayOrigin = Camera.main.ScreenPointToRay(Input.mousePosition);
            RaycastHit hitInfo;

            if (Physics.Raycast(rayOrigin, out hitInfo))
            {
                IDamageable<int> obj = hitInfo.collider.GetComponent<IDamageable<int>>();
                IDamageable<float> obj2 = hitInfo.collider.GetComponent<IDamageable<float>>();

                if (obj != null)
                {
                    obj.Damage(10);
                }

                if (obj2 != null)
                {
                    obj2.Damage(12.5f);
                }
            }
        }
    }
}
