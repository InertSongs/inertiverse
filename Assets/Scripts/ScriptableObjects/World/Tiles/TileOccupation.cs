using System.Collections;
using UnityEngine;
using UnityEngine.AI;

public class TileOccupation : MonoBehaviour
{
    public GameObject occupiedTile, obstacle;
    public bool inMotion = false;
    GameObject testDest, occupation;

    Vector3 offset = new Vector3(0, 1f, 0);
    public void SetTile(GameObject destination)
    {
        StartCoroutine(WhenStopped(destination));
    }
    public void ResetTile()
    {
        if (occupation != null)
        {
            Destroy(occupation);
        }
        Walkables.walkables.Add(occupiedTile);
        if (gameObject.GetComponent<NavMeshAgent>() != null)
        {
            gameObject.GetComponent<NavMeshAgent>().enabled = true;
        }
    }
    IEnumerator WhenStopped(GameObject destination)
    {
        testDest = destination;
        if (destination != null)
        {
            yield return new WaitUntil(() => occupiedTile == destination);
            yield return new WaitForSeconds(1f);
            gameObject.GetComponent<NavMeshAgent>().enabled = false;
            Walkables.walkables.Remove(occupiedTile);
            occupation = Instantiate(obstacle, occupiedTile.transform.position + occupiedTile.transform.rotation * offset, occupiedTile.transform.rotation);
            Initiative.activePlayer.currentAP[Initiative.activePlayer.actionSet.move] -= 1;
            inMotion = false;
            if (Initiative.activePlayer.AITurn == false)
            {
                Initiative.activePlayer.actionSet.move.Complete();
            }
        }
        else
        {
            RaycastHit hit;
            Physics.Raycast(transform.position, transform.TransformDirection(Vector3.down), out hit, 2);
            occupiedTile = hit.collider.gameObject;
            Walkables.walkables.Remove(occupiedTile);
            occupation = Instantiate(obstacle, occupiedTile.transform.position + occupiedTile.transform.rotation * offset, occupiedTile.transform.rotation);
        }
    }
    private void Update()
    {
        RaycastHit hit;
        Physics.Raycast(transform.position, transform.TransformDirection(Vector3.down), out hit, 2);
        occupiedTile = hit.collider.gameObject;
    }
}
