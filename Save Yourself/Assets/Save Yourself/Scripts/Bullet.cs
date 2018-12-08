using UnityEngine;

[RequireComponent(typeof(Rigidbody))]
public class Bullet : MonoBehaviour 
{
    // Se llama a OnCollisionEnter cuando este colisionador o cuerpo rígido comienza a tocar a otro cuerpo rígido o colisionador
    private void OnCollisionEnter(Collision collision)
    {
        if (collision.collider.CompareTag("Enemy"))
        {
            collision.gameObject.SetActive(false);
            gameObject.SetActive(false);
        }

        if (collision.collider.gameObject.name == "Box")
        {
            Rigidbody rb = collision.collider.gameObject.GetComponent<Rigidbody>();
            Vector3 direction = rb.transform.position - transform.position;
            rb.AddForceAtPosition(direction.normalized * 3f, collision.collider.gameObject.transform.position, ForceMode.Impulse);
            Debug.Log(collision.collider.gameObject);
        }
    }

    // Se llama a esta función cuando se deshabilita o desactiva el comportamiento
    private void OnDisable()
    {
        //transform.GetComponent<Rigidbody>().Sleep();
        CancelInvoke();
    }

    // Se llama a esta función cuando se habilita y activa el objeto
    private void OnEnable()
    {
      //  transform.GetComponent<Rigidbody>().WakeUp();
        Invoke("HideBullet", 2.5f);
    }

    private void HideBullet()
    {
        gameObject.SetActive(false);
    }
}
