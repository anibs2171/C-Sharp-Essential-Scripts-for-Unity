using UnityEngine;
using System.Collections;
using System.Collections.Generic;
using System.Threading;
using UnityEngine.SceneManagement;

public class PlayerCollectibles : MonoBehaviour
{

    public Rigidbody Player;
    public int points = 0;
    public int xp = 0;
    public float x, y;




    // Start is called before the first frame update
    void Start()
    {
        Player = this.GetComponent<Rigidbody>();


    }

    // Update is called once per frame
    void Update()
    {
        x = Player.transform.position.x;
        y = Player.transform.position.y;


    }
    private void OnGUI()
    {


        GUI.contentColor = Color.black;

        GUI.Label(new Rect(10, 10, 1000, 40), "MONEY : " + points);
        GUI.Label(new Rect(10, 25, 100, 20), "XP : " + xp);

    }
}

