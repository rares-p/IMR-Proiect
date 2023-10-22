using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TargetSpawner : MonoBehaviour
{
    [SerializeField]
    private GameObject targetPrefab;
    private GameObject target;
    public int Score { get; private set; }
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyUp(KeyCode.U))
            target = SpawnTargetAtRandomPosition();
    }

    public GameObject SpawnTargetAtRandomPosition()
    {
        var randomPosition = new Vector3(0.5f, Random.Range(-0.4f, 0.4f), Random.Range(-0.47f, 0.47f));
        GameObject newTarget = Instantiate(targetPrefab);
        newTarget.transform.parent = this.transform;
        newTarget.transform.localPosition = randomPosition;
        newTarget.transform.localRotation = Quaternion.Euler(0, 90, 0);
        newTarget.transform.localScale = new Vector3(0.015f, 0.05f, 0.0001f);
        Debug.Log(newTarget.transform.position);

        return newTarget;
    }

    private void OnCollisionEnter(Collision collision)
    {
        Score += (int) Mathf.Abs(Vector2.Distance(new Vector2(target.transform.position.y, target.transform.position.z), new Vector2(collision.gameObject.transform.position.y, collision.transform.position.z)));
    }
}
