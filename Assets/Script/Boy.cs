using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class Boy : MonoBehaviour
{
    [SerializeField] private GameObject Player;
    [SerializeField] private GameObject Only_My;
    [SerializeField] private GameObject With_Friend;//合流後に追加される要素

    private NavMeshAgent navMeshAgent;

    private Animator animator; // Animatorの追加
    private static readonly int SpeedParameter = Animator.StringToHash("Speed");

    public bool isPlayer = false;

    // Start is called before the first frame update
    void Start()
    {
        animator = this.GetComponent<Animator>();
        navMeshAgent = GetComponent<NavMeshAgent>();
    }

  
    private void Update()
    {
        With_Friend.SetActive(isPlayer);
        Only_My.SetActive(!isPlayer);
        OnAnimatorMove();
        if (isPlayer == true)
        {
            navMeshAgent.destination = Player.transform.position;
        }
    }

    private void OnAnimatorMove()
    {
        float speed = navMeshAgent.velocity.magnitude;
        animator.SetFloat(SpeedParameter, speed);
    }
}
