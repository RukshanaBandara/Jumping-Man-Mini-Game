using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ArrowScript : MonoBehaviour
{
    public float speed;

    public bool goRight;

    private void Update()
    {
        Move();
        DestroyAfter();
    }

     private void Move()
      {
          if (goRight == true)
          {
              transform.position += Vector3.right * speed * Time.deltaTime;
          }
          else
          {
              transform.position -= Vector3.right * speed * Time.deltaTime;
          }
      }

     private void DestroyAfter()
      {
          Destroy(this.gameObject, 4f);
      }

    } //class