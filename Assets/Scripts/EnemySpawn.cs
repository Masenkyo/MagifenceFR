using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemySpawn : MonoBehaviour
{

    public Waves waves;
    [SerializeField] int wave = 0;
    public List<Waves> wavesList;

    void Start()
    {

    }


    void Update()
    {
        if (GameObject.FindGameObjectWithTag("Enemy") == null && GameObject.FindGameObjectWithTag("FireEnemy") == null && GameObject.FindGameObjectWithTag("LightningEnemy") == null && GameObject.FindGameObjectWithTag("WaterEnemy") == null)
        {
            waves = wavesList[wave];
            StartCoroutine(wavestart());
            wave++;
        }
    }
    IEnumerator wavestart()
    {
        for (int i = 0; i < waves.Enemies.Length; i++)
        {
            for (int j = 0; j < waves.Amounts[i]; j++)
            {
                Instantiate(waves.Enemies[i], this.transform.position, Quaternion.identity);
                yield return new WaitForSeconds(1f);
            }
        }
    }
}