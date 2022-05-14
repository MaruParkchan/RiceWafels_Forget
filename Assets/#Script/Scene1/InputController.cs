using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InputController : MonoBehaviour {

    [SerializeField] private Vector3 direction;
    [SerializeField] private float moveToTime;
    [SerializeField] private string moveTo;
    [SerializeField] private Movement movement;
    public AudioClip clip;
    AudioSource audios;
    private void Awake()
    {
        audios = GetComponent<AudioSource>();
        audios.clip = clip;
    }

    public void MoveToPlayer()
    {
        if (DataController.isGameStart != true || DataController.isGameClear == true || DataController.isDie != false)
            return;

        if (Movement.moveToTimer > 0 )
            return;

        audios.Play();
        movement.playerAnimator.Play(moveTo);
        Movement.pos = direction;
        Movement.moveToTimer = moveToTime;
    }
}
