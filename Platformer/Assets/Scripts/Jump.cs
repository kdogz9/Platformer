using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Jump : MonoBehaviour
{
    public float boostForce = 500f;
    [SerializeField] private Animator springAnim;

    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.CompareTag("Player"))
        {
            Rigidbody rb = collision.gameObject.GetComponent<Rigidbody>();
            if (rb != null)
            {
                rb.AddForce(Vector3.up * boostForce);
                StartCoroutine(SpringAnimation());
            }
        }
    }

    IEnumerator SpringAnimation()
    {
        springAnim.SetBool("Spring", true);
        yield return new WaitForSeconds(2f);
        springAnim.SetBool("Spring", false);
    }




}
