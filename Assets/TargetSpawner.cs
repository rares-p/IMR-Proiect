using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class TargetSpawner : MonoBehaviour
{
    [SerializeField]
    private GameObject targetPrefab;
    [SerializeField]
    private GameObject player;
    [SerializeField]
    private Text scoreText;
    private GameObject target;
    
    public int Score { get; private set; }
    // Start is called before the first frame update
    void Start()
    {
        target = SpawnTargetAtRandomPosition();

    }

    // Update is called once per frame
    void Update()
    {
        scoreText.GetComponent<Text>().text = Score.ToString();
        Debug.Log(Score);
    }

    public GameObject SpawnTargetAtRandomPosition()
    {
        var randomPosition = new Vector3(0.5f, Random.Range(-0.37f, 0.37f), Random.Range(-0.47f, 0.47f));
        GameObject newTarget = Instantiate(targetPrefab);
        newTarget.transform.parent = this.transform;
        newTarget.transform.localPosition = randomPosition;
        newTarget.transform.localRotation = Quaternion.Euler(0, 90, 0);
        newTarget.transform.localScale = new Vector3(0.17f, 0.15f, 0.0001f);
        Debug.Log(newTarget.transform.position);

        return newTarget;
    }

    private void OnCollisionEnter(Collision collision)
    {
        Score += (int) (1 / (Vector2.Distance(new Vector2(target.transform.position.y, target.transform.position.z), new Vector2(collision.gameObject.transform.position.y, 
            collision.transform.position.z)) + 0.1) * 10
            + Vector3.Distance(this.transform.position, player.transform.position) * 250);
        Destroy(target);
        target = SpawnTargetAtRandomPosition();
    }
}
