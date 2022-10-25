using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.AI;

public class KarakterTakip : MonoBehaviour
{
    private NavMeshAgent Katil;
    public GameObject Player;
    public float KatilKovalamaMesafe = 4.0f;
    private Animator animasyon;
    // Start is called before the first frame update
    void Start()
    {
        Katil = GetComponent<NavMeshAgent>();
        animasyon = GetComponent<Animator>();
    }

    // Update is called once per frame
    void Update()
    {
        float mesafe = Vector3.Distance(transform.position, Player.transform.position);

        if (mesafe < KatilKovalamaMesafe)
        {
            Vector3 PlayerYon = transform.position - Player.transform.position;
            Vector3 YeniPozisyon = transform.position - PlayerYon;
            Katil.SetDestination(YeniPozisyon);
            animasyon.SetInteger("Tetik", (int)mesafe);
        }
        
        
    }
}
