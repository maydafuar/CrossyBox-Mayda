using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PesawatSpawner : MonoBehaviour
{
    [SerializeField] GameObject eanglePrefab;
    [SerializeField] int spawnZPos = 7;
    [SerializeField] Player player;
    [SerializeField] float timeOut = 5;
    float timer = 0;
    int playerLastMaxTravel = 0;

    private void SpawnPesawat()
    {
        player.enabled = false;
        var position = new Vector3(
            player.transform.position.x,
            1,
            player.CurrentTravel + spawnZPos);
        var rotation = Quaternion.Euler(0, 180, 0);
        var eagleObject = Instantiate(eanglePrefab, position, rotation);
        var eagle = eagleObject.GetComponent<Pesawat>();
        eagle.SetUpTarget(player);
    }

    private void Update()
    {
        // jika player ada kemajuan
        if (player.MaxTravel != playerLastMaxTravel)
        {
            // maka reset timer
            timer = 0;
            playerLastMaxTravel = player.MaxTravel;
            return;
        }

        // kalau ga maju2 jalankan timer
        if (timer < timeOut)
        {
            timer += Time.deltaTime;
            return;
        }

        // kalau sudah timeout
        if (player.IsJumping() == false && player.IsDie == false)
            SpawnPesawat();
    }
}
