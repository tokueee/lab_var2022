using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class Boy : MonoBehaviour
{
    [SerializeField] private GameObject Player;
    [SerializeField] private GameObject Only_My;
    [SerializeField] private GameObject With_Friend;//������ɒǉ������v�f

    private NavMeshAgent navMeshAgent;

    [SerializeField] private float Delaytime;

    public bool isPlayer = false;

    // Start is called before the first frame update
    void Start()
    {
        navMeshAgent = GetComponent<NavMeshAgent>();
        StartCoroutine(Delay());
    }

    // Update is called once per fram
    public IEnumerator Delay()
    {
        while (true)
        {
            if (isPlayer == true)
            {
                Debug.Log("�X�^�[�g");
                yield return new WaitForSeconds(Delaytime);
                Debug.Log("�I���");
                navMeshAgent.destination = Player.transform.position;
            }
            {
                yield return null; // isPlayer��false�̊Ԃ͑ҋ@
            }
        }
    }

    private void Update()
    {
        With_Friend.SetActive(isPlayer);
        Only_My.SetActive(!isPlayer);
    }

}
