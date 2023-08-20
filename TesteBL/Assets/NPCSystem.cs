using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class NPCSystem : MonoBehaviour
{
    public GameObject dTemplate;
    public GameObject canva;
    bool playerDetection = false;

    void Update()
    {
        if (playerDetection && Input.GetKeyDown(KeyCode.F) && !PlayerMove.dialogue)
        {
            canva.SetActive(true);
            PlayerMove.dialogue = true;
            NewDialogue("Oi garoto, eu meu chamo Homem de Papelao e voce deve estar perguntando como chegou aqui, nao e mesmo?");
            NewDialogue("Para voce andar, use as teclas A, W, S, D");
            NewDialogue("Para pegar objetos use a tecla E");
            NewDialogue("Para pegar objetos use a tecla E");
            canva.transform.GetChild(1).gameObject.SetActive(true);
        }
    }
    void NewDialogue(string text)
    {
        GameObject templateClone = Instantiate(dTemplate, dTemplate.transform);
        templateClone.transform.parent = canva.transform;
        templateClone.transform.GetChild(1).GetComponent<TextMeshProUGUI>().text = text;
    }
    private void OnTriggerEnter(Collider other)
    {
        if (other.name == "Player")
        {
            playerDetection = true;
        }
    }
    private void OnTriggerExit(Collider other)
    {
        playerDetection = false;
    }
}
