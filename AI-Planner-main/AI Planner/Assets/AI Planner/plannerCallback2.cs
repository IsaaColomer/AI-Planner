using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Generated.Semantic.Traits;

public class plannerCallback2 : MonoBehaviour
{
    Moves moves;
    UnityEngine.AI.NavMeshAgent agent;
    Robber trt;
    public GameObject cop;
    public GameObject treasure;


    void Start()
    {
        moves = this.GetComponent<Moves>();
        agent = this.GetComponent<UnityEngine.AI.NavMeshAgent>();
        trt = this.GetComponent<Robber>();
    }

    public void Steal()
    {
        Debug.Log("Steal");
        treasure.GetComponent<MeshRenderer>().enabled = false;

    }

    public IEnumerator Seek()
    {
        Debug.Log("Approach");
        agent.SetDestination(treasure.transform.position);

        while ((Vector3.Distance(treasure.transform.position, transform.position) > 2f) &&
               (Vector3.Distance(treasure.transform.position, cop.transform.position) > 10f))
            yield return null;
        if (Vector3.Distance(treasure.transform.position, cop.transform.position) < 10f)
        {
            trt.CopAway = false;
        }
        else
        {
            trt.Ready2steal = true;
        }
    }

    public IEnumerator Wander()
    {
        Debug.Log("Wander");
        while (Vector3.Distance(treasure.transform.position, cop.transform.position) < 10f)
        {
            moves.Wander();
            yield return null;
        }
    }
}
