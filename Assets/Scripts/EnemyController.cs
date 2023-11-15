using Unity.VisualScripting.Dependencies.Sqlite;
using UnityEngine;
using UnityEngine.SceneManagement;
using static UnityEngine.GraphicsBuffer;

public class EnemyController : MonoBehaviour
{
    [SerializeField] private Rigidbody2D _rigidbody2D;
    [SerializeField] private int HP;


    private void Update()
    {

        _rigidbody2D.transform.position = Vector3.Lerp(_rigidbody2D.position, new Vector3(0,0,0), Time.deltaTime * 0.05f);
    }
    private void OnCollisionEnter2D(Collision2D collision)
    {
        if(collision.gameObject.tag == "Player")
        {
            SaveResults.Save();
            SceneManager.LoadScene("MainMenu");

        }
        if(collision.gameObject.tag == "Projectile")
        {
            Destroy(collision.gameObject);
            HP--;
            if (HP <= 0)
                Destroy(this.gameObject);
        }   
    }
    private void OnDestroy()
    {
        GameManager.Score += 10;
    }
}
