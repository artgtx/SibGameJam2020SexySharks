using UnityEngine;
using UnityEngine.AI;

public class Enemy : MonoBehaviour
{
    public GameObject player;
    public float dist;
    NavMeshAgent nav;
    public float Radius = 15;
    public BodyPart[] BodyParts;
    public NavMeshAgent ThisnavMeshAgent;
    public int Health;
    public int damage = 10;
    //public Animator EnemyAnim;

    void Start()
    {
        player = GameObject.FindGameObjectWithTag("Player");
        nav = GetComponent<NavMeshAgent>();
    }


    void Update()
    {
        dist = Vector3.Distance(player.transform.position, transform.position);
        if (dist > Radius)
        {
            nav.enabled = false;
        }
        if (dist < Radius)
        {
            nav.enabled = true;
            nav.SetDestination(player.transform.position);
        }
    }
    public void TakeDamage()
    {
        Health = Health - 1;
        if (Health == 0)
        {

            //DisEnevyAnim.enabled = false;
            ThisnavMeshAgent.enabled = false;
            this.enabled = false;

            foreach (var item in BodyParts)
            {
                item.GetComponent<Rigidbody>().isKinematic = false;
                item.GetComponent<Rigidbody>().AddForce(0f, 3000f, 0f);
                item.GetComponent<Rigidbody>().AddForce(-transform.forward * 3000f);

            }

        }

    }
}
